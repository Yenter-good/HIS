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
    /// 实体类Empi_Address。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Empi_Address")]
    [Serializable]
    public partial class Empi_Address : Entity
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
		private int? _No;
		private string _Name;
		private string _FullName;
		private int? _LevelType;
		private string _Code;
		private string _ParentCode;
		private string _SearchCode;

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
		/// 
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
		/// 
		/// </summary>
		[Field("FullName")]
		public string FullName
		{
			get{ return _FullName; }
			set
			{
				this.OnPropertyValueChange("FullName");
				this._FullName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("LevelType")]
		public int? LevelType
		{
			get{ return _LevelType; }
			set
			{
				this.OnPropertyValueChange("LevelType");
				this._LevelType = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
		/// 
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
				_.Name,
				_.FullName,
				_.LevelType,
				_.Code,
				_.ParentCode,
				_.SearchCode,
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
				this._Name,
				this._FullName,
				this._LevelType,
				this._Code,
				this._ParentCode,
				this._SearchCode,
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
			public readonly static Field All = new Field("*", "Empi_Address");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field Id = new Field("Id", "Empi_Address", "ID");
            /// <summary>
			/// 创建人编号 当前用户ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Empi_Address", "创建人编号 当前用户ID");
            /// <summary>
			/// 创建时间 默认为当前时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Empi_Address", "创建时间 默认为当前时间");
            /// <summary>
			/// 最后修改人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Empi_Address", "最后修改人编号");
            /// <summary>
			/// 最后修改时间 默认为当前时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Empi_Address", "最后修改时间 默认为当前时间");
            /// <summary>
			/// 删除人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Empi_Address", "删除人编号");
            /// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Empi_Address", "删除时间");
            /// <summary>
			/// 数据状态 0失效 1启用
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Empi_Address", "数据状态 0失效 1启用");
            /// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field No = new Field("No", "Empi_Address", "排序号");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Name = new Field("Name", "Empi_Address", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FullName = new Field("FullName", "Empi_Address", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LevelType = new Field("LevelType", "Empi_Address", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Code = new Field("Code", "Empi_Address", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ParentCode = new Field("ParentCode", "Empi_Address", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SearchCode = new Field("SearchCode", "Empi_Address", "");
        }
        #endregion
	}
}