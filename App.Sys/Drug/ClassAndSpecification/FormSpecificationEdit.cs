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
using HIS.Core;

namespace App_Sys.Drug
{
    public partial class FormSpecificationEdit : BaseDialogForm
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        public DataOperation Operation { get; set; }
        /// <summary>
        /// 修改的药品规格
        /// </summary>
        public WholehospitalSpecificationEntity SelectedGG { private get; set; }
        /// <summary>
        /// 当前选中的药品
        /// </summary>
        public WholehospitalClassEntity SelectedYP { private get; set; }
        /// <summary>
        /// 药品规格服务
        /// </summary>
        private readonly IWholehospitalSpecificationService _wholehospitalSpecificationService;
        /// <summary>
        /// 生产厂家服务
        /// </summary>
        private readonly IMerchantsService _merchantsService;
        /// <summary>
        /// 添加药品规格后事件
        /// </summary>
        public event EventHandler<WholehospitalSpecificationEntity> NewDrugSpecification;


        public FormSpecificationEdit(IWholehospitalSpecificationService wholehospitalSpecificationService,
            IMerchantsService merchantsService)
        {
            InitializeComponent();

            this._wholehospitalSpecificationService = wholehospitalSpecificationService;
            this._merchantsService = merchantsService;

        }

        private void FormSpecificationEdit_Shown(object sender, EventArgs e)
        {
            HIS.DSkinControl.QLoading.Show(this);
            this.InitUI();
            HIS.DSkinControl.QLoading.Close(this);
        }

        private void InitUI()
        {
            //加载计费方式
            Dictionary<int, string> dicDrugChargeType = typeof(DrugChargeType).EnumToDictEx<DrugChargeType, int>();
            BindingSource bs = new BindingSource();
            bs.DataSource = dicDrugChargeType;
            this.cbxChargeType.DisplayMember = "Value";
            this.cbxChargeType.ValueMember = "Key";
            this.cbxChargeType.DataSource = bs;
            this.cbxChargeType.DropDownStyle = ComboBoxStyle.DropDownList;

            //加载生产厂家
            var merchantsEntitys = this._merchantsService.GetAllManufacturerJane();
            this.fcbxManufacturer.DisplayMember = nameof(MerchantsEntity.Name);
            this.fcbxManufacturer.ValueMember = nameof(MerchantsEntity.Id);
            this.fcbxManufacturer.DataSource = merchantsEntitys;
            this.fcbxManufacturer.FilterFields = new string[] { nameof(MerchantsEntity.Name), nameof(MerchantsEntity.SearchCode) };

            //显示药品名称和编码
            this.tbxClassCode.Text = this.SelectedYP.Code;
            this.tbxClassName.Text = this.SelectedYP.Name;

            if (this.Operation == DataOperation.Modify)
            {
                this.labelX17.Visible = false;
                this.swbContinuousInput.Visible = false;
                this.tbxCode.ReadOnly = true;

                //控件赋值
                this.tbxCode.Text = this.SelectedGG.Code;
                this.tbxTradeName.Text = this.SelectedGG.TradeName;
                this.tbxSearchCode.Text = this.SelectedGG.SearchCode;
                this.tbxWubiCode.Text = this.SelectedGG.WubiCode;
                this.tbxApprovalNumber.Text = this.SelectedGG.ApprovalNumber;
                this.fcbxManufacturer.SelectedValue = this.SelectedGG.Manufacturer;
                this.tbxBarCode.Text = this.SelectedGG.BarCode;
                this.tbxSpecification.Text = this.SelectedGG.Specification;
                this.intPackageNumber.Value = this.SelectedGG.PackageNumber;
                this.tbxBigPackageUnit.Text = this.SelectedGG.BigPackageUnit;
                this.tbxSmallPackageUnit.Text = this.SelectedGG.SmallPackageUnit;
                this.dbMinDose.Value = this.SelectedGG.MinDose;
                this.cbxMinDoseUnit.Text = this.SelectedGG.MinDoseUnit;
                this.tbxDDDGG.Text = this.SelectedGG.MinDoseUnit;
                this.cbxChargeType.SelectedValue = (int)this.SelectedGG.DrugChargeType;
                this.intUpperLimit.Value = this.SelectedGG.UpperLimit;
                this.intLowerLimit.Value = (int)this.SelectedGG.LowerLimit;
                this.swbContinuousInput.Value = this.SelectedGG.DataStatus == DataStatus.Enable;

                this.tbxTradeName.Focus();
            }

            //注册事件
            this.tbxTradeName.TextChanged += (x, y) =>
            {
                string tradeName = this.tbxTradeName.Text.Trim();
                this.tbxSearchCode.Text = SpellHelper.GetSpells(tradeName);
                this.tbxWubiCode.Text = SpellHelper.GetWuBis(tradeName);

            };

            if (this.Operation == DataOperation.New)
            {
                //默认设置商品名和药品名称一致
                this.tbxTradeName.Text = this.tbxClassName.Text;
            }

            //设置回车键
            this.AddTabOrderContainer(this.tbxTradeName);
            this.AddTabOrderContainer(this.tbxSearchCode);
            this.AddTabOrderContainer(this.tbxWubiCode);
            this.AddTabOrderContainer(this.tbxCode);
            this.AddTabOrderContainer(this.tbxSpecification);
            this.AddTabOrderContainer(this.tbxApprovalNumber);
            this.AddTabOrderContainer(this.fcbxManufacturer);
            this.AddTabOrderContainer(this.tbxBarCode);
            this.AddTabOrderContainer(this.intPackageNumber);
            this.AddTabOrderContainer(this.tbxBigPackageUnit);
            this.AddTabOrderContainer(this.tbxSmallPackageUnit);
            this.AddTabOrderContainer(this.dbMinDose);
            this.AddTabOrderContainer(this.cbxMinDoseUnit);
            this.AddTabOrderContainer(this.dbDDD);
            this.AddTabOrderContainer(this.tbxDDDGG);
            this.AddTabOrderContainer(this.cbxChargeType);
            this.AddTabOrderContainer(this.intUpperLimit);
            this.AddTabOrderContainer(this.intLowerLimit);
            this.AddTabOrderContainer(this.swbContinuousInput);
            this.EnabledEnterNext = true;
        }


        protected override void OnOK()
        {
            string classCode = this.tbxClassCode.Text.Trim();
            if (!this.tbxClassCode.ReadOnly && classCode == "")
            {
                this.tbxClassCode.Focus();
                this.tbxClassCode.ShowTips("药品编码不能为空");
                return;
            }

            string className = this.tbxClassName.Text.Trim();
            if (!this.tbxClassName.ReadOnly && classCode == "")
            {
                this.tbxClassName.Focus();
                this.tbxClassName.ShowTips("药品名称不能为空");
                return;
            }

            string code = this.tbxCode.Text.Trim();
            if (!this.tbxCode.ReadOnly)
            {
                if (code == "")
                {
                    this.tbxCode.Focus();
                    this.tbxCode.ShowTips("规格编码不能为空");
                    return;
                }
                bool codeExists = this._wholehospitalSpecificationService.CodeExists(code);
                if (codeExists)
                {
                    this.tbxCode.Focus();
                    this.tbxCode.SelectAll();
                    this.tbxCode.ShowTips("规格编码已经存在");
                    return;
                }
            }

            string tradeName = this.tbxTradeName.Text.Trim();
            if (tradeName == "")
            {
                this.tbxTradeName.Focus();
                this.tbxTradeName.ShowTips("商品名称不能为空");
                return;
            }

            string searchCode = this.tbxSearchCode.Text.Trim();
            if (searchCode == "")
            {
                this.tbxSearchCode.Focus();
                this.tbxSearchCode.ShowTips("拼音码不能为空");
                return;
            }

            string wubiCode = this.tbxWubiCode.Text.Trim();
            if (wubiCode == "")
            {
                this.tbxWubiCode.Focus();
                this.tbxWubiCode.ShowTips("五笔码不能为空");
                return;
            }

            string approvalNumber = this.tbxApprovalNumber.Text.Trim();
            if (approvalNumber == "")
                approvalNumber = null;

            string manufacturer = this.fcbxManufacturer.Text.Trim();
            if (manufacturer == "")
                manufacturer = null;

            string barCode = this.tbxBarCode.Text.Trim();
            if (barCode == "")
                barCode = null;


            string specification = this.tbxSpecification.Text.Trim();
            if (specification == "")
            {
                this.tbxSpecification.Focus();
                this.tbxSpecification.ShowTips("药品规格不能为空");
                return;
            }

            int packageNumber = this.intPackageNumber.Value;
            if (packageNumber == 0)
            {
                this.intPackageNumber.Focus();
                this.intPackageNumber.ShowTips("包装数不能为空");
                return;
            }

            string bigPackageUnit = this.tbxBigPackageUnit.Text.Trim();
            if (bigPackageUnit == "")
            {
                this.tbxBigPackageUnit.Focus();
                this.tbxBigPackageUnit.ShowTips("大包装单位不能为空");
                return;
            }

            string smallPackageUnit = this.tbxSmallPackageUnit.Text.Trim();
            if (smallPackageUnit == "")
            {
                this.tbxSmallPackageUnit.Focus();
                this.tbxSmallPackageUnit.ShowTips("小包装单位不能为空");
                return;
            }

            float? minDose = this.dbMinDose.Text.AsFloat();
            if (!minDose.HasValue)
            {
                minDose = 1f;
                return;
            }

            string minDoseUnit = this.cbxMinDoseUnit.Text.Trim();
            if (minDoseUnit == "")
                minDoseUnit = null;

            float? dddValue = this.dbDDD.Text.AsFloat();
            if (!dddValue.HasValue)
            {
                dddValue = 0.0000f;
            }

            string dddSpecification = this.tbxDDDGG.Text.Trim();
            if (dddSpecification == "")
                dddSpecification = null;

            if (this.cbxChargeType.Text == "")
            {
                this.cbxChargeType.Focus();
                this.cbxChargeType.ShowTips("计费方式不能为空");
                return;
            }

            int upperLimit = this.intUpperLimit.Value;
            int lowerLimit = this.intLowerLimit.Value;

            DrugChargeType drugChargeType = (DrugChargeType)Convert.ToInt32(this.cbxChargeType.SelectedValue);

            if (this.Operation == DataOperation.New)
            {
                WholehospitalSpecificationEntity newEntity = new WholehospitalSpecificationEntity();
                newEntity.ClassCode = classCode;
                newEntity.Code = code;
                newEntity.DataStatus = DataStatus.Enable;
                newEntity.Specification = specification;
                newEntity.TradeName = tradeName;
                newEntity.SearchCode = searchCode;
                newEntity.WubiCode = wubiCode;
                newEntity.PackageNumber = packageNumber;
                newEntity.BigPackageUnit = bigPackageUnit;
                newEntity.SmallPackageUnit = smallPackageUnit;
                newEntity.MinDose = minDose.Value;
                newEntity.MinDoseUnit = minDoseUnit;
                newEntity.DDD = dddValue.Value;
                newEntity.DDDSpecification = dddSpecification;
                newEntity.BarCode = barCode;
                newEntity.DrugChargeType = drugChargeType;
                newEntity.Manufacturer = manufacturer;
                newEntity.ApprovalNumber = approvalNumber;
                newEntity.UpperLimit = upperLimit;
                newEntity.LowerLimit = lowerLimit;
                newEntity.No = this._wholehospitalSpecificationService.GetNo(classCode);

                var result = this._wholehospitalSpecificationService.Add(newEntity);
                if (result.Success)
                {
                    AlertBox.Info("添加成功");
                    this.NewDrugSpecification?.Invoke(this, newEntity);
                    if (this.swbContinuousInput.Value)
                    {
                        this.ClearControlsValue();
                        this.tbxTradeName.Focus();
                    }
                    else
                        base.OnOK();
                }
                else
                    MsgBox.OK($"添加失败\r\n{result.Message}");
            }
            else
            {
                this.SelectedGG.Specification = specification;
                this.SelectedGG.TradeName = tradeName;
                this.SelectedGG.PackageNumber = packageNumber;
                this.SelectedGG.BigPackageUnit = bigPackageUnit;
                this.SelectedGG.SmallPackageUnit = smallPackageUnit;
                this.SelectedGG.MinDose = minDose.Value;
                this.SelectedGG.MinDoseUnit = minDoseUnit;
                this.SelectedGG.DDD = dddValue.Value;
                this.SelectedGG.DDDSpecification = dddSpecification;
                this.SelectedGG.BarCode = barCode;
                this.SelectedGG.DrugChargeType = drugChargeType;
                this.SelectedGG.Manufacturer = manufacturer;
                this.SelectedGG.ApprovalNumber = approvalNumber;
                this.SelectedGG.SearchCode = searchCode;
                this.SelectedGG.WubiCode = wubiCode;
                this.SelectedGG.UpperLimit = upperLimit;
                this.SelectedGG.LowerLimit = lowerLimit;

                var result = this._wholehospitalSpecificationService.Update(this.SelectedGG);
                if (result.Success)
                {
                    AlertBox.Info("修改成功");
                    base.OnOK();
                }
                else
                    MsgBox.OK($"修改失败\r\n{result.Message}");
            }

        }

        private void ClearControlsValue()
        {
            this.tbxCode.Text = "";
            this.tbxTradeName.Text = "";
            this.tbxApprovalNumber.Text = "";
            this.fcbxManufacturer.SelectedValue = null;
            this.tbxBarCode.Text = "";
            this.tbxSpecification.Text = "";
            this.intPackageNumber.Value = 0;
            this.intPackageNumber.Value = 0;
            this.tbxBigPackageUnit.Text = "";
            this.cbxMinDoseUnit.Text = "";
            this.dbMinDose.Value = 1;
            this.tbxDDDGG.Text = "";
            this.cbxChargeType.SelectedIndex = -1;
        }
    }
}
