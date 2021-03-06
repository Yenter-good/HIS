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
    /// 实体类Dic_Advice。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Dic_Advice")]
    [Serializable]
    public partial class Dic_Advice : Entity
    {
        #region Model
		private long _Id;
		private long _HosId;
		private int _DataStatus;
		private int _NO;
		private long _CreatorUserId;
		private DateTime _CreationTime;
		private long _LastModifierUserId;
		private DateTime _LastModificationTime;
		private string _Code;
		private string _Name;
		private decimal? _Price;
		private string _SearchCode;
		private string _WubiCode;
		private int? _Type;
		private long? _SampleId;
		private long? _BuretId;
		private long? _PartId;
		private long? _ModalityId;
		private bool _OFlag;
		private bool _IFlag;
		private bool _SFlag;
		private bool _MFlag;

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
		/// 医疗机构ID
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
		/// 状态 状态 0停用 1启用 2作废
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
		/// 序号
		/// </summary>
		[Field("NO")]
		public int NO
		{
			get{ return _NO; }
			set
			{
				this.OnPropertyValueChange("NO");
				this._NO = value;
			}
		}
		/// <summary>
		/// 创建者ID
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
		/// 创建时间
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
		/// 最后的修改者ID
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
		/// 最后的修改时间
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
		/// 医嘱名称
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
		/// 组合价格
		/// </summary>
		[Field("Price")]
		public decimal? Price
		{
			get{ return _Price; }
			set
			{
				this.OnPropertyValueChange("Price");
				this._Price = value;
			}
		}
		/// <summary>
		/// 拼音码
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
		/// 组合项目类型 医嘱项目类型  1检验 2检查 3处置 4护理 5膳食 6嘱托 7手术 8其他
		/// </summary>
		[Field("Type")]
		public int? Type
		{
			get{ return _Type; }
			set
			{
				this.OnPropertyValueChange("Type");
				this._Type = value;
			}
		}
		/// <summary>
		/// 标本类型 （检验类型时填写）标本类型
		/// </summary>
		[Field("SampleId")]
		public long? SampleId
		{
			get{ return _SampleId; }
			set
			{
				this.OnPropertyValueChange("SampleId");
				this._SampleId = value;
			}
		}
		/// <summary>
		/// 试管类型 （检验类型时填写）试管类型
		/// </summary>
		[Field("BuretId")]
		public long? BuretId
		{
			get{ return _BuretId; }
			set
			{
				this.OnPropertyValueChange("BuretId");
				this._BuretId = value;
			}
		}
		/// <summary>
		/// 检查部位 （检查类型时填写）检查部位
		/// </summary>
		[Field("PartId")]
		public long? PartId
		{
			get{ return _PartId; }
			set
			{
				this.OnPropertyValueChange("PartId");
				this._PartId = value;
			}
		}
		/// <summary>
		/// 设备类型 （检查类型时填写）设备类型
		/// </summary>
		[Field("ModalityId")]
		public long? ModalityId
		{
			get{ return _ModalityId; }
			set
			{
				this.OnPropertyValueChange("ModalityId");
				this._ModalityId = value;
			}
		}
		/// <summary>
		/// 门诊可用标志
		/// </summary>
		[Field("OFlag")]
		public bool OFlag
		{
			get{ return _OFlag; }
			set
			{
				this.OnPropertyValueChange("OFlag");
				this._OFlag = value;
			}
		}
		/// <summary>
		/// 住院可用标志
		/// </summary>
		[Field("IFlag")]
		public bool IFlag
		{
			get{ return _IFlag; }
			set
			{
				this.OnPropertyValueChange("IFlag");
				this._IFlag = value;
			}
		}
		/// <summary>
		/// 手术室可用标志
		/// </summary>
		[Field("SFlag")]
		public bool SFlag
		{
			get{ return _SFlag; }
			set
			{
				this.OnPropertyValueChange("SFlag");
				this._SFlag = value;
			}
		}
		/// <summary>
		/// 医技可用标志
		/// </summary>
		[Field("MFlag")]
		public bool MFlag
		{
			get{ return _MFlag; }
			set
			{
				this.OnPropertyValueChange("MFlag");
				this._MFlag = value;
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
				_.DataStatus,
				_.NO,
				_.CreatorUserId,
				_.CreationTime,
				_.LastModifierUserId,
				_.LastModificationTime,
				_.Code,
				_.Name,
				_.Price,
				_.SearchCode,
				_.WubiCode,
				_.Type,
				_.SampleId,
				_.BuretId,
				_.PartId,
				_.ModalityId,
				_.OFlag,
				_.IFlag,
				_.SFlag,
				_.MFlag,
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
				this._DataStatus,
				this._NO,
				this._CreatorUserId,
				this._CreationTime,
				this._LastModifierUserId,
				this._LastModificationTime,
				this._Code,
				this._Name,
				this._Price,
				this._SearchCode,
				this._WubiCode,
				this._Type,
				this._SampleId,
				this._BuretId,
				this._PartId,
				this._ModalityId,
				this._OFlag,
				this._IFlag,
				this._SFlag,
				this._MFlag,
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
			public readonly static Field All = new Field("*", "Dic_Advice");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field Id = new Field("Id", "Dic_Advice", "ID");
            /// <summary>
			/// 医疗机构ID
			/// </summary>
			public readonly static Field HosId = new Field("HosId", "Dic_Advice", "医疗机构ID");
            /// <summary>
			/// 状态 状态 0停用 1启用 2作废
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus", "Dic_Advice", "状态 状态 0停用 1启用 2作废");
            /// <summary>
			/// 序号
			/// </summary>
			public readonly static Field NO = new Field("NO", "Dic_Advice", "序号");
            /// <summary>
			/// 创建者ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId", "Dic_Advice", "创建者ID");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime", "Dic_Advice", "创建时间");
            /// <summary>
			/// 最后的修改者ID
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId", "Dic_Advice", "最后的修改者ID");
            /// <summary>
			/// 最后的修改时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime", "Dic_Advice", "最后的修改时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Code = new Field("Code", "Dic_Advice", "");
            /// <summary>
			/// 医嘱名称
			/// </summary>
			public readonly static Field Name = new Field("Name", "Dic_Advice", "医嘱名称");
            /// <summary>
			/// 组合价格
			/// </summary>
			public readonly static Field Price = new Field("Price", "Dic_Advice", "组合价格");
            /// <summary>
			/// 拼音码
			/// </summary>
			public readonly static Field SearchCode = new Field("SearchCode", "Dic_Advice", "拼音码");
            /// <summary>
			/// 五笔码
			/// </summary>
			public readonly static Field WubiCode = new Field("WubiCode", "Dic_Advice", "五笔码");
            /// <summary>
			/// 组合项目类型 医嘱项目类型  1检验 2检查 3处置 4护理 5膳食 6嘱托 7手术 8其他
			/// </summary>
			public readonly static Field Type = new Field("Type", "Dic_Advice", "组合项目类型 医嘱项目类型  1检验 2检查 3处置 4护理 5膳食 6嘱托 7手术 8其他");
            /// <summary>
			/// 标本类型 （检验类型时填写）标本类型
			/// </summary>
			public readonly static Field SampleId = new Field("SampleId", "Dic_Advice", "标本类型 （检验类型时填写）标本类型");
            /// <summary>
			/// 试管类型 （检验类型时填写）试管类型
			/// </summary>
			public readonly static Field BuretId = new Field("BuretId", "Dic_Advice", "试管类型 （检验类型时填写）试管类型");
            /// <summary>
			/// 检查部位 （检查类型时填写）检查部位
			/// </summary>
			public readonly static Field PartId = new Field("PartId", "Dic_Advice", "检查部位 （检查类型时填写）检查部位");
            /// <summary>
			/// 设备类型 （检查类型时填写）设备类型
			/// </summary>
			public readonly static Field ModalityId = new Field("ModalityId", "Dic_Advice", "设备类型 （检查类型时填写）设备类型");
            /// <summary>
			/// 门诊可用标志
			/// </summary>
			public readonly static Field OFlag = new Field("OFlag", "Dic_Advice", "门诊可用标志");
            /// <summary>
			/// 住院可用标志
			/// </summary>
			public readonly static Field IFlag = new Field("IFlag", "Dic_Advice", "住院可用标志");
            /// <summary>
			/// 手术室可用标志
			/// </summary>
			public readonly static Field SFlag = new Field("SFlag", "Dic_Advice", "手术室可用标志");
            /// <summary>
			/// 医技可用标志
			/// </summary>
			public readonly static Field MFlag = new Field("MFlag", "Dic_Advice", "医技可用标志");
        }
        #endregion
	}
}