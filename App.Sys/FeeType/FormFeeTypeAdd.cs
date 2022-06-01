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

namespace App_Sys
{
    public partial class FormFeeTypeAdd : BaseDialogForm
    {
        private IFeeTypeService _feeTypeService;
        private IIdService _idService;
        private Action<FeeTypeEntity> _addCallback;
        public FormFeeTypeAdd(Action<FeeTypeEntity> addCallback)
        {
            InitializeComponent();

            //初始化服务
            this._feeTypeService = HIS.Core.ServiceLocator.GetService<IFeeTypeService>();
            this._idService = HIS.Core.ServiceLocator.GetService<IIdService>();

            //设置回车键
            this.AddTabOrderContainer(this.tbxCode);
            this.AddTabOrderContainer(this.tbxName);
            this.AddTabOrderContainer(this.swbContinuityAdd);
            this.EnabledEnterNext = true;

            //变量赋值
            this._addCallback = addCallback;

            //设置焦点
            this.ActiveControl = this.tbxCode;
            this.tbxCode.Focus();
        }

        protected override void OnOK()
        {
            string code = this.tbxCode.Text.Trim();
            if (code == "")
            {
                this.tbxCode.Focus();
                this.tbxCode.ShowTips("请输入费用类型编码");
                return;
            }
            bool codeExists = this._feeTypeService.CodeExists(code);
            if (codeExists)
            {
                this.tbxCode.Focus();
                this.tbxCode.SelectAll();
                this.tbxCode.ShowTips("费用类型编码已经存在");
                return;
            }

            string name = this.tbxName.Text.Trim();
            if (name == "")
            {
                this.tbxName.Focus();
                this.tbxName.ShowTips("请输入费用类型名称");
                return;
            }

            FeeTypeEntity feeTypeEntity = new FeeTypeEntity();
            feeTypeEntity.Id = this._idService.CreateUUID();
            feeTypeEntity.Code = code;
            feeTypeEntity.Name = name;
            feeTypeEntity.DataStatus = HIS.Service.Core.Enums.DataStatus.Enable;
            feeTypeEntity.SearchCode = SpellHelper.GetSpells(name);

            var result = this._feeTypeService.Add(feeTypeEntity);
            if (result.Success)
            {
                this._addCallback?.Invoke(feeTypeEntity);
                if (this.swbContinuityAdd.Value)
                {
                    this.tbxCode.Text = "";
                    this.tbxName.Text = "";
                    this.tbxCode.Focus();
                    return;
                }

                this.OnOK();
            }
            else
                HIS.Core.MsgBox.OK($"添加失败\r\n{result.Message}");
        }
    }
}
