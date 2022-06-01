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
    /// 实体类View_OPDiseasesDetail。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("View_OPDiseasesDetail")]
    [Serializable]
    public partial class View_OPDiseasesDetail : Entity
    {
        #region Model
		private long _Id;
		private long _HosId;
		private long? _DiseaseId;
		private string _ClassCode;
		private string _SpecificationCode;
		private string _DrugName;
		private string _Specification;
		private string _TradeName;
		private string _Manufacturer;
		private string _PropertyCodes;
		private int? _PrescriptionType;
		private int? _SkinTestFlag;
		private int? _DangerFlage;
		private int? _NewFlag;
		private int? _TumorFlag;
		private long? _DrugformId;
		private string _DrugformCode;
		private string _DrugformValue;
		private int? _ToxicType;
		private int? _AntibioticType;
		private string _UseWayCode;
		private string _UseWayName;
		private string _StandardCode;
		private int? _DrugType;
		private int? _PackageNumber;
		private string _BigPackageUnit;
		private string _SmallPackageUnit;
		private float? _MinDose;
		private string _MinDoseUnit;
		private int? _ChargeType;
		private decimal? _PurchasePrice;
		private decimal? _SmallPackagePrice;
		private decimal? _BigPackagePrice;
		private int? _SmallPackageQuantity;
		private int? _BigPackageQuantity;
		private string _SearchCode;
		private string _WubiCode;

		/// <summary>
		/// 
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
		/// 
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
		/// 
		/// </summary>
		[Field("DiseaseId")]
		public long? DiseaseId
		{
			get{ return _DiseaseId; }
			set
			{
				this.OnPropertyValueChange("DiseaseId");
				this._DiseaseId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ClassCode")]
		public string ClassCode
		{
			get{ return _ClassCode; }
			set
			{
				this.OnPropertyValueChange("ClassCode");
				this._ClassCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("SpecificationCode")]
		public string SpecificationCode
		{
			get{ return _SpecificationCode; }
			set
			{
				this.OnPropertyValueChange("SpecificationCode");
				this._SpecificationCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("DrugName")]
		public string DrugName
		{
			get{ return _DrugName; }
			set
			{
				this.OnPropertyValueChange("DrugName");
				this._DrugName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Specification")]
		public string Specification
		{
			get{ return _Specification; }
			set
			{
				this.OnPropertyValueChange("Specification");
				this._Specification = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("TradeName")]
		public string TradeName
		{
			get{ return _TradeName; }
			set
			{
				this.OnPropertyValueChange("TradeName");
				this._TradeName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Manufacturer")]
		public string Manufacturer
		{
			get{ return _Manufacturer; }
			set
			{
				this.OnPropertyValueChange("Manufacturer");
				this._Manufacturer = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		[Field("PrescriptionType")]
		public int? PrescriptionType
		{
			get{ return _PrescriptionType; }
			set
			{
				this.OnPropertyValueChange("PrescriptionType");
				this._PrescriptionType = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("SkinTestFlag")]
		public int? SkinTestFlag
		{
			get{ return _SkinTestFlag; }
			set
			{
				this.OnPropertyValueChange("SkinTestFlag");
				this._SkinTestFlag = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("DangerFlage")]
		public int? DangerFlage
		{
			get{ return _DangerFlage; }
			set
			{
				this.OnPropertyValueChange("DangerFlage");
				this._DangerFlage = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("NewFlag")]
		public int? NewFlag
		{
			get{ return _NewFlag; }
			set
			{
				this.OnPropertyValueChange("NewFlag");
				this._NewFlag = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("TumorFlag")]
		public int? TumorFlag
		{
			get{ return _TumorFlag; }
			set
			{
				this.OnPropertyValueChange("TumorFlag");
				this._TumorFlag = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("DrugformId")]
		public long? DrugformId
		{
			get{ return _DrugformId; }
			set
			{
				this.OnPropertyValueChange("DrugformId");
				this._DrugformId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("DrugformCode")]
		public string DrugformCode
		{
			get{ return _DrugformCode; }
			set
			{
				this.OnPropertyValueChange("DrugformCode");
				this._DrugformCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("DrugformValue")]
		public string DrugformValue
		{
			get{ return _DrugformValue; }
			set
			{
				this.OnPropertyValueChange("DrugformValue");
				this._DrugformValue = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ToxicType")]
		public int? ToxicType
		{
			get{ return _ToxicType; }
			set
			{
				this.OnPropertyValueChange("ToxicType");
				this._ToxicType = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("AntibioticType")]
		public int? AntibioticType
		{
			get{ return _AntibioticType; }
			set
			{
				this.OnPropertyValueChange("AntibioticType");
				this._AntibioticType = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		[Field("UseWayName")]
		public string UseWayName
		{
			get{ return _UseWayName; }
			set
			{
				this.OnPropertyValueChange("UseWayName");
				this._UseWayName = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		[Field("DrugType")]
		public int? DrugType
		{
			get{ return _DrugType; }
			set
			{
				this.OnPropertyValueChange("DrugType");
				this._DrugType = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("PackageNumber")]
		public int? PackageNumber
		{
			get{ return _PackageNumber; }
			set
			{
				this.OnPropertyValueChange("PackageNumber");
				this._PackageNumber = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("BigPackageUnit")]
		public string BigPackageUnit
		{
			get{ return _BigPackageUnit; }
			set
			{
				this.OnPropertyValueChange("BigPackageUnit");
				this._BigPackageUnit = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("SmallPackageUnit")]
		public string SmallPackageUnit
		{
			get{ return _SmallPackageUnit; }
			set
			{
				this.OnPropertyValueChange("SmallPackageUnit");
				this._SmallPackageUnit = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("MinDose")]
		public float? MinDose
		{
			get{ return _MinDose; }
			set
			{
				this.OnPropertyValueChange("MinDose");
				this._MinDose = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("MinDoseUnit")]
		public string MinDoseUnit
		{
			get{ return _MinDoseUnit; }
			set
			{
				this.OnPropertyValueChange("MinDoseUnit");
				this._MinDoseUnit = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ChargeType")]
		public int? ChargeType
		{
			get{ return _ChargeType; }
			set
			{
				this.OnPropertyValueChange("ChargeType");
				this._ChargeType = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("PurchasePrice")]
		public decimal? PurchasePrice
		{
			get{ return _PurchasePrice; }
			set
			{
				this.OnPropertyValueChange("PurchasePrice");
				this._PurchasePrice = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("SmallPackagePrice")]
		public decimal? SmallPackagePrice
		{
			get{ return _SmallPackagePrice; }
			set
			{
				this.OnPropertyValueChange("SmallPackagePrice");
				this._SmallPackagePrice = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("BigPackagePrice")]
		public decimal? BigPackagePrice
		{
			get{ return _BigPackagePrice; }
			set
			{
				this.OnPropertyValueChange("BigPackagePrice");
				this._BigPackagePrice = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("SmallPackageQuantity")]
		public int? SmallPackageQuantity
		{
			get{ return _SmallPackageQuantity; }
			set
			{
				this.OnPropertyValueChange("SmallPackageQuantity");
				this._SmallPackageQuantity = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("BigPackageQuantity")]
		public int? BigPackageQuantity
		{
			get{ return _BigPackageQuantity; }
			set
			{
				this.OnPropertyValueChange("BigPackageQuantity");
				this._BigPackageQuantity = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
				_.DiseaseId,
				_.ClassCode,
				_.SpecificationCode,
				_.DrugName,
				_.Specification,
				_.TradeName,
				_.Manufacturer,
				_.PropertyCodes,
				_.PrescriptionType,
				_.SkinTestFlag,
				_.DangerFlage,
				_.NewFlag,
				_.TumorFlag,
				_.DrugformId,
				_.DrugformCode,
				_.DrugformValue,
				_.ToxicType,
				_.AntibioticType,
				_.UseWayCode,
				_.UseWayName,
				_.StandardCode,
				_.DrugType,
				_.PackageNumber,
				_.BigPackageUnit,
				_.SmallPackageUnit,
				_.MinDose,
				_.MinDoseUnit,
				_.ChargeType,
				_.PurchasePrice,
				_.SmallPackagePrice,
				_.BigPackagePrice,
				_.SmallPackageQuantity,
				_.BigPackageQuantity,
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
				this._DiseaseId,
				this._ClassCode,
				this._SpecificationCode,
				this._DrugName,
				this._Specification,
				this._TradeName,
				this._Manufacturer,
				this._PropertyCodes,
				this._PrescriptionType,
				this._SkinTestFlag,
				this._DangerFlage,
				this._NewFlag,
				this._TumorFlag,
				this._DrugformId,
				this._DrugformCode,
				this._DrugformValue,
				this._ToxicType,
				this._AntibioticType,
				this._UseWayCode,
				this._UseWayName,
				this._StandardCode,
				this._DrugType,
				this._PackageNumber,
				this._BigPackageUnit,
				this._SmallPackageUnit,
				this._MinDose,
				this._MinDoseUnit,
				this._ChargeType,
				this._PurchasePrice,
				this._SmallPackagePrice,
				this._BigPackagePrice,
				this._SmallPackageQuantity,
				this._BigPackageQuantity,
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
			public readonly static Field All = new Field("*", "View_OPDiseasesDetail");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DiseaseId = new Field("DiseaseId", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassCode = new Field("ClassCode", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SpecificationCode = new Field("SpecificationCode", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DrugName = new Field("DrugName", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Specification = new Field("Specification", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TradeName = new Field("TradeName", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Manufacturer = new Field("Manufacturer", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PropertyCodes = new Field("PropertyCodes", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PrescriptionType = new Field("PrescriptionType", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SkinTestFlag = new Field("SkinTestFlag", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DangerFlage = new Field("DangerFlage", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NewFlag = new Field("NewFlag", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TumorFlag = new Field("TumorFlag", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DrugformId = new Field("DrugformId", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DrugformCode = new Field("DrugformCode", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DrugformValue = new Field("DrugformValue", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ToxicType = new Field("ToxicType", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AntibioticType = new Field("AntibioticType", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UseWayCode = new Field("UseWayCode", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UseWayName = new Field("UseWayName", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field StandardCode = new Field("StandardCode", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DrugType = new Field("DrugType", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PackageNumber = new Field("PackageNumber", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BigPackageUnit = new Field("BigPackageUnit", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SmallPackageUnit = new Field("SmallPackageUnit", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MinDose = new Field("MinDose", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MinDoseUnit = new Field("MinDoseUnit", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ChargeType = new Field("ChargeType", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PurchasePrice = new Field("PurchasePrice", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SmallPackagePrice = new Field("SmallPackagePrice", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BigPackagePrice = new Field("BigPackagePrice", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SmallPackageQuantity = new Field("SmallPackageQuantity", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BigPackageQuantity = new Field("BigPackageQuantity", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SearchCode = new Field("SearchCode", "View_OPDiseasesDetail", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field WubiCode = new Field("WubiCode", "View_OPDiseasesDetail", "");
        }
        #endregion
	}
}