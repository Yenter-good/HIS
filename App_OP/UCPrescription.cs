using HIS.Core;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_OP.Prescription
{
    internal partial class UCPrescription : OPStationUserControl, IOPStationData
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern bool ShowWindow(HandleRef hWnd, int nCmdShow);

        private IOPPrescriptionService _prescriptionService;

        private Dictionary<PrescriptionEntity, List<PrescriptionDetailEntity>> _dictPrescriptionDetail;

        private OutpatientEntity _patient;
        private Form _previewForm;
        private List<Form> _previewForms;

        public UCPrescription()
        {
            InitializeComponent();
        }

        public event EventHandler<OPStationDataModifyEventArgs> Modify;

        #region 接口实现

        public void ChoosePatient(OutpatientEntity outpatient)
        {

            _patient = outpatient;
            this.btnRefresh_Click(null, null);
        }

        public bool DeptChanged(DeptEntity dept)
        {
            return true;
        }

        public void FinishTreatment(OutpatientEntity outpatient)
        {
        }

        public void Init()
        {
            _prescriptionService = ServiceLocator.GetService<IOPPrescriptionService>();

            _previewForms = new List<Form>();
            _previewForms.Add(new FormWMDetailPreview());
            _previewForms.Add(new FormHMDetailPreview());
            _previewForms.Add(new FormItemDetailPreview());
            _previewForms.Add(new FormMeicalTechnologyPreview());

            _dictPrescriptionDetail = new Dictionary<PrescriptionEntity, List<PrescriptionDetailEntity>>();
        }
        #endregion

        /// <summary>
        /// 新处方
        /// </summary>
        /// <param name="args"></param>
        public void NewPrescription(PrescriptionSubmitEventArgs args)
        {
            var newRow = this.dgvPrescription.Rows[this.dgvPrescription.Rows.Add()];
            this.dgvPrescription.Rows.Remove(newRow);
            this.dgvPrescription.Rows.Insert(0, newRow);

            newRow.Cells[colCreationTime.Index].Value = args.Prescription.CreationTime;
            newRow.Cells[colCreatorName.Index].Value = args.Prescription.Creator.Name;
            newRow.Cells[colPrescriptionType.Index].Value = args.Prescription.PrescriptionType.Name;
            newRow.Cells[colPrescriptionStatus.Index].Value = args.Prescription.PrescriptionStatus.GetDescription();
            newRow.Cells[colDetailNumber.Index].Value = args.Prescription.DetailNumber;

            newRow.Tag = args.Prescription;

            _dictPrescriptionDetail[args.Prescription] = args.PrescriptionDetails;

            SetForeColorByStatus(newRow, args.Prescription.PrescriptionStatus);
        }

        public void Notify(DataModifyType actionId, object data)
        {
            if (actionId == DataModifyType.SavePrescription)
            {
                var args = data as PrescriptionSubmitEventArgs;

                foreach (DataGridViewRow row in this.dgvPrescription.Rows)
                {
                    if (row.Tag is PrescriptionEntity prescription)
                    {
                        if (prescription.Id == args.Prescription.Id)
                        {
                            prescription.PrescriptionStatus = args.Prescription.PrescriptionStatus;
                            row.Cells[colDetailNumber.Index].Value = args.PrescriptionDetails.Count;
                            row.Cells[colPrescriptionStatus.Index].Value = args.Prescription.PrescriptionStatus.GetDescription();

                            _dictPrescriptionDetail[args.Prescription] = args.PrescriptionDetails;

                            SetForeColorByStatus(row, args.Prescription.PrescriptionStatus);
                            return;
                        }
                    }
                }
                NewPrescription(args);
            }
        }

        #region 方法
        /// <summary>
        /// 根据处方状态改变颜色
        /// </summary>
        /// <param name="row"></param>
        /// <param name="status"></param>
        private void SetForeColorByStatus(DataGridViewRow row, PrescriptionStatus status)
        {
            if (status == PrescriptionStatus.New)
            {
                row.DefaultCellStyle.ForeColor = Color.Black;
                row.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
            else if (status == PrescriptionStatus.Send)
            {
                row.DefaultCellStyle.ForeColor = Color.Blue;
                row.DefaultCellStyle.SelectionForeColor = Color.Blue;
            }
            else if (status == PrescriptionStatus.Charge)
            {
                row.DefaultCellStyle.ForeColor = Color.Red;
                row.DefaultCellStyle.SelectionForeColor = Color.Red;
            }
            else if (status == PrescriptionStatus.Void)
            {
                row.DefaultCellStyle.ForeColor = Color.DarkGray;
                row.DefaultCellStyle.SelectionForeColor = Color.DarkGray;
            }
        }
        #endregion

        #region 窗体事件

        private void dgvPrescription_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedRow = this.dgvPrescription.Rows[e.RowIndex];
            var prescription = selectedRow.Tag as PrescriptionEntity;
            if (prescription == null)
                return;

            if (!_dictPrescriptionDetail.ContainsKey(prescription))
                _dictPrescriptionDetail[prescription] = _prescriptionService.GetPrescriptionDetails(prescription.Id.Value);

            Modify?.Invoke(this, new OPStationDataModifyEventArgs() { ActionId = DataModifyType.SelectPrescription, Data = new PrescriptionSubmitEventArgs() { Prescription = prescription, PrescriptionDetails = _dictPrescriptionDetail[prescription] } });
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvPrescription.GetSelectedRowsByCells();

            int errorPrescriptionNumber = 0;

            foreach (var row in selectedRows)
            {
                if (row.Tag is PrescriptionEntity prescription)
                {
                    if (prescription.Creator.Id != App.Instance.User.Id)
                    {
                        errorPrescriptionNumber++;
                        continue;
                    }

                    var result = _prescriptionService.UndoPrescription(prescription);
                    if (result.Success)
                    {
                        row.Cells[colPrescriptionStatus.Index].Value = PrescriptionStatus.New.GetDescription();
                        SetForeColorByStatus(row, PrescriptionStatus.New);
                    }
                    else
                    {
                        errorPrescriptionNumber++;
                        row.Cells[colPrescriptionStatus.Index].Value = result.Value.GetDescription();

                        SetForeColorByStatus(row, result.Value);
                    }
                }
            }

            if (errorPrescriptionNumber > 0)
                AlertBox.Info(selectedRows.Count - errorPrescriptionNumber + "条处方召回成功," + errorPrescriptionNumber + "条处方召回失败");
            else
                AlertBox.Info(selectedRows.Count + "条处方召回成功");

            this.Modify?.Invoke(this, new OPStationDataModifyEventArgs() { ActionId = DataModifyType.UndoPrescription });
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.dgvPrescription.Rows.Clear();

            var prescriptions = _prescriptionService.GetPrescription(_patient.OutpatientNo);
            foreach (var prescription in prescriptions)
            {
                var newRow = this.dgvPrescription.Rows[this.dgvPrescription.Rows.Add()];
                newRow.Cells[colCreationTime.Index].Value = prescription.CreationTime;
                newRow.Cells[colCreatorName.Index].Value = prescription.Creator.Name;
                newRow.Cells[colPrescriptionType.Index].Value = prescription.PrescriptionType.Name;
                newRow.Cells[colPrescriptionStatus.Index].Value = prescription.PrescriptionStatus.GetDescription();
                newRow.Cells[colDetailNumber.Index].Value = prescription.DetailNumber;

                SetForeColorByStatus(newRow, prescription.PrescriptionStatus);

                newRow.Tag = prescription;
            }

            this.Modify?.Invoke(this, new OPStationDataModifyEventArgs() { ActionId = DataModifyType.UndoPrescription });
        }

        private void dgvPrescription_MouseMove(object sender, MouseEventArgs e)
        {
            var hit = this.dgvPrescription.HitTest(e.Location.X, e.Location.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                if (_previewForm != null)
                    _previewForm.Hide();
                _previewForm = null;
            }

            if (hit.Type == DataGridViewHitTestType.Cell && hit.ColumnIndex == this.colWhite.Index)
            {
                this.dgvPrescription.ClearSelection();
                this.dgvPrescription.Rows[hit.RowIndex].Cells[colWhite.Index].Selected = true;

                var row = this.dgvPrescription.Rows[hit.RowIndex];
                var prescription = row.Tag as PrescriptionEntity;
                if (!_dictPrescriptionDetail.ContainsKey(prescription))
                    _dictPrescriptionDetail[prescription] = _prescriptionService.GetPrescriptionDetails(prescription.Id.Value);

                if (prescription.PrescriptionType.Type == PrscriptionType.西药中成药)
                {
                    var form = _previewForms.Find(p => p is FormWMDetailPreview);
                    if (_previewForm != null && _previewForm != form)
                        _previewForm.Hide();
                    _previewForm = form;
                    ShowWindow(new HandleRef(this, _previewForm.Handle), 4);
                    _previewForm.As<FormWMDetailPreview>().Init(_dictPrescriptionDetail[prescription]);
                }
                else if (prescription.PrescriptionType.Type == PrscriptionType.草药 || prescription.PrescriptionType.Type == PrscriptionType.颗粒剂)
                {
                    var form = _previewForms.Find(p => p is FormHMDetailPreview);
                    if (_previewForm != null && _previewForm != form)
                        _previewForm.Hide();
                    _previewForm = form;
                    ShowWindow(new HandleRef(this, _previewForm.Handle), 4);
                    _previewForm.As<FormHMDetailPreview>().Init(prescription, _dictPrescriptionDetail[prescription]);
                }
                else if (prescription.PrescriptionType.Type == PrscriptionType.治疗和材料)
                {
                    var form = _previewForms.Find(p => p is FormItemDetailPreview);
                    if (_previewForm != null && _previewForm != form)
                        _previewForm.Hide();
                    _previewForm = form;
                    ShowWindow(new HandleRef(this, _previewForm.Handle), 4);
                    _previewForm.As<FormItemDetailPreview>().Init(_dictPrescriptionDetail[prescription]);
                }
                else if (prescription.PrescriptionType.Type == PrscriptionType.检验 || prescription.PrescriptionType.Type == PrscriptionType.检查)
                {
                    var form = _previewForms.Find(p => p is FormMeicalTechnologyPreview);
                    if (_previewForm != null && _previewForm != form)
                        _previewForm.Hide();
                    _previewForm = form;
                    ShowWindow(new HandleRef(this, _previewForm.Handle), 4);
                    _previewForm.As<FormMeicalTechnologyPreview>().Init(_dictPrescriptionDetail[prescription]);
                }

                if (_previewForm != null && _previewForm.Visible)
                {
                    var point = this.dgvPrescription.PointToScreen(e.Location);
                    if (point.X + this._previewForm.Width >= Screen.PrimaryScreen.Bounds.Width)
                        this._previewForm.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this._previewForm.Width, point.Y + 20);
                    else if (point.X <= 0)
                        this._previewForm.Location = new Point(0, point.Y + 20);
                    else
                        this._previewForm.Location = new Point(point.X, point.Y + 20);

                    return;
                }
            }
            else
            {
                if (_previewForm != null)
                    _previewForm.Hide();
                _previewForm = null;
            }
        }

        private void dgvPrescription_MouseLeave(object sender, EventArgs e)
        {
            if (_previewForm != null)
                _previewForm.Hide();
            _previewForm = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvPrescription.GetSelectedRowsByCells();

            if (MsgBox.YesNo("是否确认删除这" + selectedRows.Count + "条处方") != DialogResult.Yes)
                return;

            int errorPrescriptionNumber = 0;

            foreach (var row in selectedRows)
            {
                if (row.Tag is PrescriptionEntity prescription)
                {
                    if (prescription.Creator.Id != App.Instance.User.Id)
                    {
                        errorPrescriptionNumber++;
                        continue;
                    }

                    var result = _prescriptionService.DeletePrescription(prescription);
                    if (result.Success)
                    {
                        this.dgvPrescription.Rows.Remove(row);
                    }
                    else
                    {
                        errorPrescriptionNumber++;
                        row.Cells[colPrescriptionStatus.Index].Value = result.Value.GetDescription();

                        SetForeColorByStatus(row, result.Value);
                    }
                }
            }

            if (errorPrescriptionNumber > 0)
                AlertBox.Info(selectedRows.Count - errorPrescriptionNumber + "条处方删除成功," + errorPrescriptionNumber + "条处方删除失败");
            else
                AlertBox.Info(selectedRows.Count + "条处方删除成功");

            this.Modify?.Invoke(this, new OPStationDataModifyEventArgs() { ActionId = DataModifyType.UndoPrescription });
        }
        #endregion
    }
}
