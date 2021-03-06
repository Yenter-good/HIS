//------------------------------------------------------------------------------
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
	/// 实体类Drug_WarehouseReceiptDetail。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Drug_WarehouseReceiptDetail")]
	[Serializable]
	public partial class Drug_WarehouseReceiptDetail : Entity
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
		private long _ReceiptId;
		private string _ClassCode;
		private int _Quantity;
		private string _SpecificationCode;
		private decimal _PurchasePrice;
		private decimal _Price;
		private string _Production;
		private string _BatchNumber;
		private string _Memo;

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
		/// 数量
		/// </summary>
		[Field("Quantity")]
		public int Quantity
		{
			get { return _Quantity; }
			set
			{
				this.OnPropertyValueChange("Quantity");
				this._Quantity = value;
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
		/// 进货价
		/// </summary>
		[Field("PurchasePrice")]
		public decimal PurchasePrice
		{
			get { return _PurchasePrice; }
			set
			{
				this.OnPropertyValueChange("PurchasePrice");
				this._PurchasePrice = value;
			}
		}
		/// <summary>
		/// 零售价
		/// </summary>
		[Field("Price")]
		public decimal Price
		{
			get { return _Price; }
			set
			{
				this.OnPropertyValueChange("Price");
				this._Price = value;
			}
		}
		/// <summary>
		/// 生产厂家
		/// </summary>
		[Field("Production")]
		public string Production
		{
			get { return _Production; }
			set
			{
				this.OnPropertyValueChange("Production");
				this._Production = value;
			}
		}
		/// <summary>
		/// 批号
		/// </summary>
		[Field("BatchNumber")]
		public string BatchNumber
		{
			get { return _BatchNumber; }
			set
			{
				this.OnPropertyValueChange("BatchNumber");
				this._BatchNumber = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		[Field("Memo")]
		public string Memo
		{
			get { return _Memo; }
			set
			{
				this.OnPropertyValueChange("Memo");
				this._Memo = value;
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
				_.ReceiptId,
				_.ClassCode,
				_.Quantity,
				_.SpecificationCode,
				_.PurchasePrice,
				_.Price,
				_.Production,
				_.BatchNumber,
				_.Memo,
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
				this._ReceiptId,
				this._ClassCode,
				this._Quantity,
				this._SpecificationCode,
				this._PurchasePrice,
				this._Price,
				this._Production,
				this._BatchNumber,
				this._Memo,
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
			public readonly static Field All = new Field("*", "Drug_WarehouseReceiptDetail");
			/// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Id = new Field("Id", "Drug_WarehouseReceiptDetail", "编号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Drug_WarehouseReceiptDetail", "");
			/// <summary>
			/// 创建人编号 当前用户ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Drug_WarehouseReceiptDetail", "创建人编号 当前用户ID");
			/// <summary>
			/// 创建时间 默认为当前时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Drug_WarehouseReceiptDetail", "创建时间 默认为当前时间");
			/// <summary>
			/// 最后修改人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Drug_WarehouseReceiptDetail", "最后修改人编号");
			/// <summary>
			/// 最后修改时间 默认为当前时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Drug_WarehouseReceiptDetail", "最后修改时间 默认为当前时间");
			/// <summary>
			/// 删除人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Drug_WarehouseReceiptDetail", "删除人编号");
			/// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Drug_WarehouseReceiptDetail", "删除时间");
			/// <summary>
			/// 数据状态 0失效 1启用
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Drug_WarehouseReceiptDetail", "数据状态 0失效 1启用");
			/// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field No = new Field("No", "Drug_WarehouseReceiptDetail", "排序号");
			/// <summary>
			/// 单据ID
			/// </summary>
			public readonly static Field ReceiptId = new Field("ReceiptId", "Drug_WarehouseReceiptDetail", "单据ID");
			/// <summary>
			/// 药典编码
			/// </summary>
			public readonly static Field ClassCode = new Field("ClassCode", "Drug_WarehouseReceiptDetail", "药典编码");
			/// <summary>
			/// 数量
			/// </summary>
			public readonly static Field Quantity = new Field("Quantity", "Drug_WarehouseReceiptDetail", "数量");
			/// <summary>
			/// 规格编码
			/// </summary>
			public readonly static Field SpecificationCode = new Field("SpecificationCode", "Drug_WarehouseReceiptDetail", "规格编码");
			/// <summary>
			/// 进货价
			/// </summary>
			public readonly static Field PurchasePrice = new Field("PurchasePrice", "Drug_WarehouseReceiptDetail", "进货价");
			/// <summary>
			/// 零售价
			/// </summary>
			public readonly static Field Price = new Field("Price", "Drug_WarehouseReceiptDetail", "零售价");
			/// <summary>
			/// 生产厂家
			/// </summary>
			public readonly static Field Production = new Field("Production", "Drug_WarehouseReceiptDetail", "生产厂家");
			/// <summary>
			/// 批号
			/// </summary>
			public readonly static Field BatchNumber = new Field("BatchNumber", "Drug_WarehouseReceiptDetail", "批号");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field Memo = new Field("Memo", "Drug_WarehouseReceiptDetail", "备注");
		}
		#endregion
	}
}