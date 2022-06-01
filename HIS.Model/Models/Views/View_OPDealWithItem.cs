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
    /// 实体类View_OPDealWithItem。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("View_OPDealWithItem")]
    [Serializable]
    public partial class View_OPDealWithItem : Entity
    {
        #region Model
		private string _Code;
		private string _Name;
		private decimal _Price;
		private string _PackageUnit;
		private long? _ExecDeptId;
		private string _ExecDeptCode;
		private string _ExecDeptName;
		private string _Specification;
		private string _SearchCode;
		private string _WubiCode;
		private int _ItemType;

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
		[Field("Price")]
		public decimal Price
		{
			get{ return _Price; }
			set
			{
				this.OnPropertyValueChange("Price");
				this._Price = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("PackageUnit")]
		public string PackageUnit
		{
			get{ return _PackageUnit; }
			set
			{
				this.OnPropertyValueChange("PackageUnit");
				this._PackageUnit = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ExecDeptId")]
		public long? ExecDeptId
		{
			get{ return _ExecDeptId; }
			set
			{
				this.OnPropertyValueChange("ExecDeptId");
				this._ExecDeptId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ExecDeptCode")]
		public string ExecDeptCode
		{
			get{ return _ExecDeptCode; }
			set
			{
				this.OnPropertyValueChange("ExecDeptCode");
				this._ExecDeptCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ExecDeptName")]
		public string ExecDeptName
		{
			get{ return _ExecDeptName; }
			set
			{
				this.OnPropertyValueChange("ExecDeptName");
				this._ExecDeptName = value;
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
		/// <summary>
		/// 
		/// </summary>
		[Field("ItemType")]
		public int ItemType
		{
			get{ return _ItemType; }
			set
			{
				this.OnPropertyValueChange("ItemType");
				this._ItemType = value;
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
				_.Code,
				_.Name,
				_.Price,
				_.PackageUnit,
				_.ExecDeptId,
				_.ExecDeptCode,
				_.ExecDeptName,
				_.Specification,
				_.SearchCode,
				_.WubiCode,
				_.ItemType,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._Code,
				this._Name,
				this._Price,
				this._PackageUnit,
				this._ExecDeptId,
				this._ExecDeptCode,
				this._ExecDeptName,
				this._Specification,
				this._SearchCode,
				this._WubiCode,
				this._ItemType,
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
			public readonly static Field All = new Field("*", "View_OPDealWithItem");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Code = new Field("Code", "View_OPDealWithItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Name = new Field("Name", "View_OPDealWithItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Price = new Field("Price", "View_OPDealWithItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PackageUnit = new Field("PackageUnit", "View_OPDealWithItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ExecDeptId = new Field("ExecDeptId", "View_OPDealWithItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ExecDeptCode = new Field("ExecDeptCode", "View_OPDealWithItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ExecDeptName = new Field("ExecDeptName", "View_OPDealWithItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Specification = new Field("Specification", "View_OPDealWithItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SearchCode = new Field("SearchCode", "View_OPDealWithItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field WubiCode = new Field("WubiCode", "View_OPDealWithItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ItemType = new Field("ItemType", "View_OPDealWithItem", "");
        }
        #endregion
	}
}