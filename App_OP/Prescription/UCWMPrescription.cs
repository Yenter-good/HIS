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
using HIS.Utility.Win32;
using HIS.Utility;

namespace App_OP.Prescription
{
    internal partial class UCWMPrescription : UserControl, IPrescriptionInit
    {
        private IDrugInventoryService _inventoryService;
        private IOPPrescriptionService _prescriptionService;
        private IUsageService _usageService;
        private IIntervalService _intervalService;
        private IOPJournalService _journalService;

        private DeptEntity _selectPharmacy;

        private PrescriptionEntity _selectedPrescription;
        private PrescriptionTypeEntity _selectedPrescriptionType;

        private List<DrugInventoryEntity> _allDrugEntities;
        private List<UsageEntity> _allUsageEntities;
        private List<IntervalEntity> _allIntervalEntities;

        private List<PrescriptionTypeEntity> _prescriptionTypes;
        private Dictionary<int, string> _skinTest;

        private bool _modify;

        private DataGridViewColumn[] _readOnlyColumns;

        public UCWMPrescription()
        {
            InitializeComponent();
        }

        public event EventHandler<PrescriptionSubmitEventArgs> Submit;

        /// <summary>
        /// 病人主诊断
        /// </summary>
        public PatientDiagnosisEntity MainDiagnosis { get; set; }
        /// <summary>
        /// 病人
        /// </summary>
        public OutpatientEntity Outpatient { get; set; }
        /// <summary>
        /// 当前科室
        /// </summary>
        public DeptEntity Dept { get; set; }

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

            _allUsageEntities = _usageService.GetAll(0);
            _allIntervalEntities = _intervalService.GetAll(0);
        }

        /// <summary>
        /// 初始化界面
        /// </summary>
        /// <param name="prescriptionTypes"></param>
        /// <param name="pharmacies"></param>
        public void InitUI(List<PrescriptionTypeEntity> prescriptionTypes)
        {
            _prescriptionTypes = prescriptionTypes.Where(p => p.Type == PrscriptionType.西药中成药).ToList();

            this.dgvDrug.GroupDisplayColumn = this.colGroupDisplay;
            this.dgvDrug.GroupValueColumn = this.colGroupValue;
            this.dgvDrug.NameColumn = this.colName;

            _readOnlyColumns = new DataGridViewColumn[] { this.colGroupDisplay, this.colSpecification, this.colDoseUnit, this.colPackageUnit, this.colManufacturer, this.colPrice, this.colTotal, this.colWhite };

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

            //this.btnNew.MouseEnter += (s, e) =>
            // {
            //     if (btnNew.SubItems.Count > 0)
            //         this.btnNew.Expanded = true;
            // };
            //this.btnGroup.MouseEnter += (s, e) =>
            //{
            //    this.btnGroup.Expanded = true;
            //};

            //初始化药品、用法、间隔、皮试的选择框
            this.dgvDrugFilter.Headers.Clear();
            this.dgvDrugFilter.Headers.Add(new HIS.ControlLib.DataGridViewExt.TopHeader(this.colBigPackageInventory.Index, 2, "库存数量"));
            this.dgvDrugFilter.Container = new HIS.ControlLib.Container(this.dgvDrug, this.colName);
            this.dgvUsageFilter.Container = new HIS.ControlLib.Container(this.dgvDrug, this.colUsage);
            this.dgvIntervalFilter.Container = new HIS.ControlLib.Container(this.dgvDrug, this.colInterval);
            this.dgvSkinTestFilter.Container = new HIS.ControlLib.Container(this.dgvDrug, this.colSkinTest);

            _skinTest = this.GetEnumDictEx<SkinTestFlag>();
            foreach (var item in _skinTest)
            {
                var newRow = this.dgvSkinTestFilter.Rows[this.dgvSkinTestFilter.Rows.Add()];
                newRow.Cells[colSkinTestFilter.Index].Value = item.Value;
                newRow.Cells[colSkinTestFilter.Index].Tag = item.Key;
            }

            InitDrugFilter();
            InitUsageFilter();
            InitIntervalFilter();

            EnableNewPrescription(false);
            EnableButton(false);
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
            foreach (var pharmacy in execDepts.Where(p => p.CategoryDetail == DeptCategoryDetail.WMPharmacy && p.Category.Value == DeptCategory.门诊.ToString()))
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
        /// 初始化默认处方
        /// </summary>
        public void InitNormalPresciption()
        {
            var normalPrescriptionType = App.Instance.UserSet.NormalWMPrescriptionTypeCode;
            _selectedPrescriptionType = _prescriptionTypes.Find(p => p.Code == normalPrescriptionType);
            if (_selectedPrescriptionType == null)
                _selectedPrescriptionType = _prescriptionTypes[0];

            NewPrescription(_selectedPrescriptionType);
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
                    newRow.Cells[colMedicalInsurance.Index].Value = drug.MedicalInsurance;
                    newRow.Cells[colNameFilter.Index].Value = drug.DrugName;
                    newRow.Cells[colTradeNameFilter.Index].Value = drug.TradeName;
                    newRow.Cells[colSpecification.Index].Value = drug.Specification;
                    newRow.Cells[colBigPackageInventory.Index].Value = drug.BigPackageQuantity + drug.BigPackageUnit;
                    if (drug.OPCanSplit)
                        newRow.Cells[colSmallPackageInventory.Index].Value = drug.SmallPackageQuantity + drug.SmallPackageUnit;
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
        /// 初始化间隔过滤
        /// </summary>
        private void InitIntervalFilter()
        {
            this.dgvIntervalFilter.SetFilterCondition(p =>
            {
                var text = p.ToLower();

                var filter = _allIntervalEntities.Where(d => d.SearchCode.Contains(text) || d.Name.Contains(text) || d.WubiCode.Contains(text) || d.Code.Contains(text));

                this.dgvIntervalFilter.Rows.Clear();
                foreach (var interval in filter)
                {
                    var newRow = this.dgvIntervalFilter.Rows[this.dgvIntervalFilter.Rows.Add()];
                    newRow.Cells[colIntervalCodeFilter.Index].Value = interval.Code;
                    newRow.Cells[colIntervalNameFilter.Index].Value = interval.Name;
                    newRow.Tag = interval;
                }
            });
            this.dgvIntervalFilter.SetInitEditCondition(p =>
            {
                this.dgvIntervalFilter.Rows.Clear();
                foreach (var interval in _allIntervalEntities)
                {
                    var newRow = this.dgvIntervalFilter.Rows[this.dgvIntervalFilter.Rows.Add()];
                    newRow.Cells[colIntervalCodeFilter.Index].Value = interval.Code;
                    newRow.Cells[colIntervalNameFilter.Index].Value = interval.Name;
                    newRow.Tag = interval;
                    if (interval.Name == p)
                        this.dgvIntervalFilter.CurrentCell = newRow.Cells[colIntervalNameFilter.Index];
                }
            });
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
                this.EnableNewPrescription(true);
                this.EnableButton(true);
                if (_selectedPrescriptionType == null)
                    this.InitNormalPresciption();
            }
        }
        #endregion

        #region 方法
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
                newRow.Cells[colPackageUnit.Index].Value = drug.BigPackageUnit;
                newRow.Cells[colUsage.Index].Value = detail.Usage.Name;
                newRow.Cells[colInterval.Index].Value = detail.Interval.Name;
                newRow.Cells[colDay.Index].Value = detail.Day;
                newRow.Cells[colSkinTest.Index].Value = detail.SkinTestFlag;
                newRow.Cells[colManufacturer.Index].Value = drug.Manufacturer;
                newRow.Cells[colPrice.Index].Value = detail.Price;
                newRow.Cells[colTotal.Index].Value = detail.Total;
                newRow.Cells[colGroupValue.Index].Value = detail.GroupNo;

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

            this.dgvDrug.DrawGroupLine();
        }
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
            this.btnGroupCollect.Enabled = enable;
            this.btnSave.Enabled = enable;
            this.btnHistoryPrescription.Enabled = enable;
            this.btnSelectAll.Enabled = enable;
            this.btnUp.Enabled = enable;
            this.btnDown.Enabled = enable;
            this.cbxPharmacy.Enabled = enable;
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

            _allDrugEntities = _inventoryService.PharmacyGetInventory(_selectPharmacy.Id, true, DrugType.西药, DrugType.中成药);

            this.dgvDrug.Rows.Clear();

            this.EnableButton(true);
            this.EnableDGV(true);

            this.dgvDrug.GotoNextRow();
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
            row.Cells[colPackageUnit.Index].Value = drugEntity.BigPackageUnit;
            row.Cells[colUsage.Index].Value = drugEntity.Usage == null ? _allUsageEntities[0].Name : drugEntity.Usage.Name;
            row.Cells[colInterval.Index].Value = _allIntervalEntities[0].Name;
            row.Cells[colDay.Index].Value = 1;
            row.Cells[colManufacturer.Index].Value = drugEntity.Manufacturer;
            row.Cells[colPrice.Index].Value = drugEntity.BigPackagePrice;
            row.Cells[colTotal.Index].Value = drugEntity.BigPackagePrice;

            if (drugEntity.SkinTestFlag)
            {
                var dialogResult = MsgBox.YesNo("该药品需要皮试,是否皮试");
                if (dialogResult == DialogResult.Yes)
                    row.Cells[colSkinTest.Index].Value = SkinTestFlag.Need;
                else
                    row.Cells[colSkinTest.Index].Value = SkinTestFlag.Continue;
            }
            else
            {
                row.Cells[colSkinTest.Index].Value = SkinTestFlag.None;

            }
            var detail = drugEntity.Mapper<PrescriptionDrugEntity>(); ;
            detail.Quantity = 1;
            detail.Usage = drugEntity.Usage == null ? _allUsageEntities[0] : drugEntity.Usage;
            detail.Interval = _allIntervalEntities[0];
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
        /// 计算指定列的数量
        /// </summary>
        /// <param name="row"></param>
        private void ColculateQutity(DataGridViewRow row)
        {
            if (row.Tag is PrescriptionDrugEntity drug)
            {
                var intervalValue = drug.Interval.Value;
                var days = drug.Day;

                //总共要吃多少
                int totalQuantity = 0;

                if (drug.ChargeType == DrugChargeType.按次取整)
                {
                    //每次要吃多少
                    var doseQuantity = (int)Math.Ceiling(drug.Dose / drug.MinDose);
                    //每天要吃多少
                    var dayQuantity = doseQuantity * intervalValue;

                    totalQuantity = dayQuantity * days;
                }
                else
                {
                    //一天要吃多少量
                    var dayDose = drug.Dose * intervalValue;
                    //总共要吃多少量
                    var totalDose = dayDose * days;

                    totalQuantity = (int)Math.Ceiling(totalDose / drug.MinDose);
                }

                if (drug.OPCanSplit)
                {
                    var packageUnit = row.Cells[colPackageUnit.Index].Value.ToString();
                    bool isBigPackage = drug.BigPackageUnit == packageUnit;

                    //如果不是大包装，按照直接将数量显示
                    //其他所有情况都按大包装来算
                    if (!isBigPackage)
                    {
                        drug.BigPackageFlag = false;
                        drug.Quantity = totalQuantity;
                        row.Cells[colQuantity.Index].Value = drug.Quantity;
                        return;
                    }
                    else
                        drug.BigPackageFlag = true;
                }
                else
                    drug.BigPackageFlag = true;

                //如果总数量和包装数有余数，则整除后+1
                if (totalQuantity % drug.PackageNumber != 0)
                    drug.Quantity = totalQuantity / drug.PackageNumber + 1;
                else
                    drug.Quantity = totalQuantity / drug.PackageNumber;


                row.Cells[colQuantity.Index].Value = drug.Quantity;
                row.Cells[colTotal.Index].Value = drug.Total;
            }
        }
        /// <summary>
        /// 当名称列有按键按下
        /// </summary>
        /// <param name="keys"></param>
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

                this.dgvDrug.EndEdit();

                FillDataToRow(selectedRow, filterDrug);
            }
            else if (keys == Keys.Up || keys == Keys.Down)
                UnsafeNativeMethods.SendMessage(this.dgvDrugFilter.Handle, (int)WinMsg.WM_KEYDOWN, (int)keys, 0);
        }
        /// <summary>
        /// 当用法列有按键按下
        /// </summary>
        /// <param name="keys"></param>
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

                selectedRow.Tag.As<PrescriptionDrugEntity>().Usage = filterUsage;
                this.dgvDrug.EndEdit();
                selectedRow.Cells[colUsage.Index].Value = filterUsage.Name;

            }
            else if (keys == Keys.Up || keys == Keys.Down)
                UnsafeNativeMethods.SendMessage(this.dgvUsageFilter.Handle, (int)WinMsg.WM_KEYDOWN, (int)keys, 0);

        }
        /// <summary>
        /// 当间隔列有按键按下
        /// </summary>
        /// <param name="keys"></param>
        private void IntervalColumnKeyDown(Keys keys)
        {
            if (keys == Keys.Enter)
            {
                if (!this.dgvIntervalFilter.PopupVisible)
                    return;

                var selectedRow = this.dgvDrug.CurrentCell.OwningRow;
                if (selectedRow.Tag == null)
                    return;

                var filterRows = this.dgvIntervalFilter.SelectedRows;

                if (filterRows.Count == 0)
                    return;
                var filterRow = filterRows[0];
                var filterInterval = filterRow.Tag as IntervalEntity;

                selectedRow.Tag.As<PrescriptionDrugEntity>().Interval = filterInterval;
                this.dgvDrug.EndEdit();
                selectedRow.Cells[colInterval.Index].Value = filterInterval.Name;
            }
            else if (keys == Keys.Up || keys == Keys.Down)
                UnsafeNativeMethods.SendMessage(this.dgvIntervalFilter.Handle, (int)WinMsg.WM_KEYDOWN, (int)keys, 0);
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
            drug.Interval = _allIntervalEntities.Find(p => p.Name == row.Cells[colInterval.Index].Value.ToString());
            drug.Dose = row.Cells[colDose.Index].Value.AsFloat(0);
            drug.Quantity = row.Cells[colQuantity.Index].Value.AsInt(0);
            drug.Day = row.Cells[colDay.Index].Value.AsInt(0);
            drug.PatientSkinTestFlag = (SkinTestFlag)row.Cells[colSkinTest.Index].Value;
        }
        /// <summary>
        /// 向下调位置
        /// </summary>
        /// <param name="row"></param>
        private void GoDown(DataGridViewRow row)
        {
            var selectedDrug = row.Tag as PrescriptionDrugEntity;

            if (row.Index == this.dgvDrug.Rows.Count - 1 || this.dgvDrug.Rows[row.Index + 1].Tag == null || selectedDrug == null)
                return;

            var aboveDrug = this.dgvDrug.Rows[row.Index + 1].Tag as PrescriptionDrugEntity;
            if (selectedDrug.GroupNo == aboveDrug.GroupNo)
            {
                var newIndex = row.Index + 1;
                this.dgvDrug.Rows.Remove(row);
                this.dgvDrug.Rows.Insert(newIndex, row);

                this.dgvDrug.DrawGroupLine();
            }
        }
        /// <summary>
        /// 向上调位置
        /// </summary>
        /// <param name="row"></param>
        private void GoUp(DataGridViewRow row)
        {
            var selectedDrug = row.Tag as PrescriptionDrugEntity;

            if (row.Index == 0 || this.dgvDrug.Rows[row.Index - 1].Tag == null || selectedDrug == null)
                return;

            var upDrug = this.dgvDrug.Rows[row.Index - 1].Tag as PrescriptionDrugEntity;
            if (selectedDrug.GroupNo == upDrug.GroupNo)
            {
                var newIndex = row.Index - 1;
                this.dgvDrug.Rows.Remove(row);
                this.dgvDrug.Rows.Insert(newIndex, row);

                this.dgvDrug.DrawGroupLine();
            }
        }
        private void GoUp(List<DataGridViewRow> rows)
        {
            var drugs = rows.Select(p => p.Tag as PrescriptionDrugEntity).ToList();
            var groupNo = drugs[0].GroupNo;
            if (groupNo == 0)
            {
                //如果选中行的第一行是表格的第一行,则不能上调
                if (rows[0].Index == 0)
                    return;

                var upRow = this.dgvDrug.Rows[rows[0].Index - 1];
                if (upRow.Tag is PrescriptionDrugEntity drugEntity)
                {
                    if (drugEntity.GroupNo != 0)
                        return;
                }

                this.dgvDrug.Rows.Remove(upRow);
                this.dgvDrug.Rows.Insert(rows[rows.Count - 1].Index + 1, upRow);
            }
            else
            {
                var groupRows = this.dgvDrug.Rows.Cast<DataGridViewRow>().Where(p => p.Tag != null && p.Tag.As<PrescriptionDrugEntity>().GroupNo == groupNo).ToList();

                //如果当前选中的行,是这个组中的所有行
                if (groupRows.Count == rows.Count)
                {
                    var lastIndex = groupRows.Max(p => p.Index);
                    var topIndex = groupRows.Min(p => p.Index);

                    //如果选中行的第一行是表格的第一行,则不能上调
                    if (topIndex == 0)
                        return;

                    var upGroupNo = this.dgvDrug.Rows[topIndex - 1].Tag.As<PrescriptionDrugEntity>().GroupNo;
                    var upGroupRows = this.dgvDrug.Rows.Cast<DataGridViewRow>().Where(p => p.Tag != null && p.Tag.As<PrescriptionDrugEntity>().GroupNo == upGroupNo).ToList();

                    var upGroupTopIndex = upGroupRows.Min(p => p.Index);
                    foreach (var row in rows)
                    {
                        this.dgvDrug.Rows.Remove(row);
                        this.dgvDrug.Rows.Insert(upGroupTopIndex++, row);
                    }
                }
                else
                {
                    //如果选中行的第一行是当前组内的第一行,则不能上调
                    if (rows[0].Index == groupRows[0].Index)
                        return;

                    var upRow = this.dgvDrug.Rows[rows[0].Index - 1];
                    this.dgvDrug.Rows.Remove(upRow);
                    this.dgvDrug.Rows.Insert(rows[rows.Count - 1].Index + 1, upRow);
                }
            }
        }
        private void GoDown(List<DataGridViewRow> rows)
        {
            var drugs = rows.Select(p => p.Tag as PrescriptionDrugEntity).ToList();
            var groupNo = drugs[0].GroupNo;
            if (groupNo == 0)
            {
                //如果选中行的最后一行是表格的最后一行,则不能下调
                if (rows[rows.Count - 1].Index == this.dgvDrug.Rows.Count - 1 || this.dgvDrug.Rows[rows[rows.Count - 1].Index + 1].Tag == null)
                    return;

                var downRow = this.dgvDrug.Rows[rows[rows.Count - 1].Index + 1];
                this.dgvDrug.Rows.Remove(downRow);
                this.dgvDrug.Rows.Insert(rows[0].Index, downRow);
            }
            else
            {
                var groupRows = this.dgvDrug.Rows.Cast<DataGridViewRow>().Where(p => p.Tag != null && p.Tag.As<PrescriptionDrugEntity>().GroupNo == groupNo).ToList();

                //如果当前选中的行,是这个组中的所有行
                if (groupRows.Count == rows.Count)
                {
                    var lastIndex = groupRows.Max(p => p.Index);
                    var topIndex = groupRows.Min(p => p.Index);

                    //如果选中行的最后一行是表格的最后一行,则不能下调
                    if (this.dgvDrug.Rows.Count == lastIndex + 1 || this.dgvDrug.Rows[lastIndex + 1].Tag == null)
                        return;
                    //如果下一行是非同组的行,则不能下调
                    if (this.dgvDrug.Rows[lastIndex + 1].Tag.As<PrescriptionDrugEntity>().GroupNo == 0)
                        return;

                    var underGroupNo = this.dgvDrug.Rows[lastIndex + 1].Tag.As<PrescriptionDrugEntity>().GroupNo;
                    var underGroupRows = this.dgvDrug.Rows.Cast<DataGridViewRow>().Where(p => p.Tag != null && p.Tag.As<PrescriptionDrugEntity>().GroupNo == underGroupNo).ToList();
                    foreach (var row in underGroupRows)
                    {
                        this.dgvDrug.Rows.Remove(row);
                        this.dgvDrug.Rows.Insert(topIndex++, row);
                    }
                }
                else
                {
                    //如果选中行的最后一行是当前组内的最后一行,则不能下调
                    if (rows[rows.Count - 1].Index == groupRows[groupRows.Count - 1].Index)
                        return;

                    var underRow = this.dgvDrug.Rows[rows[rows.Count - 1].Index + 1];
                    this.dgvDrug.Rows.Remove(underRow);
                    this.dgvDrug.Rows.Insert(rows[0].Index, underRow);
                }
            }
        }
        #endregion

        #region 窗体事件
        private void PrescriptionType_Click(object sender, EventArgs e)
        {
            _selectedPrescriptionType = sender.As<ButtonItem>().Tag as PrescriptionTypeEntity;

            NewPrescription(_selectedPrescriptionType);
        }

        private void cbxPharmacy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectPharmacy = this.cbxPharmacy.SelectedItem.As<ComboItem>().Tag as DeptEntity;
        }

        private void dgvDrug_SpecialKeyDown(object sender, KeyEventArgs e)
        {
            if (this.dgvDrug.CurrentCell.ColumnIndex == this.colName.Index)
                NameColumnKeyDown(e.KeyCode);
            else if (this.dgvDrug.CurrentCell.ColumnIndex == this.colUsage.Index)
                UsageColumnKeyDown(e.KeyCode);
            else if (this.dgvDrug.CurrentCell.ColumnIndex == this.colInterval.Index)
                IntervalColumnKeyDown(e.KeyCode);


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
            if (this.dgvDrug.Rows[e.RowIndex].Tag is null)
                return;

            var value = this.dgvDrug.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.AsString("");
            if (e.ColumnIndex == this.colUsage.Index)
            {
                var usage = _allUsageEntities.Find(p => p.Name == value);
                if (usage is null)
                    this.dgvDrug.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _allUsageEntities[0].Name;
            }
            else if (e.ColumnIndex == this.colInterval.Index)
            {
                if (!_allIntervalEntities.Exists(p => p.Name == value))
                    this.dgvDrug.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _allIntervalEntities[0].Name;
            }
            else if (e.ColumnIndex == this.colSkinTest.Index && this.dgvDrug.Rows[e.RowIndex].Tag is PrescriptionDrugEntity drug)
            {
                if (drug.SkinTestFlag)
                    this.dgvDrug.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = SkinTestFlag.Need;
                else
                    this.dgvDrug.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = SkinTestFlag.None;
            }

            if (e.ColumnIndex != this.colName.Index)
                UpdateTagByRow(this.dgvDrug.Rows[e.RowIndex]);
            if (e.ColumnIndex == this.colInterval.Index || e.ColumnIndex == this.colDose.Index || e.ColumnIndex == this.colDay.Index)
                ColculateQutity(this.dgvDrug.Rows[e.RowIndex]);
        }

        private void dgvDrug_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;
            if (e.ColumnIndex == colSkinTest.Index)
                e.Value = ((SkinTestFlag)e.Value).GetDescription();
            else if (e.ColumnIndex == colPrice.Index || e.ColumnIndex == colTotal.Index)
                e.Value = e.Value.AsDecimal(0).ToString("0.0000元");
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

            var drugEntities = selectedRows.Select(p => p.Tag as PrescriptionDrugEntity).ToList();

            var nonGroup = drugEntities.Where(p => p.GroupNo == 0).ToList();
            var group = drugEntities.Where(p => p.GroupNo != 0).ToList();

            foreach (var item in nonGroup)
            {
                foreach (DataGridViewRow row in this.dgvDrug.Rows)
                {
                    if (row.Tag == item)
                    {
                        this.dgvDrug.Rows.Remove(row);
                        break;
                    }
                }
            }

            foreach (var item in group)
            {
                foreach (DataGridViewRow row in this.dgvDrug.Rows)
                {
                    if (row.Tag == item)
                    {
                        this.dgvDrug.Rows.Remove(row);

                        var groupRows = this.dgvDrug.Rows.Cast<DataGridViewRow>().Where(p => p.Tag != null && p.Tag.As<PrescriptionDrugEntity>().GroupNo == item.GroupNo).ToList();
                        if (groupRows.Count == 1)
                        {
                            groupRows[0].Cells[colGroupValue.Index].Value = 0;
                            groupRows[0].Tag.As<PrescriptionDrugEntity>().GroupNo = 0;
                        }
                        break;
                    }
                }
            }

            this.dgvDrug.DrawGroupLine();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDrug.GetSelectedRowsByCells().Where(p => p.Tag != null).ToList();
            if (selectedRows.Count <= 1)
                return;

            var drugEntities = selectedRows.Select(p => p.Tag as PrescriptionDrugEntity).ToList();

            var groupNos = drugEntities.Select(p => p.GroupNo).Distinct().ToList();

            //找到新的同组位置
            var newGroupIndex = 0;
            foreach (DataGridViewRow row in this.dgvDrug.Rows)
            {
                if (row.Tag is PrescriptionDrugEntity drugEntity)
                {
                    if (drugEntity.GroupNo == 0)
                    {
                        newGroupIndex = row.Index;
                        break;
                    }
                }
            }

            if (groupNos.Count == 1)
            {
                //如果全部未同组
                if (groupNos[0] == 0)
                {
                    var maxGroupNo = this.dgvDrug.Rows.Cast<DataGridViewRow>().Where(p => p.Tag != null).Select(p => p.Tag as PrescriptionDrugEntity).Select(p => p.GroupNo).Max() + 1;
                    drugEntities.ForEach(p => p.GroupNo = maxGroupNo);
                    selectedRows.ForEach(p => p.Cells[colGroupValue.Index].Value = maxGroupNo);

                    foreach (var selectedRow in selectedRows)
                    {
                        this.dgvDrug.Rows.Remove(selectedRow);
                        this.dgvDrug.Rows.Insert(newGroupIndex++, selectedRow);
                    }
                }
            }
            else
            {

                groupNos.RemoveAll(p => p == 0);
                var minGroupNo = groupNos.Min();

                var allGroupRow = this.dgvDrug.Rows.Cast<DataGridViewRow>().Where(p => p.Tag != null && p.Tag.As<PrescriptionDrugEntity>().GroupNo._In(groupNos)).ToList();
                allGroupRow.AddRange(selectedRows.Except(allGroupRow).ToList());

                var allGroupDrug = allGroupRow.Select(p => p.Tag as PrescriptionDrugEntity).ToList();

                allGroupDrug.ForEach(p => p.GroupNo = minGroupNo);
                allGroupRow.ForEach(p => p.Cells[colGroupValue.Index].Value = minGroupNo);

                var index = allGroupRow.Min(p => p.Index) + 1;
                for (int i = 1; i < allGroupRow.Count; i++)
                {
                    if (allGroupRow[i].Index != index)
                    {
                        this.dgvDrug.Rows.Remove(allGroupRow[i]);
                        this.dgvDrug.Rows.Insert(index, allGroupRow[i]);
                    }
                    index++;
                }
            }

            this.dgvDrug.DrawGroupLine();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            this.dgvDrug.SelectAll();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDrug.GetSelectedRowsByCells().Where(p => p.Tag != null).ToList();
            var selectedDrugs = selectedRows.Select(p => p.Tag as PrescriptionDrugEntity).ToList();

            var groupNos = selectedDrugs.Select(p => p.GroupNo).Distinct().ToList();
            if (groupNos.Count > 1)
            {
                MsgBox.OK("您选择的药品中,存在多个同组,无法同时移动");
                return;
            }

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
            this.dgvDrug.DrawGroupLine();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDrug.GetSelectedRowsByCells().Where(p => p.Tag != null).ToList();
            var selectedDrugs = selectedRows.Select(p => p.Tag as PrescriptionDrugEntity).ToList();

            var groupNos = selectedDrugs.Select(p => p.GroupNo).Distinct().ToList();
            if (groupNos.Count != 1)
            {
                MsgBox.OK("您选择的药品中,存在多个同组,无法同时移动");
                return;
            }

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
            this.dgvDrug.DrawGroupLine();
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

        private void btnGroupCancel_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDrug.GetSelectedRowsByCells().Where(p => p.Tag != null).ToList();

            if (selectedRows.Count == 0)
                return;

            var allRows = this.dgvDrug.Rows.Cast<DataGridViewRow>();

            var groupNos = selectedRows.Select(p => p.Tag as PrescriptionDrugEntity).Select(p => p.GroupNo).ToList();
            var groupRows = allRows.Where(p => p.Tag != null && p.Tag.As<PrescriptionDrugEntity>().GroupNo._In(groupNos)).OrderBy(p => p.Index).ToList();

            groupRows.ForEach(p =>
            {
                p.Tag.As<PrescriptionDrugEntity>().GroupNo = 0;
                p.Cells[colGroupValue.Index].Value = 0;
            });

            groupRows = allRows.Where(p => p.Tag != null && p.Cells[colGroupValue.Index].Value.AsInt(0) != 0).OrderBy(p => p.Index).ToList();

            var index = 0;
            foreach (var groupRow in groupRows)
            {
                this.dgvDrug.Rows.Remove(groupRow);
                this.dgvDrug.Rows.Insert(index++, groupRow);
            }

            this.dgvDrug.DrawGroupLine();
        }

        private void btnSingleGroupCancel_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDrug.GetSelectedRowsByCells().Where(p => p.Tag != null).ToList();

            if (selectedRows.Count == 0)
                return;
            var allRows = this.dgvDrug.Rows.Cast<DataGridViewRow>();

            var groupNos = selectedRows.Select(p => p.Cells[colGroupValue.Index].Value.AsInt(0)).ToList();

            selectedRows.ForEach(p =>
            {
                p.Cells[colGroupValue.Index].Value = 0;
                p.Tag.As<PrescriptionDrugEntity>().GroupNo = 0;
            });

            foreach (var groupNo in groupNos)
            {
                var groupRows = allRows.Where(p => p.Tag != null && p.Cells[colGroupValue.Index].Value.AsInt(0) == groupNo).ToList();
                if (groupRows.Count <= 1)
                {
                    groupRows.ForEach(p =>
                    {
                        p.Cells[colGroupValue.Index].Value = 0;
                        p.Tag.As<PrescriptionDrugEntity>().GroupNo = 0;
                    });
                }
            }

            var allgroupRows = allRows.Where(p => p.Tag != null && p.Cells[colGroupValue.Index].Value.AsInt(0) != 0).OrderBy(p => p.Index).ToList();

            var index = 0;
            foreach (var groupRow in allgroupRows)
            {
                this.dgvDrug.Rows.Remove(groupRow);
                this.dgvDrug.Rows.Insert(index++, groupRow);
            }

            this.dgvDrug.DrawGroupLine();
        }

        private void dgvDrug_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == this.colQuantity.Index)
            {
                if (this.dgvDrug.Rows[e.RowIndex].Tag is PrescriptionDrugEntity drug)
                {
                    drug.Total = drug.Quantity * (drug.BigPackageFlag ? drug.BigPackagePrice : drug.SmallPackagePrice);
                    this.dgvDrug.Rows[e.RowIndex].Cells[colTotal.Index].Value = drug.Total;
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
