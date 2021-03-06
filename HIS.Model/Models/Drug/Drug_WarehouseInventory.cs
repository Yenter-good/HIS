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
	/// 实体类Drug_WarehouseInventory。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Drug_WarehouseInventory")]
	[Serializable]
	public partial class Drug_WarehouseInventory : Entity
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
		private string _ClassCode;
		private string _SpecificationCode;
		private string _Name;
		private decimal _PurchasePrice;
		private decimal? _MarkupRate;
		private decimal _Price;
		private int _Quantity;
		private string _SearchCode;
		private string _WubiCode;
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
		/// 
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
		/// 药典编号
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
		/// 药品名称
		/// </summary>
		[Field("Name")]
		public string Name
		{
			get { return _Name; }
			set
			{
				this.OnPropertyValueChange("Name");
				this._Name = value;
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
		/// 加成率
		/// </summary>
		[Field("MarkupRate")]
		public decimal? MarkupRate
		{
			get { return _MarkupRate; }
			set
			{
				this.OnPropertyValueChange("MarkupRate");
				this._MarkupRate = value;
			}
		}
		/// <summary>
		/// 销售价
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
		/// 库存数量
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
		/// 拼音码
		/// </summary>
		[Field("SearchCode")]
		public string SearchCode
		{
			get { return _SearchCode; }
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
			get { return _WubiCode; }
			set
			{
				this.OnPropertyValueChange("WubiCode");
				this._WubiCode = value;
			}
		}
		/// <summary>
		/// 所属科室ID
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
				_.ClassCode,
				_.SpecificationCode,
				_.Name,
				_.PurchasePrice,
				_.MarkupRate,
				_.Price,
				_.Quantity,
				_.SearchCode,
				_.WubiCode,
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
				this._ClassCode,
				this._SpecificationCode,
				this._Name,
				this._PurchasePrice,
				this._MarkupRate,
				this._Price,
				this._Quantity,
				this._SearchCode,
				this._WubiCode,
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
			public readonly static Field All = new Field("*", "Drug_WarehouseInventory");
			/// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Id = new Field("Id", "Drug_WarehouseInventory", "编号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Drug_WarehouseInventory", "");
			/// <summary>
			/// 创建人编号 当前用户ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Drug_WarehouseInventory", "创建人编号 当前用户ID");
			/// <summary>
			/// 创建时间 默认为当前时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Drug_WarehouseInventory", "创建时间 默认为当前时间");
			/// <summary>
			/// 最后修改人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Drug_WarehouseInventory", "最后修改人编号");
			/// <summary>
			/// 最后修改时间 默认为当前时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Drug_WarehouseInventory", "最后修改时间 默认为当前时间");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Drug_WarehouseInventory", "");
			/// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Drug_WarehouseInventory", "删除时间");
			/// <summary>
			/// 数据状态 0失效 1启用
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Drug_WarehouseInventory", "数据状态 0失效 1启用");
			/// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field No = new Field("No", "Drug_WarehouseInventory", "排序号");
			/// <summary>
			/// 药典编号
			/// </summary>
			public readonly static Field ClassCode = new Field("ClassCode", "Drug_WarehouseInventory", "药典编号");
			/// <summary>
			/// 规格编码
			/// </summary>
			public readonly static Field SpecificationCode = new Field("SpecificationCode", "Drug_WarehouseInventory", "规格编码");
			/// <summary>
			/// 药品名称
			/// </summary>
			public readonly static Field Name = new Field("Name", "Drug_WarehouseInventory", "药品名称");
			/// <summary>
			/// 进货价
			/// </summary>
			public readonly static Field PurchasePrice = new Field("PurchasePrice", "Drug_WarehouseInventory", "进货价");
			/// <summary>
			/// 加成率
			/// </summary>
			public readonly static Field MarkupRate = new Field("MarkupRate", "Drug_WarehouseInventory", "加成率");
			/// <summary>
			/// 销售价
			/// </summary>
			public readonly static Field Price = new Field("Price", "Drug_WarehouseInventory", "销售价");
			/// <summary>
			/// 库存数量
			/// </summary>
			public readonly static Field Quantity = new Field("Quantity", "Drug_WarehouseInventory", "库存数量");
			/// <summary>
			/// 拼音码
			/// </summary>
			public readonly static Field SearchCode = new Field("SearchCode", "Drug_WarehouseInventory", "拼音码");
			/// <summary>
			/// 五笔码
			/// </summary>
			public readonly static Field WubiCode = new Field("WubiCode", "Drug_WarehouseInventory", "五笔码");
			/// <summary>
			/// 所属科室ID
			/// </summary>
			public readonly static Field DeptId = new Field("DeptId", "Drug_WarehouseInventory", "所属科室ID");
		}
		#endregion
	}
}