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

namespace App_Sys.Drug
{
    public partial class FormDrugClassEdit : BaseDialogForm
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        public DataOperation Operation { get; set; }
        /// <summary>
        /// 当前选中的药品类型
        /// </summary>
        public int SelectedDrugType { private get; set; }
        /// <summary>
        /// 字典服务
        /// </summary>
        private readonly ISysDictQueryService _sysDictQueryService;
        /// <summary>
        /// 用药途径服务
        /// </summary>
        private readonly IUsageService _usageService;
        /// <summary>
        /// 药品品种服务
        /// </summary>
        private readonly IWholehospitalClassService _wholehospitalClassService;
        /// <summary>
        /// 选中需要修改的药品品种
        /// </summary>
        public WholehospitalClassEntity ModifyWholehospitalClassEntity { private get; set; }
        /// <summary>
        /// 新增药品品种事件
        /// </summary>
        public event EventHandler<WholehospitalClassEntity> NewWholehospitalClass;

        public FormDrugClassEdit(ISysDictQueryService sysDictQueryService, IUsageService usageService, IWholehospitalClassService wholehospitalClassService)
        {
            InitializeComponent();
            this._usageService = usageService;
            this._sysDictQueryService = sysDictQueryService;
            this._wholehospitalClassService = wholehospitalClassService;
        }

        private void FormDrugClassEdit_Shown(object sender, EventArgs e)
        {
            HIS.DSkinControl.QLoading.Show(this);
            this.InitUI();
            HIS.DSkinControl.QLoading.Close(this);
        }

        private void InitUI()
        {

            //加载药品类别
            Dictionary<int, string> dicDrugType = typeof(DrugType).EnumToDictEx<DrugType, int>();
            BindingSource bs = new BindingSource();
            bs.DataSource = dicDrugType;
            this.cbxyplx.DisplayMember = "Value";
            this.cbxyplx.ValueMember = "Key";
            this.cbxyplx.DataSource = bs;
            this.cbxyplx.DropDownStyle = ComboBoxStyle.DropDownList;
            if (this.SelectedDrugType > 0)
                this.cbxyplx.SelectedValue = this.SelectedDrugType;

            //加载定价类型
            var priceTypes = this._sysDictQueryService.GetPriceType();
            if (priceTypes == null)
                priceTypes = new List<LongItem>();
            priceTypes.Insert(0, new LongItem());
            this.cbxdjlx.DisplayMember = nameof(LongItem.Value);
            this.cbxdjlx.ValueMember = nameof(LongItem.Key);
            this.cbxdjlx.DataSource = priceTypes;
            this.cbxdjlx.DropDownStyle = ComboBoxStyle.DropDownList;

            //加载药品剂型
            var drugfroms = this._sysDictQueryService.GetDrugform();
            if (drugfroms == null)
                drugfroms = new List<LongItem>();
            foreach (var item in drugfroms)
                item.Code = SpellHelper.GetSpells(item.Value);
            this.fcbxypjx.DisplayMember = nameof(LongItem.Value);
            this.fcbxypjx.ValueMember = nameof(LongItem.Key);
            this.fcbxypjx.DataSource = drugfroms;
            this.fcbxypjx.FilterFields = new string[] { nameof(LongItem.Value), nameof(LongItem.Code) };

            //加载药理分类
            var ylTypes = this._sysDictQueryService.GetPharmacologyType();
            if (ylTypes == null)
                ylTypes = new List<LongItem>();
            foreach (var item in ylTypes)
                item.Code = SpellHelper.GetSpells(item.Value);
            this.fcbxylfl.DisplayMember = nameof(LongItem.Value);
            this.fcbxylfl.ValueMember = nameof(LongItem.Key);
            this.fcbxylfl.DataSource = ylTypes;
            this.fcbxylfl.FilterFields = new string[] { nameof(LongItem.Value), nameof(LongItem.Code) };

            //加载处方药标志
            Dictionary<int, string> dicCfy = typeof(PrescriptionDrugType).EnumToDictEx<PrescriptionDrugType, int>();
            BindingSource cfyBs = new BindingSource();
            cfyBs.DataSource = dicCfy;
            this.cbxcfybz.DisplayMember = "Value";
            this.cbxcfybz.ValueMember = "Key";
            this.cbxcfybz.DataSource = cfyBs;
            this.cbxcfybz.DropDownStyle = ComboBoxStyle.DropDownList;

            //加载精神毒麻类型
            Dictionary<int, string> dicJsdm = typeof(DrugToxicType).EnumToDictEx<DrugToxicType, int>();
            BindingSource jsdmBs = new BindingSource();
            jsdmBs.DataSource = dicJsdm;
            this.cbxjsdmlx.DisplayMember = "Value";
            this.cbxjsdmlx.ValueMember = "Key";
            this.cbxjsdmlx.DataSource = jsdmBs;
            this.cbxjsdmlx.DropDownStyle = ComboBoxStyle.DropDownList;

            //加载抗生素级别
            Dictionary<int, string> dicKssjb = typeof(DrugAntibioticType).EnumToDictEx<DrugAntibioticType, int>();
            BindingSource kssjbBs = new BindingSource();
            kssjbBs.DataSource = dicKssjb;
            this.cbxkssjb.DisplayMember = "Value";
            this.cbxkssjb.ValueMember = "Key";
            this.cbxkssjb.DataSource = kssjbBs;
            this.cbxkssjb.DropDownStyle = ComboBoxStyle.DropDownList;

            //加载用药途径
            var yytjs = this._usageService.GetAll();
            if (yytjs == null)
                yytjs = new List<UsageEntity>();
            this.fcbxyytj.DisplayMember = nameof(UsageEntity.Name);
            this.fcbxyytj.ValueMember = nameof(UsageEntity.Code);
            this.fcbxyytj.DataSource = yytjs;
            this.fcbxyytj.FilterFields = new string[] { nameof(UsageEntity.Name), nameof(UsageEntity.Code), nameof(UsageEntity.SearchCode), nameof(UsageEntity.WubiCode) };

            //加载发药方式
            var fyfss = this._sysDictQueryService.GetDispensingType();
            this.cbxfyfs.DisplayMember = nameof(LongItem.Value);
            this.cbxfyfs.ValueMember = nameof(LongItem.Key);
            this.cbxfyfs.DataSource = fyfss;
            this.cbxfyfs.DropDownStyle = ComboBoxStyle.DropDownList;

            if (this.Operation == DataOperation.Modify)
            {
                this.labelX23.Visible = false;
                this.swblxlr.Visible = false;
                this.tbxypbm.ReadOnly = true;

                //赋值操作
                this.cbxyplx.SelectedValue = (int)this.ModifyWholehospitalClassEntity.DrugType;
                this.tbxypbm.Text = this.ModifyWholehospitalClassEntity.Code;
                this.tbxypmc.Text = this.ModifyWholehospitalClassEntity.Name;
                this.tbxpym.Text = this.ModifyWholehospitalClassEntity.SearchCode;
                this.tbxwbm.Text = this.ModifyWholehospitalClassEntity.WubiCode;
                //药品属性暂时不赋值
                this.cbxdjlx.SelectedValue = this.ModifyWholehospitalClassEntity.PriceType.Key;
                this.fcbxypjx.SelectedValue = this.ModifyWholehospitalClassEntity.Drugfrom.Key;
                this.fcbxylfl.SelectedValue = this.ModifyWholehospitalClassEntity.PharmacologyType.Key;
                this.tbxgmp.Text = this.ModifyWholehospitalClassEntity.GMP;
                this.cbxcfybz.SelectedValue = (int)this.ModifyWholehospitalClassEntity.PrescriptionType;
                this.cbxjsdmlx.SelectedValue = (int)this.ModifyWholehospitalClassEntity.ToxicType;
                this.cbxkssjb.SelectedValue = (int)this.ModifyWholehospitalClassEntity.AntibioticType;
                if (this.ModifyWholehospitalClassEntity.UseWay != null)
                    this.fcbxyytj.SelectedValue = this.ModifyWholehospitalClassEntity.UseWay.Code;
                this.cbxfyfs.SelectedValue = this.ModifyWholehospitalClassEntity.DispensingType.Key;
                this.tbxypbwm.Text = this.ModifyWholehospitalClassEntity.StandardCode;
                this.swbps.Value = this.ModifyWholehospitalClassEntity.SkinTestFlag;
                this.swbjy.Value = this.ModifyWholehospitalClassEntity.BasicDrugFlag;
                this.swbxy.Value = this.ModifyWholehospitalClassEntity.NewFlag;
                this.swbkzl.Value = this.ModifyWholehospitalClassEntity.TumorFlag;
                this.swbgw.Value = this.ModifyWholehospitalClassEntity.DangerFlage;
                this.swbenable.Value = this.ModifyWholehospitalClassEntity.DataStatus == DataStatus.Enable;
                this.swbmzcfbs.Value = this.ModifyWholehospitalClassEntity.OPCanSplit;
                this.swbzycfbs.Value = this.ModifyWholehospitalClassEntity.IPCanSplit;
            }

            //注册事件
            this.tbxypmc.TextChanged += (x, y) =>
            {
                string ypmc = this.tbxypmc.Text.Trim();
                this.tbxpym.Text = SpellHelper.GetSpells(ypmc);
                this.tbxwbm.Text = SpellHelper.GetWuBis(ypmc);
            };

            //设置回车快捷键
            this.AddTabOrderContainer(this.cbxyplx);
            this.AddTabOrderContainer(this.tbxypbm);
            this.AddTabOrderContainer(this.tbxypmc);
            this.AddTabOrderContainer(this.tbxpym);
            this.AddTabOrderContainer(this.tbxwbm);
            this.AddTabOrderContainer(this.tbxypsx);
            this.AddTabOrderContainer(this.cbxdjlx);
            this.AddTabOrderContainer(this.fcbxypjx);
            this.AddTabOrderContainer(this.fcbxylfl);
            this.AddTabOrderContainer(this.tbxgmp);
            this.AddTabOrderContainer(this.cbxcfybz);
            this.AddTabOrderContainer(this.cbxjsdmlx);
            this.AddTabOrderContainer(this.cbxkssjb);
            this.AddTabOrderContainer(this.fcbxyytj);
            this.AddTabOrderContainer(this.cbxfyfs);
            this.AddTabOrderContainer(this.tbxypbwm);
            this.AddTabOrderContainer(this.swbps);
            this.AddTabOrderContainer(this.swbjy);
            this.AddTabOrderContainer(this.swbxy);
            this.AddTabOrderContainer(this.swbkzl);
            this.AddTabOrderContainer(this.swbgw);
            this.AddTabOrderContainer(this.swbenable);
            this.AddTabOrderContainer(this.swbmzcfbs);
            this.AddTabOrderContainer(this.swbzycfbs);
            this.AddTabOrderContainer(this.swblxlr);
            this.EnabledEnterNext = true;

        }

        protected override void OnOK()
        {
            if (!this.Valid()) return;
            //数据状态
            DataStatus dataStatus = this.swbenable.Value == true ? DataStatus.Enable : DataStatus.Disable;
            //编码
            string code = this.tbxypbm.Text.Trim();
            //名称
            string name = this.tbxypmc.Text.Trim();
            //药品属性暂时不设置值

            //定价类型
            LongItem priceType = this.cbxdjlx.SelectedItem as LongItem;
            //GMP编号
            string gmp = null;
            if (this.tbxgmp.Text.Trim() != "")
                gmp = this.tbxgmp.Text.Trim();
            //药理分类
            LongItem pharmacologyType = new LongItem();
            if (this.fcbxylfl.SelectedItem != null)
                pharmacologyType = this.fcbxylfl.SelectedItem as LongItem;
            //处方药类型
            PrescriptionDrugType prescriptionType = (PrescriptionDrugType)Convert.ToInt32(this.cbxcfybz.SelectedValue);
            //是否皮试
            bool skinTestFlag = this.swbps.Value;
            //是否高危
            bool dangerFlage = this.swbgw.Value;
            //是否基药
            bool basicDrugFlag = this.swbjy.Value;
            //是否新药
            bool newFlag = this.swbxy.Value;
            //抗肿瘤标志
            bool tumorFlag = this.swbkzl.Value;
            //剂型
            LongItem drugfrom = new LongItem();
            if (this.fcbxypjx.SelectedItem != null)
                drugfrom = this.fcbxypjx.SelectedItem as LongItem;
            //精神毒麻类型
            DrugToxicType toxicType = (DrugToxicType)Convert.ToInt32(this.cbxjsdmlx.SelectedValue);
            //抗生素级别
            DrugAntibioticType antibioticType = (DrugAntibioticType)Convert.ToInt32(this.cbxkssjb.SelectedValue);
            //用药途径
            UsageEntity usageEntity = null;
            if (this.fcbxyytj.SelectedItem != null)
                usageEntity = this.fcbxyytj.SelectedItem as UsageEntity;
            //发药方式
            LongItem dispensingType = this.cbxfyfs.SelectedItem as LongItem;
            //药品本位码
            string standardCode = null;
            if (this.tbxypbwm.Text.Trim() != "")
                standardCode = this.tbxypbwm.Text.Trim();
            //门诊可拆分
            bool OPCanSplit = this.swbmzcfbs.Value;
            //住院可拆分
            bool IPCanSplit = this.swbzycfbs.Value;
            //药品类型
            DrugType drugType = (DrugType)Convert.ToInt32(this.cbxyplx.SelectedValue);
            //拼音码
            string searchCode = null;
            if (this.tbxpym.Text.Trim() != "")
                searchCode = this.tbxpym.Text.Trim();
            //五笔码
            string wbm = null;
            if (this.tbxwbm.Text.Trim() != "")
                wbm = this.tbxwbm.Text.Trim();

            if (this.Operation == DataOperation.New)
            {
                WholehospitalClassEntity entity = new WholehospitalClassEntity();
                //数据状态
                entity.DataStatus = dataStatus;
                //排序
                entity.No = this._wholehospitalClassService.GetNo(this.SelectedDrugType);
                //编码
                entity.Code = code;
                //名称
                entity.Name = name;
                //药品属性暂时不设置值

                //定价类型
                entity.PriceType = priceType;
                //GMP编号
                entity.GMP = gmp;
                //药理分类
                entity.PharmacologyType = pharmacologyType;
                //处方药类型
                entity.PrescriptionType = prescriptionType;
                //是否皮试
                entity.SkinTestFlag = skinTestFlag;
                //是否高危
                entity.DangerFlage = dangerFlage;
                //是否基药
                entity.BasicDrugFlag = basicDrugFlag;
                //是否新药
                entity.NewFlag = newFlag;
                //抗肿瘤标志
                entity.TumorFlag = tumorFlag;
                //剂型
                entity.Drugfrom = drugfrom;
                //精神毒麻类型
                entity.ToxicType = toxicType;
                //抗生素级别
                entity.AntibioticType = antibioticType;
                //用药途径
                entity.UseWay = usageEntity;
                //发药方式
                entity.DispensingType = dispensingType;
                //药品本位码
                entity.StandardCode = standardCode;
                //门诊可拆分
                entity.OPCanSplit = OPCanSplit;
                //住院可拆分
                entity.IPCanSplit = IPCanSplit;
                //药品类型
                entity.DrugType = drugType;
                //拼音码
                entity.SearchCode = searchCode;
                //五笔码
                entity.WubiCode = wbm;

                var result = this._wholehospitalClassService.Add(entity);
                if (result.Success)
                {
                    HIS.Core.AlertBox.Info("添加成功");
                    this.NewWholehospitalClass?.Invoke(this, entity);
                    if (this.swblxlr.Value)
                    {
                        this.ClearControlValue();
                        this.cbxyplx.Focus();
                        return;
                    }
                    else
                        base.OnOK();

                }
                else
                    HIS.Core.MsgBox.OK($"添加失败\r\n{result.Message}");
            }
            else
            {
                //数据状态
                this.ModifyWholehospitalClassEntity.DataStatus = dataStatus;
                //排序
                if (this.ModifyWholehospitalClassEntity.DrugType != drugType)
                    this.ModifyWholehospitalClassEntity.No = this._wholehospitalClassService.GetNo((int)drugType);
                //名称
                this.ModifyWholehospitalClassEntity.Name = name;
                //药品属性暂时不设置值

                //定价类型
                this.ModifyWholehospitalClassEntity.PriceType = priceType;
                //GMP编号
                this.ModifyWholehospitalClassEntity.GMP = gmp;
                //药理分类
                this.ModifyWholehospitalClassEntity.PharmacologyType = pharmacologyType;
                //处方药类型
                this.ModifyWholehospitalClassEntity.PrescriptionType = prescriptionType;
                //是否皮试
                this.ModifyWholehospitalClassEntity.SkinTestFlag = skinTestFlag;
                //是否高危
                this.ModifyWholehospitalClassEntity.DangerFlage = dangerFlage;
                //是否基药
                this.ModifyWholehospitalClassEntity.BasicDrugFlag = basicDrugFlag;
                //是否新药
                this.ModifyWholehospitalClassEntity.NewFlag = newFlag;
                //抗肿瘤标志
                this.ModifyWholehospitalClassEntity.TumorFlag = tumorFlag;
                //剂型
                this.ModifyWholehospitalClassEntity.Drugfrom = drugfrom;
                //精神毒麻类型
                this.ModifyWholehospitalClassEntity.ToxicType = toxicType;
                //抗生素级别
                this.ModifyWholehospitalClassEntity.AntibioticType = antibioticType;
                //用药途径
                this.ModifyWholehospitalClassEntity.UseWay = usageEntity;
                //发药方式
                this.ModifyWholehospitalClassEntity.DispensingType = dispensingType;
                //药品本位码
                this.ModifyWholehospitalClassEntity.StandardCode = standardCode;
                //门诊可拆分
                this.ModifyWholehospitalClassEntity.OPCanSplit = OPCanSplit;
                //住院可拆分
                this.ModifyWholehospitalClassEntity.IPCanSplit = IPCanSplit;
                //药品类型
                this.ModifyWholehospitalClassEntity.DrugType = drugType;
                //拼音码
                this.ModifyWholehospitalClassEntity.SearchCode = searchCode;
                //五笔码
                this.ModifyWholehospitalClassEntity.WubiCode = wbm;

                var result = this._wholehospitalClassService.Update(this.ModifyWholehospitalClassEntity);
                if (result.Success)
                {
                    HIS.Core.AlertBox.Info("修改成功");
                    base.OnOK();
                }
                else
                    HIS.Core.MsgBox.OK($"修改失败\r\n{result.Message}");
            }

        }

        private void ClearControlValue()
        {
            this.tbxypbm.Text = "";
            this.tbxypmc.Text = "";
            this.tbxypsx.Text = "";
            this.tbxypbwm.Text = "";
            this.swbps.Value = false;
            this.swbjy.Value = false;
            this.swbxy.Value = false;
            this.swbkzl.Value = false;
            this.swbgw.Value = false;
            this.swbenable.Value = true;
            this.swbmzcfbs.Value = true;
            this.swbzycfbs.Value = true;
        }

        private bool Valid()
        {
            if (!this.tbxypbm.ReadOnly)
            {
                string ypbm = this.tbxypbm.Text.Trim();
                if (ypbm == "")
                {
                    this.tbxypbm.Focus();
                    this.tbxypbm.ShowTips("药品编码不能为空");
                    return false;
                }

                bool ypbmExists = this._wholehospitalClassService.CodeExists(ypbm);
                if (ypbmExists)
                {
                    this.tbxypbm.Focus();
                    this.tbxypbm.ShowTips("药品编码已经存在");
                    return false;
                }
            }

            string ypmc = this.tbxypmc.Text.Trim();
            if (ypmc == "")
            {
                this.tbxypmc.Focus();
                this.tbxypmc.ShowTips("药品名称不能为空");
                return false;
            }

            if (this.cbxfyfs.Text == "")
            {
                this.cbxfyfs.Focus();
                this.cbxfyfs.ShowTips("请选择发药方式");
                return false;
            }

            return true;

        }
    }
}
