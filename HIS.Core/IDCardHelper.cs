using HIS.Service.Core.Entities;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HIS.Core
{
    public class IDCardHelper : Singleton<IDCardHelper>
    {
        private List<LongItem> _sheng = new List<LongItem>();
        private List<LongItem> _shi = new List<LongItem>();
        private List<LongItem> _xian = new List<LongItem>();

        public void Configuration(List<LongItem> sheng, List<LongItem> shi, List<LongItem> xian)
        {
            _sheng = sheng;
            _shi = shi;
            _xian = xian;
        }

        /// <summary>
        /// 验证身份证有效性
        /// </summary>
        /// <param name="idcard"></param>
        /// <returns></returns>
        public DataResult Validation(string idcard)
        {
            if (idcard.Length == 18)
                return ValidationIDCard18(idcard);
            else if (idcard.Length == 15)
                return ValidationIDCard15(idcard);
            else
                return DataResult.Fault("身份证长度验证失败");
        }
        /// <summary>
        /// 获取身份证属性
        /// </summary>
        /// <param name="idcard"></param>
        /// <returns></returns>
        public IDCardProperties GetProperties(string idcard)
        {
            IDCardProperties result = new IDCardProperties();

            DateTime time = new DateTime();
            if (idcard.Length == 18)
            {
                string birth = idcard.Substring(6, 8).Insert(6, "-").Insert(4, "-");
                DateTime.TryParse(birth, out time);
                var genderCode = idcard.Substring(16, 1).AsInt(-1);
                if (genderCode == -1)
                {
                    result.Gender = 9;
                    result.GenderText = "其他";
                }
                else if (genderCode % 2 == 0)
                {
                    result.Gender = 2;
                    result.GenderText = "女";
                }
                else
                {
                    result.Gender = 1;
                    result.GenderText = "男";
                }
            }
            else if (idcard.Length == 15)
            {
                string birth = idcard.Substring(6, 6).Insert(4, "-").Insert(2, "-");
                DateTime.TryParse(birth, out time);
                var genderCode = idcard.Last().ToString().AsInt(-1);
                if (genderCode == -1)
                {
                    result.Gender = 9;
                    result.GenderText = "其他";
                }
                else if (genderCode % 2 == 0)
                {
                    result.Gender = 2;
                    result.GenderText = "女";
                }
                else
                {
                    result.Gender = 1;
                    result.GenderText = "男";
                }
            }
            else
                return null;

            result.BirthDay = time;

            string shengCode = idcard.Substring(0, 2);
            string shiCode = idcard.Substring(0, 4);
            string xianCode = idcard.Substring(0, 6);
            if (_sheng != null)
                result.Sheng = _sheng.Find(p => p.Code == shengCode);
            if (_shi != null)
                result.Shi = _shi.Find(p => p.Code == shiCode);
            if (_xian != null)
                result.Xian = _xian.Find(p => p.Code == xianCode);

            return result;
        }

        private DataResult ValidationIDCard18(string idcard)
        {
            long n = 0;
            if (long.TryParse(idcard.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(idcard.Replace('x', '0').Replace('X', '0'), out n) == false)
            {
                return DataResult.Fault("非数字或带X的有效身份证号");//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(idcard.Remove(2)) == -1)
            {
                return DataResult.Fault("身份证号省份验证失败");//省份验证
            }
            string birth = idcard.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return DataResult.Fault("身份证号生日验证失败");//生日验证
            }
            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = idcard.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            Math.DivRem(sum, 11, out y);
            if (arrVarifyCode[y] != idcard.Substring(17, 1).ToLower())
            {
                return DataResult.Fault("身份证号校验码错误");//校验码验证
            }
            return DataResult.True();//符合GB11643-1999标准
        }
        private DataResult ValidationIDCard15(string idcard)
        {
            long n = 0;
            if (long.TryParse(idcard, out n) == false || n < Math.Pow(10, 14))
            {
                return DataResult.Fault("非数字或带X的有效身份证号");//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(idcard.Remove(2)) == -1)
            {
                return DataResult.Fault("身份证号省份验证失败");//省份验证
            }
            string birth = idcard.Substring(6, 6).Insert(4, "-").Insert(2, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return DataResult.Fault("身份证号生日验证失败");//生日验证
            }
            return DataResult.True();//符合15位身份证标准
        }
    }

    public class IDCardProperties
    {
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// 性别 1男 2女 9其他
        /// </summary>
        public int Gender { get; set; }
        /// <summary>
        /// 性别名称
        /// </summary>
        public string GenderText { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        public LongItem Sheng { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public LongItem Shi { get; set; }
        /// <summary>
        /// 县、区
        /// </summary>
        public LongItem Xian { get; set; }
    }
}
