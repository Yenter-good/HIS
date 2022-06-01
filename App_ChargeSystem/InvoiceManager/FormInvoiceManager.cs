using DevComponents.DotNetBar.SuperGrid;
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

namespace App_ChargeSystem.InvoiceManager
{
    public partial class FormInvoiceManager : BaseForm
    {
        private readonly IChargeInvoiceService _chargeService;

        private ChargeInvoiceEntity _currEntity = null;
        public FormInvoiceManager(IChargeInvoiceService chargeService)
        {
            InitializeComponent();
            this._chargeService = chargeService;
        }

        private void FormInvoiceManager_Load(object sender, EventArgs e)
        {
            var dic = this.GetEnumDictEx<ChargeInvoiceType>();
            cbxType.DataSource = new BindingSource(dic, null);//收费票据类型
            cbxType.ValueMember = "Key";
            cbxType.DisplayMember = "Value";
            cbxType.SelectedIndex = 0;
            this.cbxType.SelectedValueChanged += new System.EventHandler(this.cbxType_SelectedValueChanged);


            List<UserEntity> userList = _chargeService.GetCashier();

            fcbxUser.DataSource = userList;
            fcbxUser.ValueMember = nameof(AdministrativeDivisionEntity.Id);
            fcbxUser.DisplayMember = nameof(AdministrativeDivisionEntity.Name);
            fcbxUser.FilterFields = new string[] { nameof(UserEntity.SearchCode), nameof(UserEntity.Name) };

            LoadData();

        }

        private void LoadData()
        {
            int type = (int) cbxType.SelectedValue;
            List<ChargeInvoiceEntity> list = _chargeService.GetAll(type);
            this.dgvMain.PrimaryGrid.DataSource = list;
            this._currEntity = null;
            SetValue();

            ControlCanUse(true);

        }

        private void SetValue()
        {
            if (_currEntity.IsNull())
                _currEntity = new ChargeInvoiceEntity(); 

            cbxType.SelectedValue = _currEntity.Type;
            fcbxUser.SelectedValue = _currEntity.CashierId;

            tbxBeginNo.Text = _currEntity.BeginInvoiceNo;
            tbxCurrNo.Text = _currEntity.CurrentInvoiceNo;
            tbxEndNo.Text = _currEntity.EndInvoiceNo;

        }

        private void GetValue()
        {
            if (_currEntity == null) _currEntity = new ChargeInvoiceEntity();

            _currEntity.Type = (int) cbxType.SelectedValue;

            _currEntity.BeginInvoiceNo = tbxBeginNo.Text;
            _currEntity.CurrentInvoiceNo = tbxCurrNo.Text;
            _currEntity.EndInvoiceNo = tbxEndNo.Text;

            UserEntity user = fcbxUser.SelectedItem as UserEntity;
            if (user.IsNull())
            {
                AlertBox.Error("请选择一个收费员");
            }

            _currEntity.CashierId = user.Id;
            _currEntity.CashierCode = user.Code;
            _currEntity.CashierName = user.Name;
        }

        private void Clear()
        {
            _currEntity = null;
            SetValue();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            ControlCanUse(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetValue();
            DataResult<ChargeInvoiceEntity> result = null;
            if (_currEntity.Id <1)
            {
                result = _chargeService.AddInvoice(_currEntity);
            }
            else
            {
                result = _chargeService.UpdateInvoice(_currEntity.Id, _currEntity);
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

            _currEntity = this.dgvMain.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as ChargeInvoiceEntity;
            DataResult<ChargeInvoiceEntity> result = _chargeService.DeleteInvoice(_currEntity.Id);

            if (result.Success)
            {
                AlertBox.Info("删除成功");
                LoadData();

                ControlCanUse(false);
            }
        }

        private void dgvMain_GetCellFormattedValue(object sender, GridGetCellFormattedValueEventArgs e)
        {
            if (e.GridCell.GridColumn.Name == "colType")
            {
                var item = e.GridCell.GridRow.DataItem as ChargeInvoiceEntity;
                ChargeInvoiceType a = (ChargeInvoiceType)item.Type;
                e.FormattedValue = a.GetDescription();
            }
        }

        private void dgvMain_CellClick(object sender, GridCellClickEventArgs e)
        {
            _currEntity = this.dgvMain.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as ChargeInvoiceEntity;
            SetValue();
        }


        private void ControlCanUse(bool f)
        {
            tbxBeginNo.ReadOnly = f;
            tbxCurrNo.ReadOnly = f;
            tbxEndNo.ReadOnly = f;
            fcbxUser.Enabled = !f;
        }

        private void cbxType_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
