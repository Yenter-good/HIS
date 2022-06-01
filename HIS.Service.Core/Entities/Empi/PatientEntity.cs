using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class PatientEntity
    {
        protected long id;
        protected long creatorUserId;
        protected DateTime creationTime;
        protected long lastModifierUserId;
        protected DateTime lastModificationTime;
        protected int dataStatus;
        protected int no;
        protected string name;
        protected int sexCode;
        protected DateTime birthday;
        protected string idCard;
        protected int kinship;
        protected string phoneNo;
        protected string address;
        protected string addrProvinceCode;
        protected string addrCityCode;
        protected string addrCountyCode;
        protected string addrProvinceName;
        protected string addrCityName;
        protected string addrCountyName;
        protected int isMarried;
        protected string bloodType;
        protected string workUnit;
        protected string workUnitPhoneNo;
        protected string workUnitAddress;
        protected string patientNational;
        protected string native;
        protected string email;
        protected long educationId;
        protected double height;
        protected double weight;
        protected string searchCode;
        protected string empid;
        protected int registeredChannels;
        protected string contactName;
        protected long professionalId;

        //ID
        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        //创建人编号 当前用户ID
        public long CreatorUserId
        {
            get { return creatorUserId; }
            set { creatorUserId = value; }
        }
        //创建时间 默认为当前时间
        public DateTime CreationTime
        {
            get { return creationTime; }
            set { creationTime = value; }
        }
        //最后修改人编号
        public long LastModifierUserId
        {
            get { return lastModifierUserId; }
            set { lastModifierUserId = value; }
        }
        //最后修改时间 默认为当前时间
        public DateTime LastModificationTime
        {
            get { return lastModificationTime; }
            set { lastModificationTime = value; }
        }
        //数据状态 数据状态 0失效 1启用
        public int DataStatus
        {
            get { return dataStatus; }
            set { dataStatus = value; }
        }
        //排序号
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        //患者姓名
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //性别代码
        public int SexCode
        {
            get { return sexCode; }
            set { sexCode = value; }
        }
        //生日
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        //身份证号
        public string IdCard
        {
            get { return idCard; }
            set { idCard = value; }
        }
        //亲属关系 亲属关系  0、本人 1、子女 2、父母 3、朋友 4、其他   如果父母持本人身份证给子女注册则必须传1 否则身份证重复不许注册 且性别出生日期可能与实际情况不同
        public int Kinship
        {
            get { return kinship; }
            set { kinship = value; }
        }
        //联系电话
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }
        //住址（全）
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        //住址 省 住址 省 code
        public string AddrProvinceCode
        {
            get { return addrProvinceCode; }
            set { addrProvinceCode = value; }
        }
        //住址 市 住址 市 code
        public string AddrCityCode
        {
            get { return addrCityCode; }
            set { addrCityCode = value; }
        }
        //住址 区县 住址 区县 code
        public string AddrCountyCode
        {
            get { return addrCountyCode; }
            set { addrCountyCode = value; }
        }
        //住址 省 名称
        public string AddrProvinceName
        {
            get { return addrProvinceName; }
            set { addrProvinceName = value; }
        }
        //住址 市 名称
        public string AddrCityName
        {
            get { return addrCityName; }
            set { addrCityName = value; }
        }
        //住址 区县 名称
        public string AddrCountyName
        {
            get { return addrCountyName; }
            set { addrCountyName = value; }
        }
        //是否结婚 是否结婚 0否 1是
        public int IsMarried
        {
            get { return isMarried; }
            set { isMarried = value; }
        }
        public string BloodType
        {
            get { return bloodType; }
            set { bloodType = value; }
        }
        public string WorkUnit
        {
            get { return workUnit; }
            set { workUnit = value; }
        }
        public string WorkUnitPhoneNo
        {
            get { return workUnitPhoneNo; }
            set { workUnitPhoneNo = value; }
        }
        public string WorkUnitAddress
        {
            get { return workUnitAddress; }
            set { workUnitAddress = value; }
        }
        public string PatientNational
        {
            get { return patientNational; }
            set { patientNational = value; }
        }
        public string Native
        {
            get { return native; }
            set { native = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        //学历ID
        public long EducationId
        {
            get { return educationId; }
            set { educationId = value; }
        }
        //身高
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        //体重
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        //检索码
        public string SearchCode
        {
            get { return searchCode; }
            set { searchCode = value; }
        }
        //院内平台ID
        public string EMPID
        {
            get { return empid; }
            set { empid = value; }
        }
        //1、门诊窗口 1、门诊窗口 2、住院窗口 3、门诊服务台 4、自助机 5、微信小程序
        public int RegisteredChannels
        {
            get { return registeredChannels; }
            set { registeredChannels = value; }
        }
        public long ProfessionalId
        {
            get { return professionalId; }
            set { professionalId = value; }
        }
        
        //监护人姓名
        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }
    }
}
