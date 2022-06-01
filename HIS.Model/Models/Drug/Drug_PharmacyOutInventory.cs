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
	/// 实体类Drug_PharmacyOutInventory。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Drug_PharmacyOutInventory")]
	[Serializable]
	public partial class Drug_PharmacyOutInventory : Entity
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
		private int _ReceiptType;
		private long _ReceiptId;
		private int _BigQuantity;
		private int _SmallQuantity;
		private string _ClassCode;
		private string _SpecificationCode;
		private long _DeptId;

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
		/// 单据类型 0退库 1报损 2调拨 3抽检 4盘亏 5发药
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
		/// 单据ID
		/// </summary>
		[Field("ReceiptId")]
		public long ReceiptId
		{
			get { return _ReceiptId; }
			set
			{
				this.OnPropertyValueChange("ReceiptId");
				this._ReceiptId = value;
			}
		}
		/// <summary>
		/// 数量
		/// </summary>
		[Field("BigQuantity")]
		public int BigQuantity
		{
			get { return _BigQuantity; }
			set
			{
				this.OnPropertyValueChange("BigQuantity");
				this._BigQuantity = value;
			}
		}
		/// <summary>
		/// 小包装操作数量
		/// </summary>
		[Field("SmallQuantity")]
		public int SmallQuantity
		{
			get { return _SmallQuantity; }
			set
			{
				this.OnPropertyValueChange("SmallQuantity");
				this._SmallQuantity = value;
			}
		}
		/// <summary>
		/// 药典编码
		/// </summary>
		[Field("ClassCode")]
		public string ClassCode
		{
			get { return _ClassCode; }
			set
			{
				this.OnPropertyValueChange("ClassCode");
				this._ClassCode = value;
			}
		}
		/// <summary>
		/// 规格编码
		/// </summary>
		[Field("SpecificationCode")]
		public string SpecificationCode
		{
			get { return _SpecificationCode; }
			set
			{
				this.OnPropertyValueChange("SpecificationCode");
				this._SpecificationCode = value;
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
				_.ReceiptType,
				_.ReceiptId,
				_.BigQuantity,
				_.SmallQuantity,
				_.ClassCode,
				_.SpecificationCode,
				_.DeptId,
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
				this._ReceiptType,
				this._ReceiptId,
				this._BigQuantity,
				this._SmallQuantity,
				this._ClassCode,
				this._SpecificationCode,
				this._DeptId,
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
			public readonly static Field All = new Field("*", "Drug_PharmacyOutInventory");
			/// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Id = new Field("Id", "Drug_PharmacyOutInventory", "编号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Drug_PharmacyOutInventory", "");
			/// <summary>
			/// 创建人编号 当前用户ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Drug_PharmacyOutInventory", "创建人编号 当前用户ID");
			/// <summary>
			/// 创建时间 默认为当前时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Drug_PharmacyOutInventory", "创建时间 默认为当前时间");
			/// <summary>
			/// 最后修改人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Drug_PharmacyOutInventory", "最后修改人编号");
			/// <summary>
			/// 最后修改时间 默认为当前时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Drug_PharmacyOutInventory", "最后修改时间 默认为当前时间");
			/// <summary>
			/// 删除人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Drug_PharmacyOutInventory", "删除人编号");
			/// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Drug_PharmacyOutInventory", "删除时间");
			/// <summary>
			/// 数据状态 0失效 1启用
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Drug_PharmacyOutInventory", "数据状态 0失效 1启用");
			/// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field No = new Field("No", "Drug_PharmacyOutInventory", "排序号");
			/// <summary>
			/// 单据类型 0退库 1报损 2调拨 3抽检 4盘亏 5发药
			/// </summary>
			public readonly static Field ReceiptType = new Field("ReceiptType", "Drug_PharmacyOutInventory", "单据类型 0退库 1报损 2调拨 3抽检 4盘亏 5发药");
			/// <summary>
			/// 单据ID
			/// </summary>
			public readonly static Field ReceiptId = new Field("ReceiptId", "Drug_PharmacyOutInventory", "单据ID");
			/// <summary>
			/// 数量
			/// </summary>
			public readonly static Field BigQuantity = new Field("BigQuantity", "Drug_PharmacyOutInventory", "数量");
			/// <summary>
			/// 小包装操作数量
			/// </summary>
			public readonly static Field SmallQuantity = new Field("SmallQuantity", "Drug_PharmacyOutInventory", "小包装操作数量");
			/// <summary>
			/// 药典编码
			/// </summary>
			public readonly static Field ClassCode = new Field("ClassCode", "Drug_PharmacyOutInventory", "药典编码");
			/// <summary>
			/// 规格编码
			/// </summary>
			public readonly static Field SpecificationCode = new Field("SpecificationCode", "Drug_PharmacyOutInventory", "规格编码");
			/// <summary>
			/// 科室ID
			/// </summary>
			public readonly static Field DeptId = new Field("DeptId", "Drug_PharmacyOutInventory", "科室ID");
		}
		#endregion
	}
}