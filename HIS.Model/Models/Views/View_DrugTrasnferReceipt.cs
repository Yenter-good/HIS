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
    /// 实体类View_DrugTrasnferReceipt。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("View_DrugTrasnferReceipt")]
    [Serializable]
    public partial class View_DrugTrasnferReceipt : Entity
    {
        #region Model
		private long _Id;
		private string _ReceiptCode;
		private DateTime _CreationTime;
		private long _CreatorUserId;
		private string _CreatorUserName;
		private string _CreatorUserCode;
		private long? _AuditUserId;
		private string _AuditUserName;
		private string _AuditUserCode;
		private DateTime? _AuditTime;
		private bool _AuditStatus;
		private decimal _TotalPrice;
		private long _ApplyDeptId;
		private string _ApplyDeptName;
		private string _ApplyDeptCode;
		private long _AcceptDeptId;
		private string _AcceptDeptName;
		private string _AcceptDeptCode;
		private long _HosId;

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
		[Field("ReceiptCode")]
		public string ReceiptCode
		{
			get{ return _ReceiptCode; }
			set
			{
				this.OnPropertyValueChange("ReceiptCode");
				this._ReceiptCode = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
		/// 
		/// </summary>
		[Field("CreatorUserName")]
		public string CreatorUserName
		{
			get{ return _CreatorUserName; }
			set
			{
				this.OnPropertyValueChange("CreatorUserName");
				this._CreatorUserName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CreatorUserCode")]
		public string CreatorUserCode
		{
			get{ return _CreatorUserCode; }
			set
			{
				this.OnPropertyValueChange("CreatorUserCode");
				this._CreatorUserCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("AuditUserId")]
		public long? AuditUserId
		{
			get{ return _AuditUserId; }
			set
			{
				this.OnPropertyValueChange("AuditUserId");
				this._AuditUserId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("AuditUserName")]
		public string AuditUserName
		{
			get{ return _AuditUserName; }
			set
			{
				this.OnPropertyValueChange("AuditUserName");
				this._AuditUserName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("AuditUserCode")]
		public string AuditUserCode
		{
			get{ return _AuditUserCode; }
			set
			{
				this.OnPropertyValueChange("AuditUserCode");
				this._AuditUserCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("AuditTime")]
		public DateTime? AuditTime
		{
			get{ return _AuditTime; }
			set
			{
				this.OnPropertyValueChange("AuditTime");
				this._AuditTime = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("AuditStatus")]
		public bool AuditStatus
		{
			get{ return _AuditStatus; }
			set
			{
				this.OnPropertyValueChange("AuditStatus");
				this._AuditStatus = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("TotalPrice")]
		public decimal TotalPrice
		{
			get{ return _TotalPrice; }
			set
			{
				this.OnPropertyValueChange("TotalPrice");
				this._TotalPrice = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ApplyDeptId")]
		public long ApplyDeptId
		{
			get{ return _ApplyDeptId; }
			set
			{
				this.OnPropertyValueChange("ApplyDeptId");
				this._ApplyDeptId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ApplyDeptName")]
		public string ApplyDeptName
		{
			get{ return _ApplyDeptName; }
			set
			{
				this.OnPropertyValueChange("ApplyDeptName");
				this._ApplyDeptName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ApplyDeptCode")]
		public string ApplyDeptCode
		{
			get{ return _ApplyDeptCode; }
			set
			{
				this.OnPropertyValueChange("ApplyDeptCode");
				this._ApplyDeptCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("AcceptDeptId")]
		public long AcceptDeptId
		{
			get{ return _AcceptDeptId; }
			set
			{
				this.OnPropertyValueChange("AcceptDeptId");
				this._AcceptDeptId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("AcceptDeptName")]
		public string AcceptDeptName
		{
			get{ return _AcceptDeptName; }
			set
			{
				this.OnPropertyValueChange("AcceptDeptName");
				this._AcceptDeptName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("AcceptDeptCode")]
		public string AcceptDeptCode
		{
			get{ return _AcceptDeptCode; }
			set
			{
				this.OnPropertyValueChange("AcceptDeptCode");
				this._AcceptDeptCode = value;
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
				_.ReceiptCode,
				_.CreationTime,
				_.CreatorUserId,
				_.CreatorUserName,
				_.CreatorUserCode,
				_.AuditUserId,
				_.AuditUserName,
				_.AuditUserCode,
				_.AuditTime,
				_.AuditStatus,
				_.TotalPrice,
				_.ApplyDeptId,
				_.ApplyDeptName,
				_.ApplyDeptCode,
				_.AcceptDeptId,
				_.AcceptDeptName,
				_.AcceptDeptCode,
				_.HosId,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._Id,
				this._ReceiptCode,
				this._CreationTime,
				this._CreatorUserId,
				this._CreatorUserName,
				this._CreatorUserCode,
				this._AuditUserId,
				this._AuditUserName,
				this._AuditUserCode,
				this._AuditTime,
				this._AuditStatus,
				this._TotalPrice,
				this._ApplyDeptId,
				this._ApplyDeptName,
				this._ApplyDeptCode,
				this._AcceptDeptId,
				this._AcceptDeptName,
				this._AcceptDeptCode,
				this._HosId,
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
			public readonly static Field All = new Field("*", "View_DrugTrasnferReceipt");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ReceiptCode = new Field("ReceiptCode", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreatorUserName = new Field("CreatorUserName", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreatorUserCode = new Field("CreatorUserCode", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditUserId = new Field("AuditUserId", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditUserName = new Field("AuditUserName", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditUserCode = new Field("AuditUserCode", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditTime = new Field("AuditTime", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditStatus = new Field("AuditStatus", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TotalPrice = new Field("TotalPrice", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ApplyDeptId = new Field("ApplyDeptId", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ApplyDeptName = new Field("ApplyDeptName", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ApplyDeptCode = new Field("ApplyDeptCode", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AcceptDeptId = new Field("AcceptDeptId", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AcceptDeptName = new Field("AcceptDeptName", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AcceptDeptCode = new Field("AcceptDeptCode", "View_DrugTrasnferReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "View_DrugTrasnferReceipt", "");
        }
        #endregion
	}
}