using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HIS.Core.UI;
using HIS.Service.Core.Entities;
using HIS.Service.Core;
using HIS.Core;
using HIS.Service.Core.Enums;
using HIS.DSkinControl;
using DevComponents.DotNetBar;
using App_OP.PatientJournal;

namespace App_OP.PatientInfo
{
    /// <summary>
    /// 门诊患者列表
    /// </summary>
    public partial class FormPatientList : BaseForm
    {
        /// <summary>
        /// 门诊患者服务
        /// </summary>
        private readonly IOPPatientService _iOPPatientService;
        /// <summary>
        /// 门诊日志服务
        /// </summary>
        private readonly IOPJournalService _iOPJournalService;
        /// <summary>
        /// 科室待就诊列表
        /// </summary>
        private UCBasePatientList _deptIdlePatientList;
        /// <summary>
        /// 科室就诊中列表
        /// </summary>
        private UCPatientList _deptProcessPatientList;
        /// <summary>
        /// 科室就诊结束列表
        /// </summary>
        private UCPatientList _deptFinishPatientList;
        /// <summary>
        /// 专家待就诊列表
        /// </summary>
        private UCPatientList _expertIdlePatientList;
        /// <summary>
        /// 专家就诊中列表
        /// </summary>
        private UCPatientList _expertProcessPatientList;
        /// <summary>
        /// 专家就诊结束列表
        /// </summary>
        private UCPatientList _expertFinishPatientList;
        /// <summary>
        /// 门诊患者
        /// </summary>
        public OutpatientEntity Outpatient;
        /// <summary>
        /// 当前选中的患者页
        /// </summary>
        private SuperTabControl CurrentSelectedPatientTab
        {
            get
            {
                if (this.IsSelectedDeptTab)
                    return this.deptTabMain;

                return this.expertTabMain;
            }
        }
        /// <summary>
        /// 是否选中科室页
        /// </summary>
        private bool IsSelectedDeptTab
        {
            get
            {
                return this.tabMain.SelectedTabIndex == 0;
            }
        }

        public FormPatientList(IOPPatientService iOPPatientService, IOPJournalService iOPJournalService)
        {
            InitializeComponent();

            this._iOPPatientService = iOPPatientService;
            this._iOPJournalService = iOPJournalService;

            this.InitPatientList();
        }

        private void InitPatientList()
        {
            //科室待就诊
            this._deptIdlePatientList = new UCBasePatientList();
            this._deptIdlePatientList.Dock = DockStyle.Fill;
            this._deptIdlePatientList.SelectedPatient += SelectedPatient;
            this.sTCP1.Controls.Add(this._deptIdlePatientList);

            //科室就诊中
            this._deptProcessPatientList = new UCPatientList();
            this._deptProcessPatientList.Dock = DockStyle.Fill;
            this._deptProcessPatientList.SelectedPatient += SelectedPatient;
            this.sTCP2.Controls.Add(this._deptProcessPatientList);

            //科室就诊结束
            this._deptFinishPatientList = new UCPatientList();
            this._deptFinishPatientList.Dock = DockStyle.Fill;
            this._deptFinishPatientList.SelectedPatient += SelectedPatient;
            this.sTCP3.Controls.Add(this._deptFinishPatientList);

            //专家待就诊
            this._expertIdlePatientList = new UCPatientList();
            this._expertIdlePatientList.Dock = DockStyle.Fill;
            this._expertIdlePatientList.SelectedPatient += SelectedPatient;
            this.sTCP4.Controls.Add(this._expertIdlePatientList);

            //专家就诊中
            this._expertProcessPatientList = new UCPatientList();
            this._expertProcessPatientList.Dock = DockStyle.Fill;
            this._expertProcessPatientList.SelectedPatient += SelectedPatient;
            this.sTCP5.Controls.Add(this._expertProcessPatientList);

            //专家就诊结束
            this._expertFinishPatientList = new UCPatientList();
            this._expertFinishPatientList.Dock = DockStyle.Fill;
            this._expertFinishPatientList.SelectedPatient += SelectedPatient;
            this.sTCP6.Controls.Add(this._expertFinishPatientList);

            //设置自定义日期
            this.btnCustomDay.Text = $"{App.Instance.GlobalSet.OPPatientEffectiveDay}天内患者";
        }

        private int GetPatientEffectiveDay()
        {
            if (this.btnCustomDay.Checked)
                return App.Instance.GlobalSet.OPPatientEffectiveDay;
            else
                return 0;
        }

        #region 方法
        private void LoadData()
        {
            this.ShowMask(() =>
            {
                var patients = this._iOPPatientService.GetOPPatientList(this.ViewData.Dept.Id, this.GetPatientEffectiveDay());

                //科室待就诊数据
                List<OutpatientEntity> deptIdlePatients;
                //科室就诊中数据
                List<OutpatientEntity> deptProcessPatients;
                //科室就诊结束数据
                List<OutpatientEntity> deptFinishPatients;
                if (App.Instance.RuntimeSystemInfo.UserInfo.UserType == UserType.Admin)
                {
                    deptIdlePatients = patients.Where(d => d.Status == OutpatientStatus.Idle).OrderBy(d => d.OrderNumber).ToList();
                    deptProcessPatients = patients.Where(d => d.Status == OutpatientStatus.Process).OrderBy(d => d.OrderNumber).ToList();
                    deptFinishPatients = patients.Where(d => d.Status == OutpatientStatus.Finish).OrderBy(d => d.OrderNumber).ToList();
                }
                else
                {
                    deptIdlePatients = patients.Where(d => d.Status == OutpatientStatus.Idle && d.Doctor.Id == 0).OrderBy(d => d.OrderNumber).ToList();
                    deptProcessPatients = patients.Where(d => d.Status == OutpatientStatus.Process && d.Doctor.Id == 0).OrderBy(d => d.OrderNumber).ToList();
                    deptFinishPatients = patients.Where(d => d.Status == OutpatientStatus.Finish && d.Doctor.Id == 0).OrderBy(d => d.OrderNumber).ToList();
                }

                //专家待就诊数据
                List<OutpatientEntity> expertIdlePatients = patients.Where(d => d.Doctor.Id == App.Instance.RuntimeSystemInfo.UserInfo.Id && d.Status == OutpatientStatus.Idle).OrderBy(d => d.OrderNumber).ToList();
                //专家就诊中数据
                List<OutpatientEntity> expertProcessPatients = patients.Where(d => d.Doctor.Id == App.Instance.RuntimeSystemInfo.UserInfo.Id && d.Status == OutpatientStatus.Process).OrderBy(d => d.OrderNumber).ToList();
                //专家就诊结束数据
                List<OutpatientEntity> expertFinishPatients = patients.Where(d => d.Doctor.Id == App.Instance.RuntimeSystemInfo.UserInfo.Id && d.Status == OutpatientStatus.Finish).OrderBy(d => d.OrderNumber).ToList();

                //科室待就诊人数
                int deptIdlePatientCount = deptIdlePatients.Count;
                //科室就诊中人数
                int deptProcessPatientCount = deptProcessPatients.Count;
                //科室就诊结束人数
                int deptFinishPatientCount = deptFinishPatients.Count;
                //科室患者总人数
                int deptPatientCount = deptIdlePatientCount + deptProcessPatientCount + deptFinishPatientCount;

                //专家待就诊数据
                int expertIdlePatientCount = expertIdlePatients.Count;
                //专家就诊中数据
                int expertProcessPatientCount = expertProcessPatients.Count;
                //专家就诊结束数据
                int expertFinishPatientsCount = expertFinishPatients.Count;
                //专家患者总人数
                int expertPatientCount = expertIdlePatientCount + expertProcessPatientCount + expertFinishPatientsCount;

                this.tabDept.Text = $"科   室({deptPatientCount})人";
                this.tabPersonnel.Text = $"专   家({expertPatientCount})人";
                this.Stb1.Text = $"待就诊({deptIdlePatientCount})人";
                this.Stb2.Text = $"就诊中({deptProcessPatientCount})人";
                this.Stb3.Text = $"就诊结束({deptFinishPatientCount})人";
                this.Stb4.Text = $"待就诊({expertIdlePatientCount})人";
                this.Stb5.Text = $"就诊中({expertProcessPatientCount})人";
                this.Stb6.Text = $"就诊结束({expertFinishPatientsCount})人";

                this._deptIdlePatientList.Init();
                this._deptProcessPatientList.Init();
                this._deptFinishPatientList.Init();

                this._expertIdlePatientList.Init();
                this._expertProcessPatientList.Init();
                this._expertFinishPatientList.Init();

                this._deptIdlePatientList.DataSource = deptIdlePatients;
                this._deptProcessPatientList.DataSource = deptProcessPatients;
                this._deptFinishPatientList.DataSource = deptFinishPatients;

                this._expertIdlePatientList.DataSource = deptIdlePatients;
                this._expertProcessPatientList.DataSource = deptProcessPatients;
                this._expertFinishPatientList.DataSource = deptFinishPatients;

                (this.CurrentSelectedPatientTab.SelectedTab.AttachedControl.Controls[0] as UCBasePatientList).tbxSearch.Focus();

            });
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region 窗体事件

        private void SelectedPatient(object sender, OutpatientEntity outpatientEntity)
        {
            var result = this._iOPJournalService.AddJournal(outpatientEntity);
            if (result.Success)
            {
                this.Outpatient = outpatientEntity;

                if (!this._iOPJournalService.JournalEffective(this.Outpatient.OutpatientNo))
                {
                    FormEditJournal dialog = App.Instance.CreateView<FormEditJournal>();
                    dialog.Dept = ViewData.Dept;
                    dialog.OutpatientNo = this.Outpatient.OutpatientNo;
                    dialog.ShowDialog();
                }
                this.Outpatient.FirstOrSecond = this._iOPJournalService.FirstOrSecond(this.Outpatient.OutpatientNo);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MsgBox.OK($"门诊日志添加失败\r\n{result.Message}");
        }
        private void btnReflesh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void FormPatientList_Shown(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChangePatientEffectiveDay(object sender, EventArgs e)
        {
            var bti = sender as ButtonItem;
            if (!bti.Checked)
            {
                bti.Checked = true;
                if (bti == this.btnSameDay)
                    this.btnCustomDay.Checked = false;
                else
                    this.btnSameDay.Checked = false;
            }
            this.LoadData();
        }
        #endregion

    }
}
