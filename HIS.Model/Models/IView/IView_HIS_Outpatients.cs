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
    /// 实体类IView_HIS_Outpatients。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("IView_HIS_Outpatients")]
    [Serializable]
    public partial class IView_HIS_Outpatients : Entity
    {
        #region Model
        private long _HosId;
        private string _OutpatientNo;
        private DateTime _RegisterTime;
        private int _Status;
        private bool _ChargeFlag;
        private string _PatientName;
        private int _Gender;
        private DateTime? _Birthday;
        private string _Age;
        private long _DeptId;
        private string _DeptName;
        private string _DeptCode;
        private long _DoctorId;
        private string _DoctorName;
        private string _DoctorCode;
        private int _OrderNumber;
        private string _Address;
        private string _Phone;
        private string _Category;
        private bool _EmerencyFlag;
        private int _PayType;
        private string _IDCard;
        private long _FirstAcceptDoctorId;
        private string _FirstAcceptDoctorName;
        private string _FirstAcceptDoctorCode;
        private string _SearchCode;
        private string _WubiCode;
        private string _CardNo;

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
        [Field("OutpatientNo")]
        public string OutpatientNo
        {
            get { return _OutpatientNo; }
            set
            {
                this.OnPropertyValueChange("OutpatientNo");
                this._OutpatientNo = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RegisterTime")]
        public DateTime RegisterTime
        {
            get { return _RegisterTime; }
            set
            {
                this.OnPropertyValueChange("RegisterTime");
                this._RegisterTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Status")]
        public int Status
        {
            get { return _Status; }
            set
            {
                this.OnPropertyValueChange("Status");
                this._Status = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ChargeFlag")]
        public bool ChargeFlag
        {
            get { return _ChargeFlag; }
            set
            {
                this.OnPropertyValueChange("ChargeFlag");
                this._ChargeFlag = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("PatientName")]
        public string PatientName
        {
            get { return _PatientName; }
            set
            {
                this.OnPropertyValueChange("PatientName");
                this._PatientName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Gender")]
        public int Gender
        {
            get { return _Gender; }
            set
            {
                this.OnPropertyValueChange("Gender");
                this._Gender = value;
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
        [Field("Age")]
        public string Age
        {
            get { return _Age; }
            set
            {
                this.OnPropertyValueChange("Age");
                this._Age = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("DeptId")]
        public long DeptId
        {
            get { return _DeptId; }
            set
            {
                this.OnPropertyValueChange("DeptId");
                this._DeptId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("DeptName")]
        public string DeptName
        {
            get { return _DeptName; }
            set
            {
                this.OnPropertyValueChange("DeptName");
                this._DeptName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("DeptCode")]
        public string DeptCode
        {
            get { return _DeptCode; }
            set
            {
                this.OnPropertyValueChange("DeptCode");
                this._DeptCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("DoctorId")]
        public long DoctorId
        {
            get { return _DoctorId; }
            set
            {
                this.OnPropertyValueChange("DoctorId");
                this._DoctorId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("DoctorName")]
        public string DoctorName
        {
            get { return _DoctorName; }
            set
            {
                this.OnPropertyValueChange("DoctorName");
                this._DoctorName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("DoctorCode")]
        public string DoctorCode
        {
            get { return _DoctorCode; }
            set
            {
                this.OnPropertyValueChange("DoctorCode");
                this._DoctorCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("OrderNumber")]
        public int OrderNumber
        {
            get { return _OrderNumber; }
            set
            {
                this.OnPropertyValueChange("OrderNumber");
                this._OrderNumber = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Address")]
        public string Address
        {
            get { return _Address; }
            set
            {
                this.OnPropertyValueChange("Address");
                this._Address = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Phone")]
        public string Phone
        {
            get { return _Phone; }
            set
            {
                this.OnPropertyValueChange("Phone");
                this._Phone = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Category")]
        public string Category
        {
            get { return _Category; }
            set
            {
                this.OnPropertyValueChange("Category");
                this._Category = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("EmerencyFlag")]
        public bool EmerencyFlag
        {
            get { return _EmerencyFlag; }
            set
            {
                this.OnPropertyValueChange("EmerencyFlag");
                this._EmerencyFlag = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("PayType")]
        public int PayType
        {
            get { return _PayType; }
            set
            {
                this.OnPropertyValueChange("PayType");
                this._PayType = value;
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
        [Field("FirstAcceptDoctorId")]
        public long FirstAcceptDoctorId
        {
            get { return _FirstAcceptDoctorId; }
            set
            {
                this.OnPropertyValueChange("FirstAcceptDoctorId");
                this._FirstAcceptDoctorId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("FirstAcceptDoctorName")]
        public string FirstAcceptDoctorName
        {
            get { return _FirstAcceptDoctorName; }
            set
            {
                this.OnPropertyValueChange("FirstAcceptDoctorName");
                this._FirstAcceptDoctorName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("FirstAcceptDoctorCode")]
        public string FirstAcceptDoctorCode
        {
            get { return _FirstAcceptDoctorCode; }
            set
            {
                this.OnPropertyValueChange("FirstAcceptDoctorCode");
                this._FirstAcceptDoctorCode = value;
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
        [Field("WubiCode")]
        public string WubiCode
        {
            get { return _WubiCode; }
            set
            {
                this.OnPropertyValueChange("WubiCode");
                this._WubiCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("CardNo")]
        public string CardNo
        {
            get { return _CardNo; }
            set
            {
                this.OnPropertyValueChange("CardNo");
                this._CardNo = value;
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
                _.HosId,
                _.OutpatientNo,
                _.RegisterTime,
                _.Status,
                _.ChargeFlag,
                _.PatientName,
                _.Gender,
                _.Birthday,
                _.Age,
                _.DeptId,
                _.DeptName,
                _.DeptCode,
                _.DoctorId,
                _.DoctorName,
                _.DoctorCode,
                _.OrderNumber,
                _.Address,
                _.Phone,
                _.Category,
                _.EmerencyFlag,
                _.PayType,
                _.IDCard,
                _.FirstAcceptDoctorId,
                _.FirstAcceptDoctorName,
                _.FirstAcceptDoctorCode,
                _.SearchCode,
                _.WubiCode,
                _.CardNo,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._HosId,
                this._OutpatientNo,
                this._RegisterTime,
                this._Status,
                this._ChargeFlag,
                this._PatientName,
                this._Gender,
                this._Birthday,
                this._Age,
                this._DeptId,
                this._DeptName,
                this._DeptCode,
                this._DoctorId,
                this._DoctorName,
                this._DoctorCode,
                this._OrderNumber,
                this._Address,
                this._Phone,
                this._Category,
                this._EmerencyFlag,
                this._PayType,
                this._IDCard,
                this._FirstAcceptDoctorId,
                this._FirstAcceptDoctorName,
                this._FirstAcceptDoctorCode,
                this._SearchCode,
                this._WubiCode,
                this._CardNo,
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
            public readonly static Field All = new Field("*", "IView_HIS_Outpatients");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OutpatientNo = new Field("OutpatientNo", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RegisterTime = new Field("RegisterTime", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Status = new Field("Status", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ChargeFlag = new Field("ChargeFlag", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PatientName = new Field("PatientName", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Gender = new Field("Gender", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Birthday = new Field("Birthday", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Age = new Field("Age", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptId = new Field("DeptId", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DoctorId = new Field("DoctorId", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DoctorName = new Field("DoctorName", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DoctorCode = new Field("DoctorCode", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OrderNumber = new Field("OrderNumber", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Address = new Field("Address", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Phone = new Field("Phone", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Category = new Field("Category", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EmerencyFlag = new Field("EmerencyFlag", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PayType = new Field("PayType", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IDCard = new Field("IDCard", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FirstAcceptDoctorId = new Field("FirstAcceptDoctorId", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FirstAcceptDoctorName = new Field("FirstAcceptDoctorName", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FirstAcceptDoctorCode = new Field("FirstAcceptDoctorCode", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SearchCode = new Field("SearchCode", "IView_HIS_Outpatients", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field WubiCode = new Field("WubiCode", "IView_HIS_Outpatients", "");
            /// <summary>
            /// 
            /// </summary>
			public readonly static Field CardNo = new Field("CardNo", "IView_HIS_Outpatients", "");
        }
        #endregion
    }
}