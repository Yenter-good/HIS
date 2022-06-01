using DevComponents.AdvTree;
using DevComponents.DotNetBar;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_OP.MedicalTechnology
{
    internal partial class UCMedicalTechnologyApply : OPStationUserControl, IOPStationData
    {

        private DeptEntity _dept;
        private OutpatientEntity _outpatient;

        private List<AdviceCategoryEntity> _adviceCategories;
        private List<PrescriptionAdviceEntity> _allAdvice;

        private Dictionary<PrescriptionAdviceEntity, List<AdviceFeeItemMapperEntity>> _dictDetails;
        private Dictionary<AdviceCategoryEntity, List<PrescriptionAdviceEntity>> _dictAdviceCategoryMapper;

        private IOPPrescriptionService _prescriptionService;
        private IAdviceService _adviceService;
        private IOPJournalService _journalService;

        private HIS.ControlLib.Popups.PopupControlHost _hostDetail;
        private PrescriptionEntity _selectedPrescription;
        private PrescriptionTypeEntity _selectedPrescriptionType;
        private MedicalTechnologyEditor _editor;

        public UCMedicalTechnologyApply()
        {
            InitializeComponent();
            this.FunctionAreaHeight = 250;
        }

        [Browsable(true)]
        public MedicalTechnologyEditor Editor
        {
            get => _editor; set
            {
                _editor = value;
                if (value == MedicalTechnologyEditor.检验)
                {
                    this.panelEx1.Text = "检验分类";
                    this.panelEx3.Text = "检验项目列表";
                }
                else
                {
                    this.panelEx1.Text = "检查分类";
                    this.panelEx3.Text = "检查项目列表";
                }
            }
        }

        #region 接口实现


        public event EventHandler<OPStationDataModifyEventArgs> Modify;

        public void ChoosePatient(OutpatientEntity outpatient)
        {
            this.dgvApply.Rows.Clear();
            this.dgvSelected.Rows.Clear();
            _selectedPrescription = null;

            EnableButton(true);
            _outpatient = outpatient;
        }

        public bool DeptChanged(DeptEntity dept)
        {
            _dept = dept;
            this.dgvApply.Rows.Clear();
            this.dgvSelected.Rows.Clear();
            _selectedPrescription = null;

            EnableButton(false);

            return true;
        }

        public void FinishTreatment(OutpatientEntity outpatient)
        {
            this.dgvApply.Rows.Clear();
            this.dgvSelected.Rows.Clear();
            _selectedPrescription = null;

            EnableButton(false);
        }

        public void Init()
        {
            InitData();
            InitUI();
        }

        public void Notify(DataModifyType actionId, object data)
        {
            if (actionId == DataModifyType.SelectPrescription)
            {
                var args = data as PrescriptionSubmitEventArgs;
                if (args.Prescription.PrescriptionType.Type == PrscriptionType.检验)
                {
                    InitPrescription(args.Prescription, args.PrescriptionDetails);
                    this.ShowMe();
                }
            }
        }
        #endregion

        #region 初始化
        private void InitUI()
        {
            _hostDetail = new HIS.ControlLib.Popups.PopupControlHost(this.dgvDetail);

            this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Top;
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top | DevComponents.DotNetBar.eBorderSide.Bottom | DevComponents.DotNetBar.eBorderSide.Right;
            this.panelEx3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top | DevComponents.DotNetBar.eBorderSide.Bottom;

            this.BuildCategoryTree(0, this.treeCategory.Nodes);
            this.treeCategory.ExpandAll();

            this.EnableButton(false);
        }

        private void BuildCategoryTree(long parentId, NodeCollection nodes)
        {
            var entities = _adviceCategories.Where(p => p.Parent.Id == parentId).ToList();
            if (entities.Count > 0)
            {
                foreach (var entity in entities)
                {
                    Node node = new Node(entity.Name);
                    node.Tag = entity;

                    nodes.Add(node);
                    BuildCategoryTree(entity.Id, node.Nodes);
                }
            }
        }

        private void InitData()
        {
            _adviceService = ServiceLocator.GetService<IAdviceService>();
            _journalService = ServiceLocator.GetService<IOPJournalService>();
            _prescriptionService = ServiceLocator.GetService<IOPPrescriptionService>();

            Dictionary<long, List<long>> mappers;
            if (Editor == MedicalTechnologyEditor.检验)
            {
                _adviceCategories = _adviceService.GetAdviceCategories(AdviceCategoryType.Test);
                _allAdvice = _adviceService.GetAllByType(AdviceType.检验).Mapper<List<PrescriptionAdviceEntity>>();
                _selectedPrescriptionType = _prescriptionService.GetPrescriptionType().Find(p => p.Type == PrscriptionType.检验);
                mappers = _adviceService.GetAdviceCategoryMapper(0);
                this.btnConditionSummary.Visible = false;
            }
            else
            {
                _adviceCategories = _adviceService.GetAdviceCategories(AdviceCategoryType.Inspect);
                _allAdvice = _adviceService.GetAllByType(AdviceType.检查).Mapper<List<PrescriptionAdviceEntity>>();
                _selectedPrescriptionType = _prescriptionService.GetPrescriptionType().Find(p => p.Type == PrscriptionType.检查);
                mappers = _adviceService.GetAdviceCategoryMapper(1);
                this.btnConditionSummary.Visible = true;
            }

            _dictDetails = new Dictionary<PrescriptionAdviceEntity, List<AdviceFeeItemMapperEntity>>();

            _dictAdviceCategoryMapper = new Dictionary<AdviceCategoryEntity, List<PrescriptionAdviceEntity>>();
            foreach (var mapper in mappers)
            {
                var category = _adviceCategories.Find(p => p.Id == mapper.Key);
                if (category != null)
                    _dictAdviceCategoryMapper[category] = _allAdvice.Where(p => p.Id._In(mapper.Value)).ToList();
            }
        }

        private void EnableButton(bool enable)
        {
            this.btnDel.Enabled = enable;
            this.btnAdd.Enabled = enable;
            this.btnSave.Enabled = enable;

            this.dgvSelected.ReadOnly = !enable;
        }
        private void InitPrescription(PrescriptionEntity prescription, List<PrescriptionDetailEntity> details)
        {
            _selectedPrescription = prescription;

            this.tbxNote.Text = prescription.DoctorNote;

            if (_selectedPrescription.PrescriptionStatus != PrescriptionStatus.New)
                EnableButton(false);
            else
            {
                EnableButton(true);
                this.colItemNameSelected.ReadOnly = true;
            }

            foreach (var detail in details)
            {
                var item = detail.Mapper<PrescriptionDrugEntity>();

                var newRow = this.dgvSelected.Rows[this.dgvSelected.Rows.Add()];
                newRow.Cells[colItemNameSelected.Index].Value = item.DrugName;
                newRow.Cells[colQuantitySelected.Index].Value = item.Quantity;
                newRow.Tag = item;
            }
        }
        #endregion

        #region 方法

        private PrescriptionDetailEntity FillRowToEntity(DataGridViewRow row)
        {
            PrescriptionDrugEntity item = row.Tag as PrescriptionDrugEntity;

            var result = item.Mapper<PrescriptionDetailEntity>();
            result.No = row.Index;
            result.Quantity = row.Cells[colQuantitySelected.Index].Value.AsInt(1);
            result.Total = result.Price * result.Quantity;

            return result;
        }

        private void AddToSelected(DataGridViewRow row)
        {
            if (_outpatient == null || (_selectedPrescription != null && _selectedPrescription.PrescriptionStatus != PrescriptionStatus.New))
                return;

            var advice = row.Tag as PrescriptionAdviceEntity;
            foreach (DataGridViewRow select in this.dgvSelected.Rows)
            {
                if (select.Tag is PrescriptionDrugEntity item)
                {
                    if (item.SpecificationCode == advice.Code)
                    {
                        item.Quantity += 1;
                        select.Cells[colQuantitySelected.Index].Value = item.Quantity;
                        return;
                    }
                }
            }

            var entity = advice.Mapper<PrescriptionDrugEntity>();
            entity.ExecDept = advice.ExecDept;
            entity.BigPackageFlag = true;
            entity.ItemType = ItemType.检验;
            entity.Quantity = 1;
            entity.Total = advice.Price;

            var newRow = this.dgvSelected.Rows[this.dgvSelected.Rows.Add()];
            newRow.Cells[colItemNameSelected.Index].Value = entity.DrugName;
            newRow.Cells[colQuantitySelected.Index].Value = 1;
            newRow.Tag = entity;
        }
        #endregion

        #region 窗体事件

        private void dgvApply_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.colDetail.Index)
            {
                var advice = this.dgvApply.Rows[e.RowIndex].Tag as PrescriptionAdviceEntity;
                if (!_dictDetails.ContainsKey(advice))
                    _dictDetails[advice] = _adviceService.GetByAdviceId(advice.Id);

                var details = _dictDetails[advice];

                this.dgvDetail.Rows.Clear();
                foreach (var detail in details)
                {
                    var newRow = this.dgvDetail.Rows[this.dgvDetail.Rows.Add()];
                    newRow.Cells[colDetailName.Index].Value = detail.FeeItemName;
                    newRow.Cells[colDetailPrice.Index].Value = detail.FeeItemPrice;
                }
                this.dgvDetail.ClearSelection();

                var rect = this.dgvApply.GetCellRectangleToScreen();

                var dgvPosition = this.dgvApply.Parent.PointToScreen(this.dgvDetail.Location);

                Point p = new Point(dgvPosition.X + this.dgvApply.Width, rect.Top);
                _hostDetail.Show(p);
            }
        }

        private void treeCategory_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            var category = e.Node.Tag as AdviceCategoryEntity;
            List<PrescriptionAdviceEntity> advices = new List<PrescriptionAdviceEntity>();

            if (_dictAdviceCategoryMapper.ContainsKey(category))
                advices = _dictAdviceCategoryMapper[category];

            this.dgvApply.Rows.Clear();

            if (advices.Count == 0)
                return;

            foreach (var advice in advices)
            {
                advice.ExecDept = category.Dept;

                var newRow = this.dgvApply.Rows[this.dgvApply.Rows.Add()];
                newRow.Cells[colItemNameApply.Index].Value = advice.Name;
                newRow.Cells[colPriceApply.Index].Value = advice.Price;
                newRow.Cells[colDetail.Index].Value = "查看明细";

                newRow.Tag = advice;
            }

            this.dgvApply.ClearSelection();
        }

        private void dgvApply_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != this.colDetail.Index)
            {
                var selectedRow = this.dgvApply.GetSelectedRowByCell();
                if (selectedRow == null)
                    return;

                AddToSelected(selectedRow);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgvApply.GetSelectedRowByCell();
            if (selectedRow == null)
                return;

            AddToSelected(selectedRow);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedPrescriptionType == null)
            {
                MsgBox.OK("没有指定的处方类型,无法保存处方");
                return;
            }

            List<PrescriptionDetailEntity> details = new List<PrescriptionDetailEntity>();

            this.tbxConditionSummary.Text = this.GetData<string>(RegisterDataType.GetConditionSummary);
            this.dgvSelected.EndEdit();

            if (!_journalService.JournalEffective(_outpatient.OutpatientNo))
            {
                PatientJournal.FormEditJournal dialog = App.Instance.CreateView<PatientJournal.FormEditJournal>();
                dialog.Dept = _dept;
                dialog.OutpatientNo = _outpatient.OutpatientNo;
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
            }

            foreach (DataGridViewRow row in this.dgvSelected.Rows)
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
                prescription.Outpatient = _outpatient;
                prescription.IDCard = _outpatient.IDCard;
                prescription.CardNo = _outpatient.CardNo;
                prescription.DetailNumber = details.Count;
                prescription.Dept = _dept;
                prescription.PrescriptionStatus = PrescriptionStatus.Send;
                prescription.Diagnosis = null;
                prescription.DoctorNote = this.tbxNote.Text;
                prescription.ConditionSummary = this.tbxConditionSummary.Text;
            }

            var result = _prescriptionService.SavePrescriptionDetail(prescription, details);
            if (result.Success)
            {
                AlertBox.Info("保存成功");
                this.Modify?.Invoke(this, new OPStationDataModifyEventArgs() { ActionId = DataModifyType.SavePrescription, Data = new PrescriptionSubmitEventArgs() { Prescription = prescription, PrescriptionDetails = details } });

                this.dgvSelected.Rows.Clear();
                this.dgvApply.Rows.Clear();
                _selectedPrescription = null;
            }
            else
            {
                MsgBox.OK("保存失败" + Environment.NewLine + result.Message);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            this.dgvApply.Rows.Clear();
            var searchCode = this.tbxSearch.Text.ToUpper();

            Dictionary<AdviceCategoryEntity, List<PrescriptionAdviceEntity>> filter = new Dictionary<AdviceCategoryEntity, List<PrescriptionAdviceEntity>>();

            foreach (var item in _dictAdviceCategoryMapper)
            {
                var advices = item.Value.Where(p => p.SearchCode.Contains(searchCode) || p.Name.Contains(searchCode)).ToList();
                if (advices.Count == 0)
                    continue;

                filter[item.Key] = advices;
            }

            foreach (var item in filter)
            {
                foreach (var advice in item.Value)
                {
                    advice.ExecDept = item.Key.Dept;

                    var newRow = this.dgvApply.Rows[this.dgvApply.Rows.Add()];
                    newRow.Cells[colItemNameApply.Index].Value = $"[{item.Key.Name}]" + advice.Name;
                    newRow.Cells[colPriceApply.Index].Value = advice.Price;
                    newRow.Cells[colDetail.Index].Value = "查看明细";

                    newRow.Tag = advice;
                }
            }
        }
        #endregion

        private void btnDel_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvSelected.GetSelectedRowsByCells();
            if (MsgBox.YesNo($"确定删除这{selectedRows.Count}项项目么") != DialogResult.Yes)
                return;

            if (selectedRows.Count != 0)
            {
                foreach (var selectedRow in selectedRows)
                    this.dgvSelected.Rows.Remove(selectedRow);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _selectedPrescription = null;
            this.dgvSelected.Rows.Clear();
        }

        private void btnConditionSummary_ExpandChange(object sender, EventArgs e)
        {
            if (btnConditionSummary.Expanded)
                this.tbxConditionSummary.Text = this.GetData<string>(RegisterDataType.GetConditionSummary);
        }
    }

    public enum MedicalTechnologyEditor
    {
        检验,
        检查
    }
}
