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
	/// 实体类View_PharmacyReceipt。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("View_PharmacyReceipt")]
	[Serializable]
	public partial class View_PharmacyReceipt : Entity
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
		private long _SourceDeptId;
		private string _SourceDeptName;
		private string _SourceDeptCode;
		private long _TargetDeptId;
		private string _TargetDeptName;
		private string _TargetDeptCode;
		private int _ReceiptType;
		private long _HosId;

		/// <summary>
		/// 
		/// </summary>
		[Field("Id")]
		public long Id
		{
			get { return _Id; }
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
			get { return _ReceiptCode; }
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
			get { return _CreationTime; }
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
			get { return _CreatorUserId; }
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
			get { return _CreatorUserName; }
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
			get { return _CreatorUserCode; }
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
			get { return _AuditUserId; }
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
			get { return _AuditUserName; }
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
			get { return _AuditUserCode; }
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
			get { return _AuditTime; }
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
			get { return _AuditStatus; }
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
			get { return _TotalPrice; }
			set
			{
				this.OnPropertyValueChange("TotalPrice");
				this._TotalPrice = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("SourceDeptId")]
		public long SourceDeptId
		{
			get { return _SourceDeptId; }
			set
			{
				this.OnPropertyValueChange("SourceDeptId");
				this._SourceDeptId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("SourceDeptName")]
		public string SourceDeptName
		{
			get { return _SourceDeptName; }
			set
			{
				this.OnPropertyValueChange("SourceDeptName");
				this._SourceDeptName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("SourceDeptCode")]
		public string SourceDeptCode
		{
			get { return _SourceDeptCode; }
			set
			{
				this.OnPropertyValueChange("SourceDeptCode");
				this._SourceDeptCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("TargetDeptId")]
		public long TargetDeptId
		{
			get { return _TargetDeptId; }
			set
			{
				this.OnPropertyValueChange("TargetDeptId");
				this._TargetDeptId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("TargetDeptName")]
		public string TargetDeptName
		{
			get { return _TargetDeptName; }
			set
			{
				this.OnPropertyValueChange("TargetDeptName");
				this._TargetDeptName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("TargetDeptCode")]
		public string TargetDeptCode
		{
			get { return _TargetDeptCode; }
			set
			{
				this.OnPropertyValueChange("TargetDeptCode");
				this._TargetDeptCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ReceiptType")]
		public int ReceiptType
		{
			get { return _ReceiptType; }
			set
			{
				this.OnPropertyValueChange("ReceiptType");
				this._ReceiptType = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("HosId")]
		public long HosId
		{
			get { return _HosId; }
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
				_.SourceDeptId,
				_.SourceDeptName,
				_.SourceDeptCode,
				_.TargetDeptId,
				_.TargetDeptName,
				_.TargetDeptCode,
				_.ReceiptType,
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
				this._SourceDeptId,
				this._SourceDeptName,
				this._SourceDeptCode,
				this._TargetDeptId,
				this._TargetDeptName,
				this._TargetDeptCode,
				this._ReceiptType,
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
			public readonly static Field All = new Field("*", "View_PharmacyReceipt");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ReceiptCode = new Field("ReceiptCode", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreatorUserName = new Field("CreatorUserName", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreatorUserCode = new Field("CreatorUserCode", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditUserId = new Field("AuditUserId", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditUserName = new Field("AuditUserName", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditUserCode = new Field("AuditUserCode", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditTime = new Field("AuditTime", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditStatus = new Field("AuditStatus", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TotalPrice = new Field("TotalPrice", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SourceDeptId = new Field("SourceDeptId", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SourceDeptName = new Field("SourceDeptName", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SourceDeptCode = new Field("SourceDeptCode", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TargetDeptId = new Field("TargetDeptId", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TargetDeptName = new Field("TargetDeptName", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TargetDeptCode = new Field("TargetDeptCode", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ReceiptType = new Field("ReceiptType", "View_PharmacyReceipt", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "View_PharmacyReceipt", "");
		}
		#endregion
	}
}