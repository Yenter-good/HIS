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
using HIS.Service.Core.Enums;
using DevComponents.DotNetBar;
using HIS.Service.Core;
using HIS.Core;
using HIS.DSkinControl;
using DCSoft.Writer.Controls;
using System.Diagnostics;
using DCSoft.Writer;
using HIS.Utility.Extensions;

namespace App_OP.MedicalRecord
{
    internal partial class UCWrite : UserControl
    {
        internal DeptEntity DeptEntity;
        private IOPMedicalRecordService _iOPMedicalRecordService;
        private IOPDataElementService _oPDataElementService;
        private OutpatientEntity _patientEntity;
        private List<DataElementEntity> _dataElementEntities;
        private MedicalRecordEntity _medicalRecordEntity;
        public UCWrite()
        {
            InitializeComponent();
        }

        #region 方法
        internal void Init()
        {
            this._iOPMedicalRecordService = ServiceLocator.GetService<IOPMedicalRecordService>();
            this._oPDataElementService = ServiceLocator.GetService<IOPDataElementService>();
            this._dataElementEntities = this._oPDataElementService.GetList();
            this.cWrite.CommandControler = this.wcc;
            this.cWrite.CommandControler.Start();
            this.cWrite.ContextMenuStrip = this.contextMenuStrip;
            this.cWrite.SetZoomRate(1.25f);
            this.cWrite.FormView = FormViewMode.Strict;
            this.cWrite.DocumentOptions.ViewOptions.FieldBackColor = Color.White;
            this.cWrite.DocumentOptions.ViewOptions.FieldBorderColor = Color.Blue;
            this.cWrite.DocumentOptions.ViewOptions.FieldFocusedBackColor = Color.White;
            this.cWrite.DocumentOptions.ViewOptions.FieldHoverBackColor = Color.White;
            this.cWrite.DocumentOptions.ViewOptions.HiddenFieldBorderWhenLostFocus = true;
        }

        internal void OpenRecord(OutpatientEntity outpatientEntity)
        {
            if (this._patientEntity == null || this._patientEntity != outpatientEntity)
                this._patientEntity = outpatientEntity;
            this.ShowMask(() =>
            {
                this._medicalRecordEntity = this._iOPMedicalRecordService.GetMedicalRecord(outpatientEntity.OutpatientNo);
                if (this._medicalRecordEntity == null)
                {
                    BigTemplateType bigTemplateType = (BigTemplateType)this._patientEntity.FirstOrSecond;
                    this.cWrite.XMLText = this._iOPMedicalRecordService.GetAvailableBigTemplateContent(outpatientEntity.Dept.Id, bigTemplateType);
                    this.InitBasicsData();
                }
                else
                    this.cWrite.XMLText = this._medicalRecordEntity.Content;
            });
        }
        internal void CheckRecord(PatientJournalEntity patientJournalEntity)
        {
            if (patientJournalEntity != null)
            {
                if (this._patientEntity.FirstOrSecond != patientJournalEntity.FirstOrSecond)
                {
                    this._patientEntity.FirstOrSecond = patientJournalEntity.FirstOrSecond.Value;
                    MsgBox.OK("当前患者的初复诊状态和对应的病历模板不一致,系统即将切换模板");
                    this.OpenRecord(this._patientEntity);
                }
            }
        }

        private void InitBasicsData()
        {

        }
        private bool Save()
        {
            if (this._patientEntity == null)
                return false;

            return true;
        }

        #endregion

        #region 事件
        private void btnSpecialSymbols_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\Resource\SpecialSymbol\QuickInput.exe");
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.cWrite.Print(() => { return Save(); });
        }
        private void btnPerview_Click(object sender, EventArgs e)
        {
            this.cWrite.Preview();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            AlertBox.Info(this.Save() ? "病历保存成功" : "病历保存失败");
        }
        private void cWrite_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(nameof(SubTemplateSampleEntity)))
            {
                var data = e.Data.GetData(nameof(SubTemplateSampleEntity));
                this.cWrite.CurrentInputField.AppendXML(data.ToString());
            }
        }
        #endregion
    }
}
