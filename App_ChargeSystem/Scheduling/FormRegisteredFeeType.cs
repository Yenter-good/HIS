using DevComponents.DotNetBar.SuperGrid;
using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
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

namespace App_ChargeSystem.Scheduling
{
    public partial class FormRegisteredFeeType : BaseForm
    {
        private readonly IRegFeeTypeService _regService;
        private readonly IFeeItemService _feeItemService;

        private RegFeeType _currEntity = null;


        public FormRegisteredFeeType(IRegFeeTypeService regService, IFeeItemService feeItemService)
        {
            InitializeComponent();
            this._regService = regService;
            this._feeItemService = feeItemService;
        }

        private void FormRegisteredFeeType_Load(object sender, EventArgs e)
        {

            DataResult<List<FeeItemEntity>> result = _feeItemService.GetListByInputValue("诊察费");
            List <FeeItemEntity> feeitemList = result.Value;

            fcbxFeeItem.DataSource = feeitemList;
            fcbxFeeItem.ValueMember = nameof(AdministrativeDivisionEntity.Code);
            fcbxFeeItem.DisplayMember = nameof(AdministrativeDivisionEntity.Name);
            fcbxFeeItem.FilterFields = new string[] { nameof(FeeItemEntity.SearchCode), nameof(FeeItemEntity.Name) };

            LoadData();

        }
        private void LoadData()
        {
            List<RegFeeType> list = _regService.GetAll();
            this.dgvMain.PrimaryGrid.DataSource = list;
            this._currEntity = null;
            SetValue();

            ControlCanUse(false);

        }

        private void SetValue()
        {
            if (_currEntity.IsNull())
                _currEntity = new RegFeeType();

            fcbxFeeItem.SelectedValue = _currEntity.PriceItemCode;

            tbxCode.Text = _currEntity.Code;
            tbxName.Text = _currEntity.Name;
            tbxPrice.Value = _currEntity.Price;

        }

        private void GetValue()
        {
            if (_currEntity == null) _currEntity = new RegFeeType();


            _currEntity.Code = tbxCode.Text;
            _currEntity.Name = tbxName.Text;
            _currEntity.Price = tbxPrice.Value;

            FeeItemEntity feeItem = fcbxFeeItem.SelectedItem as FeeItemEntity;
            if (feeItem.IsNull())
            {
                AlertBox.Error("请选择一个收费项目");
            }

            _currEntity.PriceItemCode = feeItem.Code;
        }

        private void Clear()
        {
            _currEntity = null;
            SetValue();
        }

        private void dgvMain_CellClick(object sender, GridCellClickEventArgs e)
        {
            _currEntity = this.dgvMain.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as RegFeeType;
            SetValue();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            ControlCanUse(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }

            ControlCanUse(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetValue();
            DataResult<RegFeeType> result = null;
            if (_currEntity.Id < 1)
            {
                result = _regService.AddFeeType(_currEntity);
            }
            else
            {
                result = _regService.UpdateFeeType(_currEntity.Id, _currEntity);
            }

            if (result.Success)
            {
                AlertBox.Info("保存成功");
                LoadData();
            }
            else
            {
                AlertBox.Error(result.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }

            _currEntity = this.dgvMain.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as RegFeeType;
            DataResult<RegFeeType> result = _regService.DeleteFeeType(_currEntity.Id);

            if (result.Success)
            {
                AlertBox.Info("删除成功");
                LoadData();

                ControlCanUse(false);
            }

        }

        private void ControlCanUse(bool f)
        {
            tbxCode.ReadOnly = !f;
            tbxName.ReadOnly = !f;
            tbxPrice.Enabled = f;
            fcbxFeeItem.Enabled = f;
        }
    }
}
