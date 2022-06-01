using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 药品厂商实体
    /// </summary>
    public class MerchantsEntity
    {
        /// <summary>
        /// Id
        /// </summary>
		public long Id
		{
			get;
			set;
		}
		/// <summary>
		/// 厂商名称
		/// </summary>
		public string Name
		{
			get;
			set;
		}
		/// <summary>
		/// 法人
		/// </summary>
		public string LegalPerson
		{
			get;
			set;
		}
		/// <summary>
		/// 生产经营地址
		/// </summary>
		public string Address
		{
			get;
			set;
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string PhoneNo
		{
			get;
			set;
		}
		/// <summary>
		/// 营业执照
		/// </summary>
		public string BusinessLicense
		{
			get;
			set;
		}
		/// <summary>
		/// 厂商类型  
        /// 1、生产厂家 
        /// 2、供应厂商
		/// </summary>
		public MerchantType Type
		{
			get;
			set;
		}
        /// <summary>
        /// 拼音码
        /// </summary>
		public string SearchCode
		{
			get;
			set;
		}
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WubiCode
        {
            get;
            set;
        }
        /// <summary>
        /// 数据状态
        /// </summary>
        public DataStatus DataStatus
        {
            get;
            set;
        }
        /// <summary>
        /// 顺序号
        /// </summary>
        public int No
        {
            get;
            set;
        }
	}
}
