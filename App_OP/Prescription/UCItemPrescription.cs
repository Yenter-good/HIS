using HIS.Service.Core.Entities;
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
using HIS.Service.Core.Enums;
using HIS.Core;
using DevComponents.DotNetBar;
using HIS.Utility;
using HIS.Utility.Win32;

namespace App_OP.Prescription
{
    internal partial class UCItemPrescription : UserControl, IPrescriptionInit
    {
        private DeptEntity _dept;
        private OutpatientEntity _patient;

        private IOPPrescriptionService _prescriptionService;
        private IOPGroupService _groupService;
        private IOPJournalService _journalService;

        private List<PrescriptionTypeEntity> _prescriptionTypes;
        private DataGridViewColumn[] _readOnlyColumns;

        private PrescriptionEntity _selectedPrescription;
        private PrescriptionTypeEntity _selectedPrescriptionType;
        private List<DealWithItemEntity> _allDealWithItem;

        private bool _modify;

        public UCItemPrescription()
        {
            InitializeComponent();
        }

        public OutpatientEntity Outpatient { get; set; }
        public DeptEntity Dept { get; set; }
        public PatientDiagnosisEntity MainDiagnosis { get; set; }

        public event EventHandler<PrescriptionSubmitEventArgs> Submit;

        #region 接口实现

        public void ClearAll()
        {
            _selectedPrescription = null;
            _selectedPrescriptionType = null;
            this.dgvDrug.Rows.Clear();
            EnableButton(false);
        }

        public void DiagnosisChanged(List<PatientDiagnosisEntity> diagnosis)
        {
            if (diagnosis.Count == 0)
            {
                this.ClearAll();
                this.EnableButton(false);
                this.EnableNewPrescription(false);
            }
            else
            {
                this.EnableNewPrescription(true);
                this.EnableButton(true);
                if (_selectedPrescriptionType == null)
                    this.InitNormalPresciption();
            }
        }

        public void EnableButton(bool enable)
        {
            this.btnAdd.Enabled = enable;
            this.btnDelete.Enabled = enable;
            this.btnSave.Enabled = enable;
            this.btnHistoryPrescription.Enabled = enable;
            this.btnSelectAll.Enabled = enable;
            this.btnUp.Enabled = enable;
            this.btnDown.Enabled = enable;
        }

        public void EnableNewPrescription(bool enable)
        {
            this.btnNew.Enabled = enable;
        }

        public void InitData()
        {
            _prescriptionService = ServiceLocator.GetService<IOPPrescriptionService>();
            _groupService = ServiceLocator.GetService<IOPGroupService>();
            _journalService = ServiceLocator.GetService<IOPJournalService>();
        }

        public void InitNormalPresciption()
        {
            var _normalPrescriptionType = App.Instance.UserSet.NormalItemPrescriptionTypeCode;

            _selectedPrescriptionType = _prescriptionTypes.Find(p => p.Code == _normalPrescriptionType);
            if (_selectedPrescriptionType == null)
                _selectedPrescriptionType = _prescriptionTypes[0];

            NewPrescription(_selectedPrescriptionType);
        }

        public bool InitPharmacy(List<DeptEntity> execDepts)
        {
            return true;
        }

        public void InitUI(List<PrescriptionTypeEntity> prescriptionTypes)
        {
            _prescriptionTypes = prescriptionTypes.Where(p => p.Type == PrscriptionType.治疗和材料).ToList();

            _readOnlyColumns = new DataGridViewColumn[] { this.colSpecification, this.colPrice, this.colTotal, this.colWhite };

            this.dgvDrug.NameColumn = this.colName;

            this.dgvDrug.Rows.Clear();

            //初始化处方类型,如果只有一个类型,就不创建下拉
            if (_prescriptionTypes.Count == 1)
            {
                this.btnNew.Text = "添加" + _prescriptionTypes[0].Name;
                this.btnNew.Tag = _prescriptionTypes[0];
                this.btnNew.AutoExpandOnClick = false;
                this.btnNew.Click -= PrescriptionType_Click;
                this.btnNew.Click += PrescriptionType_Click;

                this.menuNew.Text = "添加" + _prescriptionTypes[0].Name;
                this.menuNew.Tag = _prescriptionTypes[0];
                this.menuNew.AutoExpandOnClick = false;
                this.menuNew.Click -= PrescriptionType_Click;
                this.menuNew.Click += PrescriptionType_Click;
            }
            else
            {
                this.btnNew.SubItems.Clear();
                foreach (var item in _prescriptionTypes)
                {
                    var prescriptionType = new ButtonItem();
                    prescriptionType.Text = item.Name;
                    prescriptionType.Tag = item;
                    prescriptionType.Click += PrescriptionType_Click;
                    this.btnNew.SubItems.Add(prescriptionType);
                }

                this.menuNew.SubItems.Clear();
                foreach (var item in _prescriptionTypes)
                {
                    var prescriptionType = new ButtonItem();
                    prescriptionType.Text = item.Name;
                    prescriptionType.Tag = item;
                    prescriptionType.Click += PrescriptionType_Click;
                    this.menuNew.SubItems.Add(prescriptionType);
                }
            }

            this.dgvDrugFilter.Container = new HIS.ControlLib.Container(this.dgvDrug, this.colName);

            InitDrugFilter();

            EnableNewPrescription(false);
            EnableButton(false);
        }

        #endregion

        #region 方法
        private void EnableDGV(bool enable)
        {
            if (enable)
            {
                this.dgvDrug.ReadOnly = false;
                foreach (var column in _readOnlyColumns)
                    column.ReadOnly = true;
            }
            else
                this.dgvDrug.ReadOnly = true;
        }
        private void InitDrugFilter()
        {
            this.dgvDrugFilter.SetFilterCondition(p =>
            {
                var text = p.ToUpper();

                var filter = _allDealWithItem.Where(d => d.SearchCode.Contains(text) || d.Name.Contains(text) || d.WubiCode.Contains(text)).Take(50);

                this.dgvDrugFilter.Rows.Clear();
                foreach (var drug in filter)
                {
                    var newRow = this.dgvDrugFilter.Rows[this.dgvDrugFilter.Rows.Add()];
                    newRow.Cells[colNameFilter.Index].Value = drug.Name;
                    newRow.Cells[colSpecification.Index].Value = drug.Specification;
                    newRow.Cells[colPriceFilter.Index].Value = drug.Price;
                    newRow.Tag = drug;
                }
            });
        }
        /// <summary>
        /// 新建处方
        /// </summary>
        /// <param name="prescriptionType"></param>
        private void NewPrescription(PrescriptionTypeEntity prescriptionType)
        {
            if (_selectedPrescription != null && _selectedPrescription.PrescriptionStatus == PrescriptionStatus.New && _modify)
            {
                var dialogResult = MsgBox.YesNo("您当前有未保存的处方,是否放弃保存");
                if (dialogResult != DialogResult.Yes)
                    return;
            }

            _selectedPrescription = null;

            this.dgvDrug.Rows.Clear();

            _allDealWithItem = _groupService.GetDealWithItem();

            this.EnableButton(true);
            this.EnableDGV(true);

            this.dgvDrug.GotoNextRow();
        }
        /// <summary>
        /// 初始化处方明细
        /// </summary>
        /// <param name="prescription"></param>
        public void InitPrescription(PrescriptionEntity prescription, List<PrescriptionDetailEntity> details)
        {
            if (prescription == _selectedPrescription)
                return;
            _selectedPrescription = prescription;

            if (_selectedPrescription.PrescriptionStatus == PrescriptionStatus.New && _modify)
            {
                var dialogResult = MsgBox.YesNo("您当前有未保存的处方,是否放弃保存");
                if (dialogResult != DialogResult.Yes)
                    return;
            }

            this.dgvDrug.Rows.Clear();

            if (prescription.PrescriptionStatus == PrescriptionStatus.New)
            {
                EnableButton(true);
                EnableDGV(true);
            }
            else
            {
                EnableButton(false);
                EnableDGV(false);
                this.dgvDrug.ReadOnly = true;
            }

            foreach (var detail in details)
            {
                var item = _allDealWithItem.Find(p => p.Code == detail.SpecificationCode);
                if (item == null)
                    continue;

                var newRow = this.dgvDrug.Rows[this.dgvDrug.Rows.Add()];

                newRow.Cells[colName.Index].Value = item.Name;
                newRow.Cells[colSpecification.Index].Value = item.Specification;
                newRow.Cells[colQuantity.Index].Value = detail.Quantity;
                newRow.Cells[colPrice.Index].Value = detail.Price;
                newRow.Cells[colTotal.Index].Value = detail.Total;

                if (detail.CustomPriceFlag)
                {
                    newRow.Cells[colPrice.Index].ReadOnly = false;
                    newRow.Cells[colPrice.Index].Style.BackColor = Color.White;
                    newRow.Cells[colPrice.Index].Style.SelectionBackColor = Color.White;
                }
                else
                {
                    newRow.Cells[colPrice.Index].ReadOnly = true;
                    newRow.Cells[colPrice.Index].Style.BackColor = Color.LightGray;
                    newRow.Cells[colPrice.Index].Style.SelectionBackColor = Color.LightGray;
                }

                newRow.Tag = item.Mapper<PrescriptionDrugEntity>().JoinMapper(detail);
            }

            if (prescription.PrescriptionStatus == PrescriptionStatus.New)
                this.dgvDrug.GotoNextRow();

        }
        /// <summary>
        /// 将药品库存实体中的信息填充到指定行中
        /// </summary>
        /// <param name="row"></param>
        /// <param name="drugEntity"></param>
        private void FillDataToRow(DataGridViewRow row, DealWithItemEntity drugEntity)
        {
            row.Cells[colName.Index].Value = drugEntity.Name;
            row.Cells[colSpecification.Index].Value = drugEntity.Specification;
            row.Cells[colPackageUnit.Index].Value = drugEntity.PackageUnit;
            row.Cells[colQuantity.Index].Value = 1;
            row.Cells[colPrice.Index].Value = drugEntity.Price;
            row.Cells[colTotal.Index].Value = drugEntity.Price;

            if (drugEntity.Price == 0)
            {
                row.Cells[colPrice.Index].ReadOnly = false;
                row.Cells[colPrice.Index].Style.BackColor = Color.White;
                row.Cells[colPrice.Index].Style.SelectionBackColor = Color.White;
            }
            else
            {
                row.Cells[colPrice.Index].ReadOnly = true;
                row.Cells[colPrice.Index].Style.BackColor = Color.LightGray;
                row.Cells[colPrice.Index].Style.SelectionBackColor = Color.LightGray;
            }

            var detail = drugEntity.Mapper<PrescriptionDrugEntity>(); ;
            if (detail.ExecDept == null)
                detail.ExecDept = Dept;

            detail.Quantity = 1;
            detail.Day = 1;
            detail.BigPackageFlag = true;

            row.Tag = detail;
        }
        private PrescriptionDetailEntity FillRowToEntity(DataGridViewRow row)
        {
            PrescriptionDrugEntity drug = row.Tag as PrescriptionDrugEntity;

            var result = drug.Mapper<PrescriptionDetailEntity>();
            result.No = row.Index;

            return result;
        }
        private void NameColumnKeyDown(Keys keys)
        {
            if (keys == Keys.Enter)
            {
                if (!this.dgvDrugFilter.PopupVisible)
                    return;

                var selectedRow = this.dgvDrug.CurrentCell.OwningRow;
                var filterRows = this.dgvDrugFilter.SelectedRows;
                if (filterRows.Count == 0)
                    return;


                var filterRow = filterRows[0];
                var filterDrug = filterRow.Tag as DealWithItemEntity;

                foreach (DataGridViewRow row in this.dgvDrug.Rows)
                {
                    if (row.Tag is PrescriptionDrugEntity drug)
                    {
                        if (drug.SpecificationCode == filterDrug.Code)
                        {
                            AlertBox.Info("该项目已开立,无法重复开立");
                            return;
                        }
                    }
                }

                this.dgvDrug.EndEdit();

                FillDataToRow(selectedRow, filterDrug);
            }
            else if (keys == Keys.Up || keys == Keys.Down)
                UnsafeNativeMethods.SendMessage(this.dgvDrugFilter.Handle, (int)WinMsg.WM_KEYDOWN, (int)keys, 0);
        }
        private void GoUp(List<DataGridViewRow> rows)
        {
            if (rows[0].Index == 0)
                return;

            var upRow = this.dgvDrug.Rows[rows[0].Index - 1];

            this.dgvDrug.Rows.Remove(upRow);
            this.dgvDrug.Rows.Insert(rows[rows.Count - 1].Index + 1, upRow);
        }
        private void GoDown(List<DataGridViewRow> rows)
        {
            if (rows[rows.Count - 1].Index == this.dgvDrug.Rows.Count - 1 || this.dgvDrug.Rows[rows[rows.Count - 1].Index + 1].Tag == null)
                return;

            var downRow = this.dgvDrug.Rows[rows[rows.Count - 1].Index + 1];

            this.dgvDrug.Rows.Remove(downRow);
            this.dgvDrug.Rows.Insert(rows[0].Index, downRow);
        }
        private void GoUp(DataGridViewRow row)
        {
            if (row.Index == 0)
                return;

            var upRow = this.dgvDrug.Rows[row.Index - 1];

            this.dgvDrug.Rows.Remove(upRow);
            this.dgvDrug.Rows.Insert(row.Index + 1, upRow);
        }
        private void GoDown(DataGridViewRow row)
        {
            if (row.Index == this.dgvDrug.Rows.Count - 1 || this.dgvDrug.Rows[row.Index + 1].Tag == null)
                return;

            var downRow = this.dgvDrug.Rows[row.Index + 1];

            this.dgvDrug.Rows.Remove(downRow);
            this.dgvDrug.Rows.Insert(row.Index, downRow);
        }
        #endregion

        #region 窗体事件

        private void PrescriptionType_Click(object sender, EventArgs e)
        {
            _selectedPrescriptionType = sender.As<ButtonItem>().Tag as PrescriptionTypeEntity;

            NewPrescription(_selectedPrescriptionType);
        }

        private void dgvDrug_SpecialKeyDown(object sender, KeyEventArgs e)
        {
            if (this.dgvDrug.CurrentCell.ColumnIndex == this.colName.Index)
                NameColumnKeyDown(e.KeyCode);

            if (e.KeyCode == Keys.Enter)
            {
                if (this.dgvDrug.CurrentCell.ColumnIndex == this.colName.Index && this.dgvDrug.CurrentCell.OwningRow.Tag == null)
                    return;
                this.dgvDrug.GotoNextCell();
            }
            else if (e.KeyCode == Keys.Escape)
                this.dgvDrug.EndEdit();
        }

        private void dgvDrug_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.colQuantity.Index || e.ColumnIndex == this.colPrice.Index)
            {
                if (this.dgvDrug.Rows[e.RowIndex].Tag is PrescriptionDrugEntity drug)
                {
                    var value = this.dgvDrug.Rows[e.RowIndex].Cells[colQuantity.Index].Value;
                    var quantity = value.AsInt(1);

                    drug.Quantity = quantity;

                    if (drug.CustomPriceFlag)
                        drug.BigPackagePrice = this.dgvDrug.Rows[e.RowIndex].Cells[colPrice.Index].Value.AsDecimal(1);

                    drug.Total = drug.BigPackagePrice * quantity;

                    this.dgvDrug.Rows[e.RowIndex].Cells[colTotal.Index].Value = drug.Total;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<PrescriptionDetailEntity> details = new List<PrescriptionDetailEntity>();

            this.dgvDrug.EndEdit();

            if (!_journalService.JournalEffective(Outpatient.OutpatientNo))
            {
                PatientJournal.FormEditJournal dialog = App.Instance.CreateView<PatientJournal.FormEditJournal>();
                dialog.Dept = Dept;
                dialog.OutpatientNo = Outpatient.OutpatientNo;
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
            }

            foreach (DataGridViewRow row in this.dgvDrug.Rows)
            {
                if (row.Tag != null)
                    details.Add(FillRowToEntity(row));
            }

            var prescription = _selectedPrescription;
            if (prescription == null)
            {
                prescription = new PrescriptionEntity();

                prescription.PrescriptionType = _selectedPrescriptionType;
                prescription.Creator = App.Instance.RuntimeSystemInfo.UserInfo;
                prescription.Outpatient = Outpatient;
                prescription.IDCard = Outpatient.IDCard;
                prescription.CardNo = Outpatient.CardNo;
                prescription.DetailNumber = details.Count;
                prescription.Dept = Dept;
                prescription.PrescriptionStatus = PrescriptionStatus.Send;
                prescription.Diagnosis = MainDiagnosis.Diagnosis;
            }

            var result = _prescriptionService.SavePrescriptionDetail(prescription, details);
            if (result.Success)
            {
                AlertBox.Info("保存成功");
                this.Submit?.Invoke(this, new PrescriptionSubmitEventArgs() { Prescription = prescription, PrescriptionDetails = details });
                NewPrescription(_selectedPrescriptionType);
            }
            else
            {
                MsgBox.OK("保存失败" + Environment.NewLine + result.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.dgvDrug.GotoNextRow();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDrug.GetSelectedRowsByCells().Where(p => p.Tag != null);

            if (MsgBox.YesNo("是否删除这" + selectedRows.Count() + "项记录") != DialogResult.Yes)
                return;

            foreach (var row in selectedRows)
            {
                this.dgvDrug.Rows.Remove(row);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            this.dgvDrug.SelectAll();

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDrug.GetSelectedRowsByCells().Where(p => p.Tag != null).ToList();

            Dictionary<int, List<int>> dictCellIndexs = new Dictionary<int, List<int>>();
            var selectedCells = this.dgvDrug.SelectedCells.Cast<DataGridViewCell>().OrderBy(p => p.RowIndex).ToList();
            foreach (var cell in selectedCells)
            {
                if (!dictCellIndexs.ContainsKey(cell.RowIndex))
                    dictCellIndexs[cell.RowIndex] = new List<int>();

                dictCellIndexs[cell.RowIndex].Add(cell.ColumnIndex);
            }
            var cellIndexs = dictCellIndexs.Select(p => p.Value).ToList();

            if (selectedRows.Count == 1)
                GoUp(selectedRows[0]);
            else
                GoUp(selectedRows);

            this.dgvDrug.ClearSelection();
            for (int i = 0; i < selectedRows.Count; i++)
            {
                for (int j = 0; j < cellIndexs[i].Count; j++)
                {
                    selectedRows[i].Cells[cellIndexs[i][j]].Selected = true;
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDrug.GetSelectedRowsByCells().Where(p => p.Tag != null).ToList();

            Dictionary<int, List<int>> dictCellIndexs = new Dictionary<int, List<int>>();
            var selectedCells = this.dgvDrug.SelectedCells.Cast<DataGridViewCell>().OrderBy(p => p.RowIndex).ToList();
            foreach (var cell in selectedCells)
            {
                if (!dictCellIndexs.ContainsKey(cell.RowIndex))
                    dictCellIndexs[cell.RowIndex] = new List<int>();

                dictCellIndexs[cell.RowIndex].Add(cell.ColumnIndex);
            }
            var cellIndexs = dictCellIndexs.Select(p => p.Value).ToList();

            if (selectedRows.Count == 1)
                GoDown(selectedRows[0]);
            else
                GoDown(selectedRows);

            this.dgvDrug.ClearSelection();
            for (int i = 0; i < selectedRows.Count; i++)
            {
                for (int j = 0; j < cellIndexs[i].Count; j++)
                {
                    selectedRows[i].Cells[cellIndexs[i][j]].Selected = true;
                }
            }
        }

        private void dgvDrug_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                this.menuBar.Popup(MousePosition);
        }
        #endregion
    }
}
