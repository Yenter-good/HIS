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
	/// 实体类Sys_Dept。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Sys_Dept")]
	[Serializable]
	public partial class Sys_Dept : Entity
	{
		#region Model
		private long _Id;
		private long _HosId;
		private long _ParentId;
		private string _Code;
		private string _Name;
		private string _AliasName;
		private string _Location;
		private string _SearchCode;
		private long _CategoryId;
		private int? _CategoryDetail;
		private bool _DefaultDept;
		private long _CreatorUserId;
		private DateTime _CreationTime;
		private long? _DeleterUserId;
		private DateTime? _DeletionTime;
		private long _LastModifierUserId;
		private DateTime _LastModificationTime;
		private int _DataStatus;
		private int _No;

		/// <summary>
		/// ID
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
		/// 医疗机构ID
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
		/// 代码
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
		/// 名称
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
		/// 科室别名
		/// </summary>
		[Field("AliasName")]
		public string AliasName
		{
			get { return _AliasName; }
			set
			{
				this.OnPropertyValueChange("AliasName");
				this._AliasName = value;
			}
		}
		/// <summary>
		/// 科室位置
		/// </summary>
		[Field("Location")]
		public string Location
		{
			get { return _Location; }
			set
			{
				this.OnPropertyValueChange("Location");
				this._Location = value;
			}
		}
		/// <summary>
		/// 检索码
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
		/// 科室大类ID
		/// </summary>
		[Field("CategoryId")]
		public long CategoryId
		{
			get { return _CategoryId; }
			set
			{
				this.OnPropertyValueChange("CategoryId");
				this._CategoryId = value;
			}
		}
		/// <summary>
		/// 科室详细分类
		/// </summary>
		[Field("CategoryDetail")]
		public int? CategoryDetail
		{
			get { return _CategoryDetail; }
			set
			{
				this.OnPropertyValueChange("CategoryDetail");
				this._CategoryDetail = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("DefaultDept")]
		public bool DefaultDept
		{
			get { return _DefaultDept; }
			set
			{
				this.OnPropertyValueChange("DefaultDept");
				this._DefaultDept = value;
			}
		}
		/// <summary>
		/// 创建者ID
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
		/// 创建时间
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
		/// 删除者ID
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
		/// 最后的修改者ID
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
		/// 最后的修改时间
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
		/// 状态 0停用 1启用 2作废
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
				_.ParentId,
				_.Code,
				_.Name,
				_.AliasName,
				_.Location,
				_.SearchCode,
				_.CategoryId,
				_.CategoryDetail,
				_.DefaultDept,
				_.CreatorUserId,
				_.CreationTime,
				_.DeleterUserId,
				_.DeletionTime,
				_.LastModifierUserId,
				_.LastModificationTime,
				_.DataStatus,
				_.No,
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
				this._ParentId,
				this._Code,
				this._Name,
				this._AliasName,
				this._Location,
				this._SearchCode,
				this._CategoryId,
				this._CategoryDetail,
				this._DefaultDept,
				this._CreatorUserId,
				this._CreationTime,
				this._DeleterUserId,
				this._DeletionTime,
				this._LastModifierUserId,
				this._LastModificationTime,
				this._DataStatus,
				this._No,
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
			public readonly static Field All = new Field("*", "Sys_Dept");
			/// <summary>
			/// ID
			/// </summary>
			public readonly static Field Id = new Field("Id", "Sys_Dept", "ID");
			/// <summary>
			/// 医疗机构ID
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Sys_Dept", "医疗机构ID");
			/// <summary>
			/// 父节点ID
			/// </summary>
			public readonly static Field ParentId = new Field("ParentId", "Sys_Dept", "父节点ID");
			/// <summary>
			/// 代码
			/// </summary>
			public readonly static Field Code = new Field("Code", "Sys_Dept", "代码");
			/// <summary>
			/// 名称
			/// </summary>
			public readonly static Field Name = new Field("Name", "Sys_Dept", "名称");
			/// <summary>
			/// 科室别名
			/// </summary>
			public readonly static Field AliasName = new Field("AliasName", "Sys_Dept", "科室别名");
			/// <summary>
			/// 科室位置
			/// </summary>
			public readonly static Field Location = new Field("Location", "Sys_Dept", "科室位置");
			/// <summary>
			/// 检索码
			/// </summary>
			public readonly static Field SearchCode = new Field("SearchCode", "Sys_Dept", "检索码");
			/// <summary>
			/// 科室大类ID
			/// </summary>
			public readonly static Field CategoryId = new Field("CategoryId", "Sys_Dept", "科室大类ID");
			/// <summary>
			/// 科室详细分类
			/// </summary>
			public readonly static Field CategoryDetail = new Field("CategoryDetail", "Sys_Dept", "科室详细分类");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DefaultDept = new Field("DefaultDept", "Sys_Dept", "");
			/// <summary>
			/// 创建者ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Sys_Dept", "创建者ID");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Sys_Dept", "创建时间");
			/// <summary>
			/// 删除者ID
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId", "Sys_Dept", "删除者ID");
			/// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime", "Sys_Dept", "删除时间");
			/// <summary>
			/// 最后的修改者ID
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Sys_Dept", "最后的修改者ID");
			/// <summary>
			/// 最后的修改时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Sys_Dept", "最后的修改时间");
			/// <summary>
			/// 状态 0停用 1启用 2作废
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Sys_Dept", "状态 0停用 1启用 2作废");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field No = new Field("No", "Sys_Dept", "");
		}
		#endregion
	}
}