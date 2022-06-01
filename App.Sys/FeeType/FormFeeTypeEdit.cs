using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
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
using HIS.Core;

namespace App_Sys
{
    public partial class FormFeeTypeEdit : BaseDialogForm
    {
        private IFeeTypeService _feeTypeService;
        private FeeTypeEntity _feeTypeEntity;

        public FormFeeTypeEdit(FeeTypeEntity feeTypeEntity)
        {
            InitializeComponent();

            //初始化服务
            this._feeTypeService = ServiceLocator.GetService<IFeeTypeService>();

            //设置回车键
            this.AddTabOrderContainer(this.tbxName);
            this.AddTabOrderContainer(this.swbDataStatus);
            this.EnabledEnterNext = true;

            //变量赋值
            this._feeTypeEntity = feeTypeEntity;

            //控件赋值
            this.tbxCode.Text = feeTypeEntity?.Code;
            this.tbxName.Text = feeTypeEntity?.Name;
            if (feeTypeEntity != null)
                this.swbDataStatus.Value = feeTypeEntity.DataStatus == HIS.Service.Core.Enums.DataStatus.Enable;

            //设置焦点
            this.ActiveControl = this.tbxName;
            this.tbxName.Focus();
        }

        protected override void OnOK()
        {
            string name = this.tbxName.Text.Trim();
            if (name == "")
            {
                this.tbxName.Focus();
                this.tbxName.ShowTips("请输入费用类型名称");
                return;
            }

            this._feeTypeEntity.Name = name;
            this._feeTypeEntity.SearchCode = SpellHelper.GetSpells(name);
            this._feeTypeEntity.DataStatus = this.swbDataStatus.Value == true ? HIS.Service.Core.Enums.DataStatus.Enable : HIS.Service.Core.Enums.DataStatus.Disable;

            var result = this._feeTypeService.Update(this._feeTypeEntity);
            if (result.Success)
            {
                this._feeTypeEntity.Name = name;
                AlertBox.Info("修改成功");
                base.OnOK();
            }
            else
                MsgBox.OK($"修改失败\r\n{result.Message}");
        }
    }
}
