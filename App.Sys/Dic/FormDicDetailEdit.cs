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

namespace App_Sys
{
    public partial class FormDicDetailEdit : BaseDialogForm
    {
        private readonly ISysDicDetailService _detailService;

        public FormDicDetailEdit(ISysDicDetailService detailService)
        {
            InitializeComponent();
            this._detailService = detailService;
        }

        public SysDicDetailEntity SelectedDetailEntity { private get; set; }
        public SysDicEntity SelectedDicEntity { private get; set; }
        public DataOperation Operation { get; set; }

        public event EventHandler<SysDicDetailEntity> NewDetail;

        private void InitUI()
        {
            if (Operation == DataOperation.Modify)
            {
                this.tbxCode.Text = SelectedDetailEntity.Code;
                this.tbxName.Text = SelectedDetailEntity.Value;
                this.swExtend.Value = SelectedDetailEntity.Extensibility;
                this.swIsBuildIn.Value = SelectedDetailEntity.IsBuiltIn;
                this.swDataDtatus.Value = SelectedDetailEntity.DataStatus.AsBoolean();
                this.tbxDescription.Text = SelectedDetailEntity.Description;

                this.tbxCode.ReadOnly = true;

                this.ActiveControl = this.tbxName;
                this.tbxName.Focus();
            }
            else if (Operation == DataOperation.New)
            {
                this.lbContinuousInput.Show();
                this.swContinuousInput.Show();

                this.ActiveControl = this.tbxCode;
                this.tbxCode.Focus();
            }
        }

        private bool Valid()
        {
            if (this.tbxCode.Text == "")
            {
                MsgBox.OK("编码不能为空");
                this.tbxCode.Focus();
                return false;
            }
            if (this.tbxName.Text == "")
            {
                MsgBox.OK("明细值不能为空");
                this.tbxName.Focus();
                return false;
            }

            return true;
        }

        protected override void OnOK()
        {
            if (!this.Valid())
            {
                return;
            }

            if (SelectedDetailEntity == null)
                SelectedDetailEntity = new SysDicDetailEntity();

            if (Operation == DataOperation.Modify)
            {
                SelectedDetailEntity.Value = this.tbxName.Text;
                SelectedDetailEntity.Extensibility = this.swExtend.Value;
                SelectedDetailEntity.IsBuiltIn = this.swIsBuildIn.Value;
                SelectedDetailEntity.DataStatus = this.swDataDtatus.Value == true ? DataStatus.Enable : DataStatus.Disable;
                SelectedDetailEntity.Description = this.tbxDescription.Text;

                var result = _detailService.Update(SelectedDetailEntity);
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
                SelectedDetailEntity.Code = this.tbxCode.Text;
                SelectedDetailEntity.Value = this.tbxName.Text;
                SelectedDetailEntity.Extensibility = this.swExtend.Value;
                SelectedDetailEntity.IsBuiltIn = this.swIsBuildIn.Value;
                SelectedDetailEntity.DataStatus = this.swDataDtatus.Value == true ? DataStatus.Enable : DataStatus.Disable;
                SelectedDetailEntity.Description = this.tbxDescription.Text;
                SelectedDetailEntity.DicCode = this.SelectedDicEntity.Code;

                if (_detailService.ExistCode(SelectedDetailEntity.Code, SelectedDetailEntity.DicCode))
                {
                    MsgBox.OK("编码重复");
                    return;
                }

                var result = _detailService.Add(SelectedDetailEntity);
                if (result.Success)
                {
                    this.NewDetail?.Invoke(this, SelectedDetailEntity);
                    AlertBox.Info("增加成功");
                    if (swContinuousInput.Value)
                    {
                        this.tbxCode.Text = "";
                        this.tbxName.Text = "";
                        this.tbxDescription.Text = "";
                    }
                    else
                        base.OnOK();
                }
                else
                    MsgBox.OK("增加失败" + Environment.NewLine + result.Message);
            }

        }

        private void FormDicDetailEdit_Shown(object sender, EventArgs e)
        {
            this.InitUI();
        }
    }
}
