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
    /// 实体类Dic_FeeCategory。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Dic_FeeCategory")]
    [Serializable]
    public partial class Dic_FeeCategory : Entity
    {
        #region Model
		private long _Id;
		private long _HosId;
		private string _CODE;
		private string _ParentCode;
		private string _Name;
		private long _CreatorUserId;
		private DateTime? _CreationTime;
		private long _LastModifierUserId;
		private DateTime? _LastModificationTime;
		private long? _DeleterUserId;
		private DateTime? _DeletionTime;
		private int? _NO;
		private int? _DataStatus;

		/// <summary>
		/// ID
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
		/// 编号
		/// </summary>
		[Field("CODE")]
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange("CODE");
				this._CODE = value;
			}
		}
		/// <summary>
		/// 父级归类编号
		/// </summary>
		[Field("ParentCode")]
		public string ParentCode
		{
			get{ return _ParentCode; }
			set
			{
				this.OnPropertyValueChange("ParentCode");
				this._ParentCode = value;
			}
		}
		/// <summary>
		/// 费用归类名称
		/// </summary>
		[Field("Name")]
		public string Name
		{
			get{ return _Name; }
			set
			{
				this.OnPropertyValueChange("Name");
				this._Name = value;
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
				_.CODE,
				_.ParentCode,
				_.Name,
				_.CreatorUserId,
				_.CreationTime,
				_.LastModifierUserId,
				_.LastModificationTime,
				_.DeleterUserId,
				_.DeletionTime,
				_.NO,
				_.DataStatus,
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
				this._CODE,
				this._ParentCode,
				this._Name,
				this._CreatorUserId,
				this._CreationTime,
				this._LastModifierUserId,
				this._LastModificationTime,
				this._DeleterUserId,
				this._DeletionTime,
				this._NO,
				this._DataStatus,
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
			public readonly static Field All = new Field("*", "Dic_FeeCategory");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field Id = new Field("Id", "Dic_FeeCategory", "ID");
            /// <summary>
			/// 医疗机构ID
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Dic_FeeCategory", "医疗机构ID");
            /// <summary>
			/// 编号
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "Dic_FeeCategory", "编号");
            /// <summary>
			/// 父级归类编号
			/// </summary>
			public readonly static Field ParentCode = new Field("ParentCode", "Dic_FeeCategory", "父级归类编号");
            /// <summary>
			/// 费用归类名称
			/// </summary>
			public readonly static Field Name = new Field("Name", "Dic_FeeCategory", "费用归类名称");
            /// <summary>
			/// 创建人编号 当前用户ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Dic_FeeCategory", "创建人编号 当前用户ID");
            /// <summary>
			/// 创建时间 默认为当前时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Dic_FeeCategory", "创建时间 默认为当前时间");
            /// <summary>
			/// 最后修改人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Dic_FeeCategory", "最后修改人编号");
            /// <summary>
			/// 最后修改时间 默认为当前时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Dic_FeeCategory", "最后修改时间 默认为当前时间");
            /// <summary>
			/// 删除人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Dic_FeeCategory", "删除人编号");
            /// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Dic_FeeCategory", "删除时间");
            /// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field NO = new Field("NO", "Dic_FeeCategory", "排序号");
            /// <summary>
			/// 数据状态 0失效 1启用
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Dic_FeeCategory", "数据状态 0失效 1启用");
        }
        #endregion
	}
}