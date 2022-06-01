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
    /// 实体类Dic_AdviceFeeItemMapper。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Dic_AdviceFeeItemMapper")]
    [Serializable]
    public partial class Dic_AdviceFeeItemMapper : Entity
    {
        #region Model
		private long _Id;
		private long _HosId;
		private long _CreatorUserId;
		private DateTime? _CreationTime;
		private long _LastModifierUserId;
		private DateTime? _LastModificationTime;
		private long? _DeleterUserId;
		private DateTime? _DeletionTime;
		private int? _DataStatus;
		private int? _NO;
		private long? _AdviceId;
		private long? _FeeItemId;
		private int? _Quantity;
		private int? _Type;
		private int? _ItemType;

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
		/// 医疗机构ID
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
		public DateTime? CreationTime
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
		public DateTime? LastModificationTime
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
		public int? DataStatus
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
		[Field("NO")]
		public int? NO
		{
			get{ return _NO; }
			set
			{
				this.OnPropertyValueChange("NO");
				this._NO = value;
			}
		}
		/// <summary>
		/// 医嘱ID 医嘱ID
		/// </summary>
		[Field("AdviceId")]
		public long? AdviceId
		{
			get{ return _AdviceId; }
			set
			{
				this.OnPropertyValueChange("AdviceId");
				this._AdviceId = value;
			}
		}
		/// <summary>
		/// 物价表ID 物价表ID
		/// </summary>
		[Field("FeeItemId")]
		public long? FeeItemId
		{
			get{ return _FeeItemId; }
			set
			{
				this.OnPropertyValueChange("FeeItemId");
				this._FeeItemId = value;
			}
		}
		/// <summary>
		/// 数量 物价表项目数量
		/// </summary>
		[Field("Quantity")]
		public int? Quantity
		{
			get{ return _Quantity; }
			set
			{
				this.OnPropertyValueChange("Quantity");
				this._Quantity = value;
			}
		}
		/// <summary>
		/// _1、包含 2、关联     包含时只算医嘱的内容  关联时单独一条收费记录
		/// </summary>
		[Field("Type")]
		public int? Type
		{
			get{ return _Type; }
			set
			{
				this.OnPropertyValueChange("Type");
				this._Type = value;
			}
		}
		/// <summary>
		/// _1、诊疗 2、材料 3、药品
		/// </summary>
		[Field("ItemType")]
		public int? ItemType
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
				_.NO,
				_.AdviceId,
				_.FeeItemId,
				_.Quantity,
				_.Type,
				_.ItemType,
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
				this._NO,
				this._AdviceId,
				this._FeeItemId,
				this._Quantity,
				this._Type,
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
			public readonly static Field All = new Field("*", "Dic_AdviceFeeItemMapper");
            /// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Id = new Field("Id", "Dic_AdviceFeeItemMapper", "编号");
            /// <summary>
			/// 医疗机构ID
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Dic_AdviceFeeItemMapper", "医疗机构ID");
            /// <summary>
			/// 创建人编号 当前用户ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Dic_AdviceFeeItemMapper", "创建人编号 当前用户ID");
            /// <summary>
			/// 创建时间 默认为当前时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Dic_AdviceFeeItemMapper", "创建时间 默认为当前时间");
            /// <summary>
			/// 最后修改人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Dic_AdviceFeeItemMapper", "最后修改人编号");
            /// <summary>
			/// 最后修改时间 默认为当前时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Dic_AdviceFeeItemMapper", "最后修改时间 默认为当前时间");
            /// <summary>
			/// 删除人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Dic_AdviceFeeItemMapper", "删除人编号");
            /// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Dic_AdviceFeeItemMapper", "删除时间");
            /// <summary>
			/// 数据状态 0失效 1启用
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Dic_AdviceFeeItemMapper", "数据状态 0失效 1启用");
            /// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field NO = new Field("NO", "Dic_AdviceFeeItemMapper", "排序号");
            /// <summary>
			/// 医嘱ID 医嘱ID
			/// </summary>
			public readonly static Field AdviceId = new Field("AdviceId", "Dic_AdviceFeeItemMapper", "医嘱ID 医嘱ID");
            /// <summary>
			/// 物价表ID 物价表ID
			/// </summary>
			public readonly static Field FeeItemId = new Field("FeeItemId", "Dic_AdviceFeeItemMapper", "物价表ID 物价表ID");
            /// <summary>
			/// 数量 物价表项目数量
			/// </summary>
			public readonly static Field Quantity = new Field("Quantity", "Dic_AdviceFeeItemMapper", "数量 物价表项目数量");
            /// <summary>
			/// _1、包含 2、关联     包含时只算医嘱的内容  关联时单独一条收费记录
			/// </summary>
			public readonly static Field Type = new Field("Type", "Dic_AdviceFeeItemMapper", "_1、包含 2、关联     包含时只算医嘱的内容  关联时单独一条收费记录");
            /// <summary>
			/// _1、诊疗 2、材料 3、药品
			/// </summary>
			public readonly static Field ItemType = new Field("ItemType", "Dic_AdviceFeeItemMapper", "_1、诊疗 2、材料 3、药品");
        }
        #endregion
	}
}