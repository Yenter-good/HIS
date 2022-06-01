using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.SuperGrid;
using HIS.Core;
using HIS.Core.UI;
using HIS.DSkinControl;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;

namespace App_Sys.Drug
{
    /// <summary>
    /// 药品品种及规格定义
    /// </summary>
    public partial class FormClassAndSpecificationManager : BaseForm
    {
        private readonly IWholehospitalClassService _wholehospitalClassService;
        private readonly IWholehospitalSpecificationService _wholehospitalSpecificationService;
        private List<WholehospitalClassEntity> _cachYPs;
        public FormClassAndSpecificationManager(IWholehospitalClassService wholehospitalClassService,
            IWholehospitalSpecificationService wholehospitalSpecificationService)
        {
            InitializeComponent();

            this._wholehospitalClassService = wholehospitalClassService;
            this._wholehospitalSpecificationService = wholehospitalSpecificationService;


            this.gridYP.PrimaryGrid.UseAlternateRowStyle = true;
            this.gridYP.PrimaryGrid.MultiSelect = false;
            this.gridYP.PrimaryGrid.ShowRowGridIndex = true;
            this.gridYP.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.gridYP.PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None;
            this.gridYP.PrimaryGrid.SelectionGranularity = SelectionGranularity.Row;
            this.gridYP.PrimaryGrid.RowHeaderWidth += 10;
            this.gridGG.PrimaryGrid.UseAlternateRowStyle = true;
            this.gridGG.PrimaryGrid.MultiSelect = false;
            this.gridGG.PrimaryGrid.ShowRowGridIndex = true;
            this.gridGG.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.gridGG.PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None;
            this.gridGG.PrimaryGrid.SelectionGranularity = SelectionGranularity.Row;
            this.panelEx1.Enabled = false;
            this.ggBar.Enabled = false;
        }
        /// <summary>
        /// 当前选中的药品类型
        /// </summary>
        private int _CurrentSelectedDrugType
        {
            get
            {
                object tag = this.drugTypeTree.SelectedNode.Tag;
                if (tag == null)
                    return -1;
                return Convert.ToInt32(tag);
            }
        }
        /// <summary>
        /// 当前选中的药品品种
        /// </summary>
        private WholehospitalClassEntity _CurrentSelectedYP
        {
            get
            {
                var rows = this.gridYP.GetSelectedRows();
                if (rows == null || rows.Count == 0)
                    return null;
                return rows[0].Tag as WholehospitalClassEntity;
            }
        }
        /// <summary>
        /// 当前选中的药品规格
        /// </summary>
        private WholehospitalSpecificationEntity _CurrentSelectedGG
        {
            get
            {
                var rows = this.gridGG.GetSelectedRows();
                if (rows == null || rows.Count == 0)
                    return null;
                return rows[0].Tag as WholehospitalSpecificationEntity;
            }
        }

        private void FormClassAndSpecificationManager_Shown(object sender, EventArgs e)
        {
            this.InitUI();
        }

        private void InitUI()
        {
            this.rootNode.Nodes.Clear();
            this.rootNode.NodeClick += N_NodeClick;

            Dictionary<int, string> dicDrugType = typeof(DrugType).EnumToDictEx<DrugType, int>();
            foreach (var item in dicDrugType)
            {
                Node n = new Node();
                n.Text = item.Value;
                n.Tag = item.Key;
                n.NodeClick += N_NodeClick;

                this.rootNode.Nodes.Add(n);
            }
        }

        private void N_NodeClick(object sender, EventArgs e)
        {
            this.LoadYP();
        }

        private void LoadYP()
        {
            this.drugTypeTree.Enabled = false;
            this.ggBar.Enabled = false;
            this.gridYP.ShowMask(() =>
            {
                this._cachYPs = null;
                this.delaytbxInput.Text = "";
                var result = this._wholehospitalClassService.GetListByDrugType(this._CurrentSelectedDrugType);
                if (result.Success)
                {
                    //启用编辑面板
                    this.panelEx1.Enabled = true;
                    //缓存数据
                    this._cachYPs = result.Value;
                    //添加行数据
                    this.DrugClassAddRows();
                }
                else
                    MsgBox.OK($"加载药品品种异常\r\n{result.Message}");
            });
            this.drugTypeTree.Enabled = true;
        }

        private void DrugClassAddRows(List<WholehospitalClassEntity> yps = null)
        {
            this.gridYP.PrimaryGrid.Rows.Clear();
            this.gridYP.HScrollOffset = 0;
            this.gridYP.VScrollOffset = 0;
            this.gridYP.PrimaryGrid.VirtualRowCount = 0;
            var ypList = yps == null ? this._cachYPs : yps;
            foreach (var yp in ypList)
            {
                this.gridYP.PrimaryGrid.Rows.Add(this.CreateDrugClassRow(yp));
            }
        }
        private void GGAddRows(List<WholehospitalSpecificationEntity> ggs)
        {
            this.gridGG.PrimaryGrid.Rows.Clear();
            this.gridGG.HScrollOffset = 0;
            this.gridGG.VScrollOffset = 0;
            this.gridGG.PrimaryGrid.VirtualRowCount = 0;
            if (ggs != null)
            {
                foreach (var item in ggs)
                {
                    this.gridGG.PrimaryGrid.Rows.Add(this.CreateGGRow(item));
                }
            }
        }

        private GridRow CreateGGRow(WholehospitalSpecificationEntity gg)
        {
            if (gg != null)
            {
                GridRow gr = this.gridGG.PrimaryGrid.NewRow();

                gr.Cells[colYPCode.ColumnIndex].Value = gg.ClassCode;
                gr.Cells[colGGCode.ColumnIndex].Value = gg.Code;
                gr.Cells[colspm.ColumnIndex].Value = gg.TradeName;
                gr.Cells[colgg.ColumnIndex].Value = gg.Specification;
                gr.Cells[colbzs.ColumnIndex].Value = gg.PackageNumber;
                gr.Cells[coldbzdw.ColumnIndex].Value = gg.BigPackageUnit;
                gr.Cells[colxbzdw.ColumnIndex].Value = gg.SmallPackageUnit;
                gr.Cells[colzxjl.ColumnIndex].Value = gg.MinDose;
                gr.Cells[colzxjldw.ColumnIndex].Value = gg.MinDoseUnit;
                gr.Cells[colsccj.ColumnIndex].Value = gg.Manufacturer;
                gr.Cells[colqyzt.ColumnIndex].Value = gg.DataStatus.AsBoolean();
                gr.Cells[colGGpym.ColumnIndex].Value = gg.SearchCode;
                gr.Cells[colGGwbm.ColumnIndex].Value = gg.WubiCode;

                gr.Tag = gg;

                return gr;
            }

            return null;
        }

        private GridRow CreateDrugClassRow(WholehospitalClassEntity yp)
        {
            if (yp != null)
            {
                GridRow gr = this.gridYP.PrimaryGrid.NewRow();

                gr.Cells[colypbm.ColumnIndex].Value = yp.Code;
                gr.Cells[colypmc.ColumnIndex].Value = yp.Name;
                gr.Cells[coljx.ColumnIndex].Value = yp.Drugfrom.Value;
                gr.Cells[colyytj.ColumnIndex].Value = yp.UseWay?.Name;
                gr.Cells[colfyfs.ColumnIndex].Value = yp.DispensingType.Value;
                gr.Cells[colkssjb.ColumnIndex].Value = yp.AntibioticType.ToString();
                gr.Cells[colps.ColumnIndex].Value = yp.SkinTestFlag;
                gr.Cells[coldjlx.ColumnIndex].Value = yp.PriceType.Value;
                gr.Cells[colgmp.ColumnIndex].Value = yp.GMP;
                gr.Cells[colmzcf.ColumnIndex].Value = yp.OPCanSplit;
                gr.Cells[colzycf.ColumnIndex].Value = yp.IPCanSplit;

                gr.Tag = yp;

                return gr;
            }

            return null;
        }

        private void LoadGG()
        {
            var yp = this._CurrentSelectedYP;
            if (yp == null)
            {
                this.GGAddRows(null);
                this.ggBar.Enabled = false;
                return;
            }
            var result = this._wholehospitalSpecificationService.GetListByClassCode(yp.Code, true);
            if (result.Success)
            {
                this.ggBar.Enabled = true;
                this.GGAddRows(result.Value);
            }
            else
                MsgBox.OK($"加载药品规格异常\r\n{result.Message}");
        }

        private void delaytbxInput_TextChanged(object sender, EventArgs e)
        {
            if (this._cachYPs == null || this._cachYPs.Count == 0) return;
            string inputTxt = this.delaytbxInput.Text.Trim().ToUpper();
            if (inputTxt == "")
                this.DrugClassAddRows();
            else
            {
                var filterData = this._cachYPs.Where(d => d.SearchCode.AsString("").Contains(inputTxt) || d.WubiCode.AsString("").Contains(inputTxt) || d.Name.Contains(inputTxt)).ToList();
                if (filterData == null || filterData.Count == 0)
                    this.gridYP.PrimaryGrid.Rows.Clear();
                else
                    this.DrugClassAddRows(filterData);
            }
        }

        private void gridClass_SelectionChanged(object sender, GridEventArgs e)
        {
            if (this._CurrentSelectedYP == null)
                this.gridGG.PrimaryGrid.Rows.Clear();
            else
                this.LoadGG();
        }

        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            FormDrugClassEdit dialog = App.Instance.CreateView<FormDrugClassEdit>();
            dialog.Operation = DataOperation.New;
            dialog.SelectedDrugType = this._CurrentSelectedDrugType;
            dialog.NewWholehospitalClass += (x, y) =>
            {
                if (this._CurrentSelectedDrugType == (int)y.DrugType)
                {
                    GridRow gr = this.CreateDrugClassRow(y);
                    this.gridYP.PrimaryGrid.Rows.Add(gr);
                    if (!gr.IsOnScreen)
                        gr.EnsureVisible();
                }
            };
            dialog.ShowDialog();
        }

        private void btnClassEdit_Click(object sender, EventArgs e)
        {
            var model = this._CurrentSelectedYP;
            if (model == null) return;
            FormDrugClassEdit dialog = App.Instance.CreateView<FormDrugClassEdit>();
            dialog.ModifyWholehospitalClassEntity = model;
            dialog.Operation = DataOperation.Modify;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                GridRow gr = this.gridYP.PrimaryGrid.ActiveRow as GridRow;
                if ((int)model.DrugType != this._CurrentSelectedDrugType)
                {
                    //删除当前行
                    gr.IsDeleted = true;
                    this.gridYP.PrimaryGrid.PurgeDeletedRows();
                    return;
                }
                gr.Cells[colypbm.ColumnIndex].Value = model.Code;
                gr.Cells[colypmc.ColumnIndex].Value = model.Name;
                gr.Cells[coljx.ColumnIndex].Value = model.Drugfrom.Value;
                gr.Cells[colyytj.ColumnIndex].Value = model.UseWay?.Name ?? "";
                gr.Cells[colfyfs.ColumnIndex].Value = model.DispensingType?.Value ?? "";
                gr.Cells[colkssjb.ColumnIndex].Value = model.AntibioticType.ToString();
                gr.Cells[colps.ColumnIndex].Value = model.SkinTestFlag;
                gr.Cells[coldjlx.ColumnIndex].Value = model.PriceType.Value;
                gr.Cells[colgmp.ColumnIndex].Value = model.GMP;
                gr.Cells[colmzcf.ColumnIndex].Value = model.OPCanSplit;
                gr.Cells[colzycf.ColumnIndex].Value = model.IPCanSplit;
            }
        }

        private void gridClass_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            this.btnClassEdit_Click(null, null);
        }

        private void btnClassReflesh_Click(object sender, EventArgs e)
        {
            this.LoadYP();
        }

        #region 药品规格列表
        private void btnGGAdd_Click(object sender, EventArgs e)
        {
            FormSpecificationEdit dialog = App.Instance.CreateView<FormSpecificationEdit>();
            dialog.Operation = DataOperation.New;
            dialog.SelectedYP = this._CurrentSelectedYP;
            dialog.NewDrugSpecification += (x, y) =>
            {
                GridRow gr = this.CreateGGRow(y);
                this.gridGG.PrimaryGrid.Rows.Add(gr);
                if (!gr.IsOnScreen)
                    gr.EnsureVisible();
            };
            dialog.ShowDialog();
        }
        private void btnGGEdit_Click(object sender, EventArgs e)
        {
            FormSpecificationEdit dialog = App.Instance.CreateView<FormSpecificationEdit>();
            dialog.Operation = DataOperation.Modify;
            var drugClass = this._CurrentSelectedYP;
            var drugGG = this._CurrentSelectedGG;
            if (drugClass == null || drugGG == null) return;
            dialog.SelectedGG = drugGG;
            dialog.SelectedYP = drugClass;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                GridRow gr = this.gridGG.PrimaryGrid.ActiveRow as GridRow;

                gr.Cells[colYPCode.ColumnIndex].Value = drugGG.ClassCode;
                gr.Cells[colGGCode.ColumnIndex].Value = drugGG.Code;
                gr.Cells[colspm.ColumnIndex].Value = drugGG.TradeName;
                gr.Cells[colgg.ColumnIndex].Value = drugGG.Specification;
                gr.Cells[colbzs.ColumnIndex].Value = drugGG.PackageNumber;
                gr.Cells[coldbzdw.ColumnIndex].Value = drugGG.BigPackageUnit;
                gr.Cells[colxbzdw.ColumnIndex].Value = drugGG.SmallPackageUnit;
                gr.Cells[colzxjl.ColumnIndex].Value = drugGG.MinDose;
                gr.Cells[colzxjldw.ColumnIndex].Value = drugGG.MinDoseUnit;
                gr.Cells[colsccj.ColumnIndex].Value = drugGG.Manufacturer;
                gr.Cells[colGGpym.ColumnIndex].Value = drugGG.SearchCode;
                gr.Cells[colGGwbm.ColumnIndex].Value = drugGG.WubiCode;

            }
        }
        private void btnGGReflesh_Click(object sender, EventArgs e)
        {
            this.LoadGG();
        }
        private void gridGG_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            this.btnGGEdit_Click(null, null);
        }
        private void btnGGEnable_Click(object sender, EventArgs e)
        {
            this.SetGGDataStatus(DataStatus.Enable);
        }
        private void btnGGDisable_Click(object sender, EventArgs e)
        {
            this.SetGGDataStatus(DataStatus.Disable);
        }

        private void SetGGDataStatus(DataStatus dataStatus)
        {
            var gg = this._CurrentSelectedGG;
            if (gg == null || dataStatus == gg.DataStatus)
                return;
            string dataStatusTxt = dataStatus == DataStatus.Enable ? "启用" : "停用";
            if (MsgBox.YesNo($"是否{dataStatusTxt}此规格?") != DialogResult.Yes) return;
            var result = this._wholehospitalSpecificationService.UpdateDataStatus(gg, dataStatus);
            if (result.Success)
            {
                AlertBox.Info("修改成功");
                gg.DataStatus = dataStatus;
                GridRow gr = this.gridGG.PrimaryGrid.GetSelectedRows()[0] as GridRow;
                gr.Cells[colqyzt.ColumnIndex].Value = dataStatus.AsBoolean();
            }
            else
                MsgBox.OK($"修改失败\r\n{result.Message}");

        }
        #endregion
    }
}
