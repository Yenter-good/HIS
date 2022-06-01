using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Cache
{
    /// <summary>
    /// 缓存键清单
    /// </summary>
    public struct CacheKeys
    {
        public const string ISysDicService_GetListByDicCode = "ISysDicService.GetListByDicCode{0}";
        public const string IRoleService_GetAuthority = "IRoleService_GetAuthority{0}";
        public const string IOPPrescriptionService_GetPrescriptionType = "IOPPrescriptionService_GetPrescriptionType";
        public const string IDiagnosisService_Get = "IDiagnosisService_Get";
    }
}
