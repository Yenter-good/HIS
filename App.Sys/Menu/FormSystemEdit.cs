using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;
using HIS.Core.UI;
using System;
using System.Windows.Forms;
using HIS.Service.Core.Enums;

namespace App_Sys
{
    /// <summary>
    /// 模块分类
    /// </summary>
    public partial class FormSystemEdit : BaseDialogForm
    {
        private bool _isInsertOperation = false;
        private IAppService _appService;
        private AppEntity _updateModel;
        /// <summary>
        /// 获取当前的分类实体
        /// </summary>
        public AppEntity App { get; private set; }

        public FormSystemEdit()
        {
            InitializeComponent();
            this._appService = HIS.Core.ServiceLocator.GetService<IAppService>();
            _isInsertOperation = true;
            this.InitializeUI();
        }

        public FormSystemEdit(AppEntity app)
        {
            InitializeComponent();
            app.CheckNotNull(nameof(app));
            this._appService = HIS.Core.ServiceLocator.GetService<IAppService>();
            _isInsertOperation = false;
            this._updateModel = app;
            this.InitializeUI();
        }

        private void InitializeUI()
        {
            if (this._updateModel != null)
            {
                this.txtName.Text = this._updateModel.Name;
                this.txtNo.Text = this._updateModel.No.ToString();
                if (this._updateModel.Status == DataStatus.Enable)
                    this.rbtnEnable.Checked = true;
                else
                    this.rbtnDisable.Checked = true;
            }
        }

        protected override void OnOK()
        {
            if (this.txtName.Text.IsNullOrWhiteSpace())
            {
                this.txtName.Focus();
                this.warningBox1.Text = "系统名称不能为空";
                this.warningBox1.AutoCloseTimeout = 2;
                this.warningBox1.Show();
                return;
            }
            if (_isInsertOperation)
            {
                AppEntity appEntity = new AppEntity();
                appEntity.Name = this.txtName.Text.Trim();
                appEntity.No = this.txtNo.Text.AsInt(0);
                appEntity.Status = this.rbtnEnable.Checked ? DataStatus.Enable : DataStatus.Disable;
                this.App = this._appService.Insert(appEntity);
            }
            else
            {
                this._updateModel.Name = this.txtName.Text.Trim();
                this._updateModel.No = this.txtNo.Text.AsInt(0);
                this._updateModel.Status = this.rbtnEnable.Checked ? DataStatus.Enable : DataStatus.Disable;
                var result = this._appService.Update(this._updateModel.Id, _updateModel);
                if (!result.Success)
                {
                    this.warningBox1.Text = result.Message;
                    this.warningBox1.AutoCloseTimeout = 2;
                    this.warningBox1.Show();
                    return;
                }
                this.App = _updateModel;
            }
            base.OnOK();
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {

        }
    }
}
