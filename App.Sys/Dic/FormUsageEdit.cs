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

namespace App_Sys.Dic
{
    public partial class FormUsageEdit : BaseDialogForm
    {
        private readonly IUsageService _usageService;

        public FormUsageEdit(IUsageService usageService)
        {
            InitializeComponent();
            this._usageService = usageService;
        }

        public UsageEntity SelectedUsage { get; set; }
        public DataOperation Operation { get; set; }

        public event EventHandler<UsageEntity> NewUsage;

        private void InitUI()
        {
            var type = this.GetEnumDictEx<UsageType>();
            this.cbxCategory.DisplayMember = "Value";
            this.cbxCategory.ValueMember = "Key";
            this.cbxCategory.DataSource = new BindingSource(type, null);

            if (Operation == DataOperation.Modify)
            {
                this.tbxCode.Text = SelectedUsage.Code;
                this.tbxName.Text = SelectedUsage.Name;
                this.tbxSearchCode.Text = SelectedUsage.SearchCode;
                this.tbxWubiCode.Text = SelectedUsage.WubiCode;
                this.cbxCategory.SelectedIndex = (int)SelectedUsage.Category;
                this.intNo.Value = SelectedUsage.No;

                this.tbxCode.ReadOnly = true;
            }
            else if (Operation == DataOperation.New)
            {
                this.lbContinuousInput.Show();
                this.swContinuousInput.Show();
            }

            this.tbxName.TextChanged += TbxName_TextChanged;

            this.AddTabOrderContainer(this.tbxCode);
            this.AddTabOrderContainer(this.tbxName);
            this.AddTabOrderContainer(this.tbxSearchCode);
            this.AddTabOrderContainer(this.tbxWubiCode);
            this.AddTabOrderContainer(this.cbxCategory);
            this.AddTabOrderContainer(this.intNo);
        }



        private void FormUsageEdit_Shown(object sender, EventArgs e)
        {
            InitUI();
        }

        protected override void OnOK()
        {
            if (SelectedUsage == null)
                SelectedUsage = new UsageEntity();

            SelectedUsage.Code = this.tbxCode.Text;
            SelectedUsage.Name = this.tbxName.Text;
            SelectedUsage.SearchCode = this.tbxSearchCode.Text;
            SelectedUsage.WubiCode = this.tbxWubiCode.Text;
            SelectedUsage.Category = (UsageType)this.cbxCategory.SelectedValue.AsInt(0);
            SelectedUsage.No = this.intNo.Value;

            if (Operation == DataOperation.Modify)
            {
                var result = _usageService.Update(SelectedUsage);
                if (result.Success)
                {
                    AlertBox.Info("修改成功");
                    base.OnOK();
                }
                else
                    MsgBox.OK("修改失败" + Environment.NewLine + result.Message);
            }
            else if (Operation == DataOperation.New)
            {
                if (_usageService.ExistCode(this.tbxCode.Text))
                {
                    MsgBox.OK("当前编码已经被使用,请更换");
                    return;
                }
                var result = _usageService.Insert(SelectedUsage);
                if (result.Success)
                {
                    NewUsage?.Invoke(this, SelectedUsage);
                    AlertBox.Info("增加成功");
                    if (!this.swContinuousInput.Value)
                        base.OnOK();
                }
                else
                    MsgBox.OK("增加失败" + Environment.NewLine + result.Message);
            }

        }
        private void TbxName_TextChanged(object sender, EventArgs e)
        {
            this.tbxSearchCode.Text = this.tbxName.Text.GetSpell();
            this.tbxWubiCode.Text = this.tbxName.Text.GetWBM();
        }
    }
}
