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

namespace App_OP.MedicalRecord
{
    /// <summary>
    /// 创建人:wfg
    /// 创建时间:2021-02-20 12:44:09
    /// 描述:
    /// </summary>
    public partial class FormDataElementEdit : BaseDialogForm
    {
        public DataOperation DataOperation;
        public DataElementEntity ModifyDataElementEntity;
        public event EventHandler<DataElementEntity> NewDataElement;
        private IOPDataElementService _iOPDataElementService;
        public FormDataElementEdit(IOPDataElementService oPDataElementService)
        {
            InitializeComponent();
            this._iOPDataElementService = oPDataElementService;
            this.AddTabOrderContainer(this.tbxCode);
            this.AddTabOrderContainer(this.tbxName);
            this.EnabledEnterNext = true;
        }

        private void FormDataElementEdit_Shown(object sender, EventArgs e)
        {
            this.labelX3.Visible = true;
            this.switchButton1.Visible = true;
            if (this.DataOperation == DataOperation.Modify)
            {
                this.labelX3.Visible = false;
                this.switchButton1.Visible = false;
                if (ModifyDataElementEntity != null)
                {
                    this.tbxCode.Text = this.ModifyDataElementEntity.Code;
                    this.tbxName.Text = this.ModifyDataElementEntity.Name;
                }
            }
        }

        protected override void OnOK()
        {
            string code = this.tbxCode.Text.Trim();
            if (code == "")
            {
                this.tbxCode.Focus();
                this.tbxCode.ShowTips("编码不能为空");
                return;
            }

            string name = this.tbxName.Text.Trim();
            if (name == "")
            {
                this.tbxName.Focus();
                this.tbxName.ShowTips("名称不能为空");
                return;
            }

            if (this.DataOperation == DataOperation.Modify)
            {
                if (code == this.ModifyDataElementEntity.Code && name == this.ModifyDataElementEntity.Name)
                {
                    base.DialogResult = DialogResult.OK;
                    base.Close();
                    return;
                }

                if (code != this.ModifyDataElementEntity.Code)
                {
                    bool codeExists = this._iOPDataElementService.CodeExists(code);
                    if (codeExists)
                    {
                        this.tbxCode.Focus();
                        this.tbxCode.ShowTips("编码已经存在");
                        return;
                    }
                }

                var result = this._iOPDataElementService.Update(code, name, this.ModifyDataElementEntity.Id);
                if (result.Success)
                {
                    this.ModifyDataElementEntity.Code = code;
                    this.ModifyDataElementEntity.Name = name;
                    this.OnOK();
                }
                else
                    MsgBox.OK($"修改数据源失败\r\n{result.Message}");
            }
            else
            {
                bool codeExists = this._iOPDataElementService.CodeExists(code);
                if (codeExists)
                {
                    this.tbxCode.Focus();
                    this.tbxCode.ShowTips("编码已经存在");
                    return;
                }
                DataElementEntity dataElementEntity = new DataElementEntity();
                dataElementEntity.Code = code;
                dataElementEntity.Name = name;

                var result = this._iOPDataElementService.Insert(dataElementEntity);
                if (result.Success)
                {
                    this.NewDataElement?.Invoke(this, dataElementEntity);
                    if (this.switchButton1.Value)
                    {
                        this.tbxCode.Text = "";
                        this.tbxName.Text = "";
                        this.tbxCode.Focus();
                        return;
                    }
                    else
                        base.OnOK();
                }
                else
                    MsgBox.OK($"添加数据源失败\r\n{result.Message}");
            }
        }
    }
}
