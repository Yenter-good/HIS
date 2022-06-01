using Queuing.Core;
using Queuing.Service.Core.Entities;
using Queuing.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-06 09:36:46
/// 功能:
/// </summary>
namespace Queuing.Common
{
    public class NetPackageFactory
    {
        public NetEntity Get(NetIntention intention)
        {
            if (intention == NetIntention.RequestThumbnail)
                return GetRequestThumbnail();
            else
                return null;
        }

        private NetEntity GetRequestThumbnail()
        {
            NetEntity result = new NetEntity();
            result.SourceIP = App.Instance.AppConfig.LocalIP;
            result.SourceMAC = App.Instance.AppConfig.MAC;
            result.Intention = NetIntention.RequestThumbnail;

            return result;
        }

    }

}
