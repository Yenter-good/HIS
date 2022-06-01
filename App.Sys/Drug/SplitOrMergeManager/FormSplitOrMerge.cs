using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using HIS.Core.UI;
using HIS.DSkinControl;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.ControlLib.Popups;

namespace App_Sys.Drug.SplitOrMergeManager
{
    /// <summary>
    /// 创建人:wfg
    /// 创建时间:2021-01-21 16:04:57
    /// 描述:药品拆分与合并
    /// </summary>
    public partial class FormSplitOrMerge : BaseForm
    {
        /// <summary>
        /// 门诊药房标识
        /// </summary>
        private bool OPPharmacyFlag
        {
            get
            {
                return this.ViewData.Dept.Category.Value == DeptCategory.门诊.ToString();
            }
        }
        /// <summary>
        /// 药品接口服务
        /// </summary>
        private readonly IDrugInventoryService _drugInventoryService;
        /// <summary>
        /// 缓存的药品
        /// </summary>
        private List<DrugInventoryEntity> _cacheDrugInventorys;
        /// <summary>
        /// 数量列显示的字体
        /// </summary>
        private Font _quantityFont;
        /// <summary>
        /// 数量列显示的颜色
        /// </summary>
        private Color _quantityColor;
        private PopupControlHost _popupControlHost;
        private UCSplit _ucSplit;
        private UCMerge _ucMerge;
        public FormSplitOrMerge(IDrugInventoryService drugInventoryService, IDrugSplitOrMergeService drugSplitOrMergeService)
        {
            InitializeComponent();

            this._drugInventoryService = drugInventoryService;
            this._quantityFont = new Font("新宋体", 12, FontStyle.Bold);
            this._quantityColor = Color.Green;

            this.InitGrid();

            this._ucSplit = new UCSplit();
            this._ucMerge = new UCMerge();
            this._ucSplit.Dock = DockStyle.Fill;
            this._ucMerge.Dock = DockStyle.Fill;
            this._ucSplit.DrugSplitOrMergeService = drugSplitOrMergeService;
            this._ucMerge.DrugSplitOrMergeService = drugSplitOrMergeService;
            this.stabSplit.Controls.Add(this._ucSplit);
            this.stabMerge.Controls.Add(this._ucMerge);
            this._popupControlHost = new PopupControlHost(this.tabMain);
            this._popupControlHost.AutoClose = true;

        }

        #region 自定义按钮
        /// <summary>
        /// 拆分按钮
        /// </summary>
        private class CustomButn : GridButtonXEditControl
        {
            private bool IsSplitBnt { get; set; }
            private FormSplitOrMerge Owner { get; set; }
            public CustomButn(bool isSplitBnt, FormSplitOrMerge owner)
            {
                this.IsSplitBnt = isSplitBnt;
                this.Owner = owner;

                this.Cursor = Cursors.Hand;
                this.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
                this.Click += SplitBtn_Click;

                if (this.IsSplitBnt)
                    this.Owner._ucSplit.ScuessCallback = ScuessCallback;
                else
                    this.Owner._ucMerge.ScuessCallback = ScuessCallback;
            }

            private void ScuessCallback()
            {
                if (this.EditorCell.GridPanel.SelectedRowCount == 0)
                    return;

                var gr = this.EditorCell.GridPanel.GetSelectedRows()[0] as GridRow;
                var drug = gr.Tag as DrugInventoryEntity;
                var temp = this.Owner._drugInventoryService.PharmacyGetInventoryById(drug.InventoryId);

                drug.BigPackageQuantity = temp.BigPackageQuantity;
                drug.SmallPackageQuantity = temp.SmallPackageQuantity;
                gr.Cells[this.Owner.colBigPackageQuantity.ColumnIndex].Value = temp.BigPackageQuantity;
                gr.Cells[this.Owner.colSmallPackageQuantity.ColumnIndex].Value = temp.SmallPackageQuantity;


            }
            private void SplitBtn_Click(object sender, EventArgs e)
            {
                var point = this.GetPoint();
                var drug = this.EditorCell.GridRow.Tag.As<DrugInventoryEntity>();

                if (this.IsSplitBnt)
                {
                    this.Owner._ucSplit.ShowData(drug, this.Owner.OPPharmacyFlag);
                    this.Owner.tabMain.SelectedTabIndex = 0;
                }
                else
                {
                    this.Owner._ucMerge.ShowData(drug, this.Owner.OPPharmacyFlag);
                    this.Owner.tabMain.SelectedTabIndex = 1;
                }

                this.Owner._popupControlHost.Show(this.Owner.dgvDrug.PointToScreen(point));

                if (this.IsSplitBnt)
                    this.Owner._ucSplit.SetFocus();
                else
                    this.Owner._ucMerge.SetFocus();
            }
            private Point GetPoint()
            {
                var gridCell = this.EditorCell.GridRow.Cells[this.Owner.colClassCode.ColumnIndex] as GridCell;
                return gridCell.LocationRelative;
            }
            public override void InitializeContext(GridCell cell, CellVisualStyle style)
            {
                base.InitializeContext(cell, style);
                cell.Value = this.IsSplitBnt ? "拆分" : "合并";
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 表格初始化
        /// </summary>
        private void InitGrid()
        {
            ColumnGroupHeader columnGroupHeader1 = new ColumnGroupHeader();
            columnGroupHeader1.RowHeight += 25;
            columnGroupHeader1.HeaderText = "用户操作";
            columnGroupHeader1.StartDisplayIndex = this.colSplit.ColumnIndex;
            columnGroupHeader1.EndDisplayIndex = this.colMerge.ColumnIndex;
            this.dgvDrug.PrimaryGrid.ColumnHeader.GroupHeaders.Add(columnGroupHeader1);

            ColumnGroupHeader columnGroupHeader2 = new ColumnGroupHeader();
            columnGroupHeader2.RowHeight += 25;
            columnGroupHeader2.HeaderText = "大包装";
            columnGroupHeader2.StartDisplayIndex = this.colBigPackageQuantity.ColumnIndex;
            columnGroupHeader2.EndDisplayIndex = this.colBigPackagePrice.ColumnIndex;
            this.dgvDrug.PrimaryGrid.ColumnHeader.GroupHeaders.Add(columnGroupHeader2);

            ColumnGroupHeader columnGroupHeader3 = new ColumnGroupHeader();
            columnGroupHeader3.RowHeight += 25;
            columnGroupHeader3.HeaderText = "小包装";
            columnGroupHeader3.StartDisplayIndex = this.colSmallPackageQuantity.ColumnIndex;
            columnGroupHeader3.EndDisplayIndex = this.colSmallPackagePrice.ColumnIndex;
            this.dgvDrug.PrimaryGrid.ColumnHeader.GroupHeaders.Add(columnGroupHeader3);

            this.dgvDrug.PrimaryGrid.FrozenColumnCount = 2;
            this.dgvDrug.PrimaryGrid.AutoGenerateColumns = false;
            this.dgvDrug.PrimaryGrid.MultiSelect = false;
            this.dgvDrug.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvDrug.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvDrug.PrimaryGrid.DefaultRowHeight = 30;
            this.dgvDrug.PrimaryGrid.UseAlternateRowStyle = true;
            this.dgvDrug.PrimaryGrid.ColumnDragBehavior = ColumnDragBehavior.None;
            this.dgvDrug.PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None;
            this.dgvDrug.PrimaryGrid.GroupHeaderClickBehavior = GroupHeaderClickBehavior.None;
            this.dgvDrug.PrimaryGrid.SelectionGranularity = SelectionGranularity.Row;
        }
        /// <summary>
        /// 添加行
        /// </summary>
        /// <param name="drugs"></param>
        private void AddRows(List<DrugInventoryEntity> drugs = null)
        {
            if (drugs == null)
                drugs = this._cacheDrugInventorys;
            this.dgvDrug.PrimaryGrid.Rows.Clear();
            if (drugs == null || drugs.Count == 0)
                return;
            foreach (var item in drugs)
            {
                var gr = this.CreateRow(item);

                this.dgvDrug.PrimaryGrid.Rows.Add(gr);
            }
        }
        /// <summary>
        /// 创建行
        /// </summary>
        /// <param name="drug"></param>
        /// <returns></returns>
        private GridRow CreateRow(DrugInventoryEntity drug)
        {
            GridRow row = this.dgvDrug.PrimaryGrid.NewRow();
            row.Cells[colSplit.ColumnIndex].EditorType = typeof(CustomButn);
            row.Cells[colSplit.ColumnIndex].EditorParams = new object[] { true, this };
            row.Cells[colMerge.ColumnIndex].EditorType = typeof(CustomButn);
            row.Cells[colMerge.ColumnIndex].EditorParams = new object[] { false, this };
            row.Cells[colClassCode.ColumnIndex].Value = drug.ClassCode;
            row.Cells[colClassName.ColumnIndex].Value = drug.DrugName;
            row.Cells[colGGCode.ColumnIndex].Value = drug.SpecificationCode;
            row.Cells[colGGName.ColumnIndex].Value = drug.Specification;
            row.Cells[colDrugform.ColumnIndex].Value = drug.Drugform?.Value;
            row.Cells[colPackageNumber.ColumnIndex].Value = drug.PackageNumber;
            row.Cells[colBigPackageQuantity.ColumnIndex].Value = drug.BigPackageQuantity;
            row.Cells[colBigPackagePrice.ColumnIndex].Value = drug.BigPackagePrice.ToString("0.0000元");
            row.Cells[colSmallPackageQuantity.ColumnIndex].Value = drug.SmallPackageQuantity;
            row.Cells[colSmallPackagePrice.ColumnIndex].Value = drug.SmallPackagePrice.ToString("0.0000元");

            row.Cells[colBigPackageQuantity.ColumnIndex].CellStyles.Default.Font = this._quantityFont;
            row.Cells[colSmallPackageQuantity.ColumnIndex].CellStyles.Default.Font = this._quantityFont;
            row.Cells[colPackageNumber.ColumnIndex].CellStyles.Default.Font = this._quantityFont;


            row.Cells[colBigPackageQuantity.ColumnIndex].CellStyles.Default.TextColor = this._quantityColor;
            row.Cells[colSmallPackageQuantity.ColumnIndex].CellStyles.Default.TextColor = this._quantityColor;
            row.Cells[colPackageNumber.ColumnIndex].CellStyles.Default.TextColor = this._quantityColor;

            row.Tag = drug;

            return row;
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadData()
        {
            QLoading.Show(this);
            try
            {
                this._cacheDrugInventorys = null;
                this._popupControlHost.Close();

                var drugs = this._drugInventoryService.PharmacyGetInventory(this.ViewData.Dept.Id);
                if (drugs != null && drugs.Count > 0)
                {
                    //根据包装数以及拆分标识进行数据过滤
                    if (this.OPPharmacyFlag)
                        this._cacheDrugInventorys = drugs.Where(d => d.OPCanSplit == true && d.PackageNumber > 1).ToList();
                    else
                        this._cacheDrugInventorys = drugs.Where(d => d.IPCanSplit == true && d.PackageNumber > 1).ToList();
                }

                this.AddRows();
            }
            catch (Exception ex)
            {
                HIS.Core.MsgBox.OK($"加载失败\r\n{ex.Message}");
            }

            QLoading.Close(this);
        }
        /// <summary>
        /// 过滤科室
        /// 只显示药房科室
        /// </summary>
        /// <returns></returns>
        public override List<DeptEntity> FilterViewDeptList()
        {
            return base.FilterViewDeptList()
                .Where(d => d.CategoryDetail == DeptCategoryDetail.HMPharmacy
                         || d.CategoryDetail == DeptCategoryDetail.WMPharmacy)
                .ToList();
        }
        /// <summary>
        /// 科室切换从新加载数据
        /// </summary>
        protected override void OnDeptChanged()
        {
            this.LoadData();
        }
        /// <summary>
        /// 过滤药品数据
        /// </summary>
        /// <param name="inputTxt"></param>
        private void Filter(string inputTxt)
        {
            if (inputTxt == "")
                this.AddRows();
            else
            {
                if (this._cacheDrugInventorys == null)
                    return;

                var filterData = this._cacheDrugInventorys
                    .Where(d => d.SearchCode.Contains(inputTxt) || d.WubiCode.Contains(inputTxt) || d.DrugName.Contains(inputTxt))
                    .ToList();

                this.AddRows(filterData);

            }
        }
        #endregion

        #region 窗体事件
        private void FormSplitOrMerge_Shown(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void btnReflesh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            this.Filter(this.tbxSearch.Text.ToUpper());
        }
        #endregion
    }
}
