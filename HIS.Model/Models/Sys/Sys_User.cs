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
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace HIS.Model
{

	/// <summary>
	/// 实体类Sys_User 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Sys_User")]
	[Serializable]
	public partial class Sys_User : Entity 
	{
		#region Model
		private long _Id;
		private long _HosId;
		private string _Code;
		private string _Password;
		private string _Name;
		private int _UserType;
		private int _UserNature;
		private long? _EducationId;
		private long? _TitleId;
		private long? _RoleId;
		private string _IDCard;
		private DateTime? _Birthday;
		private string _PhoneNumber;
		private string _SearchCode;
		private long _CreatorUserId;
		private DateTime _CreationTime;
		private long? _DeleterUserId;
		private DateTime? _DeletionTime;
		private long _LastModifierUserId;
		private DateTime _LastModificationTime;
		private int _DataStatus;
		private int _No;
		/// <summary>
		/// 用户ID
		/// </summary>
		public long Id
		{
			get{ return _Id; }
			set
			{
				this.OnPropertyValueChange(_.Id,_Id,value);
				this._Id=value;
			}
		}
		/// <summary>
		/// 医疗机构ID
		/// </summary>
		public long HosId
		{
			get{ return _HosId; }
			set
			{
				this.OnPropertyValueChange(_.HosId,_HosId,value);
				this._HosId=value;
			}
		}
		/// <summary>
		/// 用户账户
		/// </summary>
		public string Code
		{
			get{ return _Code; }
			set
			{
				this.OnPropertyValueChange(_.Code,_Code,value);
				this._Code=value;
			}
		}
		/// <summary>
		/// 用户密码
		/// </summary>
		public string Password
		{
			get{ return _Password; }
			set
			{
				this.OnPropertyValueChange(_.Password,_Password,value);
				this._Password=value;
			}
		}
		/// <summary>
		/// 用户真实姓名
		/// </summary>
		public string Name
		{
			get{ return _Name; }
			set
			{
				this.OnPropertyValueChange(_.Name,_Name,value);
				this._Name=value;
			}
		}
		/// <summary>
		/// 用户类型 1 医生  2护士 0 其他
		/// </summary>
		public int UserType
		{
			get{ return _UserType; }
			set
			{
				this.OnPropertyValueChange(_.UserType,_UserType,value);
				this._UserType=value;
			}
		}
		/// <summary>
		/// 用户性质 0 普通 1 试用 2 实习 3 进修   注意：其中试用生成的工号约定前缀为SY 实习为SX 进修为JX
		/// </summary>
		public int UserNature
		{
			get{ return _UserNature; }
			set
			{
				this.OnPropertyValueChange(_.UserNature,_UserNature,value);
				this._UserNature=value;
			}
		}
		/// <summary>
		/// 用户学历
		/// </summary>
		public long? EducationId
		{
			get{ return _EducationId; }
			set
			{
				this.OnPropertyValueChange(_.EducationId,_EducationId,value);
				this._EducationId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? TitleId
		{
			get{ return _TitleId; }
			set
			{
				this.OnPropertyValueChange(_.TitleId,_TitleId,value);
				this._TitleId=value;
			}
		}
		/// <summary>
		/// 默认角色id
		/// </summary>
		public long? RoleId
		{
			get{ return _RoleId; }
			set
			{
				this.OnPropertyValueChange(_.RoleId,_RoleId,value);
				this._RoleId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IDCard
		{
			get{ return _IDCard; }
			set
			{
				this.OnPropertyValueChange(_.IDCard,_IDCard,value);
				this._IDCard=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Birthday
		{
			get{ return _Birthday; }
			set
			{
				this.OnPropertyValueChange(_.Birthday,_Birthday,value);
				this._Birthday=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PhoneNumber
		{
			get{ return _PhoneNumber; }
			set
			{
				this.OnPropertyValueChange(_.PhoneNumber,_PhoneNumber,value);
				this._PhoneNumber=value;
			}
		}
		/// <summary>
		/// 检索码
		/// </summary>
		public string SearchCode
		{
			get{ return _SearchCode; }
			set
			{
				this.OnPropertyValueChange(_.SearchCode,_SearchCode,value);
				this._SearchCode=value;
			}
		}
		/// <summary>
		/// 创建者ID
		/// </summary>
		public long CreatorUserId
		{
			get{ return _CreatorUserId; }
			set
			{
				this.OnPropertyValueChange(_.CreatorUserId,_CreatorUserId,value);
				this._CreatorUserId=value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreationTime
		{
			get{ return _CreationTime; }
			set
			{
				this.OnPropertyValueChange(_.CreationTime,_CreationTime,value);
				this._CreationTime=value;
			}
		}
		/// <summary>
		/// 删除者ID
		/// </summary>
		public long? DeleterUserId
		{
			get{ return _DeleterUserId; }
			set
			{
				this.OnPropertyValueChange(_.DeleterUserId,_DeleterUserId,value);
				this._DeleterUserId=value;
			}
		}
		/// <summary>
		/// 删除时间
		/// </summary>
		public DateTime? DeletionTime
		{
			get{ return _DeletionTime; }
			set
			{
				this.OnPropertyValueChange(_.DeletionTime,_DeletionTime,value);
				this._DeletionTime=value;
			}
		}
		/// <summary>
		/// 最后一次修改人ID
		/// </summary>
		public long LastModifierUserId
		{
			get{ return _LastModifierUserId; }
			set
			{
				this.OnPropertyValueChange(_.LastModifierUserId,_LastModifierUserId,value);
				this._LastModifierUserId=value;
			}
		}
		/// <summary>
		/// 最后的修改时间
		/// </summary>
		public DateTime LastModificationTime
		{
			get{ return _LastModificationTime; }
			set
			{
				this.OnPropertyValueChange(_.LastModificationTime,_LastModificationTime,value);
				this._LastModificationTime=value;
			}
		}
		/// <summary>
		/// 状态 0停用 1启用 2作废
		/// </summary>
		public int DataStatus
		{
			get{ return _DataStatus; }
			set
			{
				this.OnPropertyValueChange(_.DataStatus,_DataStatus,value);
				this._DataStatus=value;
			}
		}
		/// <summary>
		/// 序号
		/// </summary>
		public int No
		{
			get{ return _No; }
			set
			{
				this.OnPropertyValueChange(_.No,_No,value);
				this._No=value;
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
				_.Id};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Id,
				_.HosId,
				_.Code,
				_.Password,
				_.Name,
				_.UserType,
				_.UserNature,
				_.EducationId,
				_.TitleId,
				_.RoleId,
				_.IDCard,
				_.Birthday,
				_.PhoneNumber,
				_.SearchCode,
				_.CreatorUserId,
				_.CreationTime,
				_.DeleterUserId,
				_.DeletionTime,
				_.LastModifierUserId,
				_.LastModificationTime,
				_.DataStatus,
				_.No};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._HosId,
				this._Code,
				this._Password,
				this._Name,
				this._UserType,
				this._UserNature,
				this._EducationId,
				this._TitleId,
				this._RoleId,
				this._IDCard,
				this._Birthday,
				this._PhoneNumber,
				this._SearchCode,
				this._CreatorUserId,
				this._CreationTime,
				this._DeleterUserId,
				this._DeletionTime,
				this._LastModifierUserId,
				this._LastModificationTime,
				this._DataStatus,
				this._No};
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
			public readonly static Field All = new Field("*","Sys_User");
			/// <summary>
			/// 用户ID
			/// </summary>
			public readonly static Field Id = new Field("Id","Sys_User","用户ID");
			/// <summary>
			/// 医疗机构ID
			/// </summary>
			public readonly static Field HosId = new Field("HosId","Sys_User","医疗机构ID");
			/// <summary>
			/// 用户账户
			/// </summary>
			public readonly static Field Code = new Field("Code","Sys_User","用户账户");
			/// <summary>
			/// 用户密码
			/// </summary>
			public readonly static Field Password = new Field("Password","Sys_User","用户密码");
			/// <summary>
			/// 用户真实姓名
			/// </summary>
			public readonly static Field Name = new Field("Name","Sys_User","用户真实姓名");
			/// <summary>
			/// 用户类型 1 医生  2护士 0 其他
			/// </summary>
			public readonly static Field UserType = new Field("UserType","Sys_User","用户类型 1 医生  2护士 0 其他");
			/// <summary>
			/// 用户性质 0 普通 1 试用 2 实习 3 进修   注意：其中试用生成的工号约定前缀为SY 实习为SX 进修为JX
			/// </summary>
			public readonly static Field UserNature = new Field("UserNature","Sys_User","用户性质 0 普通 1 试用 2 实习 3 进修   注意：其中试用生成的工号约定前缀为SY 实习为SX 进修为JX");
			/// <summary>
			/// 用户学历
			/// </summary>
			public readonly static Field EducationId = new Field("EducationId","Sys_User","用户学历");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TitleId = new Field("TitleId","Sys_User","TitleId");
			/// <summary>
			/// 默认角色id
			/// </summary>
			public readonly static Field RoleId = new Field("RoleId","Sys_User","默认角色id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IDCard = new Field("IDCard","Sys_User","IDCard");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Birthday = new Field("Birthday","Sys_User","Birthday");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PhoneNumber = new Field("PhoneNumber","Sys_User","PhoneNumber");
			/// <summary>
			/// 检索码
			/// </summary>
			public readonly static Field SearchCode = new Field("SearchCode","Sys_User","检索码");
			/// <summary>
			/// 创建者ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId","Sys_User","创建者ID");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime","Sys_User","创建时间");
			/// <summary>
			/// 删除者ID
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId","Sys_User","删除者ID");
			/// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime","Sys_User","删除时间");
			/// <summary>
			/// 最后一次修改人ID
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId","Sys_User","最后一次修改人ID");
			/// <summary>
			/// 最后的修改时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime","Sys_User","最后的修改时间");
			/// <summary>
			/// 状态 0停用 1启用 2作废
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus","Sys_User","状态 0停用 1启用 2作废");
			/// <summary>
			/// 序号
			/// </summary>
			public readonly static Field No = new Field("No","Sys_User","序号");
		}
		#endregion


	}
}

