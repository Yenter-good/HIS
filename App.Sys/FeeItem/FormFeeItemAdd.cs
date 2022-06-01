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
    public partial class FormFeeItemAdd : BaseDialogForm
    {
        private Action<FeeItemEntity> _addCallBack;
        private FeeTypeEntity _feeTypeEntity;
        private List<DeptEntity> _deptEntitys;
        private IIdService _idService;
        private IFeeItemService _feeItemService;

        public FormFeeItemAdd(Action<FeeItemEntity> addCallBack, FeeTypeEntity feeTypeEntity, List<DeptEntity> deptEntitys)
        {
            InitializeComponent();

            this._idService = HIS.Core.ServiceLocator.GetService<IIdService>();
            this._feeItemService = HIS.Core.ServiceLocator.GetService<IFeeItemService>();

            this._addCallBack = addCallBack;
            this._feeTypeEntity = feeTypeEntity;

            if (deptEntitys != null && deptEntitys.Count > 0)
                this._deptEntitys = deptEntitys.FindAll(d => d.DataStatus == DataStatus.Enable);

            //设置回车键
            this.AddTabOrderContainer(this.tbxCode);
            this.AddTabOrderContainer(this.tbxName);
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
            this.AddTabOrderContainer(this.swbContinuityAdd);
            this.EnabledEnterNext = true;

            //设置科室显示值
            this.fcbxDept.DisplayMember = nameof(DeptEntity.Name);
            this.fcbxDept.ValueMember = nameof(DeptEntity.Id);
            this.fcbxDept.FilterFields = new string[] { nameof(DeptEntity.Name), nameof(DeptEntity.SearchCode) };
            this.fcbxDept.DataSource = this._deptEntitys;

            this.ActiveControl = this.tbxCode;
            this.tbxCode.Focus();
        }


        protected override void OnOK()
        {
            string code = this.tbxCode.Text.Trim();
            if (code == "")
            {
                this.tbxCode.Focus();
                this.tbxCode.ShowTips("请输入项目编码");
                return;
            }

            string name = this.tbxName.Text.Trim();
            if (name == "")
            {
                this.tbxName.Focus();
                this.tbxName.ShowTips("请输入项目名称");
                return;
            }

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


            FeeItemEntity feeItemEntity = new FeeItemEntity();
            feeItemEntity.Id = this._idService.CreateUUID();
            feeItemEntity.Code = code;
            feeItemEntity.Name = name;
            feeItemEntity.DataStatus = dataStatus ? DataStatus.Enable : DataStatus.Disable;
            feeItemEntity.Specification = specification;
            feeItemEntity.Measure = measure.Value;
            feeItemEntity.MeasureUnit = measureUnit;
            feeItemEntity.Price = price.Value;
            feeItemEntity.ExecDeptId = execDeptId;
            feeItemEntity.FinanceTypeCode = this._feeTypeEntity.Code;
            feeItemEntity.SearchCode = SpellHelper.GetSpells(name);
            feeItemEntity.WubiCode = SpellHelper.GetWuBis(name);
            feeItemEntity.OFlag = oFlag;
            feeItemEntity.IFlag = iFlag;
            feeItemEntity.SFlag = sFlag;
            feeItemEntity.MFlag = mFlag;
            feeItemEntity.VariableFlag = variableFlag;

            //添加收费项
            var result = this._feeItemService.Add(feeItemEntity);
            if (result.Success)
            {
                this._addCallBack?.Invoke(feeItemEntity);
                if (this.swbContinuityAdd.Value)
                {
                    this.ClearControlValue();
                    this.tbxCode.Focus();
                    return;
                }

                base.OnOK();
            }
            else
                HIS.Core.MsgBox.OK($"添加失败\r\n{result.Message}");
        }

        private void ClearControlValue()
        {
            this.tbxCode.Text = "";
            this.tbxName.Text = "";
            this.dpPrice.Text = "";
            this.tbxSpecification.Text = "";
            this.tbxMeasureUnit.Text = "";
            this.dpMeasure.Text = "";
            this.swbEnable.Value = true;
            this.swbMZEnable.Value = true;
            this.swbZYEnable.Value = true;
            this.swbSSEnable.Value = true;
            this.swbYJEnable.Value = true;
            this.swbvariableFlag.Value = false;
            this.fcbxDept.SelectedItem = null;
        }
    }
}
