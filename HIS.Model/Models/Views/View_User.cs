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
    /// 实体类View_User。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("View_User")]
    [Serializable]
    public partial class View_User : Entity
    {
        #region Model
        private long _Id;
        private string _Code;
        private string _Name;
        private string _Password;
        private int _UserType;
        private int _UserNature;
        private long? _EducationId;
        private string _EducationValue;
        private long? _TitleId;
        private int? _TitleLevel;
        private string _TitleName;
        private long? _DefaultRoleId;
        private string _DefaultRoleName;
        private string _DefaultRoleCode;
        private long? _RoleId;
        private string _RoleName;
        private string _RoleCode;
        private DateTime? _Birthday;
        private string _PhoneNumber;
        private string _IDCard;
        private int _DataStatus;
        private int _No;
        private string _SearchCode;
        private long _HosId;
        private string _HosName;
        private string _HosCode;

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        [Field("Password")]
        public string Password
        {
            get { return _Password; }
            set
            {
                this.OnPropertyValueChange("Password");
                this._Password = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("UserType")]
        public int UserType
        {
            get { return _UserType; }
            set
            {
                this.OnPropertyValueChange("UserType");
                this._UserType = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("UserNature")]
        public int UserNature
        {
            get { return _UserNature; }
            set
            {
                this.OnPropertyValueChange("UserNature");
                this._UserNature = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("EducationId")]
        public long? EducationId
        {
            get { return _EducationId; }
            set
            {
                this.OnPropertyValueChange("EducationId");
                this._EducationId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("EducationValue")]
        public string EducationValue
        {
            get { return _EducationValue; }
            set
            {
                this.OnPropertyValueChange("EducationValue");
                this._EducationValue = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("TitleId")]
        public long? TitleId
        {
            get { return _TitleId; }
            set
            {
                this.OnPropertyValueChange("TitleId");
                this._TitleId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("TitleLevel")]
        public int? TitleLevel
        {
            get { return _TitleLevel; }
            set
            {
                this.OnPropertyValueChange("TitleLevel");
                this._TitleLevel = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("TitleName")]
        public string TitleName
        {
            get { return _TitleName; }
            set
            {
                this.OnPropertyValueChange("TitleName");
                this._TitleName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("DefaultRoleId")]
        public long? DefaultRoleId
        {
            get { return _DefaultRoleId; }
            set
            {
                this.OnPropertyValueChange("DefaultRoleId");
                this._DefaultRoleId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("DefaultRoleName")]
        public string DefaultRoleName
        {
            get { return _DefaultRoleName; }
            set
            {
                this.OnPropertyValueChange("DefaultRoleName");
                this._DefaultRoleName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("DefaultRoleCode")]
        public string DefaultRoleCode
        {
            get { return _DefaultRoleCode; }
            set
            {
                this.OnPropertyValueChange("DefaultRoleCode");
                this._DefaultRoleCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RoleId")]
        public long? RoleId
        {
            get { return _RoleId; }
            set
            {
                this.OnPropertyValueChange("RoleId");
                this._RoleId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RoleName")]
        public string RoleName
        {
            get { return _RoleName; }
            set
            {
                this.OnPropertyValueChange("RoleName");
                this._RoleName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RoleCode")]
        public string RoleCode
        {
            get { return _RoleCode; }
            set
            {
                this.OnPropertyValueChange("RoleCode");
                this._RoleCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Birthday")]
        public DateTime? Birthday
        {
            get { return _Birthday; }
            set
            {
                this.OnPropertyValueChange("Birthday");
                this._Birthday = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("PhoneNumber")]
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set
            {
                this.OnPropertyValueChange("PhoneNumber");
                this._PhoneNumber = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("IDCard")]
        public string IDCard
        {
            get { return _IDCard; }
            set
            {
                this.OnPropertyValueChange("IDCard");
                this._IDCard = value;
            }
        }
        /// <summary>
        /// 
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
        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        [Field("HosName")]
        public string HosName
        {
            get { return _HosName; }
            set
            {
                this.OnPropertyValueChange("HosName");
                this._HosName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("HosCode")]
        public string HosCode
        {
            get { return _HosCode; }
            set
            {
                this.OnPropertyValueChange("HosCode");
                this._HosCode = value;
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
                _.Code,
                _.Name,
                _.Password,
                _.UserType,
                _.UserNature,
                _.EducationId,
                _.EducationValue,
                _.TitleId,
                _.TitleLevel,
                _.TitleName,
                _.DefaultRoleId,
                _.DefaultRoleName,
                _.DefaultRoleCode,
                _.RoleId,
                _.RoleName,
                _.RoleCode,
                _.Birthday,
                _.PhoneNumber,
                _.IDCard,
                _.DataStatus,
                _.No,
                _.SearchCode,
                _.HosId,
                _.HosName,
                _.HosCode,
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
                this._Name,
                this._Password,
                this._UserType,
                this._UserNature,
                this._EducationId,
                this._EducationValue,
                this._TitleId,
                this._TitleLevel,
                this._TitleName,
                this._DefaultRoleId,
                this._DefaultRoleName,
                this._DefaultRoleCode,
                this._RoleId,
                this._RoleName,
                this._RoleCode,
                this._Birthday,
                this._PhoneNumber,
                this._IDCard,
                this._DataStatus,
                this._No,
                this._SearchCode,
                this._HosId,
                this._HosName,
                this._HosCode,
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
            public readonly static Field All = new Field("*", "View_User");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Id = new Field("Id", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Code = new Field("Code", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Name = new Field("Name", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Password = new Field("Password", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UserType = new Field("UserType", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UserNature = new Field("UserNature", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field EducationId = new Field("EducationId", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field EducationValue = new Field("EducationValue", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TitleId = new Field("TitleId", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TitleLevel = new Field("TitleLevel", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TitleName = new Field("TitleName", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DefaultRoleId = new Field("DefaultRoleId", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DefaultRoleName = new Field("DefaultRoleName", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DefaultRoleCode = new Field("DefaultRoleCode", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RoleId = new Field("RoleId", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RoleName = new Field("RoleName", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RoleCode = new Field("RoleCode", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Birthday = new Field("Birthday", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PhoneNumber = new Field("PhoneNumber", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IDCard = new Field("IDCard", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DataStatus = new Field("DataStatus", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field No = new Field("No", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SearchCode = new Field("SearchCode", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field HosId = new Field("HosId", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field HosName = new Field("HosName", "View_User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field HosCode = new Field("HosCode", "View_User", "");
        }
        #endregion
    }
}