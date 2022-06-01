using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;

namespace App_Sys
{
    /// <summary>
    /// 修改字典
    /// </summary>
    public partial class FormDicEdit : BaseDialogForm
    {
        private ISysDicService _sysDicService;
        private SysDicEntity _sysDicEntity;
        public FormDicEdit(SysDicEntity sysDicEntity)
        {
            InitializeComponent();

            this._sysDicService = HIS.Core.ServiceLocator.GetService<ISysDicService>();
            this._sysDicEntity = sysDicEntity;
            if (sysDicEntity != null)
            {
                this.tbxCode.Text = sysDicEntity.Code;
                this.tbxName.Text = sysDicEntity.Name;
                this.tbxSearchCode.Text = sysDicEntity.SearchCode;
                this.tbxDesc.Text = sysDicEntity.Description;
                this.swbEnable.Value = sysDicEntity.DataStatus.AsBoolean();
                this.swbBuiltIn.Value = sysDicEntity.IsBuiltIn;
            }
            this.AddTabOrderContainer(this.tbxCode);
            this.AddTabOrderContainer(this.tbxName);
            this.AddTabOrderContainer(this.tbxSearchCode);
            this.AddTabOrderContainer(this.tbxDesc);
            this.AddTabOrderContainer(this.swbEnable);
            this.AddTabOrderContainer(this.swbBuiltIn);
            this.EnabledEnterNext = true;

            this.tbxName.TextChanged += (x, y) =>
            {
                this.tbxSearchCode.Text = SpellHelper.GetSpells(this.tbxName.Text.Trim());
            };
        }

        protected override void OnOK()
        {
            string name = this.tbxName.Text.Trim();
            if (name == "")
            {
                this.tbxName.Focus();
                this.tbxName.ShowTips("请输入名称");
                return;
            }

            string searchCode = this.tbxSearchCode.Text.Trim();
            if (searchCode == "")
            {
                this.tbxSearchCode.Focus();
                this.tbxSearchCode.ShowTips("请输入拼音码");
                return;
            }

            string desc = this.tbxDesc.Text.Trim();
            if (desc == "")
            {
                desc = null;
            }


            DataStatus dataStatus = this.swbEnable.Value == true ? DataStatus.Enable : DataStatus.Disable;

            bool isBuiltIn = this.swbBuiltIn.Value;


            this._sysDicEntity.Name = name;
            this._sysDicEntity.SearchCode = searchCode;
            this._sysDicEntity.Description = desc;
            this._sysDicEntity.DataStatus = dataStatus;
            this._sysDicEntity.IsBuiltIn = isBuiltIn;

            var result = this._sysDicService.Update(this._sysDicEntity);
            if (result.Success)
            {
                HIS.Core.AlertBox.Info("修改成功");
                base.OnOK();
            }
            else
                HIS.Core.MsgBox.OK($"修改失败\r\n{result.Message}");

        }
    }
}
