using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core.Entities;
using HIS.Core;

namespace App_OP.MedicalRecord
{
    /// <summary>
    /// 门诊病历
    /// </summary>
    internal partial class UCRecord : OPStationUserControl, IOPStationData
    {
        private DeptEntity DeptEntity;
        public UCRecord()
        {
            InitializeComponent();
        }

        #region 接口实现

        public event EventHandler<OPStationDataModifyEventArgs> Modify;

        public void ChoosePatient(OutpatientEntity outpatient)
        {
            this.Enabled = true;
            this.ucWrite.OpenRecord(outpatient);
        }

        public bool DeptChanged(DeptEntity dept)
        {
            this.DeptEntity = dept;
            this.Init();
            return true;
        }

        public void FinishTreatment(OutpatientEntity outpatient)
        {

        }

        public void Init()
        {
            this.ucWrite.DeptEntity = this.DeptEntity;
            this.ucModelEssay.DeptEntity = this.DeptEntity;
            this.ucSubTemplate.DeptEntity = this.DeptEntity;
            this.ucWrite.Init();
            this.ucModelEssay.Init();
            this.ucSubTemplate.Init();
            this.Enabled = false;
            this.RegisterData(RegisterDataType.GetConditionSummary, p => this.GetConditionSummary());
        }

        public void Notify(DataModifyType actionId, object data)
        {
            switch (actionId)
            {
                case DataModifyType.PatientInfoChanged:
                    this.ucWrite.CheckRecord(data as PatientJournalEntity);
                    break;
            }
        }

        #endregion

        private string GetConditionSummary()
        {
            var nodes = App.Instance.GlobalSet.OPConditionSummaryNode;

            string resultValue = string.Empty;
            if (nodes != null || nodes.Count > 0)
            {
                resultValue = "456789";
            }

            return resultValue;
        }
    }
}
