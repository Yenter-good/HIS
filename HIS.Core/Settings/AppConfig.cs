
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Settings
{
    public class AppConfig
    {

        private IOrgService _orgService;

        internal Configuration Configuration { get; set; }
        internal AppConfig(Configuration configuration)
        {
            this.Configuration = configuration;
            this._orgService = ServiceLocator.GetService<IOrgService>();
        }
        /// <summary>
        /// 获取本地应用所在机构信息
        /// </summary>
        internal OrganizationInfo Hospital
        {
            get
            {
                int? orgId = GetConfigValue("OrgId").AsInt();
                if (!orgId.HasValue)
                {
                    MsgBox.OK("未配置本地默认机构信息");
                    System.Windows.Forms.Application.Exit();
                    return null;
                }
                var org = this._orgService.Get(orgId.Value);
                if (org == null)
                {
                    MsgBox.OK("请联系厂商设置机构授权或者机构未维护");
                    System.Windows.Forms.Application.Exit();
                    return null;
                }
                return org;
            }
        }
        public string LocalIP { get; set; }
        public string MAC { get; set; }

        private string GetConfigValue(string key, bool throwException = true)
        {
            key.CheckNotNullOrEmpty(nameof(key));
            try
            {
                return Configuration.AppSettings.Settings[key].Value;
            }
            catch (Exception)
            {
                if (throwException)
                    throw new Exception($"缺少[{key}]本地参数信息");
            }
            return "";
        }

    }
}
