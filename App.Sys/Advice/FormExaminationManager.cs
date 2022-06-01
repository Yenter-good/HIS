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
using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;

namespace App_Sys.Advice
{
    public partial class FormExaminationManager : BaseForm
    {

        private readonly IAdviceService _adviceService;
        private readonly IFeeItemService _feeService;

        private long containsItemId = 0;//暂存 医嘱明细需要添加的 物价项目 ID
        private int currAdviceGridIndex = -1;//当前选中医嘱的行号
        public FormExaminationManager(IAdviceService adviceService , IFeeItemService feeService)
        {
            InitializeComponent();
            this._adviceService = adviceService;
            this._feeService = feeService;
        }

        public FormExaminationManager()
        {
            InitializeComponent();
        }

        private void FormExaminationManager_Load(object sender, EventArgs e)
        {
            InitUI();
        }

        private void InitUI() 
        {

            cbxType.DataSource = new BindingSource(this.GetEnumDictEx<ThreeDirectoryType>(),null);
            cbxType.ValueMember = "Key";
            cbxType.DisplayMember = "Value";

            cbxType.DataSource = new BindingSource(this.GetEnumDictEx<ThreeDirectoryType>(), null);
            cbxType.ValueMember = "Key";
            cbxType.DisplayMember = "Value";

            List<AdviceEntity> adviceList = GetAdviceList();
            dgvAdvice.PrimaryGrid.DataSource = adviceList;

            dgvDetail.AutoGenerateColumns = false; //去除自动绑定列
            dgvDetail.AllowUserToAddRows = false;  //去除空白行

            dgvDetail2.AutoGenerateColumns = false;
            dgvDetail2.AllowUserToAddRows = false;

            LoadFeeItemData();
        }
        //加载 费用价表数据
        private void LoadFeeItemData()
        {
            List<FeeItemEntity> list = _feeService.GetAll().Value;
            fbxName.DataSource = list;
            fbxName.ValueMember = nameof(FeeItemEntity.Id);
            fbxName.DisplayMember = nameof(FeeItemEntity.Name);
            fbxName.ColumnHeaders = "项目名称,Name,*|单价,Price,*|规格,Specification,*|单位,MeasureUnit,*";
            fbxName.FilterFields = new string[] { nameof(FeeItemEntity.Name), nameof(FeeItemEntity.SearchCode) };
        }

        #region   数据操作

        private List<AdviceEntity> GetAdviceList() 
        {
            return _adviceService.GetAllByType(AdviceType.检查);
        }
        //查询医嘱包含明细
        private List<AdviceFeeItemMapperEntity> GetContainsDetail(long id)
        {
            return _adviceService.GetByAdviceId(id);
        }
        //查询医嘱关联收费项目
        private List<AdviceFeeItemMapperEntity> GetRelationDetail(long id)
        {
            return _adviceService.GetByAdviceMapperId(id);
        }

        //界面加载医嘱明细
        private void LoadContainsDetail() {
            if (this.dgvAdvice.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            var model = this.dgvAdvice.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as AdviceEntity;
            List<AdviceFeeItemMapperEntity> containsList = GetContainsDetail(model.Id);
            dgvDetail.DataSource = containsList;


            List<AdviceFeeItemMapperEntity> relationList = GetRelationDetail(model.Id);
            dgvDetail2.DataSource = relationList;
        }
    
        #endregion


        #region   界面控件操作
        //医嘱列表单击加载明细
        private void dgvAdvice_CellClick(object sender, DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs e)
        {
            LoadContainsDetail();
            currAdviceGridIndex = e.GridCell.RowIndex;
        }
        //医嘱列表中   0 1 转成 启用 停用
        private void dgvAdvice_GetCellFormattedValue(object sender, DevComponents.DotNetBar.SuperGrid.GridGetCellFormattedValueEventArgs e)
        {
            if (e.GridCell.GridColumn.Name == "colStatus") {
                var item = e.GridCell.GridRow.DataItem as AdviceEntity;
                e.FormattedValue = item.DataStatus == DataStatus.Disable ? "停用" : "启用";
            }
        }
        //刷新
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAdvice();
        }

        private void LoadAdvice()
        {
            List<AdviceEntity> adviceList = GetAdviceList();
            dgvAdvice.PrimaryGrid.DataSource = adviceList;

            if (currAdviceGridIndex >= 0) {
                //dgvAdvice.PrimaryGrid.SetSelectedRows(currAdviceGridIndex, 1, true);

                GridRow row = dgvAdvice.PrimaryGrid.Rows[currAdviceGridIndex] as GridRow;
                dgvAdvice.PrimaryGrid.SetSelected(row, true);
            }

        }

        //新增
        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormAdviceEdit frm = new FormAdviceEdit();
            frm._editModel = "add";
            frm._adviceType = AdviceType.检查;

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                List<AdviceEntity> adviceList = GetAdviceList();
                dgvAdvice.PrimaryGrid.DataSource = adviceList;
            }
        }
        //修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateAdvice();
        }
        //双击修改
        private void dgvAdvice_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            UpdateAdvice();

        }
        private void UpdateAdvice()
        {
            if (this.dgvAdvice.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }

            FormAdviceEdit frm = new FormAdviceEdit();
            frm._editModel = "edit";
            frm._adviceType = AdviceType.检查;
            frm._entity = this.dgvAdvice.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as AdviceEntity;

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                List<AdviceEntity> adviceList = GetAdviceList();
                dgvAdvice.PrimaryGrid.DataSource = adviceList;
            }
        }

        //启用
        private void btnRestop_Click(object sender, EventArgs e)
        {
            if (this.dgvAdvice.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            AdviceEntity model = this.dgvAdvice.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as AdviceEntity;
            DataResult<AdviceEntity> result = _adviceService.StopAdvice(model.Id, DataStatus.Enable);
            if (result.Success)
            {
                List<AdviceEntity> adviceList = GetAdviceList();
                dgvAdvice.PrimaryGrid.DataSource = adviceList;
            }
            else {
                AlertBox.Error(result.Message);
            }

        }
        //停用
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (this.dgvAdvice.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            AdviceEntity model = this.dgvAdvice.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as AdviceEntity;
            DataResult<AdviceEntity> result = _adviceService.StopAdvice(model.Id, DataStatus.Disable);
            if (result.Success)
            {
                List<AdviceEntity> adviceList = GetAdviceList();
                dgvAdvice.PrimaryGrid.DataSource = adviceList;
            }
            else
            {
                AlertBox.Error(result.Message);
            }
        }
        //增加医嘱明细
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.dgvAdvice.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Error("请选中一条医嘱");
                return;
            }

            if (fbxName.Text == "")
            {
                this.fbxName.Focus();
                AlertBox.Error("选择物价项目");
                return;
            }
            //当前医嘱记录
            AdviceEntity adviceModel = this.dgvAdvice.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as AdviceEntity;

            AdviceFeeItemMapperEntity containsModel = new AdviceFeeItemMapperEntity();
            containsModel.AdviceId = adviceModel.Id;
            containsModel.FeeItemId = containsItemId;
            containsModel.Quantity = txtQuantity.Value;
            containsModel.FeeItemPrice = double.Parse(txtPrice.Text);
            containsModel.Type = rbContains.Checked ? 1 : 2;//1包含 2关联
            containsModel.ItemType = (int)cbxType.SelectedValue;
            containsModel.DataStatus = (int)DataStatus.Enable;

            DataResult<AdviceFeeItemMapperEntity> result = _adviceService.InsertAdviceFeeItemMapper(containsModel);

            if (result.Success)
            {
                AlertBox.Info("保存成功");
                LoadContainsDetail(); 
                LoadAdvice();
            }
            else {
                AlertBox.Error(result.Message);
            }

        }
        //删除医嘱明细
        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetail.Columns[e.ColumnIndex].Name == "colItemOperate")
            {
                AdviceFeeItemMapperEntity item = dgvDetail.Rows[e.RowIndex].DataBoundItem as AdviceFeeItemMapperEntity;

                DataResult<AdviceFeeItemMapperEntity> result = _adviceService.DeleteAdviceFeeItemMapper(item.AdviceId,item.Id);

                if (result.Success)
                {
                    AlertBox.Info("删除成功");
                    LoadContainsDetail();
                    LoadAdvice();
                }
                else
                {
                    AlertBox.Error(result.Message);
                }
            }
        }
        //删除关联收费
        private void dgvDetail2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetail2.Columns[e.ColumnIndex].Name == "colFeeOperate")
            {
                AdviceFeeItemMapperEntity item = dgvDetail2.Rows[e.RowIndex].DataBoundItem as AdviceFeeItemMapperEntity;

                DataResult<AdviceFeeItemMapperEntity> result = _adviceService.DeleteAdviceFeeItemMapper(item.AdviceId,item.Id);

                if (result.Success)
                {
                    AlertBox.Info("删除成功");
                    LoadContainsDetail();
                }
                else
                {
                    AlertBox.Error(result.Message);
                }
            }
        }
        //选中物价信息
        private void fbxName_TextChanged(object sender, EventArgs e)
        {
            FeeItemEntity item = fbxName.SelectedItem as FeeItemEntity;
            if (item == null) return;
            this.containsItemId = item.Id;
            txtPrice.Text = item.Price.ToString();
            txtSpecification.Text = item.Specification;
            txtUnit.Text = item.MeasureUnit;
        }

        #endregion

       
    }
}
