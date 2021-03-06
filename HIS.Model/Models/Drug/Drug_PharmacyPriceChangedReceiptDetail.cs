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
	/// 实体类Drug_PharmacyPriceChangedReceiptDetail 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Drug_PharmacyPriceChangedReceiptDetail")]
	[Serializable]
	public partial class Drug_PharmacyPriceChangedReceiptDetail : Entity 
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
		private int _No;
		private string _ClassCode;
		private string _SpecificationCode;
		private decimal _OldPrice;
		private decimal _NewPrice;
		private int _BigQuantity;
		private int _SmallQuantity;
		private long _ReceiptId;
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
		/// 创建人编号 当前用户ID
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
		/// 创建时间 默认为当前时间
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
		/// 最后修改人编号
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
		/// 最后修改时间 默认为当前时间
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
		/// 删除人编号
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
		/// 数据状态 0失效 1启用
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
		/// 排序号
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
		/// 药典编码
		/// </summary>
		public string ClassCode
		{
			get{ return _ClassCode; }
			set
			{
				this.OnPropertyValueChange(_.ClassCode,_ClassCode,value);
				this._ClassCode=value;
			}
		}
		/// <summary>
		/// 规格编码
		/// </summary>
		public string SpecificationCode
		{
			get{ return _SpecificationCode; }
			set
			{
				this.OnPropertyValueChange(_.SpecificationCode,_SpecificationCode,value);
				this._SpecificationCode=value;
			}
		}
		/// <summary>
		/// 调价前的单价
		/// </summary>
		public decimal OldPrice
		{
			get{ return _OldPrice; }
			set
			{
				this.OnPropertyValueChange(_.OldPrice,_OldPrice,value);
				this._OldPrice=value;
			}
		}
		/// <summary>
		/// 调价后的单价
		/// </summary>
		public decimal NewPrice
		{
			get{ return _NewPrice; }
			set
			{
				this.OnPropertyValueChange(_.NewPrice,_NewPrice,value);
				this._NewPrice=value;
			}
		}
		/// <summary>
		/// 受到影响的大包装数量
		/// </summary>
		public int BigQuantity
		{
			get{ return _BigQuantity; }
			set
			{
				this.OnPropertyValueChange(_.BigQuantity,_BigQuantity,value);
				this._BigQuantity=value;
			}
		}
		/// <summary>
		/// 受影响的小包装数量
		/// </summary>
		public int SmallQuantity
		{
			get{ return _SmallQuantity; }
			set
			{
				this.OnPropertyValueChange(_.SmallQuantity,_SmallQuantity,value);
				this._SmallQuantity=value;
			}
		}
		/// <summary>
		/// 单据Id
		/// </summary>
		public long ReceiptId
		{
			get{ return _ReceiptId; }
			set
			{
				this.OnPropertyValueChange(_.ReceiptId,_ReceiptId,value);
				this._ReceiptId=value;
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
				_.CreatorUserId,
				_.CreationTime,
				_.LastModifierUserId,
				_.LastModificationTime,
				_.DeleterUserId,
				_.DeletionTime,
				_.DataStatus,
				_.No,
				_.ClassCode,
				_.SpecificationCode,
				_.OldPrice,
				_.NewPrice,
				_.BigQuantity,
				_.SmallQuantity,
				_.ReceiptId};
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
				this._ClassCode,
				this._SpecificationCode,
				this._OldPrice,
				this._NewPrice,
				this._BigQuantity,
				this._SmallQuantity,
				this._ReceiptId};
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
			public readonly static Field All = new Field("*","Drug_PharmacyPriceChangedReceiptDetail");
			/// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Id = new Field("Id","Drug_PharmacyPriceChangedReceiptDetail","编号");
			/// <summary>
			/// 创建人编号 当前用户ID
			/// </summary>
			public readonly static Field CreatorUserId = new Field("CreatorUserId","Drug_PharmacyPriceChangedReceiptDetail","创建人编号 当前用户ID");
			/// <summary>
			/// 创建时间 默认为当前时间
			/// </summary>
			public readonly static Field CreationTime = new Field("CreationTime","Drug_PharmacyPriceChangedReceiptDetail","创建时间 默认为当前时间");
			/// <summary>
			/// 最后修改人编号
			/// </summary>
			public readonly static Field LastModifierUserId = new Field("LastModifierUserId","Drug_PharmacyPriceChangedReceiptDetail","最后修改人编号");
			/// <summary>
			/// 最后修改时间 默认为当前时间
			/// </summary>
			public readonly static Field LastModificationTime = new Field("LastModificationTime","Drug_PharmacyPriceChangedReceiptDetail","最后修改时间 默认为当前时间");
			/// <summary>
			/// 删除人编号
			/// </summary>
			public readonly static Field DeleterUserId = new Field("DeleterUserId","Drug_PharmacyPriceChangedReceiptDetail","删除人编号");
			/// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DeletionTime = new Field("DeletionTime","Drug_PharmacyPriceChangedReceiptDetail","删除时间");
			/// <summary>
			/// 数据状态 0失效 1启用
			/// </summary>
			public readonly static Field DataStatus = new Field("DataStatus","Drug_PharmacyPriceChangedReceiptDetail","数据状态 0失效 1启用");
			/// <summary>
			/// 排序号
			/// </summary>
			public readonly static Field No = new Field("No","Drug_PharmacyPriceChangedReceiptDetail","排序号");
			/// <summary>
			/// 药典编码
			/// </summary>
			public readonly static Field ClassCode = new Field("ClassCode","Drug_PharmacyPriceChangedReceiptDetail","药典编码");
			/// <summary>
			/// 规格编码
			/// </summary>
			public readonly static Field SpecificationCode = new Field("SpecificationCode","Drug_PharmacyPriceChangedReceiptDetail","规格编码");
			/// <summary>
			/// 调价前的单价
			/// </summary>
			public readonly static Field OldPrice = new Field("OldPrice","Drug_PharmacyPriceChangedReceiptDetail","调价前的单价");
			/// <summary>
			/// 调价后的单价
			/// </summary>
			public readonly static Field NewPrice = new Field("NewPrice","Drug_PharmacyPriceChangedReceiptDetail","调价后的单价");
			/// <summary>
			/// 受到影响的大包装数量
			/// </summary>
			public readonly static Field BigQuantity = new Field("BigQuantity","Drug_PharmacyPriceChangedReceiptDetail","受到影响的大包装数量");
			/// <summary>
			/// 受影响的小包装数量
			/// </summary>
			public readonly static Field SmallQuantity = new Field("SmallQuantity","Drug_PharmacyPriceChangedReceiptDetail","受影响的小包装数量");
			/// <summary>
			/// 单据Id
			/// </summary>
			public readonly static Field ReceiptId = new Field("ReceiptId","Drug_PharmacyPriceChangedReceiptDetail","单据Id");
		}
		#endregion


	}
}

