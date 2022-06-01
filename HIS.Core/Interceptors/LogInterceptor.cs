using Castle.DynamicProxy;
using HIS.Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using HIS.Utility;

namespace HIS.Core.Interceptors
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-18 11:46:23
    /// 描述:
    /// </summary>
    public class LogInterceptor : IInterceptor
    {
        private ILogService _logService;

        public LogInterceptor()
        {
        }

        public void Intercept(IInvocation invocation)
        {
            var logAttribute = GetCachingAttribute(invocation.MethodInvocationTarget ?? invocation.Method);
            if (logAttribute == null)
            {
                //无日志标识 则照常操作
                invocation.Proceed();
                return;
            }
            if (_logService == null)
                _logService = ServiceLocator.GetService<ILogService>(App.Instance.GlobalSet.LogMode);

            this.ProcessLog(invocation, logAttribute);
        }

        private LogAttribute GetCachingAttribute(MethodInfo method)
        {
            return method.GetCustomAttributes<LogAttribute>(true).FirstOrDefault();
        }

        private void ProcessLog(IInvocation invocation, LogAttribute attribute)
        {
            var methodInfo = invocation.MethodInvocationTarget ?? invocation.Method;

            var arg = invocation.Arguments.BeginJsonSerializable();
            var action = attribute.Action;
            if (action.IsNullOrWhiteSpace())
                action = methodInfo.Name;

            invocation.Proceed();

            var result = invocation.ReturnValue.BeginJsonSerializable();

            _logService.Write(action, methodInfo.DeclaringType.ToString() + "." + methodInfo.Name, attribute.Description, arg, result, attribute.Level.GetDescription());
        }
    }
}
