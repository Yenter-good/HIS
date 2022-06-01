using DevComponents.AdvTree;
using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_OP.ItemGroup
{
    public partial class FormItemGroupManager : BaseForm
    {
        IOPGroupService _groupService;
        IUsageService _usageService;
        IDrugInventoryService _drugService;
        public FormItemGroupManager(IOPGroupService groupService, IUsageService usageService, IDrugInventoryService drugService)
        {
            InitializeComponent();
            this._groupService = groupService;
            this._usageService = usageService;
            this._drugService = drugService;
            SetEnter();
        }

        List<PrescriptionGroupEntity> groupList = new List<PrescriptionGroupEntity>();//套餐列表
        List<DealWithItemEntity> itemList = new List<DealWithItemEntity>();//项目列表
        List<DrugInventoryEntity> drugList = new List<DrugInventoryEntity>();//药品列表

        private void FormItemGroupManager_Shown(object sender, EventArgs e)
        {
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.SelectColumn = colCheck;
            LoadGroupData();
            LoadInitData();
        }
        private void SetEnter()
        {
            //设置回车键
            this.AddTabOrderContainer(this.fcbxDrug);
            this.AddTabOrderContainer(this.inputDose_w);
            this.AddTabOrderContainer(this.fcbxUsage_w);
            this.AddTabOrderContainer(this.fcbxInterval_w);
            this.AddTabOrderContainer(this.btnDetailAdd);
            this.AddTabOrderContainer(this.fcbxItem);
            this.AddTabOrderContainer(this.tbxQuantity_t);
            this.AddTabOrderContainer(this.btnAdd_t);
            this.AddTabOrderContainer(this.fcbxDrug_C);
            this.AddTabOrderContainer(this.tbxQuantity_C);
            this.AddTabOrderContainer(this.fcbxUsage_C);
            this.AddTabOrderContainer(this.btnAdd_C);
            this.AddTabOrderContainer(this.fcbxDrug_G);
            this.AddTabOrderContainer(this.tbxQuantity_G);
            this.AddTabOrderContainer(this.fcbxUsage_G);
            this.AddTabOrderContainer(this.btnAdd_G);

            this.EnabledEnterNext = true;
        }
        private void LoadInitData()
        {
            itemList = _groupService.GetDealWithItem();
            drugList = _drugService.WholehospitalDrugInfoGetAll();

            var westDrugList = drugList.Where(x => x.ItemType == ItemType.西药 || x.ItemType == ItemType.中成药).ToList();
            var chineseDrugList = drugList.Where(x => x.ItemType == ItemType.草药).ToList();
            var granulesDrugList = drugList.Where(x => x.ItemType == ItemType.颗粒剂).ToList();

            fcbxDrug.DataSource = westDrugList;
            fcbxDrug.ValueMember = nameof(DrugInventoryEntity.SpecificationCode);
            fcbxDrug.DisplayMember = nameof(DrugInventoryEntity.DrugName);
            fcbxDrug.ColumnHeaders = "药品名称,DrugName,*|规格,Specification,*|剂型,Drugform,*|价格,BigPackagePrice,*|包装单位,BigPackageUnit,*|包装数,PackageNumber,*|生产厂家,Manufacturer";
            fcbxDrug.FilterFields = new string[] { nameof(DrugInventoryEntity.SearchCode), nameof(DrugInventoryEntity.DrugName) };

            fcbxDrug_C.DataSource = chineseDrugList;
            fcbxDrug_C.ValueMember = nameof(DrugInventoryEntity.SpecificationCode);
            fcbxDrug_C.DisplayMember = nameof(DrugInventoryEntity.DrugName);
            fcbxDrug_C.ColumnHeaders = "药品名称,DrugName,*|生产厂家,Manufacturer";
            fcbxDrug_C.FilterFields = new string[] { nameof(DrugInventoryEntity.SearchCode), nameof(DrugInventoryEntity.DrugName) };

            fcbxDrug_G.DataSource = granulesDrugList;
            fcbxDrug_G.ValueMember = nameof(DrugInventoryEntity.SpecificationCode);
            fcbxDrug_G.DisplayMember = nameof(DrugInventoryEntity.DrugName);
            fcbxDrug_G.ColumnHeaders = "药品名称,DrugName,*|生产厂家,Manufacturer";
            fcbxDrug_G.FilterFields = new string[] { nameof(DrugInventoryEntity.SearchCode), nameof(DrugInventoryEntity.DrugName) };

            fcbxItem.DataSource = itemList;
            fcbxItem.ValueMember = nameof(DealWithItemEntity.Code);
            fcbxItem.DisplayMember = nameof(DealWithItemEntity.Name);
            fcbxItem.ColumnHeaders = "项目名称,Name,*|规格,Specification|价格,Price,*";
            fcbxItem.FilterFields = new string[] { nameof(DealWithItemEntity.SearchCode), nameof(DealWithItemEntity.Name) };

            var usageList = _usageService.GetAll();//用法
            var invoiceList = _usageService.GetAll();//间隔 TODO 还没有间隔 的服务

            var WesterntUsage = usageList.Where(x => x.Category == UsageType.WesternMedicine).ToList();//西药用法
            var chineseUsage = usageList.Where(x => x.Category == UsageType.ChinestMedicine).ToList();//中药用法

            fcbxUsage_w.DataSource = WesterntUsage;
            fcbxUsage_w.ValueMember = nameof(UsageEntity.Code);
            fcbxUsage_w.DisplayMember = nameof(UsageEntity.Name);
            fcbxUsage_w.FilterFields = new string[] { nameof(UsageEntity.SearchCode), nameof(UsageEntity.Name) };

            fcbxUsage_C.DataSource = chineseUsage;
            fcbxUsage_C.ValueMember = nameof(UsageEntity.Code);
            fcbxUsage_C.DisplayMember = nameof(UsageEntity.Name);
            fcbxUsage_C.FilterFields = new string[] { nameof(UsageEntity.SearchCode), nameof(UsageEntity.Name) };

            fcbxUsage_G.DataSource = chineseUsage;
            fcbxUsage_G.ValueMember = nameof(UsageEntity.Code);
            fcbxUsage_G.DisplayMember = nameof(UsageEntity.Name);
            fcbxUsage_G.FilterFields = new string[] { nameof(UsageEntity.SearchCode), nameof(UsageEntity.Name) };

            fcbxInterval_w.DataSource = invoiceList;
            fcbxInterval_w.ValueMember = nameof(UsageEntity.Code);
            fcbxInterval_w.DisplayMember = nameof(UsageEntity.Name);
            fcbxInterval_w.FilterFields = new string[] { nameof(UsageEntity.SearchCode), nameof(UsageEntity.Name) };
        }

        private void LoadGroupData()
        {
            groupList.Clear();
            var listUserGroup = _groupService.GetByUser(App.Instance.RuntimeSystemInfo.UserInfo.Id);
            var listDeptGroup = _groupService.GetByDept(ViewData.Dept.Id);
            groupList = groupList.Concat(listUserGroup).ToList();
            groupList = groupList.Concat(listDeptGroup).ToList();
            InitTree();
        }

        private void LoadDetailData()
        {
            Node node = treeGroup.SelectedNode;
            if (node == null)
            {
                AlertBox.Error("请选中一个套餐");
                return;
            }

            PrescriptionGroupEntity group = node.Tag as PrescriptionGroupEntity;

            var detailList = _groupService.GetDetailByGroup(group.Id);
            dgvMain.DataSource = detailList;

            DrawGroupLine();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddGroup form = new FormAddGroup(_groupService);
            form.status = "add";
            Node node = treeGroup.SelectedNode;
            if (node == null)
            {
                AlertBox.Error("请选中一个套餐");
                return;
            }
            else if (node.TagString == "科室套餐" || node.TagString == "个人套餐")
            {
                form.parentID = 0;
                form.type = node.TagString == "科室套餐" ? 1 : 2;
            }
            else
            {
                PrescriptionGroupEntity temp = node.Tag as PrescriptionGroupEntity;
                if (dgvMain.Rows.Count > 0)
                {
                    AlertBox.Error("该节点下有套餐项目不可以再添加子节点！如有必要添加请先删除该节点后重新建立");
                    return;
                }

                form.parentID = temp.Id;
                form.type = (int)temp.GroupType;

            }
            form.deptId = ViewData.Dept.Id;
            form.userId = App.Instance.RuntimeSystemInfo.UserInfo.Id;

            form.ShowDialog();
            LoadGroupData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Node node = treeGroup.SelectedNode;
            if (node == null)
            {
                AlertBox.Error("请选中一个套餐");
                return;
            }
            FormAddGroup form = new FormAddGroup(_groupService);
            form.status = "edit";
            PrescriptionGroupEntity temp = node.Tag as PrescriptionGroupEntity;
            form.group = temp;
            form.parentID = temp.Id;
            form.deptId = ViewData.Dept.Id;
            form.userId = App.Instance.RuntimeSystemInfo.UserInfo.Id;
            form.ShowDialog();
            LoadGroupData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Node node = treeGroup.SelectedNode;
            if (node == null)
            {
                AlertBox.Error("请选中一个套餐");
                return;
            }
            if (node.Parent == null)
            {
                AlertBox.Error("该节点不可删除");
                return;
            }
            PrescriptionGroupEntity temp = node.Tag as PrescriptionGroupEntity;

            DataResult<PrescriptionGroupEntity> result = _groupService.DeleteGroup(temp.Id);
            if (result.Success)
                AlertBox.Info("删除成功");
            else
                AlertBox.Error(result.Message);

            LoadGroupData();
            dgvMain.Rows.Clear();
        }

        private void InitTree()
        {
            foreach (Node node in treeGroup.Nodes)
            {
                node.Nodes.Clear();
            }
            List<PrescriptionGroupEntity> rootList = groupList.Where(x => x.ParentId == 0).OrderBy(x => x.No).ToList();
            foreach (PrescriptionGroupEntity item in rootList)
            {
                Node node = new Node();
                node.Text = item.Name;
                node.Tag = item;
                if (item.GroupType == 1)
                {
                    nodeDept.Nodes.Add(node);
                }
                else
                {
                    nodeUser.Nodes.Add(node);
                }

                CreateChildNode(node, item.Id);
            }
            treeGroup.ExpandAll();
        }
        private void CreateChildNode(Node parentNode, long parentCode)
        {
            List<PrescriptionGroupEntity> list = groupList.Where(x => x.ParentId == parentCode).OrderBy(x => x.No).ToList();
            if (list.Count < 1) return;
            foreach (PrescriptionGroupEntity item in list)
            {
                Node node = new Node();
                node.Text = item.Name;
                node.Tag = item;
                parentNode.Nodes.Add(node);
                CreateChildNode(node, item.Id);
            }

        }

        private void btnDetailAdd_Click(object sender, EventArgs e)
        {
            PrescriptionGroupDetailEntity entity = new PrescriptionGroupDetailEntity();
            DrugInventoryEntity drug = fcbxDrug.SelectedItem as DrugInventoryEntity;//选中的药品
            UsageEntity usage = fcbxUsage_w.SelectedItem as UsageEntity;//选中的用法
            UsageEntity interval = fcbxInterval_w.SelectedItem as UsageEntity;//选中的用药间隔  TODO


            if (drug == null || usage == null || interval == null)
            {
                AlertBox.Error("数据填写不完整");
                return;
            }
            if (inputDose_w.Value <= 0)
            {
                AlertBox.Error("请正确填写一次用量");
                return;
            }
            entity.DrugCode = drug.ClassCode;
            entity.ItemCode = drug.SpecificationCode;
            entity.ItemType = (int)drug.ItemType;

            entity.Usage = usage.Code;
            entity.Interval = interval.Code;
            entity.Dose = float.Parse(inputDose_w.Text);

            bool b = AddDetail(entity);
            if (b)
            {
                fcbxDrug.SelectedItem = null;
                inputDose_w.Value = 0;
                tbxDoseUnit_w.Text = "";
            }
        }

        private void btnAdd_t_Click(object sender, EventArgs e)
        {
            PrescriptionGroupDetailEntity entity = new PrescriptionGroupDetailEntity();
            DealWithItemEntity item = fcbxItem.SelectedItem as DealWithItemEntity;//选中的项目

            if (item == null)
            {
                AlertBox.Error("请选择一个项目");
                return;

            }

            entity.ItemCode = item.Code;
            entity.ItemType = (int)ItemType.诊疗;
            entity.Dose = tbxQuantity_t.Value;

            bool b = AddDetail(entity);
            if (b)
            {
                fcbxItem.SelectedItem = null;
                tbxQuantity_t.Value = 1;
            }
        }

        private void btnAdd_C_Click(object sender, EventArgs e)
        {
            PrescriptionGroupDetailEntity entity = new PrescriptionGroupDetailEntity();
            DrugInventoryEntity drug = fcbxDrug_C.SelectedItem as DrugInventoryEntity;//选中的药品
            UsageEntity usage = fcbxUsage_C.SelectedItem as UsageEntity;//选中的用法
            if (drug == null || usage == null)
            {
                AlertBox.Error("数据填写不完整");
                return;
            }
            if (tbxQuantity_C.Value <= 0)
            {
                AlertBox.Error("请正确填写一次用量");
                return;
            }
            entity.DrugCode = drug.ClassCode;
            entity.ItemCode = drug.SpecificationCode;
            entity.ItemType = (int)drug.ItemType;

            entity.Usage = usage.Code;
            entity.Dose = tbxQuantity_C.Value;

            bool b = AddDetail(entity);
            if (b)
            {
                fcbxDrug_C.SelectedItem = null;
                tbxQuantity_C.Value = 0;
                tbxDoseUnit_C.Text = "";
            }

        }

        private void btnAdd_G_Click(object sender, EventArgs e)
        {
            PrescriptionGroupDetailEntity entity = new PrescriptionGroupDetailEntity();
            DrugInventoryEntity drug = fcbxDrug_G.SelectedItem as DrugInventoryEntity;//选中的药品
            UsageEntity usage = fcbxUsage_G.SelectedItem as UsageEntity;//选中的用法

            if (drug == null || usage == null)
            {
                AlertBox.Error("数据填写不完整");
                return;
            }
            if (tbxQuantity_G.Value <= 0)
            {
                AlertBox.Error("请正确填写一次用量");
                return;
            }
            entity.DrugCode = drug.ClassCode;
            entity.ItemCode = drug.SpecificationCode;
            entity.ItemType = (int)drug.ItemType;

            entity.Usage = usage.Code;
            entity.Dose = tbxQuantity_G.Value;

            bool b = AddDetail(entity);
            if (b)
            {
                fcbxDrug_G.SelectedItem = null;
                tbxQuantity_G.Value = 0;
                tbxQuantity_G.Text = "";
            }

        }

        private bool AddDetail(PrescriptionGroupDetailEntity entity)
        {
            Node node = treeGroup.SelectedNode;
            if (node == null)
            {
                AlertBox.Error("请选中一个套餐");
                return false;
            }

            PrescriptionGroupEntity group = node.Tag as PrescriptionGroupEntity;
            entity.GroupId = group.Id;

            DataResult<PrescriptionGroupDetailEntity> result = _groupService.AddDetail(entity);
            if (result.Success)
            {
                AlertBox.Info("添加成功");
                LoadDetailData();
                return true;
            }
            else
            {
                AlertBox.Error(result.Message);
                return false;
            }


        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count < 1)
            {
                AlertBox.Error("请选中一条明细");
                return;
            }

            PrescriptionGroupDetailEntity entity = this.dgvMain.CurrentRow.DataBoundItem as PrescriptionGroupDetailEntity;

            DataResult<PrescriptionGroupDetailEntity> result = _groupService.DeleteDetail(entity.Id);

            if (result.Success)
            {
                AlertBox.Info("删除成功");
                LoadDetailData();
            }
            else
                AlertBox.Error(result.Message);

        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = this.dgvMain.GetCheckedRows();
            if (rows.Count < 2)
            {
                AlertBox.Info("请选择需要同组的项目，且至少有两个");
                return;
            }

            List<long> ids = new List<long>();

            for (int i = 0; i < rows.Count; i++) //遍历同组药品  判断是否可以同组
            {
                PrescriptionGroupDetailEntity entity = rows[i].DataBoundItem as PrescriptionGroupDetailEntity;

                if (i != 0)
                {
                    PrescriptionGroupDetailEntity lastentity = rows[i - 1].DataBoundItem as PrescriptionGroupDetailEntity;
                    if (entity.Usage != lastentity.Usage || entity.Interval != lastentity.Interval)
                    {
                        AlertBox.Error("用法与用药间隔不一致，不可以同组");
                        return;
                    }
                }

                if (entity.ItemType != (int)ItemType.西药 && entity.ItemType != (int)ItemType.中成药)
                {
                    AlertBox.Info("非西药、中成药请不要同组");
                    return;
                }
                ids.Add(entity.Id);
            }


            DataResult<PrescriptionGroupDetailEntity> result = _groupService.SameGroup(ids);
            if (result.Success)
                LoadDetailData();
            else
                AlertBox.Error(result.Message);
        }

        private void btnCancelGroup_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = this.dgvMain.GetCheckedRows();
            if (rows.Count < 1)
            {
                AlertBox.Info("请选择需要取消同组的项目");
                return;
            }
            List<long> ids = new List<long>();

            for (int i = 0; i < rows.Count; i++)
            {
                PrescriptionGroupDetailEntity entity = rows[i].DataBoundItem as PrescriptionGroupDetailEntity;
                ids.Add(entity.Id);
            }

            DataResult<PrescriptionGroupDetailEntity> result = _groupService.CancelGroup(ids);
            if (result.Success)
                LoadDetailData();
            else
                AlertBox.Error(result.Message);
        }

        private void DrawGroupLine()
        {
            string[] tabs = new string[] { "┓", "┫", "┛", "┃" };
            string currTZBH = "";
            for (int i = 0; i < this.dgvMain.Rows.Count; i++)
            {
                //得到当前处理行的同组编号和下一行的同组编号,如果已经是最后一行,那么下一行的同组编号为-1
                if ((int)this.dgvMain.Rows[i].Cells["colGroupNo"].Value == 0) continue;
                string currRowValue = this.dgvMain.Rows[i].Cells["colGroupNo"].Value.ToString();
                string nextRowValue = i != this.dgvMain.Rows.Count - 1 ? this.dgvMain.Rows[i + 1].Cells["colGroupNo"].Value == null ? "-1" : this.dgvMain.Rows[i + 1].Cells["colGroupNo"].Value.ToString() : "-1";

                if (currRowValue == "0")
                {
                    this.dgvMain.Rows[i].Cells["colGroup"].Value = "";
                    continue;   //如果没有同组编号则跳过
                }

                //如果当前行等于上一次的同组编号并且已经是最后一行
                if (currRowValue == currTZBH && nextRowValue == "-1")
                {
                    this.dgvMain.Rows[i].Cells["colGroup"].Value = tabs[2];
                    this.dgvMain.Rows[i].Cells["colGroup"].Style.Alignment = DataGridViewContentAlignment.TopLeft;
                }
                //如果当前行不等于上一次的同组编号并且和下一行一样
                else if (currRowValue != currTZBH && nextRowValue == currRowValue)
                {
                    this.dgvMain.Rows[i].Cells["colGroup"].Value = tabs[0];
                    this.dgvMain.Rows[i].Cells["colGroup"].Style.Alignment = DataGridViewContentAlignment.BottomLeft;
                    currTZBH = currRowValue;
                }
                //如果当前行等于上一次的同组编号并且和下一行一样
                else if (currRowValue == currTZBH && nextRowValue == currRowValue)
                {
                    this.dgvMain.Rows[i].Cells["colGroup"].Value = tabs[3];
                    this.dgvMain.Rows[i].Cells["colGroup"].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                //如果当前行等于上一次的同组编号并且和下一行不一样
                else if (currRowValue == currTZBH && nextRowValue != currRowValue)
                {
                    this.dgvMain.Rows[i].Cells["colGroup"].Value = tabs[2];
                    this.dgvMain.Rows[i].Cells["colGroup"].Style.Alignment = DataGridViewContentAlignment.TopLeft;
                }
            }
        }

        private void fcbxDrug_SelectedValueChanged(object sender, EventArgs e)
        {
            DrugInventoryEntity drug = fcbxDrug.SelectedItem as DrugInventoryEntity;//选中的药品
            if (drug == null) return;

            inputDose_w.Value = drug.MinDose;
            tbxDoseUnit_w.Text = drug.MinDoseUnit;
            tbxManufacturer_w.Text = drug.Manufacturer;
            tbxSpecification_w.Text = drug.Specification;
            tbxPrice_w.Text = drug.BigPackagePrice.ToString();
            tbxDrugFrom.Text = drug.Drugform.ToString();
        }

        private void fcbxItem_SelectedValueChanged(object sender, EventArgs e)
        {
            DealWithItemEntity item = fcbxItem.SelectedItem as DealWithItemEntity;
            if (item == null) return;

            tbxSpecification_t.Text = item.Specification;
            tbxPrice_t.Text = item.Price.ToString();
        }

        private void fcbxDrug_C_SelectedValueChanged(object sender, EventArgs e)
        {
            DrugInventoryEntity drug = fcbxDrug_C.SelectedItem as DrugInventoryEntity;//选中的药品
            if (drug == null) return;

            tbxDoseUnit_C.Text = drug.MinDoseUnit;
            tbxManufacturer_C.Text = drug.Manufacturer;
            tbxPrice_C.Text = drug.SmallPackagePrice.ToString();
        }

        private void fcbxDrug_G_SelectedValueChanged(object sender, EventArgs e)
        {
            DrugInventoryEntity drug = fcbxDrug_G.SelectedItem as DrugInventoryEntity;//选中的药品
            if (drug == null) return;

            tbxDoseUnit_G.Text = drug.MinDoseUnit;
            tbxManufacturer_G.Text = drug.Manufacturer;
            tbxPrice_G.Text = drug.SmallPackagePrice.ToString();
        }

        private void dgvMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PrescriptionGroupDetailEntity entity = this.dgvMain.Rows[e.RowIndex].DataBoundItem as PrescriptionGroupDetailEntity;

            if (entity.ItemType == (int)ItemType.草药 || entity.ItemType == (int)ItemType.颗粒剂)
            {
                if (dgvMain.Columns["colUnit"].Index == e.ColumnIndex)
                {
                    e.Value = entity.SmallPackageUnit;
                }
                if (dgvMain.Columns["colPrice"].Index == e.ColumnIndex)
                {
                    e.Value = entity.SmallPackagePrice;
                }
            }


        }

        private void treeGroup_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            if (e.Node.TagString == "科室套餐" || e.Node.TagString == "个人套餐") return;
            LoadDetailData();
        }
    }
}
