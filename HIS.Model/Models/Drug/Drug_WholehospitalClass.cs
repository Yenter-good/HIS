﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dos.ORM;

namespace HIS.Model
{
    /// <summary>
    /// 实体类Drug_WholehospitalClass。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Drug_WholehospitalClass")]
    [Serializable]
    public partial class Drug_WholehospitalClass : Entity
    {
        #region Model
		private long _Id;
		private long _HosId;
		private long _CreatorUserId;
		private DateTime _CreationTime;
		private long _LastModifierUserId;
		private DateTime _LastModificationTime;
		private long? _DeleterUserId;
		private DateTime? _DeletionTime;
		private int _DataStatus;
		private int _No;
		private string _Code;
		private string _Name;
		private string _PropertyCodes;
		private long _PriceTypeId;
		private string _GMP;
		private long _PharmacologyTypeId;
		private int _PrescriptionType;
		private bool _SkinTestFlag;
		private bool _DangerFlage;
		private bool _BasicDrugFlag;
		private bool _NewFlag;
		private bool _TumorFlag;
		private long _DrugformId;
		private int _ToxicType;
		private int _AntibioticType;
		private string _UseWayCode;
		private long _DispensingTypeId;
		private string _StandardCode;
		private bool _OPCanSplit;
		private bool _IPCanSplit;
		private int _DrugType;
		private string _SearchCode;
		private string _WubiCode;

		/// <summary>
		/// 编号
		/// </summary>
		[Field("Id")]
		public long Id
		{
			get{ return _Id; }
			set
			{
				this.OnPropertyValueChange("Id");
				this._Id = value;
			}
		}
		/// <summary>
		/// 医疗机构ID
		/// </summary>
		[Field("HosId")]
		public long HosId
		{
			get{ return _HosId; }
			set
			{
				this.OnPropertyValueChange("HosId");
				this._HosId = value;
			}
		}
		/// <summary>
		/// 创建人编号 当前用户ID
		/// </summary>
		[Field("CreatorUserId")]
		public long CreatorUserId
		{
			get{ return _CreatorUserId; }
			set
			{
				this.OnPropertyValueChange("CreatorUserId");
				this._CreatorUserId = value;
			}
		}
		/// <summary>
		/// 创建时间 默认为当前时间
		/// </summary>
		[Field("CreationTime")]
		public DateTime CreationTime
		{
			get{ return _CreationTime; }
			set
			{
				this.OnPropertyValueChange("CreationTime");
				this._CreationTime = value;
			}
		}
		/// <summary>
		/// 最后修改人编号
		/// </summary>
		[Field("LastModifierUserId")]
		public long LastModifierUserId
		{
			get{ return _LastModifierUserId; }
			set
			{
				this.OnPropertyValueChange("LastModifierUserId");
				this._LastModifierUserId = value;
			}
		}
		/// <summary>
		/// 最后修改时间 默认为当前时间
		/// </summary>
		[Field("LastModificationTime")]
		public DateTime LastModificationTime
		{
			get{ return _LastModificationTime; }
			set
			{
				this.OnPropertyValueChange("LastModificationTime");
				this._LastModificationTime = value;
			}
		}
		/// <summary>
		/// 删除人编号
		/// </summary>
		[Field("DeleterUserId")]
		public long? DeleterUserId
		{
			get{ return _DeleterUserId; }
			set
			{
				this.OnPropertyValueChange("DeleterUserId");
				this._DeleterUserId = value;
			}
		}
		/// <summary>
		/// 删除时间
		/// </summary>
		[Field("DeletionTime")]
		public DateTime? DeletionTime
		{
			get{ return _DeletionTime; }
			set
			{
				this.OnPropertyValueChange("DeletionTime");
				this._DeletionTime = value;
			}
		}
		/// <summary>
		/// 数据状态 0失效 1启用
		/// </summary>
		[Field("DataStatus")]
		public int DataStatus
		{
			get{ return _DataStatus; }
			set
			{
				this.OnPropertyValueChange("DataStatus");
				this._DataStatus = value;
			}
		}
		/// <summary>
		/// 排序号
		/// </summary>
		[Field("No")]
		public int No
		{
			get{ return _No; }
			set
			{
				this.OnPropertyValueChange("No");
				this._No = value;
			}
		}
		/// <summary>
		/// 药典编码 药典编码
		/// </summary>
		[Field("Code")]
		public string Code
		{
			get{ return _Code; }
			set
			{
				this.OnPropertyValueChange("Code");
				this._Code = value;
			}
		}
		/// <summary>
		/// 药品名称
		/// </summary>
		[Field("Name")]
		public string Name
		{
			get{ return _Name; }
			set
			{
				this.OnPropertyValueChange("Name");
				this._Name = value;
			}
		}
		/// <summary>
		/// 药品属性 对应字典明细里面的编码 多个之间用分号隔开
		/// </summary>
		[Field("PropertyCodes")]
		public string PropertyCodes
		{
			get{ return _PropertyCodes; }
			set
			{
				this.OnPropertyValueChange("PropertyCodes");
				this._PropertyCodes = value;
			}
		}
		/// <summary>
		/// 定价类型ID
		/// </summary>
		[Field("PriceTypeId")]
		public long PriceTypeId
		{
			get{ return _PriceTypeId; }
			set
			{
				this.OnPropertyValueChange("PriceTypeId");
				this._PriceTypeId = value;
			}
		}
		/// <summary>
		/// GMP编号
		/// </summary>
		[Field("GMP")]
		public string GMP
		{
			get{ return _GMP; }
			set
			{
				this.OnPropertyValueChange("GMP");
				this._GMP = value;
			}
		}
		/// <summary>
		/// 药理分类
		/// </summary>
		[Field("PharmacologyTypeId")]
		public long PharmacologyTypeId
		{
			get{ return _PharmacologyTypeId; }
			set
			{
				this.OnPropertyValueChange("PharmacologyTypeId");
				this._PharmacologyTypeId = value;
			}
		}
		/// <summary>
		/// 处方药标志 0处方药 1非处方药(甲类) 2非处方药(乙类) 3非药品
		/// </summary>
		[Field("PrescriptionType")]
		public int PrescriptionType
		{
			get{ return _PrescriptionType; }
			set
			{
				this.OnPropertyValueChange("PrescriptionType");
				this._PrescriptionType = value;
			}
		}
		/// <summary>
		/// 是否皮试   0 否 1需皮试
		/// </summary>
		[Field("SkinTestFlag")]
		public bool SkinTestFlag
		{
			get{ return _SkinTestFlag; }
			set
			{
				this.OnPropertyValueChange("SkinTestFlag");
				this._SkinTestFlag = value;
			}
		}
		/// <summary>
		/// 高危标志 0 否 1 是
		/// </summary>
		[Field("DangerFlage")]
		public bool DangerFlage
		{
			get{ return _DangerFlage; }
			set
			{
				this.OnPropertyValueChange("DangerFlage");
				this._DangerFlage = value;
			}
		}
		/// <summary>
		/// 是否基药 0否 1是
		/// </summary>
		[Field("BasicDrugFlag")]
		public bool BasicDrugFlag
		{
			get{ return _BasicDrugFlag; }
			set
			{
				this.OnPropertyValueChange("BasicDrugFlag");
				this._BasicDrugFlag = value;
			}
		}
		/// <summary>
		/// 新药标志 0否 1是
		/// </summary>
		[Field("NewFlag")]
		public bool NewFlag
		{
			get{ return _NewFlag; }
			set
			{
				this.OnPropertyValueChange("NewFlag");
				this._NewFlag = value;
			}
		}
		/// <summary>
		/// 抗肿瘤标志 0 否 1 是
		/// </summary>
		[Field("TumorFlag")]
		public bool TumorFlag
		{
			get{ return _TumorFlag; }
			set
			{
				this.OnPropertyValueChange("TumorFlag");
				this._TumorFlag = value;
			}
		}
		/// <summary>
		/// 药品剂型ID
		/// </summary>
		[Field("DrugformId")]
		public long DrugformId
		{
			get{ return _DrugformId; }
			set
			{
				this.OnPropertyValueChange("DrugformId");
				this._DrugformId = value;
			}
		}
		/// <summary>
		/// 精神毒麻类型 0否 1普通 2 精一 3 精二 4 麻醉
		/// </summary>
		[Field("ToxicType")]
		public int ToxicType
		{
			get{ return _ToxicType; }
			set
			{
				this.OnPropertyValueChange("ToxicType");
				this._ToxicType = value;
			}
		}
		/// <summary>
		/// 抗生素级别 0非抗生素  1非限制 2 限制使用 3特殊使用
		/// </summary>
		[Field("AntibioticType")]
		public int AntibioticType
		{
			get{ return _AntibioticType; }
			set
			{
				this.OnPropertyValueChange("AntibioticType");
				this._AntibioticType = value;
			}
		}
		/// <summary>
		/// 用药途径编码 对应表Dic_Usage的编码
		/// </summary>
		[Field("UseWayCode")]
		public string UseWayCode
		{
			get{ return _UseWayCode; }
			set
			{
				this.OnPropertyValueChange("UseWayCode");
				this._UseWayCode = value;
			}
		}
		/// <summary>
		/// 发药方式 例如 汇总发药  摆药  毒麻发药等
		/// </summary>
		[Field("DispensingTypeId")]
		public long DispensingTypeId
		{
			get{ return _DispensingTypeId; }
			set
			{
				this.OnPropertyValueChange("DispensingTypeId");
				this._DispensingTypeId = value;
			}
		}
		/// <summary>
		/// 药品本位码
		/// </summary>
		[Field("StandardCode")]
		public string StandardCode
		{
			get{ return _StandardCode; }
			set
			{
				this.OnPropertyValueChange("StandardCode");
				this._StandardCode = value;
			}
		}
		/// <summary>
		/// 门诊可拆分
		/// </summary>
		[Field("OPCanSplit")]
		public bool OPCanSplit
		{
			get{ return _OPCanSplit; }
			set
			{
				this.OnPropertyValueChange("OPCanSplit");
				this._OPCanSplit = value;
			}
		}
		/// <summary>
		/// 住院可拆分
		/// </summary>
		[Field("IPCanSplit")]
		public bool IPCanSplit
		{
			get{ return _IPCanSplit; }
			set
			{
				this.OnPropertyValueChange("IPCanSplit");
				this._IPCanSplit = value;
			}
		}
		/// <summary>
		/// 药品类型 0西药 1中成药 2草药 3颗粒剂
		/// </summary>
		[Field("DrugType")]
		public int DrugType
		{
			get{ return _DrugType; }
			set
			{
				this.OnPropertyValueChange("DrugType");
				this._DrugType = value;
			}
		}
		/// <summary>
		/// 拼音码
		/// </summary>
		[Field("SearchCode")]
		public string SearchCode
		{
			get{ return _SearchCode; }
			set
			{
				this.OnPropertyValueChange("SearchCode");
				this._SearchCode = value;
			}
		}
		/// <summary>
		/// 五笔码
		/// </summary>
		[Field("WubiCode")]
		public string WubiCode
		{
			get{ return _WubiCode; }
			set
			{
				this.OnPropertyValueChange("WubiCode");
				this._WubiCode = value;
			}
		}
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.Id,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.Id,
				_.HosId,
				_.CreatorUserId,
				_.CreationTime,
				_.LastModifierUserId,
				_.LastModificationTime,
				_.DeleterUserId,
				_.DeletionTime,
				_.DataStatus,
				_.No,
				_.Code,
				_.Name,
				_.PropertyCodes,
				_.PriceTypeId,
				_.GMP,
				_.PharmacologyTypeId,
				_.PrescriptionType,
				_.SkinTestFlag,
				_.DangerFlage,
				_.BasicDrugFlag,
				_.NewFlag,
				_.TumorFlag,
				_.DrugformId,
				_.ToxicType,
				_.AntibioticType,
				_.UseWayCode,
				_.DispensingTypeId,
				_.StandardCode,
				_.OPCanSplit,
				_.IPCanSplit,
				_.DrugType,
				_.SearchCode,
				_.WubiCode,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._Id,
				this._HosId,
				this._CreatorUserId,
				this._CreationTime,
				this._LastModifierUserId,
				this._LastModificationTime,
				this._DeleterUserId,
				this._DeletionTime,
				this._DataStatus,
				this._No,
				this._Code,
				this._Name,
				this._PropertyCodes,
				this._PriceTypeId,
				this._GMP,
				this._PharmacologyTypeId,
				this._PrescriptionType,
				this._SkinTestFlag,
				this._DangerFlage,
				this._BasicDrugFlag,
				this._NewFlag,
				this._TumorFlag,
				this._DrugformId,
				this._ToxicType,
				this._AntibioticType,
				this._UseWayCode,
				this._DispensingTypeId,
				this._StandardCode,
				this._OPCanSplit,
				this._IPCanSplit,
				this._DrugType,
				this._SearchCode,
				this._WubiCode,
			};
        }
        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "Drug_WholehospitalClass");
            /// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Id = new Field("Id", "Drug_WholehospitalClass", "编号");
            /// <summary>
			/// 医疗机构ID
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Drug_WholehospitalClass", "医疗机构ID");
            /// <summary>
			/// 创建人编号 当前用户ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Drug_WholehospitalClass", "创建人编号 当前用户ID");
            /// <summary>
			/// 创建时间 默认为当前时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Drug_WholehospitalClass", "创建时间 默认为当前时间");
            /// <summary>
			/// 最后修改人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Drug_WholehospitalClass", "最后修改人编号");
            /// <summary>
			/// 最后修改时间 默认为当前时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Drug_WholehospitalClass", "最后修改时间 默认为当前时间");
            /// <summary>
			/// 删除人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Drug_WholehospitalClass", "删除人编号");
            /// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Drug_WholehospitalClass", "删除时间");
            /// <summary>
			/// 数据状态 0失效 1启用
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Drug_WholehospitalClass", "数据状态 0失效 1启用");
            /// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field No = new Field("No", "Drug_WholehospitalClass", "排序号");
            /// <summary>
			/// 药典编码 药典编码
			/// </summary>
			public readonly static Field Code = new Field("Code", "Drug_WholehospitalClass", "药典编码 药典编码");
            /// <summary>
			/// 药品名称
			/// </summary>
			public readonly static Field Name = new Field("Name", "Drug_WholehospitalClass", "药品名称");
            /// <summary>
			/// 药品属性 对应字典明细里面的编码 多个之间用分号隔开
			/// </summary>
			public readonly static Field PropertyCodes = new Field("PropertyCodes", "Drug_WholehospitalClass", "药品属性 对应字典明细里面的编码 多个之间用分号隔开");
            /// <summary>
			/// 定价类型ID
			/// </summary>
			public readonly static Field PriceTypeId = new Field("PriceTypeId", "Drug_WholehospitalClass", "定价类型ID");
            /// <summary>
			/// GMP编号
			/// </summary>
			public readonly static Field GMP = new Field("GMP", "Drug_WholehospitalClass", "GMP编号");
            /// <summary>
			/// 药理分类
			/// </summary>
			public readonly static Field PharmacologyTypeId = new Field("PharmacologyTypeId", "Drug_WholehospitalClass", "药理分类");
            /// <summary>
			/// 处方药标志 0处方药 1非处方药(甲类) 2非处方药(乙类) 3非药品
			/// </summary>
			public readonly static Field PrescriptionType = new Field("PrescriptionType", "Drug_WholehospitalClass", "处方药标志 0处方药 1非处方药(甲类) 2非处方药(乙类) 3非药品");
            /// <summary>
			/// 是否皮试   0 否 1需皮试
			/// </summary>
			public readonly static Field SkinTestFlag = new Field("SkinTestFlag", "Drug_WholehospitalClass", "是否皮试   0 否 1需皮试");
            /// <summary>
			/// 高危标志 0 否 1 是
			/// </summary>
			public readonly static Field DangerFlage = new Field("DangerFlage", "Drug_WholehospitalClass", "高危标志 0 否 1 是");
            /// <summary>
			/// 是否基药 0否 1是
			/// </summary>
			public readonly static Field BasicDrugFlag = new Field("BasicDrugFlag", "Drug_WholehospitalClass", "是否基药 0否 1是");
            /// <summary>
			/// 新药标志 0否 1是
			/// </summary>
			public readonly static Field NewFlag = new Field("NewFlag", "Drug_WholehospitalClass", "新药标志 0否 1是");
            /// <summary>
			/// 抗肿瘤标志 0 否 1 是
			/// </summary>
			public readonly static Field TumorFlag = new Field("TumorFlag", "Drug_WholehospitalClass", "抗肿瘤标志 0 否 1 是");
            /// <summary>
			/// 药品剂型ID
			/// </summary>
			public readonly static Field DrugformId = new Field("DrugformId", "Drug_WholehospitalClass", "药品剂型ID");
            /// <summary>
			/// 精神毒麻类型 0否 1普通 2 精一 3 精二 4 麻醉
			/// </summary>
			public readonly static Field ToxicType = new Field("ToxicType", "Drug_WholehospitalClass", "精神毒麻类型 0否 1普通 2 精一 3 精二 4 麻醉");
            /// <summary>
			/// 抗生素级别 0非抗生素  1非限制 2 限制使用 3特殊使用
			/// </summary>
			public readonly static Field AntibioticType = new Field("AntibioticType", "Drug_WholehospitalClass", "抗生素级别 0非抗生素  1非限制 2 限制使用 3特殊使用");
            /// <summary>
			/// 用药途径编码 对应表Dic_Usage的编码
			/// </summary>
			public readonly static Field UseWayCode = new Field("UseWayCode", "Drug_WholehospitalClass", "用药途径编码 对应表Dic_Usage的编码");
            /// <summary>
			/// 发药方式 例如 汇总发药  摆药  毒麻发药等
			/// </summary>
			public readonly static Field DispensingTypeId = new Field("DispensingTypeId", "Drug_WholehospitalClass", "发药方式 例如 汇总发药  摆药  毒麻发药等");
            /// <summary>
			/// 药品本位码
			/// </summary>
			public readonly static Field StandardCode = new Field("StandardCode", "Drug_WholehospitalClass", "药品本位码");
            /// <summary>
			/// 门诊可拆分
			/// </summary>
			public readonly static Field OPCanSplit = new Field("OPCanSplit", "Drug_WholehospitalClass", "门诊可拆分");
            /// <summary>
			/// 住院可拆分
			/// </summary>
			public readonly static Field IPCanSplit = new Field("IPCanSplit", "Drug_WholehospitalClass", "住院可拆分");
            /// <summary>
			/// 药品类型 0西药 1中成药 2草药 3颗粒剂
			/// </summary>
			public readonly static Field DrugType = new Field("DrugType", "Drug_WholehospitalClass", "药品类型 0西药 1中成药 2草药 3颗粒剂");
            /// <summary>
			/// 拼音码
			/// </summary>
			public readonly static Field SearchCode = new Field("SearchCode", "Drug_WholehospitalClass", "拼音码");
            /// <summary>
			/// 五笔码
			/// </summary>
			public readonly static Field WubiCode = new Field("WubiCode", "Drug_WholehospitalClass", "五笔码");
        }
        #endregion
	}
}