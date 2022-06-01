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
    /// 添加字典
    /// </summary>
    public partial class FormDicAdd : BaseDialogForm
    {
        private ISysDicService _sysDicService;
        private long _catalogId;
        private Action<SysDicEntity> _addCallBack;
        public FormDicAdd(long catalogId, Action<SysDicEntity> addCallBack)
        {
            InitializeComponent();

            this._sysDicService = HIS.Core.ServiceLocator.GetService<ISysDicService>();
            this._catalogId = catalogId;
            this._addCallBack = addCallBack;
            this.tbxName.TextChanged += (x, y) =>
            {
                this.tbxSearchCode.Text = SpellHelper.GetSpells(this.tbxName.Text.Trim());
            };
            this.AddTabOrderContainer(this.tbxCode);
            this.AddTabOrderContainer(this.tbxName);
            this.AddTabOrderContainer(this.tbxSearchCode);
            this.AddTabOrderContainer(this.tbxDesc);
            this.AddTabOrderContainer(this.swbEnable);
            this.AddTabOrderContainer(this.swbBuiltIn);
            this.AddTabOrderContainer(this.swbContinuityAdd);
            this.EnabledEnterNext = true;
        }

        protected override void OnOK()
        {
            string code = this.tbxCode.Text.Trim();
            if (code == "")
            {
                this.tbxCode.Focus();
                this.tbxCode.ShowTips("请输入编码");
                return;
            }
            bool codeExists = this._sysDicService.CodeExists(code);
            if (codeExists)
            {
                this.tbxCode.Focus();
                this.tbxCode.SelectAll();
                this.tbxCode.ShowTips("编码已经存在");
                return;
            }

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

            int no = this._sysDicService.GetNo(this._catalogId);

            DataStatus dataStatus = this.swbEnable.Value == true ? DataStatus.Enable : DataStatus.Disable;

            bool isBuiltIn = this.swbBuiltIn.Value;


            SysDicEntity sysDicEntity = new SysDicEntity();
            sysDicEntity.CatalogId = this._catalogId;
            sysDicEntity.Code = code;
            sysDicEntity.Name = name;
            sysDicEntity.SearchCode = searchCode;
            sysDicEntity.Description = desc;
            sysDicEntity.No = no;
            sysDicEntity.DataStatus = dataStatus;
            sysDicEntity.IsBuiltIn = isBuiltIn;

            var result = this._sysDicService.Add(sysDicEntity);
            if (result.Success)
            {
                this._addCallBack?.Invoke(sysDicEntity);
                if (this.swbContinuityAdd.Value)
                {
                    this.tbxCode.Text = "";
                    this.tbxName.Text = "";
                    this.tbxDesc.Text = "";
                    this.tbxCode.Focus();
                    return;
                }
                base.OnOK();
            }
            else
                HIS.Core.MsgBox.OK($"添加失败\r\n{result.Message}");

        }
    }
}
