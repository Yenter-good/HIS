using HIS.Core;
using HIS.Core.UI;
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

namespace App_Sys.Drug.MerchantsManager
{
    public partial class FormMerchantsEdit : BaseDialogForm
    {
        private IMerchantsService _merchantsService;

        public DataOperation Operation { get; set; }
        public MerchantsEntity _entity = null;
        public MerchantType merchantType;
        public event EventHandler<MerchantsEntity> New;
        public FormMerchantsEdit()
        {
            InitializeComponent();
            this._merchantsService = ServiceLocator.GetService<IMerchantsService>();

            //设置回车键
            this.AddTabOrderContainer(this.tbxName);
            this.AddTabOrderContainer(this.tbxAddr);
            this.AddTabOrderContainer(this.tbxLegalPerson);
            this.AddTabOrderContainer(this.tbxPhoneNo);
            this.AddTabOrderContainer(this.tbxBusinessLicense);
            this.EnabledEnterNext = true;
        }

        private void FormMerchantsEdit_Load(object sender, EventArgs e)
        {
            if (this.Operation == DataOperation.Modify)
            {
                swbContinuous.Visible = false;
                lblContinuous.Visible = false;

                if (this._entity != null)
                {
                    this.tbxName.Text = this._entity.Name;
                    this.tbxSearchCode.Text = this._entity.SearchCode;
                    this.tbxWubiCode.Text = this._entity.WubiCode;
                    this.tbxLegalPerson.Text = this._entity.LegalPerson;
                    this.tbxAddr.Text = this._entity.Address;
                    this.tbxBusinessLicense.Text = this._entity.BusinessLicense;
                    this.tbxPhoneNo.Text = this._entity.PhoneNo;
                }
            }

            this.tbxName.TextChanged += tbxName_TextChanged;
        }
        protected override void OnOK()
        {
            string name = tbxName.Text.Trim();
            if (name == "")
            {
                this.tbxName.Focus();
                this.tbxName.ShowTips("请输入厂家名称");
                return;
            }

            string pym = this.tbxSearchCode.Text.Trim();
            if (pym == "")
                pym = SpellHelper.GetSpells(name);

            string wbm = this.tbxWubiCode.Text.Trim();
            if (wbm == "")
                wbm = SpellHelper.GetWuBis(name);

            string address = this.tbxAddr.Text.Trim();
            if (address == "")
                address = null;

            string businessLicense = this.tbxBusinessLicense.Text.Trim();
            if (businessLicense == "")
                businessLicense = null;

            string phoneNo = this.tbxPhoneNo.Text.Trim();
            if (phoneNo == "")
                phoneNo = null;

            string legalPerson = this.tbxLegalPerson.Text.Trim();
            if (legalPerson == "")
                legalPerson = null;

            if (this._entity == null)
                this._entity = new MerchantsEntity();
            this._entity.Name = name;
            this._entity.SearchCode = pym;
            this._entity.WubiCode = wbm;
            this._entity.Address = address;
            this._entity.BusinessLicense = businessLicense;
            this._entity.PhoneNo = phoneNo;
            this._entity.LegalPerson = legalPerson;
            if (this.Operation == DataOperation.New)
            {
                this._entity.Type = merchantType;
                var result = this._merchantsService.InsertMerchants(this._entity);
                if (result.Success)
                {
                    AlertBox.Info("新增成功");
                    this.New?.Invoke(this, this._entity);
                    if (this.swbContinuous.Value)//如果连续新增 启用 则清空界面继续录入
                    {
                        this.ClearControlValue();
                        this.tbxName.Focus();
                        return;
                    }
                    else
                        base.Close();
                }
                else
                    MsgBox.OK($"添加失败\r\n{result.Message}");
            }
            else
            {
                var result = this._merchantsService.UpdateMerchants(this._entity);
                if (result.Success)
                {
                    AlertBox.Info("更新成功");
                    base.OnOK();
                }
                else
                    MsgBox.OK($"更新失败\r\n{result.Message}");
            }

        }
        private void ClearControlValue()
        {
            this.tbxName.Text = "";
            this.tbxLegalPerson.Text = "";
            this.tbxAddr.Text = "";
            this.tbxBusinessLicense.Text = "";
            this.tbxPhoneNo.Text = "";

        }
        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            this.tbxSearchCode.Text = SpellHelper.GetSpells(this.tbxName.Text.Trim());
            this.tbxWubiCode.Text = SpellHelper.GetWuBis(this.tbxName.Text.Trim());
        }
    }
}
