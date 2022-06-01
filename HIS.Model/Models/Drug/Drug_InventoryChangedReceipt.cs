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
	/// 实体类Drug_ChangeInventoryReceipt。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Drug_ChangeInventoryReceipt")]
	[Serializable]
	public partial class Drug_ChangeInventoryReceipt : Entity
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
		private string _ReceiptCode;
		private int _ReceiptType;
		private long? _AuditUserId;
		private DateTime? _AuditTime;
		private bool _AuditStatus;
		private long _DeptId;
		private decimal _Total;

		/// <summary>
		/// 编号
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
		/// <summary>
		/// 创建人编号 当前用户ID
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
		/// 创建时间 默认为当前时间
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
		/// 最后修改人编号
		/// </summary>
		[Field("LastModifierUserId")]
		public long LastModifierUserId
		{
			get { return _LastModifierUserId; }
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
			get { return _LastModificationTime; }
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
			get { return _DeleterUserId; }
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
			get { return _DeletionTime; }
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
			get { return _DataStatus; }
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
			get { return _No; }
			set
			{
				this.OnPropertyValueChange("No");
				this._No = value;
			}
		}
		/// <summary>
		/// 单据号
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
		/// 类型 0盘盈 1盘亏 2报损 3抽检
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
		/// 审核人ID
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
		/// 审核时间
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
		/// 审核状态 0未审核 1审核
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
		/// 科室ID
		/// </summary>
		[Field("DeptId")]
		public long DeptId
		{
			get { return _DeptId; }
			set
			{
				this.OnPropertyValueChange("DeptId");
				this._DeptId = value;
			}
		}
		/// <summary>
		/// 总价
		/// </summary>
		[Field("Total")]
		public decimal Total
		{
			get { return _Total; }
			set
			{
				this.OnPropertyValueChange("Total");
				this._Total = value;
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
				_.ReceiptCode,
				_.ReceiptType,
				_.AuditUserId,
				_.AuditTime,
				_.AuditStatus,
				_.DeptId,
				_.Total,
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
				this._ReceiptCode,
				this._ReceiptType,
				this._AuditUserId,
				this._AuditTime,
				this._AuditStatus,
				this._DeptId,
				this._Total,
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
			public readonly static Field All = new Field("*", "Drug_ChangeInventoryReceipt");
			/// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Id = new Field("Id", "Drug_ChangeInventoryReceipt", "编号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Drug_ChangeInventoryReceipt", "");
			/// <summary>
			/// 创建人编号 当前用户ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Drug_ChangeInventoryReceipt", "创建人编号 当前用户ID");
			/// <summary>
			/// 创建时间 默认为当前时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Drug_ChangeInventoryReceipt", "创建时间 默认为当前时间");
			/// <summary>
			/// 最后修改人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Drug_ChangeInventoryReceipt", "最后修改人编号");
			/// <summary>
			/// 最后修改时间 默认为当前时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Drug_ChangeInventoryReceipt", "最后修改时间 默认为当前时间");
			/// <summary>
			/// 删除人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Drug_ChangeInventoryReceipt", "删除人编号");
			/// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Drug_ChangeInventoryReceipt", "删除时间");
			/// <summary>
			/// 数据状态 0失效 1启用
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Drug_ChangeInventoryReceipt", "数据状态 0失效 1启用");
			/// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field No = new Field("No", "Drug_ChangeInventoryReceipt", "排序号");
			/// <summary>
			/// 单据号
			/// </summary>
			public readonly static Field ReceiptCode = new Field("ReceiptCode", "Drug_ChangeInventoryReceipt", "单据号");
			/// <summary>
			/// 类型 0盘盈 1盘亏 2报损 3抽检
			/// </summary>
			public readonly static Field ReceiptType = new Field("ReceiptType", "Drug_ChangeInventoryReceipt", "类型 0盘盈 1盘亏 2报损 3抽检");
			/// <summary>
			/// 审核人ID
			/// </summary>
			public readonly static Field AuditUserId = new Field("AuditUserId", "Drug_ChangeInventoryReceipt", "审核人ID");
			/// <summary>
			/// 审核时间
			/// </summary>
			public readonly static Field AuditTime = new Field("AuditTime", "Drug_ChangeInventoryReceipt", "审核时间");
			/// <summary>
			/// 审核状态 0未审核 1审核
			/// </summary>
			public readonly static Field AuditStatus = new Field("AuditStatus", "Drug_ChangeInventoryReceipt", "审核状态 0未审核 1审核");
			/// <summary>
			/// 科室ID
			/// </summary>
			public readonly static Field DeptId = new Field("DeptId", "Drug_ChangeInventoryReceipt", "科室ID");
			/// <summary>
			/// 总价
			/// </summary>
			public readonly static Field Total = new Field("Total", "Drug_ChangeInventoryReceipt", "总价");
		}
		#endregion
	}
}