using Autofac;
using Autofac.Extras.DynamicProxy;
using AutoMapper;
using HIS.Core.Settings;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-06-30 17:38:45
/// 功能:
/// </summary>
namespace HIS.Core
{
    public class App : Singleton<App>
    {
        /// <summary>
        /// 获取当前应用程序配置 只读
        /// </summary>
        public AppConfig AppConfig { get; private set; }

        public RunSysInfo RuntimeSystemInfo { get; private set; }
        /// <summary>
        /// 系统全局参数设置
        /// </summary>
        public GlobalSet GlobalSet { get; private set; }
        /// <summary>
        /// 用户参数设置
        /// </summary>
        public UserSet UserSet { get; private set; }
        /// <summary>
        /// 登陆用户信息
        /// </summary>
        public LoginUser User { get; private set; }
        /// <summary>
        /// 本次登录信使
        /// </summary>
        public long SessionId { get; private set; }

        /// <summary>
        /// 验证账号密码
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DataResult<UserEntity> Validation(string account, string password)
        {
            var userService = ServiceLocator.GetService<IUserService>();
            var user = userService.ValidationAccount(account, password);
            if (user == null)
                return DataResult.Fault<UserEntity>("账号或密码不正确");

            return DataResult.True(user);
        }

        /// <summary>
        /// 登录系统
        /// </summary>
        /// <param name="userEntity"></param>
        /// <param name="roleEntity"></param>
        /// <returns></returns>
        public DataResult Login(UserEntity userEntity, RoleEntity roleEntity)
        {
            this.GlobalSet = new GlobalSet();
            this.UserSet = new UserSet();

            this.User = new LoginUser(userEntity, roleEntity);

            var sessionService = ServiceLocator.GetService<ISessionService>();
            var result = sessionService.Generate();
            if (!result.Success)
                return DataResult.Fault("登录信使生成失败" + Environment.NewLine + "请重新登录");

            this.SessionId = result.Value;
            this.RuntimeSystemInfo.UserInfo = userEntity;

            return DataResult.True();
        }

        /// <summary>
        /// 初始化计算机网络信息
        /// </summary>
        private void InitNetInfo()
        {
            IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in ips)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    this.AppConfig.LocalIP = ip.ToString();
            }
            string mac = "";
            try
            {
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        mac = mo["MacAddress"].ToString();
                        break;
                    }
                }
                moc = null;
                mc = null;
            }
            catch
            {
                mac = "unknow";
            }
            this.AppConfig.MAC = mac;
        }

        /// <summary>
        /// 创建视图
        /// </summary>
        /// <param name="assmely">程序集</param>
        /// <param name="className">类名</param>
        /// <returns></returns>
        public Form CreateView(string assmely, string className)
        {
            var type = Assembly.Load(assmely).GetType(className);
            return this.CreateView(type);
        }
        /// <summary>
        /// 创建视图
        /// </summary>
        /// <param name="type">窗体类型</param>
        /// <returns></returns>
        public Form CreateView(Type type)
        {
            Form form;
            if (ServiceLocator.IsRegistered(type))
                form = (Form)ServiceLocator.GetService(type);
            else
                form = (Form)Activator.CreateInstance(type);

            return form;
        }
        /// <summary>
        /// 创建视图
        /// </summary>
        /// <typeparam name="T">窗体类型</typeparam>
        /// <returns></returns>
        public T CreateView<T>() where T : Form
        {
            T form;
            if (ServiceLocator.IsRegistered<T>())
                form = ServiceLocator.GetService<T>();
            else
                form = Activator.CreateInstance<T>();

            return form;
        }

        /// <summary>
        /// 切换系统模块
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public DataResult SwitchApp(long appId)
        {
            var app = this.User.AppList.Find(d => d.Id == appId);
            if (app == null)
                return DataResult.Fault();
            if (this.RuntimeSystemInfo.AppInfo == app) return DataResult.Fault();
            //设置切换后的系统模块信息
            this.RuntimeSystemInfo.AppInfo = app;
            this.RuntimeSystemInfo.DeptList = this.User.GetDeptListByApp(appId);
            this.RuntimeSystemInfo.DefaultDeptList = ServiceLocator.GetService<IDeptService>().GetDefaultByApp(appId);

            return DataResult.True();
        }

        /// <summary>
        /// 服务注册
        /// </summary>
        public void RegisterService()
        {
            var builder = new ContainerBuilder();

            var files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.TopDirectoryOnly).Concat(
               Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.exe", SearchOption.TopDirectoryOnly))
               .Where(f =>
               {
                   string name = System.IO.Path.GetFileNameWithoutExtension(f);
                   return name.StartsWith("HIS.") || name.StartsWith("App_") || name == "HIS";
               }).ToArray();

            var assemblies = files.Select(Assembly.LoadFrom).Distinct().ToArray();

            //注册单例服务方法
            builder.RegisterAssemblyTypes(assemblies)
                    .Where(type => typeof(IServiceSingleton).IsAssignableFrom(type) && !type.GetTypeInfo().IsAbstract && !typeof(IService).IsAssignableFrom(type))
                    .AsSelf()
                    .AsImplementedInterfaces()
                    .SingleInstance();

            //注册非单例服务方法
            builder.RegisterAssemblyTypes(assemblies)
                    .Where(type => !type.GetTypeInfo().IsAbstract && typeof(IService).IsAssignableFrom(type))
                    .AsSelf()
                    .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assemblies)
                    .Where(type => typeof(IModuleInitializer).IsAssignableFrom(type) && !type.GetTypeInfo().IsAbstract)
                    .As<IModuleInitializer>();

            //注册缓存拦截器
            builder.RegisterType<Interceptors.CacheInterceptor>();
            builder.RegisterType<Interceptors.LogInterceptor>();

            //使用接口缓存拦截
            builder.RegisterAssemblyTypes(assemblies)
                         .Where(type => type.FindMembers(MemberTypes.Method, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static, Type.FilterName, "*")
                         .Any(m => Attribute.IsDefined(m, typeof(Interceptors.CacheMethodAttribute)) || Attribute.IsDefined(m, typeof(Interceptors.LogAttribute))) && !type.GetTypeInfo().IsAbstract)
                         .AsImplementedInterfaces()
                         //.InstancePerLifetimeScope()
                         .InterceptedBy(new Type[] { typeof(Interceptors.CacheInterceptor), typeof(Interceptors.LogInterceptor) })//使用缓存拦截
                         .EnableInterfaceInterceptors();//启用接口拦截

            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes().Where(t => typeof(IServiceSingleton).GetTypeInfo().IsAssignableFrom(t) && t.GetTypeInfo().GetCustomAttribute<ServiceIdAttribute>() != null);
                foreach (var type in types)
                {
                    var module = type.GetTypeInfo().GetCustomAttribute<ServiceIdAttribute>();
                    //对ServiceId不为空的对象，找到第一个继承IService的接口并注入接口及实现
                    var interfaceObj = type.GetInterfaces()
                        .FirstOrDefault(t => typeof(IServiceSingleton).GetTypeInfo().IsAssignableFrom(t));

                    if (interfaceObj != null)
                    {
                        builder.RegisterType(type).AsImplementedInterfaces().Named(module.Id, interfaceObj);
                        builder.RegisterType(type).Named(module.Id, type);
                    }
                }
            }

            ServiceLocator.Current = builder.Build();

            AutoMapperHelper.Instance.Configuration();
        }

        /// <summary>
        /// 启动服务初始化
        /// </summary>
        public void StartServiceInitialize()
        {
            var starters = ServiceLocator.Current.Resolve<IList<IModuleInitializer>>();
            foreach (var item in starters)
            {
                item.OnApplicationStartInitialize(this.AppConfig.Configuration);
                item.OnApplicationStartInitialize();
            }
        }

        /// <summary>
        /// 初始化服务
        /// <param name="exeConfigFileName">程序配置文件路径</param>
        /// </summary>
        public void InitializeService(string exeConfigFileName = null)
        {
            this.RegisterService();

            Configuration configuration;
            if (exeConfigFileName.IsNullOrWhiteSpace())
                configuration = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
            else
            {
                exeConfigFileName.CheckFileExists(nameof(exeConfigFileName));
                var exeConfigMap = new System.Configuration.ExeConfigurationFileMap();
                exeConfigMap.ExeConfigFilename = exeConfigFileName;
                configuration = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(exeConfigMap, System.Configuration.ConfigurationUserLevel.None);
            }
            this.AppConfig = new AppConfig(configuration);

            this.StartServiceInitialize();
            InitNetInfo();

            //HIS.Utility.NativeMethods.SetLocalTime(DBHelper.ServerTime);
            //HIS.Utility.NativeMethods.UpdateLocalDateTimeFormat();
            #region 初始化系统运行中信息

            this.RuntimeSystemInfo = new RunSysInfo();
            //加载所需的机器信息
            this.RuntimeSystemInfo.MachineInfo = new MachineInfo()
            {
                ClientIP = MachineHelper.GetIPAddress()
                ,
                ClientMAC = MachineHelper.GetMacAddress()
                ,
                ComputeName = MachineHelper.HostName
                ,
                CPUSerialNo = MachineHelper.GetCPUSerialNo()
                ,
                HardDiskInfo = MachineHelper.GetHardDiskInfo()
            };
            //设置默认的医疗机构 登陆时必须的信息
            this.RuntimeSystemInfo.HospitalInfo = this.AppConfig.Hospital;
            #endregion

        }

    }
}
