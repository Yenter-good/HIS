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
    /// 实体类Drug_PriceChangedDeptInfluence。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Drug_PriceChangedDeptInfluence")]
    [Serializable]
    public partial class Drug_PriceChangedDeptInfluence : Entity
    {
        #region Model
		private long _Id;
		private long _HosId;
		private long _CreatorUserId;
		private DateTime _CreationTime;
		private long? _DeleterUserId;
		private DateTime? _DeletionTime;
		private long _LastModifierUserId;
		private DateTime _LastModificationTime;
		private int _DataStatus;
		private int _No;
		private long _ReceiptId;
		private long _ReceiptDetailId;
		private long _DeptId;
		private int _BigPackageQuantity;
		private int _SmallPackageQuantity;
		private decimal _BigPackageTotal;
		private decimal _SmallPackageTotal;

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
		/// 组织机构编号
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
		/// 创建人编号
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
		/// 创建日期
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
		/// 删除操作人编号
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
		/// 删除操作日期
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
		/// 最后一次操作人编号
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
		/// 最后一次操作日期
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
		/// 状态 0停用 1启用 2作废
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
		/// 排序
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
		/// 单据ID
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
		/// 单据明细ID
		/// </summary>
		[Field("ReceiptDetailId")]
		public long ReceiptDetailId
		{
			get{ return _ReceiptDetailId; }
			set
			{
				this.OnPropertyValueChange("ReceiptDetailId");
				this._ReceiptDetailId = value;
			}
		}
		/// <summary>
		/// 药库药房科室ID
		/// </summary>
		[Field("DeptId")]
		public long DeptId
		{
			get{ return _DeptId; }
			set
			{
				this.OnPropertyValueChange("DeptId");
				this._DeptId = value;
			}
		}
		/// <summary>
		/// 受影响的大包装数量
		/// </summary>
		[Field("BigPackageQuantity")]
		public int BigPackageQuantity
		{
			get{ return _BigPackageQuantity; }
			set
			{
				this.OnPropertyValueChange("BigPackageQuantity");
				this._BigPackageQuantity = value;
			}
		}
		/// <summary>
		/// 受影响的小包装数量
		/// </summary>
		[Field("SmallPackageQuantity")]
		public int SmallPackageQuantity
		{
			get{ return _SmallPackageQuantity; }
			set
			{
				this.OnPropertyValueChange("SmallPackageQuantity");
				this._SmallPackageQuantity = value;
			}
		}
		/// <summary>
		/// 大包装受影响总价
		/// </summary>
		[Field("BigPackageTotal")]
		public decimal BigPackageTotal
		{
			get{ return _BigPackageTotal; }
			set
			{
				this.OnPropertyValueChange("BigPackageTotal");
				this._BigPackageTotal = value;
			}
		}
		/// <summary>
		/// 小包装受影响总价
		/// </summary>
		[Field("SmallPackageTotal")]
		public decimal SmallPackageTotal
		{
			get{ return _SmallPackageTotal; }
			set
			{
				this.OnPropertyValueChange("SmallPackageTotal");
				this._SmallPackageTotal = value;
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
				_.CreatorUserId,
				_.CreationTime,
				_.DeleterUserId,
				_.DeletionTime,
				_.LastModifierUserId,
				_.LastModificationTime,
				_.DataStatus,
				_.No,
				_.ReceiptId,
				_.ReceiptDetailId,
				_.DeptId,
				_.BigPackageQuantity,
				_.SmallPackageQuantity,
				_.BigPackageTotal,
				_.SmallPackageTotal,
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
				this._DeleterUserId,
				this._DeletionTime,
				this._LastModifierUserId,
				this._LastModificationTime,
				this._DataStatus,
				this._No,
				this._ReceiptId,
				this._ReceiptDetailId,
				this._DeptId,
				this._BigPackageQuantity,
				this._SmallPackageQuantity,
				this._BigPackageTotal,
				this._SmallPackageTotal,
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
			public readonly static Field All = new Field("*", "Drug_PriceChangedDeptInfluence");
            /// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Id = new Field("Id", "Drug_PriceChangedDeptInfluence", "编号");
            /// <summary>
			/// 组织机构编号
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Drug_PriceChangedDeptInfluence", "组织机构编号");
            /// <summary>
			/// 创建人编号
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Drug_PriceChangedDeptInfluence", "创建人编号");
            /// <summary>
			/// 创建日期
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Drug_PriceChangedDeptInfluence", "创建日期");
            /// <summary>
			/// 删除操作人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Drug_PriceChangedDeptInfluence", "删除操作人编号");
            /// <summary>
			/// 删除操作日期
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Drug_PriceChangedDeptInfluence", "删除操作日期");
            /// <summary>
			/// 最后一次操作人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Drug_PriceChangedDeptInfluence", "最后一次操作人编号");
            /// <summary>
			/// 最后一次操作日期
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Drug_PriceChangedDeptInfluence", "最后一次操作日期");
            /// <summary>
			/// 状态 0停用 1启用 2作废
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Drug_PriceChangedDeptInfluence", "状态 0停用 1启用 2作废");
            /// <summary>
			/// 排序
			/// </summary>
			public readonly static Field No = new Field("No", "Drug_PriceChangedDeptInfluence", "排序");
            /// <summary>
			/// 单据ID
			/// </summary>
			public readonly static Field ReceiptId = new Field("ReceiptId", "Drug_PriceChangedDeptInfluence", "单据ID");
            /// <summary>
			/// 单据明细ID
			/// </summary>
			public readonly static Field ReceiptDetailId = new Field("ReceiptDetailId", "Drug_PriceChangedDeptInfluence", "单据明细ID");
            /// <summary>
			/// 药库药房科室ID
			/// </summary>
			public readonly static Field DeptId = new Field("DeptId", "Drug_PriceChangedDeptInfluence", "药库药房科室ID");
            /// <summary>
			/// 受影响的大包装数量
			/// </summary>
			public readonly static Field BigPackageQuantity = new Field("BigPackageQuantity", "Drug_PriceChangedDeptInfluence", "受影响的大包装数量");
            /// <summary>
			/// 受影响的小包装数量
			/// </summary>
			public readonly static Field SmallPackageQuantity = new Field("SmallPackageQuantity", "Drug_PriceChangedDeptInfluence", "受影响的小包装数量");
            /// <summary>
			/// 大包装受影响总价
			/// </summary>
			public readonly static Field BigPackageTotal = new Field("BigPackageTotal", "Drug_PriceChangedDeptInfluence", "大包装受影响总价");
            /// <summary>
			/// 小包装受影响总价
			/// </summary>
			public readonly static Field SmallPackageTotal = new Field("SmallPackageTotal", "Drug_PriceChangedDeptInfluence", "小包装受影响总价");
        }
        #endregion
	}
}