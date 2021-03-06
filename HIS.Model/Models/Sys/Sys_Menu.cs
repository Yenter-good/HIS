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
	/// 实体类Sys_Menu。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Sys_Menu")]
	[Serializable]
	public partial class Sys_Menu : Entity
	{
		#region Model
		private long _Id;
		private string _Code;
		private long _ParentId;
		private string _Text;
		private string _AssemblyName;
		private string _FormName;
		private string _OpenStyle;
		private string _MethodName;
		private long _AppId;
		private long _HosId;
		private long _CreatorUserId;
		private DateTime _CreationTime;
		private long? _DeleterUserId;
		private DateTime? _DeletionTime;
		private long _LastModifierUserId;
		private DateTime _LastModificationTime;
		private int _No;
		private int _DataStatus;
		private string _InitParam;
		private string _ImagePath;

        /// <summary>
        /// 系统编号
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
		/// 菜单代码
		/// </summary>
		[Field("Code")]
		public string Code
		{
			get { return _Code; }
			set
			{
				this.OnPropertyValueChange("Code");
				this._Code = value;
			}
		}
		/// <summary>
		/// 父节点ID
		/// </summary>
		[Field("ParentId")]
		public long ParentId
		{
			get { return _ParentId; }
			set
			{
				this.OnPropertyValueChange("ParentId");
				this._ParentId = value;
			}
		}
		/// <summary>
		/// 菜单名称
		/// </summary>
		[Field("Text")]
		public string Text
		{
			get { return _Text; }
			set
			{
				this.OnPropertyValueChange("Text");
				this._Text = value;
			}
		}
		/// <summary>
		/// 命名空间
		/// </summary>
		[Field("AssemblyName")]
		public string AssemblyName
		{
			get { return _AssemblyName; }
			set
			{
				this.OnPropertyValueChange("AssemblyName");
				this._AssemblyName = value;
			}
		}
		/// <summary>
		/// 窗体文件名全称
		/// </summary>
		[Field("FormName")]
		public string FormName
		{
			get { return _FormName; }
			set
			{
				this.OnPropertyValueChange("FormName");
				this._FormName = value;
			}
		}
		/// <summary>
		/// 打开方式
		/// </summary>
		[Field("OpenStyle")]
		public string OpenStyle
		{
			get { return _OpenStyle; }
			set
			{
				this.OnPropertyValueChange("OpenStyle");
				this._OpenStyle = value;
			}
		}
		/// <summary>
		/// 方法名
		/// </summary>
		[Field("MethodName")]
		public string MethodName
		{
			get { return _MethodName; }
			set
			{
				this.OnPropertyValueChange("MethodName");
				this._MethodName = value;
			}
		}
		/// <summary>
		/// 系统编号
		/// </summary>
		[Field("AppId")]
		public long AppId
		{
			get { return _AppId; }
			set
			{
				this.OnPropertyValueChange("AppId");
				this._AppId = value;
			}
		}
		/// <summary>
		/// 组织机构编号
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
		/// 创建人编号
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
		/// 创建日期
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
		/// 删除操作人编号
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
		/// 删除操作日期
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
		/// 最后一次操作人编号
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
		/// 最后一次操作日期
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
		/// 序号
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
		/// _0停用 1启用 2作废
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
		/// 
		/// </summary>
		[Field("InitParam")]
		public string InitParam
		{
			get { return _InitParam; }
			set
			{
				this.OnPropertyValueChange("InitParam");
				this._InitParam = value;
			}
		}
        /// <summary>
        /// 菜单图标相对路径
        /// </summary>
        [Field("ImagePath")]
        public string ImagePath
        {
            get { return _ImagePath; }
            set
            {
                this.OnPropertyValueChange("ImagePath");
                this._ImagePath = value;
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
				_.Code,
				_.ParentId,
				_.Text,
				_.AssemblyName,
				_.FormName,
				_.OpenStyle,
				_.MethodName,
				_.AppId,
				_.HosId,
				_.CreatorUserId,
				_.CreationTime,
				_.DeleterUserId,
				_.DeletionTime,
				_.LastModifierUserId,
				_.LastModificationTime,
				_.No,
				_.DataStatus,
				_.InitParam,
				_.ImagePath,
            };
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._Code,
				this._ParentId,
				this._Text,
				this._AssemblyName,
				this._FormName,
				this._OpenStyle,
				this._MethodName,
				this._AppId,
				this._HosId,
				this._CreatorUserId,
				this._CreationTime,
				this._DeleterUserId,
				this._DeletionTime,
				this._LastModifierUserId,
				this._LastModificationTime,
				this._No,
				this._DataStatus,
				this._InitParam,
				this._ImagePath,
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
			public readonly static Field All = new Field("*", "Sys_Menu");
			/// <summary>
			/// 系统编号
			/// </summary>
			public readonly static Field Id = new Field("Id", "Sys_Menu", "系统编号");
			/// <summary>
			/// 菜单代码
			/// </summary>
			public readonly static Field Code = new Field("Code", "Sys_Menu", "菜单代码");
			/// <summary>
			/// 父节点ID
			/// </summary>
			public readonly static Field ParentId = new Field("ParentId", "Sys_Menu", "父节点ID");
			/// <summary>
			/// 菜单名称
			/// </summary>
			public readonly static Field Text = new Field("Text", "Sys_Menu", "菜单名称");
			/// <summary>
			/// 命名空间
			/// </summary>
			public readonly static Field AssemblyName = new Field("AssemblyName", "Sys_Menu", "命名空间");
			/// <summary>
			/// 窗体文件名全称
			/// </summary>
			public readonly static Field FormName = new Field("FormName", "Sys_Menu", "窗体文件名全称");
			/// <summary>
			/// 打开方式
			/// </summary>
			public readonly static Field OpenStyle = new Field("OpenStyle", "Sys_Menu", "打开方式");
			/// <summary>
			/// 方法名
			/// </summary>
			public readonly static Field MethodName = new Field("MethodName", "Sys_Menu", "方法名");
			/// <summary>
			/// 系统编号
			/// </summary>
			public readonly static Field AppId = new Field("AppId", "Sys_Menu", "系统编号");
			/// <summary>
			/// 组织机构编号
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Sys_Menu", "组织机构编号");
			/// <summary>
			/// 创建人编号
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Sys_Menu", "创建人编号");
			/// <summary>
			/// 创建日期
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Sys_Menu", "创建日期");
			/// <summary>
			/// 删除操作人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Sys_Menu", "删除操作人编号");
			/// <summary>
			/// 删除操作日期
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Sys_Menu", "删除操作日期");
			/// <summary>
			/// 最后一次操作人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Sys_Menu", "最后一次操作人编号");
			/// <summary>
			/// 最后一次操作日期
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Sys_Menu", "最后一次操作日期");
			/// <summary>
			/// 序号
			/// </summary>
			public readonly static Field No = new Field("No", "Sys_Menu", "序号");
			/// <summary>
			/// _0停用 1启用 2作废
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Sys_Menu", "_0停用 1启用 2作废");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field InitParam = new Field("InitParam", "Sys_Menu", "");
            /// <summary>
            /// 菜单图标相对路径
            /// </summary>
			public readonly static Field ImagePath = new Field("ImagePath", "Sys_Menu", "菜单图标相对路径");
        }
		#endregion
	}
}