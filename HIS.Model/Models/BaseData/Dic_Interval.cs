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
    /// 实体类Dic_Interval。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Dic_Interval")]
    [Serializable]
    public partial class Dic_Interval : Entity
    {
        #region Model
		private long _Id;
		private int? _HosId;
		private long _CreatorUserId;
		private DateTime _CreationTime;
		private long _LastModifierUserId;
		private DateTime _LastModificationTime;
		private long? _DeleterUserId;
		private DateTime? _DeletionTime;
		private int _DataStatus;
		private int? _No;
		private string _Code;
		private string _Name;
		private int? _Value;
		private int? _IntervalUnit;
		private string _IntervalTime;
		private DateTime? _LoopTime;
		private string _SearchCode;
		private string _WubiCode;
		private int _Type;

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
		public int? HosId
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
		/// 创建日期 默认为当前时间
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
		/// 最后一次操作人编号 当前用户ID
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
		/// 最后一次操作日期 默认为当前时间
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
		/// 排序号
		/// </summary>
		[Field("No")]
		public int? No
		{
			get{ return _No; }
			set
			{
				this.OnPropertyValueChange("No");
				this._No = value;
			}
		}
		/// <summary>
		/// 编码
		/// </summary>
		[Field("Code")]
		public string Code
		{
			get{ return _Code; }
			set
			{
				this.OnPropertyValueChange("Code");
				this._Code = value;
			}
		}
		/// <summary>
		/// 名称
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
		/// 间隔值 一天几次
		/// </summary>
		[Field("Value")]
		public int? Value
		{
			get{ return _Value; }
			set
			{
				this.OnPropertyValueChange("Value");
				this._Value = value;
			}
		}
		/// <summary>
		/// 间隔单位  0周 1 天 2 指定时间 LoopTime
		/// </summary>
		[Field("IntervalUnit")]
		public int? IntervalUnit
		{
			get{ return _IntervalUnit; }
			set
			{
				this.OnPropertyValueChange("IntervalUnit");
				this._IntervalUnit = value;
			}
		}
		/// <summary>
		/// 间隔时间   格式 组用/隔开 时间以逗号隔开 星期以分号隔开 0表示星期天  8:00/12:00/17:00 表示8点,12点,17点  1;8:00,12:00/3;12:00/5;17:00 表示星期一8点和12点 星期三12点 星期五17点
		/// </summary>
		[Field("IntervalTime")]
		public string IntervalTime
		{
			get{ return _IntervalTime; }
			set
			{
				this.OnPropertyValueChange("IntervalTime");
				this._IntervalTime = value;
			}
		}
		/// <summary>
		/// 如果间隔单位为循环 则以当前时间循环 2:00表示两小时循环一次
		/// </summary>
		[Field("LoopTime")]
		public DateTime? LoopTime
		{
			get{ return _LoopTime; }
			set
			{
				this.OnPropertyValueChange("LoopTime");
				this._LoopTime = value;
			}
		}
		/// <summary>
		/// 检索码
		/// </summary>
		[Field("SearchCode")]
		public string SearchCode
		{
			get{ return _SearchCode; }
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
			get{ return _WubiCode; }
			set
			{
				this.OnPropertyValueChange("WubiCode");
				this._WubiCode = value;
			}
		}
		/// <summary>
		/// 类型 0西药 1草药
		/// </summary>
		[Field("Type")]
		public int Type
		{
			get{ return _Type; }
			set
			{
				this.OnPropertyValueChange("Type");
				this._Type = value;
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
				_.LastModifierUserId,
				_.LastModificationTime,
				_.DeleterUserId,
				_.DeletionTime,
				_.DataStatus,
				_.No,
				_.Code,
				_.Name,
				_.Value,
				_.IntervalUnit,
				_.IntervalTime,
				_.LoopTime,
				_.SearchCode,
				_.WubiCode,
				_.Type,
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
				this._Code,
				this._Name,
				this._Value,
				this._IntervalUnit,
				this._IntervalTime,
				this._LoopTime,
				this._SearchCode,
				this._WubiCode,
				this._Type,
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
			public readonly static Field All = new Field("*", "Dic_Interval");
            /// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Id = new Field("Id", "Dic_Interval", "编号");
            /// <summary>
			/// 组织机构编号
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Dic_Interval", "组织机构编号");
            /// <summary>
			/// 创建人编号 当前用户ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Dic_Interval", "创建人编号 当前用户ID");
            /// <summary>
			/// 创建日期 默认为当前时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Dic_Interval", "创建日期 默认为当前时间");
            /// <summary>
			/// 最后一次操作人编号 当前用户ID
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Dic_Interval", "最后一次操作人编号 当前用户ID");
            /// <summary>
			/// 最后一次操作日期 默认为当前时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Dic_Interval", "最后一次操作日期 默认为当前时间");
            /// <summary>
			/// 删除操作人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Dic_Interval", "删除操作人编号");
            /// <summary>
			/// 删除操作日期
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Dic_Interval", "删除操作日期");
            /// <summary>
			/// 状态 0停用 1启用 2作废
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Dic_Interval", "状态 0停用 1启用 2作废");
            /// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field No = new Field("No", "Dic_Interval", "排序号");
            /// <summary>
			/// 编码
			/// </summary>
			public readonly static Field Code = new Field("Code", "Dic_Interval", "编码");
            /// <summary>
			/// 名称
			/// </summary>
			public readonly static Field Name = new Field("Name", "Dic_Interval", "名称");
            /// <summary>
			/// 间隔值 一天几次
			/// </summary>
			public readonly static Field Value = new Field("Value", "Dic_Interval", "间隔值 一天几次");
            /// <summary>
			/// 间隔单位  0周 1 天 2 指定时间 LoopTime
			/// </summary>
			public readonly static Field IntervalUnit = new Field("IntervalUnit", "Dic_Interval", "间隔单位  0周 1 天 2 指定时间 LoopTime");
            /// <summary>
			/// 间隔时间   格式 组用/隔开 时间以逗号隔开 星期以分号隔开 0表示星期天  8:00/12:00/17:00 表示8点,12点,17点  1;8:00,12:00/3;12:00/5;17:00 表示星期一8点和12点 星期三12点 星期五17点
			/// </summary>
			public readonly static Field IntervalTime = new Field("IntervalTime", "Dic_Interval", "间隔时间   格式 组用/隔开 时间以逗号隔开 星期以分号隔开 0表示星期天  8:00/12:00/17:00 表示8点,12点,17点  1;8:00,12:00/3;12:00/5;17:00 表示星期一8点和12点 星期三12点 星期五17点");
            /// <summary>
			/// 如果间隔单位为循环 则以当前时间循环 2:00表示两小时循环一次
			/// </summary>
			public readonly static Field LoopTime = new Field("LoopTime", "Dic_Interval", "如果间隔单位为循环 则以当前时间循环 2:00表示两小时循环一次");
            /// <summary>
			/// 检索码
			/// </summary>
			public readonly static Field SearchCode = new Field("SearchCode", "Dic_Interval", "检索码");
            /// <summary>
			/// 五笔码
			/// </summary>
			public readonly static Field WubiCode = new Field("WubiCode", "Dic_Interval", "五笔码");
            /// <summary>
			/// 类型 0西药 1草药
			/// </summary>
			public readonly static Field Type = new Field("Type", "Dic_Interval", "类型 0西药 1草药");
        }
        #endregion
	}
}