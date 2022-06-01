using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Core;
using HIS.Service.Core.Enums;
using HIS.Utility.Win32;
using DevComponents.DotNetBar;

namespace App_OP.Prescription
{
    internal partial class UCPatientDiagnosis : OPStationUserControl, IOPStationData
    {
        private IOPPatientDiagnosisService _patientDiagnosisService;
        private IDiagnosisService _diagnosisService;
        private IOPPrescriptionService _prescriptionService;

        private OutpatientEntity _patient;
        private DeptEntity _dept;

        private List<DiagnosisEntity> _allDiagnosisEntities;
        private List<DiagnosisEntity> _allDiagnosisGroupEntities;

        public event EventHandler<OPStationDataModifyEventArgs> Modify;

        public UCPatientDiagnosis()
        {
            InitializeComponent();

        }

        #region 接口实现

        public void ChoosePatient(OutpatientEntity outpatient)
        {
            _patient = outpatient;
            InitPatientDiagnosis();
        }

        public void FinishTreatment(OutpatientEntity outpatient)
        {
            _patient = null;
            this.dgvDiagnosis.Rows.Clear();
        }

        public void Init()
        {
            this.RegisterData(RegisterDataType.GetAllDiagnosis, p => GetAllPatientDiagnosis());

            this.dgvDiagnosisFilter.Container = new HIS.ControlLib.Container(this.dgvDiagnosis, this.colName);

            _patientDiagnosisService = ServiceLocator.GetService<IOPPatientDiagnosisService>();
            _diagnosisService = ServiceLocator.GetService<IDiagnosisService>();
            _prescriptionService = ServiceLocator.GetService<IOPPrescriptionService>();

            _allDiagnosisEntities = _diagnosisService.Get();

            InitFilter();

            this.dgvDiagnosis.Rows.Clear();

            GotoNewRow();
        }

        public bool DeptChanged(DeptEntity dept)
        {
            _dept = dept;
            _allDiagnosisGroupEntities = _patientDiagnosisService.GetDiagnosisGroup(_dept.Id);

            return true;
        }

        public void Notify(DataModifyType actionId, object data)
        {
        }
        #endregion

        #region 初始化
        /// <summary>
        /// 寻找新的空白行,如果没有则创建
        /// </summary>
        private void GotoNewRow()
        {
            if (_patient == null)
                return;
            var whiteRow = this.dgvDiagnosis.Rows.Cast<DataGridViewRow>().ToList().Find(p => p.Tag is null);

            if (whiteRow is null)
            {
                var newIndex = this.dgvDiagnosis.Rows.Add();
                whiteRow = this.dgvDiagnosis.Rows[newIndex];
            }

            this.dgvDiagnosis.CurrentCell = whiteRow.Cells[colName.Index];
            this.dgvDiagnosis.BeginEdit(true);
        }
        /// <summary>
        /// 初始化病人诊断
        /// </summary>
        private void InitPatientDiagnosis()
        {
            var diagnosis = _patientDiagnosisService.Get(_patient.OutpatientNo);
            this.dgvDiagnosis.Rows.Clear();

            foreach (var entity in diagnosis)
            {
                var newIndex = this.dgvDiagnosis.Rows.Add();
                var newRow = this.dgvDiagnosis.Rows[newIndex];

                newRow.Cells[colPrefix.Index].Value = entity.Prefix;
                newRow.Cells[colName.Index].Value = entity.Diagnosis.Name;
                newRow.Cells[colPostfix.Index].Value = entity.Postfix;
                newRow.Cells[colConfirmFlag.Index].Value = entity.ConfirmFlag;
                newRow.Cells[colMainFlag.Index].Value = entity.MainFlag;

                if (entity.CreatorUser.Id != App.Instance.User.Id)
                    newRow.ReadOnly = true;

                newRow.Tag = entity;
            }

            GotoNewRow();
        }
        /// <summary>
        /// 初始化检索条件
        /// </summary>
        private void InitFilter()
        {
            this.dgvDiagnosisFilter.SetFilterCondition(p =>
            {
                this.dgvDiagnosisFilter.Rows.Clear();
                if (p == "")
                    return;
                string searchCode = p.ToUpper();

                IEnumerable<DiagnosisEntity> filter;
                if (this.btnCommon.Checked)
                    filter = _allDiagnosisGroupEntities.Where(d => d.SearchCode.Contains(searchCode) || d.Name.Contains(searchCode)).OrderBy(d => d.Length).Take(100);
                else
                {
                    DiagnosisType type;
                    if (this.btnICD.Checked)
                        type = DiagnosisType.ICD;
                    else if (this.btnCMDiagnosis.Checked)
                        type = DiagnosisType.CMDiagnosis;
                    else
                        type = DiagnosisType.CMSymptoms;

                    filter = _allDiagnosisEntities.Where(d => (d.SearchCode.Contains(searchCode) || d.Name.Contains(searchCode)) && d.Type == type).OrderBy(d => d.Length).Take(100);
                }
                foreach (var item in filter)
                {
                    var newIndex = this.dgvDiagnosisFilter.Rows.Add();
                    var newRow = this.dgvDiagnosisFilter.Rows[newIndex];

                    newRow.Cells[colFilterName.Index].Value = item.Name;
                    newRow.Cells[colFilterType.Index].Value = item.Type.GetDescription();
                    newRow.Tag = item;
                }
            });
        }

        private List<PatientDiagnosisEntity> GetAllPatientDiagnosis()
        {
            if (this.dgvDiagnosis.Rows.Count == 0)
                return new List<PatientDiagnosisEntity>();

            return this.dgvDiagnosis.Rows.Cast<DataGridViewRow>().Where(p => p.Tag is PatientDiagnosisEntity).Select(p => p.Tag as PatientDiagnosisEntity).ToList();
        }
        #endregion

        #region 窗体事件

        private void dgvDiagnosis_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == this.colConfirmFlag.Index)
                e.Value = e.Value == null ? "" : e.Value.AsBoolean() ? "确诊" : "疑似";
            else if (e.ColumnIndex == this.colMainFlag.Index)
                e.Value = e.Value == null ? "" : e.Value.AsBoolean() ? "√" : "";
        }

        private void dgvDiagnosis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            this.dgvDiagnosis.BeginEdit(true);
            var entity = this.dgvDiagnosis.Rows[e.RowIndex].Tag as PatientDiagnosisEntity;
            if (entity == null)
                return;
            if (e.ColumnIndex == this.colConfirmFlag.Index || e.ColumnIndex == this.colMainFlag.Index)
            {
                if (entity.CreatorUser.Id != App.Instance.User.Id)
                {
                    MsgBox.OK("该诊断不是您创建的,无法操作");
                    return;
                }
            }

            if (e.ColumnIndex == this.colConfirmFlag.Index)
            {
                entity.ConfirmFlag = !entity.ConfirmFlag;
                this.dgvDiagnosis.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = entity.ConfirmFlag;

                var result = _patientDiagnosisService.UpdateConfirmFlag(entity.Id, !entity.ConfirmFlag);
                if (!result.Success)
                {
                    entity.ConfirmFlag = !entity.ConfirmFlag;
                    this.dgvDiagnosis.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = entity.ConfirmFlag;
                    MsgBox.OK("修改失败" + Environment.NewLine + result.Message);
                }
            }
            else if (e.ColumnIndex == this.colMainFlag.Index && !entity.MainFlag)
            {
                var result = _patientDiagnosisService.UpdateMainFlag(entity.Id, _patient.OutpatientNo);
                if (result.Success)
                {
                    foreach (DataGridViewRow row in this.dgvDiagnosis.Rows)
                    {
                        if (row.Tag is PatientDiagnosisEntity diagnosis)
                        {
                            if (diagnosis == entity)
                                continue;
                            diagnosis.MainFlag = false;
                            row.Cells[colMainFlag.Index].Value = diagnosis.MainFlag;
                        }
                    }

                    entity.MainFlag = true;
                    this.dgvDiagnosis.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = entity.MainFlag;

                    this.Notify(DataModifyType.MainDiagnosisChanged, entity);
                }
                else
                {
                    MsgBox.OK("修改失败" + Environment.NewLine + result.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GotoNewRow();
        }

        private void dgvDiagnosis_SpecialKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var selectedRows = this.dgvDiagnosisFilter.SelectedRows;
                if (selectedRows.Count == 0)
                    return;

                this.dgvDiagnosis.EndEdit();
                var diagnosisRow = this.dgvDiagnosis.CurrentCell.OwningRow;
                var entity = selectedRows[0].Tag as DiagnosisEntity;

                foreach (DataGridViewRow row in this.dgvDiagnosis.Rows)
                {
                    if (row == diagnosisRow)
                        continue;
                    if (row.Tag is PatientDiagnosisEntity diagnosisEntity)
                    {
                        if (diagnosisEntity.Diagnosis.Code == entity.Code)
                        {
                            MsgBox.OK("已经添加相同的诊断");
                            diagnosisRow.Cells[colName.Index].Value = "";
                            return;
                        }
                    }
                }

                PatientDiagnosisEntity patientDiagnosis;

                //如果当前诊断行不为null,那么就更新诊断,否则新增诊断
                if (diagnosisRow.Tag != null)
                {
                    patientDiagnosis = diagnosisRow.Tag as PatientDiagnosisEntity;
                    if (patientDiagnosis.Diagnosis.Code == entity.Code)
                        return;

                    var result = _patientDiagnosisService.UpdateDiagnosis(patientDiagnosis.Id, entity);
                    if (!result.Success)
                    {
                        MsgBox.OK("更新诊断失败" + Environment.NewLine + result.Message);
                        return;
                    }

                    patientDiagnosis.Diagnosis = entity;
                }
                else
                {
                    //创建新的用户诊断实体,新增完成后赋值到界面
                    patientDiagnosis = new PatientDiagnosisEntity();
                    patientDiagnosis.Diagnosis = entity;
                    patientDiagnosis.Prefix = diagnosisRow.Cells[colPrefix.Index].Value.AsString("");
                    patientDiagnosis.Postfix = diagnosisRow.Cells[colPostfix.Index].Value.AsString("");
                    patientDiagnosis.ConfirmFlag = true;
                    patientDiagnosis.CreatorUser = App.Instance.RuntimeSystemInfo.UserInfo;

                    if (this.dgvDiagnosis.Rows.Cast<DataGridViewRow>().Count(p => p.Tag != null) == 0)
                        patientDiagnosis.MainFlag = true;
                    else
                        patientDiagnosis.MainFlag = false;
                    var result = _patientDiagnosisService.AddDiagnosis(patientDiagnosis, _patient.OutpatientNo, _dept.Id);
                    if (!result.Success)
                    {
                        MsgBox.OK("添加诊断失败" + Environment.NewLine + result.Message);
                        return;
                    }
                    patientDiagnosis.Id = result.Value;
                }

                diagnosisRow.Cells[colName.Index].Value = patientDiagnosis.Diagnosis.Name;
                diagnosisRow.Cells[colConfirmFlag.Index].Value = patientDiagnosis.ConfirmFlag;
                diagnosisRow.Cells[colMainFlag.Index].Value = patientDiagnosis.MainFlag;
                diagnosisRow.Tag = patientDiagnosis;

                this.Modify?.Invoke(this, new OPStationDataModifyEventArgs() { ActionId = DataModifyType.DiagnosisChanged, Data = this.GetAllPatientDiagnosis() });

                GotoNewRow();

            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                UnsafeNativeMethods.SendMessage(this.dgvDiagnosisFilter.Handle, (int)WinMsg.WM_KEYDOWN, e.KeyValue, 0);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                GotoNewRow();
            }
        }

        private void dgvDiagnosis_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDiagnosis.Rows[e.RowIndex].Tag == null)
                return;

            var entity = this.dgvDiagnosis.Rows[e.RowIndex].Tag as PatientDiagnosisEntity;

            if (e.ColumnIndex == this.colPrefix.Index)
            {
                _patientDiagnosisService.UpdatePrefix(entity.Id, this.dgvDiagnosis.Rows[e.RowIndex].Cells[colPrefix.Index].Value.AsString(""));
            }
            else if (e.ColumnIndex == this.colPostfix.Index)
            {
                _patientDiagnosisService.UpdatePostfix(entity.Id, this.dgvDiagnosis.Rows[e.RowIndex].Cells[colPostfix.Index].Value.AsString(""));
            }
            else if (e.ColumnIndex == this.colName.Index)
            {
                if (this.dgvDiagnosis.Rows[e.RowIndex].Cells[colName.Index].Value.AsString("") != entity.Diagnosis.Name)
                    this.dgvDiagnosis.Rows[colName.Index].Cells[colName.Index].Value = entity.Diagnosis.Name;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDiagnosis.SelectedCells.Cast<DataGridViewCell>().Select(p => p.OwningRow).Distinct().ToList();
            foreach (var row in selectedRows)
            {
                var entity = row.Tag as PatientDiagnosisEntity;
                if (entity == null)
                    continue;
                if (entity.CreatorUser.Id != App.Instance.User.Id)
                {
                    MsgBox.OK(entity.Diagnosis.Name + "删除失败,该诊断不是您创建的,无法操作");
                    continue;
                }
                if (_prescriptionService.ExistsPrescriptionByDiagnosis(_patient.OutpatientNo, entity.Diagnosis.Code))
                {
                    MsgBox.OK(entity.Diagnosis.Name + "删除失败,该诊断已经被一条处方绑定,无法删除");
                    continue;
                }

                var result = _patientDiagnosisService.DeleteDiagnosis(entity.Id);
                if (result.Success)
                {
                    this.dgvDiagnosis.Rows.Remove(row);
                    this.Modify?.Invoke(this, new OPStationDataModifyEventArgs() { ActionId = DataModifyType.DiagnosisChanged, Data = this.GetAllPatientDiagnosis() });
                }
                else
                    MsgBox.OK(entity.Diagnosis.Name + "删除失败" + Environment.NewLine + result.Message);
            }
        }

        private void dgvDiagnosisFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvDiagnosis_SpecialKeyDown(this, new KeyEventArgs(Keys.Enter));
        }
        #endregion

        private void btnCommon_Click(object sender, EventArgs e)
        {
            this.btnCommon.Checked = false;
            this.btnICD.Checked = false;
            this.btnCMDiagnosis.Checked = false;
            this.btnCMSymptoms.Checked = false;

            sender.As<ButtonItem>().Checked = true;
        }
    }
}
