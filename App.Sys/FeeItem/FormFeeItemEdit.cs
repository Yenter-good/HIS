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
using HIS.Utility;
using HIS.Service.Core.Enums;

namespace App_Sys
{
    public partial class FormFeeItemEdit : BaseDialogForm
    {
        private List<FeeTypeEntity> _feeTypeEntitys;
        private List<DeptEntity> _deptEntitys;
        private IFeeItemService _feeItemService;
        private FeeItemEntity _feeItemEntity;

        public FormFeeItemEdit(List<FeeTypeEntity> feeTypeEntitys, List<DeptEntity> deptEntitys, FeeItemEntity feeItemEntity)
        {
            InitializeComponent();

            //初始化服务
            this._feeItemService = HIS.Core.ServiceLocator.GetService<IFeeItemService>();

            this._feeTypeEntitys = feeTypeEntitys;
            this._feeItemEntity = feeItemEntity;

            //过滤科室数据
            if (deptEntitys != null && deptEntitys.Count > 0)
            {
                if (feeItemEntity == null || feeItemEntity.ExecDeptId == 0)
                    this._deptEntitys = deptEntitys.FindAll(d => d.DataStatus == DataStatus.Enable);
                else
                    this._deptEntitys = deptEntitys.FindAll(d => d.DataStatus == DataStatus.Enable || d.Id == feeItemEntity.ExecDeptId);
            }

            //设置回车键
            this.AddTabOrderContainer(this.fcbxFeeType);
            this.AddTabOrderContainer(this.tbxName);
            this.AddTabOrderContainer(this.tbxSearchCode);
            this.AddTabOrderContainer(this.tbxWubiCode);
            this.AddTabOrderContainer(this.dpPrice);
            this.AddTabOrderContainer(this.tbxSpecification);
            this.AddTabOrderContainer(this.dpMeasure);
            this.AddTabOrderContainer(this.tbxMeasureUnit);
            this.AddTabOrderContainer(this.swbEnable);
            this.AddTabOrderContainer(this.swbMZEnable);
            this.AddTabOrderContainer(this.swbZYEnable);
            this.AddTabOrderContainer(this.swbSSEnable);
            this.AddTabOrderContainer(this.swbYJEnable);
            this.AddTabOrderContainer(this.swbvariableFlag);
            this.AddTabOrderContainer(this.fcbxDept);
            this.EnabledEnterNext = true;

            //设置财务分类下拉列表
            this.fcbxFeeType.DisplayMember = nameof(FeeTypeEntity.Name);
            this.fcbxFeeType.ValueMember = nameof(FeeTypeEntity.Code);
            this.fcbxFeeType.FilterFields = new string[] { nameof(FeeTypeEntity.Name), nameof(FeeTypeEntity.Code) };
            this.fcbxFeeType.DataSource = feeTypeEntitys;

            //设置科室下拉列表
            this.fcbxDept.DisplayMember = nameof(DeptEntity.Name);
            this.fcbxDept.ValueMember = nameof(DeptEntity.Id);
            this.fcbxDept.FilterFields = new string[] { nameof(DeptEntity.Name), nameof(DeptEntity.SearchCode) };
            this.fcbxDept.DataSource = this._deptEntitys;

            this.ActiveControl = this.fcbxFeeType;
            this.fcbxFeeType.Focus();

            //界面控件赋值
            if (feeItemEntity != null)
            {
                this.fcbxFeeType.SelectedValue = feeItemEntity.FinanceTypeCode;
                this.tbxCode.Text = feeItemEntity.Code;
                this.tbxName.Text = feeItemEntity.Name;
                this.tbxSearchCode.Text = feeItemEntity.SearchCode;
                this.tbxWubiCode.Text = feeItemEntity.WubiCode;
                this.dpPrice.Text = feeItemEntity.Price.ToString();
                this.tbxSpecification.Text = feeItemEntity.Specification;
                this.dpMeasure.Text = feeItemEntity.Measure.ToString();
                this.tbxMeasureUnit.Text = feeItemEntity.MeasureUnit;
                this.swbEnable.Value = feeItemEntity.DataStatus == DataStatus.Enable;
                this.swbMZEnable.Value = feeItemEntity.OFlag;
                this.swbZYEnable.Value = feeItemEntity.IFlag;
                this.swbSSEnable.Value = feeItemEntity.SFlag;
                this.swbYJEnable.Value = feeItemEntity.MFlag;
                this.swbvariableFlag.Value = feeItemEntity.VariableFlag;
                this.fcbxDept.SelectedValue = feeItemEntity.ExecDeptId;
            }
        }

        protected override void OnOK()
        {
            string financeTypeCode = null;
            if (this.fcbxFeeType.SelectedValue != null)
                financeTypeCode = this.fcbxFeeType.SelectedValue.ToString();
            if (financeTypeCode == null)
            {
                this.fcbxFeeType.Focus();
                this.fcbxFeeType.ShowTips("请选择所属财务分类");
                return;
            }

            string name = this.tbxName.Text.Trim();
            if (name == "")
            {
                this.tbxName.Focus();
                this.tbxName.ShowTips("请输入项目名称");
                return;
            }

            string searchCode = this.tbxSearchCode.Text.Trim();
            if (searchCode == "")
                searchCode = SpellHelper.GetSpells(name);

            string wubiCode = this.tbxWubiCode.Text.Trim();
            if (wubiCode == "")
                wubiCode = SpellHelper.GetWuBis(name);

            decimal? price = this.dpPrice.Text.AsDecimal();
            if (!price.HasValue)
            {
                price = 0.0000m;
            }

            string specification = this.tbxSpecification.Text.Trim();
            if (specification == "")
            {
                specification = null;
            }

            float? measure = this.dpMeasure.Text.AsFloat();
            if (!measure.HasValue)
            {
                measure = 1f;
            }

            string measureUnit = this.tbxMeasureUnit.Text.Trim();
            if (measureUnit == "")
            {
                measureUnit = null;
            }

            bool dataStatus = this.swbEnable.Value;

            bool oFlag = this.swbMZEnable.Value;

            bool iFlag = this.swbZYEnable.Value;

            bool sFlag = this.swbSSEnable.Value;

            bool mFlag = this.swbYJEnable.Value;

            bool variableFlag = this.swbvariableFlag.Value;

            long execDeptId = 0;
            if (this.fcbxDept.SelectedItem != null)
            {
                execDeptId = (this.fcbxDept.SelectedItem as DeptEntity).Id;
            }

            this._feeItemEntity.FinanceTypeCode = financeTypeCode;
            this._feeItemEntity.Name = name;
            this._feeItemEntity.SearchCode = searchCode;
            this._feeItemEntity.WubiCode = wubiCode;
            this._feeItemEntity.Price = price.Value;
            this._feeItemEntity.Specification = specification;
            this._feeItemEntity.Measure = measure.Value;
            this._feeItemEntity.MeasureUnit = measureUnit;
            this._feeItemEntity.DataStatus = dataStatus == true ? DataStatus.Enable : DataStatus.Disable;
            this._feeItemEntity.OFlag = oFlag;
            this._feeItemEntity.IFlag = iFlag;
            this._feeItemEntity.SFlag = sFlag;
            this._feeItemEntity.MFlag = mFlag;
            this._feeItemEntity.VariableFlag = variableFlag;
            this._feeItemEntity.ExecDeptId = execDeptId;

            var result = this._feeItemService.Update(this._feeItemEntity);
            if (result.Success)
            {
                HIS.Core.AlertBox.Info("修改成功");
                base.OnOK();
            }
            else
                HIS.Core.MsgBox.OK($"修改失败\r\n{result.Message}");

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            string name = this.tbxName.Text.Trim();

            this.tbxSearchCode.Text = SpellHelper.GetSpells(name);
            this.tbxWubiCode.Text = SpellHelper.GetWuBis(name);
        }
    }
}
