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
    /// 实体类View_PriceChangedReceipt。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("View_PriceChangedReceipt")]
    [Serializable]
    public partial class View_PriceChangedReceipt : Entity
    {
        #region Model
        private long _HosId;
        private long _Id;
        private string _ReceiptCode;
        private DateTime _CreationTime;
        private long _CreatorUserId;
        private string _CreatorUserName;
        private string _CreatorUserCode;
        private DateTime? _AuditTime;
        private long? _AuditUserId;
        private string _AuditUserName;
        private string _AuditUserCode;
        private bool _AuditStatus;
        private long _DeptId;
        private string _DeptName;
        private string _DeptCode;
        private DateTime _PlanEffectTime;
        private DateTime? _ActualEffectTime;
        private string _Memo;

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
        [Field("ReceiptCode")]
        public string ReceiptCode
        {
            get { return _ReceiptCode; }
            set
            {
                this.OnPropertyValueChange("ReceiptCode");
                this._ReceiptCode = value;
            }
        }
        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        [Field("CreatorUserName")]
        public string CreatorUserName
        {
            get { return _CreatorUserName; }
            set
            {
                this.OnPropertyValueChange("CreatorUserName");
                this._CreatorUserName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("CreatorUserCode")]
        public string CreatorUserCode
        {
            get { return _CreatorUserCode; }
            set
            {
                this.OnPropertyValueChange("CreatorUserCode");
                this._CreatorUserCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("AuditTime")]
        public DateTime? AuditTime
        {
            get { return _AuditTime; }
            set
            {
                this.OnPropertyValueChange("AuditTime");
                this._AuditTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("AuditUserId")]
        public long? AuditUserId
        {
            get { return _AuditUserId; }
            set
            {
                this.OnPropertyValueChange("AuditUserId");
                this._AuditUserId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("AuditUserName")]
        public string AuditUserName
        {
            get { return _AuditUserName; }
            set
            {
                this.OnPropertyValueChange("AuditUserName");
                this._AuditUserName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("AuditUserCode")]
        public string AuditUserCode
        {
            get { return _AuditUserCode; }
            set
            {
                this.OnPropertyValueChange("AuditUserCode");
                this._AuditUserCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("AuditStatus")]
        public bool AuditStatus
        {
            get { return _AuditStatus; }
            set
            {
                this.OnPropertyValueChange("AuditStatus");
                this._AuditStatus = value;
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
        [Field("PlanEffectTime")]
        public DateTime PlanEffectTime
        {
            get { return _PlanEffectTime; }
            set
            {
                this.OnPropertyValueChange("PlanEffectTime");
                this._PlanEffectTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ActualEffectTime")]
        public DateTime? ActualEffectTime
        {
            get { return _ActualEffectTime; }
            set
            {
                this.OnPropertyValueChange("ActualEffectTime");
                this._ActualEffectTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Memo")]
        public string Memo
        {
            get { return _Memo; }
            set
            {
                this.OnPropertyValueChange("Memo");
                this._Memo = value;
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
                _.Id,
                _.ReceiptCode,
                _.CreationTime,
                _.CreatorUserId,
                _.CreatorUserName,
                _.CreatorUserCode,
                _.AuditTime,
                _.AuditUserId,
                _.AuditUserName,
                _.AuditUserCode,
                _.AuditStatus,
                _.DeptId,
                _.DeptName,
                _.DeptCode,
                _.PlanEffectTime,
                _.ActualEffectTime,
                _.Memo,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._HosId,
                this._Id,
                this._ReceiptCode,
                this._CreationTime,
                this._CreatorUserId,
                this._CreatorUserName,
                this._CreatorUserCode,
                this._AuditTime,
                this._AuditUserId,
                this._AuditUserName,
                this._AuditUserCode,
                this._AuditStatus,
                this._DeptId,
                this._DeptName,
                this._DeptCode,
                this._PlanEffectTime,
                this._ActualEffectTime,
                this._Memo,
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
            public readonly static Field All = new Field("*", "View_PriceChangedReceipt");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ReceiptCode = new Field("ReceiptCode", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreatorUserName = new Field("CreatorUserName", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreatorUserCode = new Field("CreatorUserCode", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditTime = new Field("AuditTime", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditUserId = new Field("AuditUserId", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditUserName = new Field("AuditUserName", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditUserCode = new Field("AuditUserCode", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AuditStatus = new Field("AuditStatus", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptId = new Field("DeptId", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PlanEffectTime = new Field("PlanEffectTime", "View_PriceChangedReceipt", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ActualEffectTime = new Field("ActualEffectTime", "View_PriceChangedReceipt", "");
            /// <summary>
            /// 
            /// </summary>
			public readonly static Field Memo = new Field("Memo", "View_PriceChangedReceipt", "");
        }
        #endregion
    }
}