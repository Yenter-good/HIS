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
    /// 实体类Sys_RoleMenuMapper。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Sys_RoleMenuMapper")]
    [Serializable]
    public partial class Sys_RoleMenuMapper : Entity
    {
        #region Model
		private long _Id;
		private long _RoleId;
		private long _MenuId;
		private long _HosId;
		private int _No;

		/// <summary>
		/// 
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
		/// 角色ID
		/// </summary>
		[Field("RoleId")]
		public long RoleId
		{
			get{ return _RoleId; }
			set
			{
				this.OnPropertyValueChange("RoleId");
				this._RoleId = value;
			}
		}
		/// <summary>
		/// 菜单ID
		/// </summary>
		[Field("MenuId")]
		public long MenuId
		{
			get{ return _MenuId; }
			set
			{
				this.OnPropertyValueChange("MenuId");
				this._MenuId = value;
			}
		}
		/// <summary>
		/// 机构ID
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
		/// 序号
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
				_.RoleId,
				_.MenuId,
				_.HosId,
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
				this._RoleId,
				this._MenuId,
				this._HosId,
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
			public readonly static Field All = new Field("*", "Sys_RoleMenuMapper");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "Sys_RoleMenuMapper", "");
            /// <summary>
			/// 角色ID
			/// </summary>
			public readonly static Field RoleId = new Field("RoleId", "Sys_RoleMenuMapper", "角色ID");
            /// <summary>
			/// 菜单ID
			/// </summary>
			public readonly static Field MenuId = new Field("MenuId", "Sys_RoleMenuMapper", "菜单ID");
            /// <summary>
			/// 机构ID
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Sys_RoleMenuMapper", "机构ID");
            /// <summary>
			/// 序号
			/// </summary>
			public readonly static Field No = new Field("No", "Sys_RoleMenuMapper", "序号");
        }
        #endregion
	}
}