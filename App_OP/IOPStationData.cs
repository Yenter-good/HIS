using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_OP
{
    /// <summary>
    /// 门诊医生站数据接口
    /// </summary>
    internal interface IOPStationData
    {
        /// <summary>
        /// 选择患者
        /// </summary>
        /// <param name="outpatient"></param>
        void ChoosePatient(OutpatientEntity outpatient);
        /// <summary>
        /// 结束就诊
        /// </summary>
        /// <param name="outpatient"></param>
        void FinishTreatment(OutpatientEntity outpatient);
        /// <summary>
        /// 初始化
        /// </summary>
        void Init();
        /// <summary>
        /// 科室变更
        /// </summary>
        /// <param name="dept"></param>
        bool DeptChanged(DeptEntity dept);
        /// <summary>
        /// 发生更改
        /// </summary>
        /// <returns></returns>
        event EventHandler<OPStationDataModifyEventArgs> Modify;
        /// <summary>
        /// 通知更改
        /// </summary>
        /// <param name="actionId"></param>
        /// <param name="data"></param>
        void Notify(DataModifyType actionId, object data);
    }

    internal class OPStationDataModifyEventArgs
    {
        public DataModifyType ActionId { get; set; }
        public object Data { get; set; }
    }

    internal class GetDataEventArgs
    {
        public RegisterDataType Key { get; set; }
        public object Arg { get; set; }
        public object Value { get; set; }
    }
    internal class RegisterDataEventArgs
    {
        public RegisterDataType Key { get; set; }
        public Func<object, object> Func { get; set; }
    }

  
}
