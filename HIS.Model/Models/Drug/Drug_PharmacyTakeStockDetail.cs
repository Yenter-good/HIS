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
    /// 实体类Drug_PharmacyTakeStockDetail。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Drug_PharmacyTakeStockDetail")]
    [Serializable]
    public partial class Drug_PharmacyTakeStockDetail : Entity
    {
        #region Model
		private long _Id;
		private long _CreatorUserId;
		private DateTime _CreationTime;
		private long _LastModifierUserId;
		private DateTime _LastModificationTime;
		private long? _DeleterUserId;
		private DateTime? _DeletionTime;
		private int _DataStatus;
		private int _No;
		private long _TakeStockId;
		private string _ClassCode;
		private string _SpecificationCode;
		private int _CurrentBigQuantity;
		private int _ActualBigQuantity;
		private int _CurrentSmallQuantity;
		private int _ActualSmallQuantity;
		private int? _ProfitLossBigQuantity;
		private decimal? _ProfitLossBigPrice;
		private int? _ProfitLossSmallQuantity;
		private decimal? _ProfitLossSmallPrice;

		/// <summary>
		/// 编号
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
		/// 创建人编号 当前用户ID
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
		/// 创建时间 默认为当前时间
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
		/// 最后修改人编号
		/// </summary>
		[Field("LastModifierUserId")]
		public long LastModifierUserId
		{
			get{ return _LastModifierUserId; }
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
			get{ return _LastModificationTime; }
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
			get{ return _DeleterUserId; }
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
			get{ return _DeletionTime; }
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
			get{ return _DataStatus; }
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
			get{ return _No; }
			set
			{
				this.OnPropertyValueChange("No");
				this._No = value;
			}
		}
		/// <summary>
		/// 盘点表ID
		/// </summary>
		[Field("TakeStockId")]
		public long TakeStockId
		{
			get{ return _TakeStockId; }
			set
			{
				this.OnPropertyValueChange("TakeStockId");
				this._TakeStockId = value;
			}
		}
		/// <summary>
		/// 药典编码
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
		/// 规格编码
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
		/// 盘点前大包装库存数量
		/// </summary>
		[Field("CurrentBigQuantity")]
		public int CurrentBigQuantity
		{
			get{ return _CurrentBigQuantity; }
			set
			{
				this.OnPropertyValueChange("CurrentBigQuantity");
				this._CurrentBigQuantity = value;
			}
		}
		/// <summary>
		/// 实际大包装库存数量
		/// </summary>
		[Field("ActualBigQuantity")]
		public int ActualBigQuantity
		{
			get{ return _ActualBigQuantity; }
			set
			{
				this.OnPropertyValueChange("ActualBigQuantity");
				this._ActualBigQuantity = value;
			}
		}
		/// <summary>
		/// 盘点前小包装库存数量
		/// </summary>
		[Field("CurrentSmallQuantity")]
		public int CurrentSmallQuantity
		{
			get{ return _CurrentSmallQuantity; }
			set
			{
				this.OnPropertyValueChange("CurrentSmallQuantity");
				this._CurrentSmallQuantity = value;
			}
		}
		/// <summary>
		/// 实际小包装库存数量
		/// </summary>
		[Field("ActualSmallQuantity")]
		public int ActualSmallQuantity
		{
			get{ return _ActualSmallQuantity; }
			set
			{
				this.OnPropertyValueChange("ActualSmallQuantity");
				this._ActualSmallQuantity = value;
			}
		}
		/// <summary>
		/// 盘盈盘亏数量 大包装
		/// </summary>
		[Field("ProfitLossBigQuantity")]
		public int? ProfitLossBigQuantity
		{
			get{ return _ProfitLossBigQuantity; }
			set
			{
				this.OnPropertyValueChange("ProfitLossBigQuantity");
				this._ProfitLossBigQuantity = value;
			}
		}
		/// <summary>
		/// 盘盈盘亏金额 大包装
		/// </summary>
		[Field("ProfitLossBigPrice")]
		public decimal? ProfitLossBigPrice
		{
			get{ return _ProfitLossBigPrice; }
			set
			{
				this.OnPropertyValueChange("ProfitLossBigPrice");
				this._ProfitLossBigPrice = value;
			}
		}
		/// <summary>
		/// 盘盈盘亏数量 大包装
		/// </summary>
		[Field("ProfitLossSmallQuantity")]
		public int? ProfitLossSmallQuantity
		{
			get{ return _ProfitLossSmallQuantity; }
			set
			{
				this.OnPropertyValueChange("ProfitLossSmallQuantity");
				this._ProfitLossSmallQuantity = value;
			}
		}
		/// <summary>
		/// 盘盈盘亏金额 小包装
		/// </summary>
		[Field("ProfitLossSmallPrice")]
		public decimal? ProfitLossSmallPrice
		{
			get{ return _ProfitLossSmallPrice; }
			set
			{
				this.OnPropertyValueChange("ProfitLossSmallPrice");
				this._ProfitLossSmallPrice = value;
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
				_.CreatorUserId,
				_.CreationTime,
				_.LastModifierUserId,
				_.LastModificationTime,
				_.DeleterUserId,
				_.DeletionTime,
				_.DataStatus,
				_.No,
				_.TakeStockId,
				_.ClassCode,
				_.SpecificationCode,
				_.CurrentBigQuantity,
				_.ActualBigQuantity,
				_.CurrentSmallQuantity,
				_.ActualSmallQuantity,
				_.ProfitLossBigQuantity,
				_.ProfitLossBigPrice,
				_.ProfitLossSmallQuantity,
				_.ProfitLossSmallPrice,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._Id,
				this._CreatorUserId,
				this._CreationTime,
				this._LastModifierUserId,
				this._LastModificationTime,
				this._DeleterUserId,
				this._DeletionTime,
				this._DataStatus,
				this._No,
				this._TakeStockId,
				this._ClassCode,
				this._SpecificationCode,
				this._CurrentBigQuantity,
				this._ActualBigQuantity,
				this._CurrentSmallQuantity,
				this._ActualSmallQuantity,
				this._ProfitLossBigQuantity,
				this._ProfitLossBigPrice,
				this._ProfitLossSmallQuantity,
				this._ProfitLossSmallPrice,
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
			public readonly static Field All = new Field("*", "Drug_PharmacyTakeStockDetail");
            /// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Id = new Field("Id", "Drug_PharmacyTakeStockDetail", "编号");
            /// <summary>
			/// 创建人编号 当前用户ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Drug_PharmacyTakeStockDetail", "创建人编号 当前用户ID");
            /// <summary>
			/// 创建时间 默认为当前时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Drug_PharmacyTakeStockDetail", "创建时间 默认为当前时间");
            /// <summary>
			/// 最后修改人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Drug_PharmacyTakeStockDetail", "最后修改人编号");
            /// <summary>
			/// 最后修改时间 默认为当前时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Drug_PharmacyTakeStockDetail", "最后修改时间 默认为当前时间");
            /// <summary>
			/// 删除人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Drug_PharmacyTakeStockDetail", "删除人编号");
            /// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Drug_PharmacyTakeStockDetail", "删除时间");
            /// <summary>
			/// 数据状态 0失效 1启用
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Drug_PharmacyTakeStockDetail", "数据状态 0失效 1启用");
            /// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field No = new Field("No", "Drug_PharmacyTakeStockDetail", "排序号");
            /// <summary>
			/// 盘点表ID
			/// </summary>
			public readonly static Field TakeStockId = new Field("TakeStockId", "Drug_PharmacyTakeStockDetail", "盘点表ID");
            /// <summary>
			/// 药典编码
			/// </summary>
			public readonly static Field ClassCode = new Field("ClassCode", "Drug_PharmacyTakeStockDetail", "药典编码");
            /// <summary>
			/// 规格编码
			/// </summary>
			public readonly static Field SpecificationCode = new Field("SpecificationCode", "Drug_PharmacyTakeStockDetail", "规格编码");
            /// <summary>
			/// 盘点前大包装库存数量
			/// </summary>
			public readonly static Field CurrentBigQuantity = new Field("CurrentBigQuantity", "Drug_PharmacyTakeStockDetail", "盘点前大包装库存数量");
            /// <summary>
			/// 实际大包装库存数量
			/// </summary>
			public readonly static Field ActualBigQuantity = new Field("ActualBigQuantity", "Drug_PharmacyTakeStockDetail", "实际大包装库存数量");
            /// <summary>
			/// 盘点前小包装库存数量
			/// </summary>
			public readonly static Field CurrentSmallQuantity = new Field("CurrentSmallQuantity", "Drug_PharmacyTakeStockDetail", "盘点前小包装库存数量");
            /// <summary>
			/// 实际小包装库存数量
			/// </summary>
			public readonly static Field ActualSmallQuantity = new Field("ActualSmallQuantity", "Drug_PharmacyTakeStockDetail", "实际小包装库存数量");
            /// <summary>
			/// 盘盈盘亏数量 大包装
			/// </summary>
			public readonly static Field ProfitLossBigQuantity = new Field("ProfitLossBigQuantity", "Drug_PharmacyTakeStockDetail", "盘盈盘亏数量 大包装");
            /// <summary>
			/// 盘盈盘亏金额 大包装
			/// </summary>
			public readonly static Field ProfitLossBigPrice = new Field("ProfitLossBigPrice", "Drug_PharmacyTakeStockDetail", "盘盈盘亏金额 大包装");
            /// <summary>
			/// 盘盈盘亏数量 大包装
			/// </summary>
			public readonly static Field ProfitLossSmallQuantity = new Field("ProfitLossSmallQuantity", "Drug_PharmacyTakeStockDetail", "盘盈盘亏数量 大包装");
            /// <summary>
			/// 盘盈盘亏金额 小包装
			/// </summary>
			public readonly static Field ProfitLossSmallPrice = new Field("ProfitLossSmallPrice", "Drug_PharmacyTakeStockDetail", "盘盈盘亏金额 小包装");
        }
        #endregion
	}
}