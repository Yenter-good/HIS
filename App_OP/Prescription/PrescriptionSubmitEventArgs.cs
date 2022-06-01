using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_OP
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-02-23 11:02:56
    /// 描述:
    /// </summary>
    internal class PrescriptionSubmitEventArgs : EventArgs
    {
        /// <summary>
        /// 处方
        /// </summary>
        public PrescriptionEntity Prescription { get; set; }
        /// <summary>
        /// 处方明细
        /// </summary>
        public List<PrescriptionDetailEntity> PrescriptionDetails { get; set; }
    }
}
