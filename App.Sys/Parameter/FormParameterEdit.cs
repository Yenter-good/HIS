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
using HIS.Core;
using DevComponents.DotNetBar;
using HIS.Utility;

namespace App_Sys
{
    public partial class FormParameterEdit : BaseDialogForm
    {
        /// <summary>
        /// 参数服务
        /// </summary>
        private ISystemParameterService _systemParameterService;
        /// <summary>
        /// 修改的系统参数实体
        /// </summary>
        private SysParameterEntity _sysParameterEntity;

        public FormParameterEdit(SysParameterEntity sysParameterEntity)
        {
            InitializeComponent();
            this._systemParameterService = ServiceLocator.GetService<ISystemParameterService>();
            this._sysParameterEntity = sysParameterEntity;
        }

        private void FormParameterEdit_Shown(object sender, EventArgs e)
        {
            if (this._sysParameterEntity != null)
            {
                this.tbxCode.Text = this._sysParameterEntity.ParameterCode;
                this.tbxName.Text = this._sysParameterEntity.ParameterName;
                this.tbxValue.Text = this._sysParameterEntity.ParameterValue;
                this.tbxDescription.Text = this._sysParameterEntity.Description;
                this.swbDataStatus.Value = this._sysParameterEntity.DataStatus == HIS.Service.Core.Enums.DataStatus.Enable;

                this.ActiveControl = this.tbxValue;
                this.tbxValue.Focus();
                this.tbxValue.SelectAll();
            }
        }

        protected override void OnOK()
        {
            base.OnOK();

            string parameterValue = this.tbxValue.Text.Trim();
            if (parameterValue == "")
                parameterValue = null;

            string description = this.tbxDescription.Text.Trim();
            if (description == "")
                description = null;

            HIS.Service.Core.Enums.DataStatus dataStatus = this.swbDataStatus.Value == true
                ? HIS.Service.Core.Enums.DataStatus.Enable
                : HIS.Service.Core.Enums.DataStatus.Disable;

            this._sysParameterEntity.ParameterValue = parameterValue;
            this._sysParameterEntity.Description = description;
            this._sysParameterEntity.DataStatus = dataStatus;

            this.Enabled = false;

            var result = this._systemParameterService.Update(this._sysParameterEntity);
            if (result.Success)
            {
                AlertBox.Info("修改成功");
                base.OnOK();
            }
            else
            {
                this.Enabled = true;
                MsgBox.OK($"修改失败\r\n{result.Message}");
                this.tbxValue.Focus();
            }
        }

        private void SetValueClick(object sender, EventArgs e)
        {
            ButtonX btnX = sender as ButtonX;

            this.tbxValue.Text = btnX.Text;

            this.tbxValue.Focus();
            this.tbxValue.SelectAll();
        }
    }
}
