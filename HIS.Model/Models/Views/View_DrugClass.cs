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
    /// 实体类View_DrugClass。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("View_DrugClass")]
    [Serializable]
    public partial class View_DrugClass : Entity
    {
        #region Model
		private long _Id;
		private long _HosId;
		private int _DataStatus;
		private int _No;
		private string _Code;
		private string _Name;
		private string _PropertyCodes;
		private long _PriceTypeId;
		private string _PriceTypeName;
		private string _GMP;
		private long _PharmacologyTypeId;
		private string _PharmacologyTypeName;
		private int _PrescriptionType;
		private bool _SkinTestFlag;
		private bool _DangerFlage;
		private bool _NewFlag;
		private bool _TumorFlag;
		private bool _BasicDrugFlag;
		private long _DrugformId;
		private string _DrugformName;
		private int _ToxicType;
		private int _AntibioticType;
		private string _UseWayCode;
		private string _UseWayName;
		private long _DispensingTypeId;
		private string _DispensingTypeName;
		private string _StandardCode;
		private bool _OPCanSplit;
		private bool _IPCanSplit;
		private int? _DrugType;
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
		/// 
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
		/// 
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
		/// 
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
		/// 
		/// </summary>
		[Field("PriceTypeName")]
		public string PriceTypeName
		{
			get{ return _PriceTypeName; }
			set
			{
				this.OnPropertyValueChange("PriceTypeName");
				this._PriceTypeName = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
		/// 
		/// </summary>
		[Field("PharmacologyTypeName")]
		public string PharmacologyTypeName
		{
			get{ return _PharmacologyTypeName; }
			set
			{
				this.OnPropertyValueChange("PharmacologyTypeName");
				this._PharmacologyTypeName = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
		/// 
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
		/// 
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
		/// 
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
		/// 
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
		/// 
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
		/// 
		/// </summary>
		[Field("DrugformName")]
		public string DrugformName
		{
			get{ return _DrugformName; }
			set
			{
				this.OnPropertyValueChange("DrugformName");
				this._DrugformName = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
		/// 
		/// </summary>
		[Field("DispensingTypeName")]
		public string DispensingTypeName
		{
			get{ return _DispensingTypeName; }
			set
			{
				this.OnPropertyValueChange("DispensingTypeName");
				this._DispensingTypeName = value;
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
		/// 
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
				_.DataStatus,
				_.No,
				_.Code,
				_.Name,
				_.PropertyCodes,
				_.PriceTypeId,
				_.PriceTypeName,
				_.GMP,
				_.PharmacologyTypeId,
				_.PharmacologyTypeName,
				_.PrescriptionType,
				_.SkinTestFlag,
				_.DangerFlage,
				_.NewFlag,
				_.TumorFlag,
				_.BasicDrugFlag,
				_.DrugformId,
				_.DrugformName,
				_.ToxicType,
				_.AntibioticType,
				_.UseWayCode,
				_.UseWayName,
				_.DispensingTypeId,
				_.DispensingTypeName,
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
				this._DataStatus,
				this._No,
				this._Code,
				this._Name,
				this._PropertyCodes,
				this._PriceTypeId,
				this._PriceTypeName,
				this._GMP,
				this._PharmacologyTypeId,
				this._PharmacologyTypeName,
				this._PrescriptionType,
				this._SkinTestFlag,
				this._DangerFlage,
				this._NewFlag,
				this._TumorFlag,
				this._BasicDrugFlag,
				this._DrugformId,
				this._DrugformName,
				this._ToxicType,
				this._AntibioticType,
				this._UseWayCode,
				this._UseWayName,
				this._DispensingTypeId,
				this._DispensingTypeName,
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
			public readonly static Field All = new Field("*", "View_DrugClass");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field No = new Field("No", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Code = new Field("Code", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Name = new Field("Name", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PropertyCodes = new Field("PropertyCodes", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PriceTypeId = new Field("PriceTypeId", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PriceTypeName = new Field("PriceTypeName", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GMP = new Field("GMP", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PharmacologyTypeId = new Field("PharmacologyTypeId", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PharmacologyTypeName = new Field("PharmacologyTypeName", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PrescriptionType = new Field("PrescriptionType", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SkinTestFlag = new Field("SkinTestFlag", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DangerFlage = new Field("DangerFlage", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NewFlag = new Field("NewFlag", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TumorFlag = new Field("TumorFlag", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BasicDrugFlag = new Field("BasicDrugFlag", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DrugformId = new Field("DrugformId", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DrugformName = new Field("DrugformName", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ToxicType = new Field("ToxicType", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AntibioticType = new Field("AntibioticType", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UseWayCode = new Field("UseWayCode", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UseWayName = new Field("UseWayName", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DispensingTypeId = new Field("DispensingTypeId", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DispensingTypeName = new Field("DispensingTypeName", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field StandardCode = new Field("StandardCode", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPCanSplit = new Field("OPCanSplit", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IPCanSplit = new Field("IPCanSplit", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DrugType = new Field("DrugType", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SearchCode = new Field("SearchCode", "View_DrugClass", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field WubiCode = new Field("WubiCode", "View_DrugClass", "");
        }
        #endregion
	}
}