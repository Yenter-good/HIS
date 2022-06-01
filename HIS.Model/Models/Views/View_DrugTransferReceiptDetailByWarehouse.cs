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
    /// 实体类View_DrugTransferReceiptDetailByWarehouse。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("View_DrugTransferReceiptDetailByWarehouse")]
    [Serializable]
    public partial class View_DrugTransferReceiptDetailByWarehouse : Entity
    {
        #region Model
		private long _Id;
		private long _HosId;
		private long _ReceiptId;
		private string _ClassCode;
		private string _SpecificationCode;
		private string _DrugName;
		private string _Specification;
		private string _Manufacturer;
		private int _Quantity;
		private decimal _ReceiptPrice;
		private int? _Inventory;
		private decimal? _PurchasePrice;
		private decimal? _Price;
		private string _BigPackageUnit;
		private string _ApprovalNumber;
		private int _No;

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
		[Field("ReceiptId")]
		public long ReceiptId
		{
			get{ return _ReceiptId; }
			set
			{
				this.OnPropertyValueChange("ReceiptId");
				this._ReceiptId = value;
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
		[Field("Quantity")]
		public int Quantity
		{
			get{ return _Quantity; }
			set
			{
				this.OnPropertyValueChange("Quantity");
				this._Quantity = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ReceiptPrice")]
		public decimal ReceiptPrice
		{
			get{ return _ReceiptPrice; }
			set
			{
				this.OnPropertyValueChange("ReceiptPrice");
				this._ReceiptPrice = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Inventory")]
		public int? Inventory
		{
			get{ return _Inventory; }
			set
			{
				this.OnPropertyValueChange("Inventory");
				this._Inventory = value;
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
		[Field("Price")]
		public decimal? Price
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
		[Field("ApprovalNumber")]
		public string ApprovalNumber
		{
			get{ return _ApprovalNumber; }
			set
			{
				this.OnPropertyValueChange("ApprovalNumber");
				this._ApprovalNumber = value;
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
				_.ReceiptId,
				_.ClassCode,
				_.SpecificationCode,
				_.DrugName,
				_.Specification,
				_.Manufacturer,
				_.Quantity,
				_.ReceiptPrice,
				_.Inventory,
				_.PurchasePrice,
				_.Price,
				_.BigPackageUnit,
				_.ApprovalNumber,
				_.No,
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
				this._ReceiptId,
				this._ClassCode,
				this._SpecificationCode,
				this._DrugName,
				this._Specification,
				this._Manufacturer,
				this._Quantity,
				this._ReceiptPrice,
				this._Inventory,
				this._PurchasePrice,
				this._Price,
				this._BigPackageUnit,
				this._ApprovalNumber,
				this._No,
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
			public readonly static Field All = new Field("*", "View_DrugTransferReceiptDetailByWarehouse");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ReceiptId = new Field("ReceiptId", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassCode = new Field("ClassCode", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SpecificationCode = new Field("SpecificationCode", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DrugName = new Field("DrugName", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Specification = new Field("Specification", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Manufacturer = new Field("Manufacturer", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Quantity = new Field("Quantity", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ReceiptPrice = new Field("ReceiptPrice", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Inventory = new Field("Inventory", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PurchasePrice = new Field("PurchasePrice", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Price = new Field("Price", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BigPackageUnit = new Field("BigPackageUnit", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ApprovalNumber = new Field("ApprovalNumber", "View_DrugTransferReceiptDetailByWarehouse", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field No = new Field("No", "View_DrugTransferReceiptDetailByWarehouse", "");
        }
        #endregion
	}
}