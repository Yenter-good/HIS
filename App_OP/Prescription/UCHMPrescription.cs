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
using HIS.Service.Core.Enums;
using HIS.Core;
using DevComponents.DotNetBar;
using DevComponents.Editors;
using HIS.Utility;
using HIS.Utility.Win32;

namespace App_OP.Prescription
{
    internal partial class UCHMPrescription : UserControl, IPrescriptionInit
    {
        private IDrugInventoryService _inventoryService;
        private IOPPrescriptionService _prescriptionService;
        private IUsageService _usageService;
        private IIntervalService _intervalService;
        private IOPJournalService _journalService;

        private bool _modify;

        private List<DrugInventoryEntity> _allDrugEntities;
        private List<UsageEntity> _allUsageEntities;
        private List<IntervalEntity> _allIntervalEntities;

        private List<PrescriptionTypeEntity> _prescriptionTypes;
        private DataGridViewColumn[] _readOnlyColumns;

        private PrescriptionEntity _selectedPrescription;
        private PrescriptionTypeEntity _selectedPrescriptionType;
        private DeptEntity _selectPharmacy;
        private IntervalEntity _selectInterval;
        private UsageEntity _selectUsage;

        public UCHMPrescription()
        {
            InitializeComponent();
        }

        public event EventHandler<PrescriptionSubmitEventArgs> Submit;

        [Browsable(true), Description("是否颗粒剂编辑器")]
        public HMPrescriptionEditor GranulesEditor { get; set; }

        /// <summary>
        /// 病人
        /// </summary>
        public OutpatientEntity Outpatient { get; set; }
        /// <summary>
        /// 当前科室
        /// </summary>
        public DeptEntity Dept { get; set; }
        /// <summary>
        /// 当前主诊断
        /// </summary>
        public PatientDiagnosisEntity MainDiagnosis { get; set; }

        #region 初始化
        /// <summary>
        /// 初始化数据
        /// </summary>
        public void InitData()
        {
            _inventoryService = ServiceLocator.GetService<IDrugInventoryService>();
            _prescriptionService = ServiceLocator.GetService<IOPPrescriptionService>();
            _usageService = ServiceLocator.GetService<IUsageService>();
            _intervalService = ServiceLocator.GetService<IIntervalService>();
            _journalService = ServiceLocator.GetService<IOPJournalService>();

            _allUsageEntities = _usageService.GetAll(1);
            _allIntervalEntities = _intervalService.GetAll(1);
        }
        /// <summary>
        /// 初始化执行科室
        /// </summary>
        /// <param name="execDepts"></param>
        public bool InitPharmacy(List<DeptEntity> execDepts)
        {
            if (this._selectedPrescription != null && this._selectedPrescription.PrescriptionStatus == PrescriptionStatus.New && _modify)
            {
                var dialogResult = MsgBox.YesNo("您当前有未保存的处方,是否放弃保存");
                if (dialogResult != DialogResult.Yes)
                    return false;
            }

            this.cbxPharmacy.Items.Clear();
            //初始化药房科室
            foreach (var pharmacy in execDepts.Where(p => p.CategoryDetail == DeptCategoryDetail.HMPharmacy && p.Category.Value == DeptCategory.门诊.ToString()))
            {
                ComboItem item = new ComboItem(pharmacy.Name);
                item.Tag = pharmacy;
                this.cbxPharmacy.Items.Add(item);
            }

            if (this.cbxPharmacy.Items.Count > 0)
                this.cbxPharmacy.SelectedIndex = 0;
            return true;
        }
        /// <summary>
        /// 初始化界面
        /// </summary>
        /// <param name="prescriptionTypes"></param>
        /// <param name="pharmacies"></param>
        public void InitUI(List<PrescriptionTypeEntity> prescriptionTypes)
        {
            if (GranulesEditor == HMPrescriptionEditor.全部)
            {
                _prescriptionTypes = prescriptionTypes.Where(p => p.Type == PrscriptionType.草药).ToList();
                this.btnSave.Text = "保存草药";
            }
            else if (GranulesEditor == HMPrescriptionEditor.饮片)
            {
                _prescriptionTypes = prescriptionTypes.Where(p => p.Type == PrscriptionType.草药).ToList();
                this.btnSave.Text = "保存饮片";
            }
            else
            {
                _prescriptionTypes = prescriptionTypes.Where(p => p.Type == PrscriptionType.颗粒剂).ToList();
                this.btnSave.Text = "保存颗粒剂";
            }

            _readOnlyColumns = new DataGridViewColumn[] { this.colSpecification, this.colDoseUnit, this.colManufacturer, this.colPrice, this.colTotal, this.colWhite };

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

            //初始化药品、用法、间隔、皮试的选择框
            this.dgvDrugFilter.Container = new HIS.ControlLib.Container(this.dgvDrug, this.colName);
            this.dgvUsageFilter.Container = new HIS.ControlLib.Container(this.dgvDrug, this.colUsage);

            InitDrugFilter();
            InitUsageFilter();

            this.cbxInterval.Items.Clear();
            foreach (var interval in _allIntervalEntities)
            {
                ComboItem item = new ComboItem(interval.Name);
                item.Tag = interval;
                this.cbxInterval.Items.Add(item);
            }
            if (this.cbxInterval.Items.Count > 0)
                this.cbxInterval.SelectedIndex = 0;

            this.cbxUsage.Items.Clear();
            foreach (var usage in _allUsageEntities)
            {
                ComboItem item = new ComboItem(usage.Name);
                item.Tag = usage;
                this.cbxUsage.Items.Add(item);
            }
            if (this.cbxUsage.Items.Count > 0)
                this.cbxUsage.SelectedIndex = 0;

            EnableNewPrescription(false);
            EnableButton(false);
        }
        /// <summary>
        /// 初始化药品过滤
        /// </summary>
        private void InitDrugFilter()
        {
            this.dgvDrugFilter.SetFilterCondition(p =>
            {
                var text = p.ToUpper();

                var filter = _allDrugEntities.Where(d => d.SearchCode.Contains(text) || d.DrugName.Contains(text) || d.TradeName.Contains(text) || d.WubiCode.Contains(text) && d.DataStatus == DataStatus.Enable).Take(50);

                this.dgvDrugFilter.Rows.Clear();
                foreach (var drug in filter)
                {
                    var newRow = this.dgvDrugFilter.Rows[this.dgvDrugFilter.Rows.Add()];
                    newRow.Cells[colNameFilter.Index].Value = drug.DrugName;
                    newRow.Cells[colSpecification.Index].Value = drug.Specification;
                    newRow.Cells[colPriceFilter.Index].Value = drug.BigPackagePrice;
                    newRow.Cells[colManufacturerFilter.Index].Value = drug.Manufacturer;
                    newRow.Tag = drug;
                }
            });
        }
        /// <summary>
        /// 初始化用法过滤
        /// </summary>
        private void InitUsageFilter()
        {
            this.dgvUsageFilter.SetFilterCondition(p =>
            {
                var text = p.ToLower();

                var filter = _allUsageEntities.Where(d => d.SearchCode.Contains(text) || d.Name.Contains(text) || d.WubiCode.Contains(text) || d.Code.Contains(text));

                this.dgvUsageFilter.Rows.Clear();
                foreach (var usage in filter)
                {
                    var newRow = this.dgvUsageFilter.Rows[this.dgvUsageFilter.Rows.Add()];
                    newRow.Cells[colUsageCodeFilter.Index].Value = usage.Code;
                    newRow.Cells[colUsageNameFilter.Index].Value = usage.Name;
                    newRow.Tag = usage;
                }
            });
            this.dgvUsageFilter.SetInitEditCondition(p =>
            {
                this.dgvUsageFilter.Rows.Clear();
                foreach (var usage in _allUsageEntities)
                {
                    var newRow = this.dgvUsageFilter.Rows[this.dgvUsageFilter.Rows.Add()];
                    newRow.Cells[colUsageCodeFilter.Index].Value = usage.Code;
                    newRow.Cells[colUsageNameFilter.Index].Value = usage.Name;
                    newRow.Tag = usage;
                    if (usage.Name == p)
                        this.dgvUsageFilter.CurrentCell = newRow.Cells[colUsageNameFilter.Index];
                }
            });
        }
        /// <summary>
        /// 初始化默认处方
        /// </summary>
        public void InitNormalPresciption()
        {
            string normalPrescriptionType;
            if (this.GranulesEditor == HMPrescriptionEditor.全部 || this.GranulesEditor == HMPrescriptionEditor.饮片)
                normalPrescriptionType = App.Instance.UserSet.NormalHMPrescriptionTypeCode;
            else
                normalPrescriptionType = App.Instance.UserSet.NormalHMGranulesPrescriptionTypeCode;

            _selectedPrescriptionType = _prescriptionTypes.Find(p => p.Code == normalPrescriptionType);
            if (_selectedPrescriptionType == null)
                _selectedPrescriptionType = _prescriptionTypes[0];

            NewPrescription(_selectedPrescriptionType);
        }
        /// <summary>
        /// 诊断变更
        /// </summary>
        /// <param name="diagnosis"></param>
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
                if (diagnosis.Exists(p => p.Diagnosis.Type == DiagnosisType.CMDiagnosis) || diagnosis.Exists(p => p.Diagnosis.Type == DiagnosisType.CMSymptoms))
                {
                    this.EnableNewPrescription(true);
                    this.EnableButton(true);
                    if (_selectedPrescriptionType == null)
                        this.InitNormalPresciption();
                }
            }
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
        /// <summary>
        /// 关闭和启用功能按钮
        /// </summary>
        /// <param name="enable"></param>
        public void EnableButton(bool enable)
        {
            this.btnAdd.Enabled = enable;
            this.btnDelete.Enabled = enable;
            this.btnSave.Enabled = enable;
            this.btnHistoryPrescription.Enabled = enable;
            this.btnSelectAll.Enabled = enable;
            this.btnUp.Enabled = enable;
            this.btnDown.Enabled = enable;
            this.cbxPharmacy.Enabled = enable;
            this.cbxInterval.Enabled = enable;
            this.cbxUsage.Enabled = enable;
            this.inputHerbalMedicineNum.Enabled = enable;
        }
        /// <summary>
        /// 关闭和启用新增处方按钮
        /// </summary>
        /// <param name="enable"></param>
        public void EnableNewPrescription(bool enable)
        {
            this.btnNew.Enabled = enable;
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

            if (_selectPharmacy == null)
            {
                if (GranulesEditor == HMPrescriptionEditor.颗粒剂)
                    MsgBox.OK("当前科室没有绑定中药房,无法开具颗粒剂");
                else if (GranulesEditor == HMPrescriptionEditor.饮片)
                    MsgBox.OK("当前科室没有绑定中药房,无法开具饮片");
                else
                    MsgBox.OK("当前科室没有绑定中药房,无法开具处方");

                return;
            }

            if (GranulesEditor == HMPrescriptionEditor.颗粒剂)
                _allDrugEntities = _inventoryService.PharmacyGetInventory(_selectPharmacy.Id, true, DrugType.颗粒剂);
            else if (GranulesEditor == HMPrescriptionEditor.饮片)
                _allDrugEntities = _inventoryService.PharmacyGetInventory(_selectPharmacy.Id, true, DrugType.草药);
            else
                _allDrugEntities = _inventoryService.PharmacyGetInventory(_selectPharmacy.Id, true, DrugType.草药, DrugType.颗粒剂);

            this.dgvDrug.Rows.Clear();

            this.EnableButton(true);
            this.EnableDGV(true);

            this.dgvDrug.GotoNextRow();
        }
        /// <summary>
        /// 清空处方栏
        /// </summary>
        public void ClearAll()
        {
            _selectedPrescription = null;
            _selectedPrescriptionType = null;
            this.dgvDrug.Rows.Clear();
            EnableButton(false);
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

            _selectInterval = _allIntervalEntities.Find(p => p.Code == details[0].Interval.Code);
            _selectUsage = _allUsageEntities.Find(p => p.Code == prescription.HerbalMedicineUsage.Code);

            foreach (ComboItem item in this.cbxInterval.Items)
            {
                if (item.Tag.As<IntervalEntity>().Code == _selectInterval.Code)
                {
                    this.cbxInterval.SelectedItem = item;
                    break;
                }
            }
            foreach (ComboItem item in this.cbxUsage.Items)
            {
                if (item.Tag.As<UsageEntity>().Code == _selectUsage.Code)
                {
                    this.cbxUsage.SelectedItem = item;
                    break;
                }
            }
            this.inputHerbalMedicineNum.Value = prescription.HerbalMedicineDose;

            this.dgvDrug.Rows.Clear();

            foreach (var detail in details)
            {
                var drug = _allDrugEntities.Find(p => p.ClassCode == detail.ClassCode && p.SpecificationCode == detail.SpecificationCode);
                if (drug == null)
                    continue;

                var newRow = this.dgvDrug.Rows[this.dgvDrug.Rows.Add()];

                newRow.Cells[colName.Index].Value = drug.DrugName;
                newRow.Cells[colSpecification.Index].Value = drug.Specification;
                newRow.Cells[colDose.Index].Value = detail.Dose;
                newRow.Cells[colDoseUnit.Index].Value = drug.MinDoseUnit;
                newRow.Cells[colQuantity.Index].Value = detail.Quantity;
                newRow.Cells[colUsage.Index].Value = detail.Usage.Name;
                newRow.Cells[colManufacturer.Index].Value = drug.Manufacturer;
                newRow.Cells[colPrice.Index].Value = detail.Price;
                newRow.Cells[colTotal.Index].Value = detail.Total;

                newRow.Tag = drug.Mapper<PrescriptionDrugEntity>().JoinMapper(detail);
            }

            if (prescription.PrescriptionStatus == PrescriptionStatus.New)
            {
                EnableButton(true);
                EnableDGV(true);
                this.dgvDrug.GotoNextRow();
            }
            else
            {
                EnableButton(false);
                EnableDGV(false);
                this.dgvDrug.ReadOnly = true;
            }

        }
        /// <summary>
        /// 将药品库存实体中的信息填充到指定行中
        /// </summary>
        /// <param name="row"></param>
        /// <param name="drugEntity"></param>
        private void FillDataToRow(DataGridViewRow row, DrugInventoryEntity drugEntity)
        {
            row.Cells[colName.Index].Value = drugEntity.DrugName;
            row.Cells[colSpecification.Index].Value = drugEntity.Specification;
            row.Cells[colDose.Index].Value = drugEntity.MinDose;
            row.Cells[colDoseUnit.Index].Value = drugEntity.MinDoseUnit;
            row.Cells[colQuantity.Index].Value = 1;
            row.Cells[colUsage.Index].Value = drugEntity.Usage == null ? _allUsageEntities[0].Name : drugEntity.Usage.Name;
            row.Cells[colManufacturer.Index].Value = drugEntity.Manufacturer;
            row.Cells[colPrice.Index].Value = drugEntity.BigPackagePrice;
            row.Cells[colTotal.Index].Value = drugEntity.BigPackagePrice;

            var detail = drugEntity.Mapper<PrescriptionDrugEntity>(); ;
            detail.Quantity = 1;
            detail.Usage = drugEntity.Usage == null ? _allUsageEntities[0] : drugEntity.Usage;
            detail.Interval = _selectInterval;
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
        /// <summary>
        /// 计算指定行的数量
        /// </summary>
        /// <param name="row"></param>
        private void ColculateQutity(DataGridViewRow row)
        {
            if (row.Tag is PrescriptionDrugEntity drug)
            {
                var intervalValue = this.cbxInterval.SelectedItem.As<ComboItem>().Tag.As<IntervalEntity>().Value;
                var hmNum = this.inputHerbalMedicineNum.Value;  //副数

                //一天吃多少
                var dayQuantity = (int)Math.Ceiling(drug.Dose / drug.MinDose) * intervalValue;
                //总数
                drug.Quantity = dayQuantity * hmNum;
                drug.Total = drug.BigPackagePrice * drug.Quantity;

                row.Cells[colTotal.Index].Value = drug.Total;
            }
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
                var filterDrug = filterRow.Tag as DrugInventoryEntity;

                foreach (DataGridViewRow row in this.dgvDrug.Rows)
                {
                    if (row.Tag is PrescriptionDrugEntity drug)
                    {
                        if (drug.ClassCode == filterDrug.ClassCode && drug.SpecificationCode == filterDrug.SpecificationCode)
                        {
                            AlertBox.Info("该药品已开立,无法重复开立");
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
        private void UsageColumnKeyDown(Keys keys)
        {
            if (keys == Keys.Enter)
            {
                if (!this.dgvUsageFilter.PopupVisible)
                    return;

                var selectedRow = this.dgvDrug.CurrentCell.OwningRow;
                if (selectedRow.Tag == null)
                    return;

                var filterRows = this.dgvUsageFilter.SelectedRows;
                if (filterRows.Count == 0)
                    return;

                var filterRow = filterRows[0];
                var filterUsage = filterRow.Tag as UsageEntity;

                this.dgvDrug.EndEdit();
                selectedRow.Tag.As<PrescriptionDrugEntity>().Usage = filterUsage;
                selectedRow.Cells[colUsage.Index].Value = filterUsage.Name;

            }
            else if (keys == Keys.Up || keys == Keys.Down)
                UnsafeNativeMethods.SendMessage(this.dgvUsageFilter.Handle, (int)WinMsg.WM_KEYDOWN, (int)keys, 0);
        }
        /// <summary>
        /// 通过界面更新实体
        /// </summary>
        /// <param name="row"></param>
        private void UpdateTagByRow(DataGridViewRow row)
        {
            var drug = row.Tag as PrescriptionDrugEntity;
            if (drug == null)
                return;

            drug.Usage = _allUsageEntities.Find(p => p.Name == row.Cells[colUsage.Index].Value.ToString());

            drug.Dose = row.Cells[colDose.Index].Value.AsFloat(0);
            if (drug.Dose <= 0)
            {
                drug.Dose = drug.MinDose;
                row.Cells[colDose.Index].Value = drug.Dose;
            }
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
        private void dgvDrug_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;
            if (e.ColumnIndex == colPrice.Index || e.ColumnIndex == colTotal.Index)
                e.Value = e.Value.AsDecimal(0).ToString("0.0000元");
        }
        private void cbxPharmacy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectPharmacy = this.cbxPharmacy.SelectedItem.As<ComboItem>().Tag as DeptEntity;
        }

        private void cbxUsage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectUsage = this.cbxUsage.SelectedItem.As<ComboItem>().Tag as UsageEntity;

            foreach (DataGridViewRow row in this.dgvDrug.Rows)
            {
                if (row.Tag is PrescriptionDrugEntity drug)
                {
                    row.Cells[colUsage.Index].Value = _selectUsage.Name;
                    drug.Usage = _selectUsage;
                }
            }
        }

        private void cbxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectInterval = this.cbxInterval.SelectedItem.As<ComboItem>().Tag as IntervalEntity;

            foreach (DataGridViewRow row in this.dgvDrug.Rows)
            {
                if (row.Tag is PrescriptionDrugEntity drug)
                {
                    drug.Interval = _selectInterval;
                }
                ColculateQutity(row);
            }
        }

        private void dgvDrug_SpecialKeyDown(object sender, KeyEventArgs e)
        {
            if (this.dgvDrug.CurrentCell.ColumnIndex == this.colName.Index)
                NameColumnKeyDown(e.KeyCode);
            else if (this.dgvDrug.CurrentCell.ColumnIndex == this.colUsage.Index)
                UsageColumnKeyDown(e.KeyCode);

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
            var value = this.dgvDrug.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.AsString("");
            if (e.ColumnIndex == this.colUsage.Index)
            {
                var usage = _allUsageEntities.Find(p => p.Name == value);
                if (usage is null)
                    this.dgvDrug.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _selectUsage.Name;
            }
            if (e.ColumnIndex != this.colName.Index)
                UpdateTagByRow(this.dgvDrug.Rows[e.RowIndex]);
            if (e.ColumnIndex == this.colDose.Index)
            {
                ColculateQutity(this.dgvDrug.Rows[e.RowIndex]);
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
                prescription.HerbalMedicineUsage = _selectUsage;
                prescription.HerbalMedicineDose = this.inputHerbalMedicineNum.Value;
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

        private void inputHerbalMedicineNum_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvDrug.Rows)
            {
                ColculateQutity(row);
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

    internal enum HMPrescriptionEditor
    {
        颗粒剂,
        饮片,
        全部
    }
}
