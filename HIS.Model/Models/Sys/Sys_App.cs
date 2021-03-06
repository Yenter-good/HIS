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
	/// 实体类Sys_App 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Sys_App")]
	[Serializable]
	public partial class Sys_App : Entity 
	{
		#region Model
		private long _Id;
		private string _Name;
		private string _HomePage;
		private int _No;
		private long _HosId;
		private long _CreatorUserId;
		private DateTime _CreationTime;
		private long? _DeleterUserId;
		private DateTime? _DeletionTime;
		private long _LastModifierUserId;
		private DateTime _LastModificationTime;
		private int _DataStatus;
		/// <summary>
		/// 编号
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
		/// 系统名称
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
		/// 主页,起始页    DLL|类名
		/// </summary>
		public string HomePage
		{
			get{ return _HomePage; }
			set
			{
				this.OnPropertyValueChange(_.HomePage,_HomePage,value);
				this._HomePage=value;
			}
		}
		/// <summary>
		/// 排序
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
		/// <summary>
		/// 组织机构编号
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
		/// 创建人编号
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
		/// 创建日期
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
		/// 删除操作人编号
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
		/// 删除操作日期
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
		/// 最后一次操作人编号
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
		/// 最后一次操作日期
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
				_.Name,
				_.HomePage,
				_.No,
				_.HosId,
				_.CreatorUserId,
				_.CreationTime,
				_.DeleterUserId,
				_.DeletionTime,
				_.LastModifierUserId,
				_.LastModificationTime,
				_.DataStatus};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._Name,
				this._HomePage,
				this._No,
				this._HosId,
				this._CreatorUserId,
				this._CreationTime,
				this._DeleterUserId,
				this._DeletionTime,
				this._LastModifierUserId,
				this._LastModificationTime,
				this._DataStatus};
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
			public readonly static Field All = new Field("*","Sys_App");
			/// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Id = new Field("Id","Sys_App","编号");
			/// <summary>
			/// 系统名称
			/// </summary>
			public readonly static Field Name = new Field("Name","Sys_App","系统名称");
			/// <summary>
			/// 主页,起始页    DLL|类名
			/// </summary>
			public readonly static Field HomePage = new Field("HomePage","Sys_App","主页,起始页    DLL|类名");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field No = new Field("No","Sys_App","排序");
			/// <summary>
			/// 组织机构编号
			/// </summary>
			public readonly static Field HosId = new Field("HosId","Sys_App","组织机构编号");
			/// <summary>
			/// 创建人编号
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId","Sys_App","创建人编号");
			/// <summary>
			/// 创建日期
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime","Sys_App","创建日期");
			/// <summary>
			/// 删除操作人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId","Sys_App","删除操作人编号");
			/// <summary>
			/// 删除操作日期
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime","Sys_App","删除操作日期");
			/// <summary>
			/// 最后一次操作人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId","Sys_App","最后一次操作人编号");
			/// <summary>
			/// 最后一次操作日期
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime","Sys_App","最后一次操作日期");
			/// <summary>
			/// 状态 0停用 1启用 2作废
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus","Sys_App","状态 0停用 1启用 2作废");
		}
		#endregion


	}
}

