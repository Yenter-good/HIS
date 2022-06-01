using App_OP.PatientInfo;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.DSkinControl;
using HIS.Service.Core.Entities;
using HIS.Utility;
using HIS.Utility.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace App_OP
{
    public partial class FormMain : BaseForm
    {

        private Dictionary<RegisterDataType, Func<object, object>> _dictDataExchange;
        private List<IOPStationData> _oPStationDatas;
        private OutpatientEntity _selectedOutpatient;

        private IOPJournalService _journalService;

        private SuperTabItem _selectedTabItem;


        public FormMain(IOPJournalService journalService)
        {
            InitializeComponent();

            _journalService = journalService;

            this._dictDataExchange = new Dictionary<RegisterDataType, Func<object, object>>();
            this._oPStationDatas = new List<IOPStationData>();

            this.tbxOutpatientNo.GotFocus += TbxOutpatientNo_GotFocus;
            this.tbxName.GotFocus += TbxOutpatientNo_GotFocus;
            this.tbxAge.GotFocus += TbxOutpatientNo_GotFocus;
            this.tbxCategory.GotFocus += TbxOutpatientNo_GotFocus;
            this.tbxGender.GotFocus += TbxOutpatientNo_GotFocus;
            this.tbxPayType.GotFocus += TbxOutpatientNo_GotFocus;
        }

        private void TbxOutpatientNo_GotFocus(object sender, EventArgs e)
        {
            UnsafeNativeMethods.SendMessage(sender.As<TextBoxX>().Handle, (int)WinMsg.WM_KILLFOCUS, 0, 0);
        }

        private void Uc_GetDataHandler(object sender, GetDataEventArgs e)
        {
            if (_dictDataExchange.ContainsKey(e.Key))
                e.Value = _dictDataExchange[e.Key].Invoke(e.Arg);
        }

        private void Uc_RegisterDataHandler(object sender, RegisterDataEventArgs e)
        {
            if (e.Func == null || _dictDataExchange.ContainsKey(e.Key))
                return;

            _dictDataExchange[e.Key] = e.Func;
        }

        private void Uc_ShowMeHandler(object sender, EventArgs e)
        {
            foreach (SuperTabItem item in this.tabMain.Tabs)
            {
                if (item.AttachedControl.Controls.Count > 0)
                {
                    if (item.AttachedControl.Controls[0] == sender as Control)
                    {
                        this.tabMain.SelectedTab = item;
                        return;
                    }
                }
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                this.pnlPatientInfo.Style.BorderSide = eBorderSide.Right | eBorderSide.Bottom;

                if (ucRecord is OPStationUserControl record)
                {
                    record.RegisterDataHandler += Uc_RegisterDataHandler;
                    record.GetDataHandler += Uc_GetDataHandler;
                }
                if (ucRecord is IOPStationData irecord)
                {
                    this._oPStationDatas.Add(irecord);
                    irecord.DeptChanged(ViewData.Dept);
                    irecord.Init();
                    irecord.Modify += OP_Modify;
                }
                foreach (var view in pnlFunctionArea.Controls)
                {
                    if (view is OPStationUserControl uc)
                    {
                        uc.RegisterDataHandler += Uc_RegisterDataHandler;
                        uc.GetDataHandler += Uc_GetDataHandler;
                    }
                    if (view is IOPStationData oP)
                    {
                        this._oPStationDatas.Add(oP);
                        oP.Init();
                        oP.DeptChanged(ViewData.Dept);
                        oP.Modify += OP_Modify;
                    }
                }
                foreach (var item in this.tabMain.Tabs)
                {
                    if (item is SuperTabItem)
                    {
                        Control ctr = (item as SuperTabItem).AttachedControl;
                        if (ctr.Controls.Count == 0)
                            continue;
                        var view = ctr.Controls[0];
                        if (view is OPStationUserControl uc)
                        {
                            uc.RegisterDataHandler += Uc_RegisterDataHandler;
                            uc.GetDataHandler += Uc_GetDataHandler;
                            uc.ShowMeHandler += Uc_ShowMeHandler;
                        }
                        if (view is IOPStationData oP)
                        {
                            this._oPStationDatas.Add(oP);
                            oP.Init();
                            oP.DeptChanged(ViewData.Dept);
                            oP.Modify += OP_Modify;
                        }
                    }
                }

                this.expandableSplitter1.BackColor = this.tabMain.BackColor;
                this.expandableSplitter1.BackColor2 = this.tabMain.BackColor;
                this.expandableSplitter2.BackColor = this.tabMain.BackColor;
                this.expandableSplitter2.BackColor2 = this.tabMain.BackColor;

                this.tabMain_SelectedTabChanged(this, new SuperTabStripSelectedTabChangedEventArgs(null, this.tabMedicalRecordButton, eEventSource.Code));
            });
        }


        private void OP_Modify(object sender, OPStationDataModifyEventArgs e)
        {
            this.SendMsg(p =>
            {
                if (p != sender)
                    p.Notify(e.ActionId, e.Data);
            });
        }

        private void SendMsg(Action<IOPStationData> a)
        {
            this._oPStationDatas.ForEach(p =>
            {
                a.Invoke(p);
            });
        }
        protected override void OnDeptChanging(DeptEntity dept, CancelEventArgs args)
        {
            this.SendMsg((p) =>
            {
                var result = p.DeptChanged(dept);
                if (!result)
                    return;
            });
            base.OnDeptChanging(dept, args);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            FormPatientList dialog = App.Instance.CreateView<FormPatientList>();
            this.SetChildView(dialog);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _selectedOutpatient = dialog.Outpatient;

                SetPatientInfo();

                this.SendMsg((p) =>
                {
                    p.ChoosePatient(dialog.Outpatient);
                });
            }
        }

        private void SetPatientInfo()
        {
            this.tbxOutpatientNo.Text = _selectedOutpatient.OutpatientNo;
            this.tbxName.Text = _selectedOutpatient.PatientName;
            this.tbxAge.Text = _selectedOutpatient.Age;
            this.tbxGender.Text = _selectedOutpatient.Gender.GetDescription();
            this.tbxPayType.Text = _selectedOutpatient.PayType.GetDescription();
            this.tbxCategory.Text = _selectedOutpatient.Category;

            var age = _selectedOutpatient.Age.GetAge();
            if (_selectedOutpatient.Gender == HIS.Service.Core.Enums.Gender.Man)
            {
                if (age > 14 && age < 50)
                    this.pictureBox1.Image = Properties.Resources.man2;
                else if (age >= 50)
                    this.pictureBox1.Image = Properties.Resources.man1;
            }
            else
            {
                if (age > 14 && age < 50)
                    this.pictureBox1.Image = Properties.Resources.woman2;
                else if (age >= 50)
                    this.pictureBox1.Image = Properties.Resources.woman1;
            }
        }

        private void tbxOutpatientNo_ButtonCustomClick(object sender, EventArgs e)
        {
            var tbx = sender as TextBoxX;
            try
            {
                Clipboard.SetText(tbx.Text);
                tbx.ShowTips("复制成功", 1);
            }
            catch
            {
                tbx.ShowTips("复制失败", 1);
            }

        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            if (_selectedOutpatient == null)
                return;

            PatientJournal.FormEditJournal dialog = App.Instance.CreateView<PatientJournal.FormEditJournal>();
            dialog.Dept = ViewData.Dept;
            dialog.OutpatientNo = _selectedOutpatient.OutpatientNo;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.SendMsg(p => p.Notify(DataModifyType.PatientInfoChanged, dialog.ModifyPatientJournalEntity));
            }
        }

        private void tabMain_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            if (e.NewValue == this.tabMedicalRecordButton)
            {
                this.pnlPrescription.Hide();
                this.pnlMedicalRecord.Show();
                this.tabMainMedicalRecord.SelectedTab = this.tabMedicalRecord;
            }

            _selectedTabItem = e.NewValue as SuperTabItem;

            if (_selectedTabItem.AttachedControl.Controls.Count > 0)
            {
                if (_selectedTabItem.AttachedControl.Controls[0] is OPStationUserControl control)
                {
                    this.pnlFunctionArea.Height = control.FunctionAreaHeight;
                }
            }

        }

        private void pnlFunctionArea_SizeChanged(object sender, EventArgs e)
        {
            if (_selectedTabItem == null)
                return;

            if (_selectedTabItem.AttachedControl.Controls.Count > 0)
            {
                if (_selectedTabItem.AttachedControl.Controls[0] is OPStationUserControl control)
                {
                    control.FunctionAreaHeight = this.pnlFunctionArea.Height;
                }
            }
        }

        private void tabMainMedicalRecord_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            if (e.NewValue != this.tabMedicalRecord)
            {
                this.pnlMedicalRecord.Hide();
                this.pnlPrescription.Show();

                this.tabMain.SelectedTabIndex = this.tabMainMedicalRecord.SelectedTabIndex;
            }
        }
    }
}
