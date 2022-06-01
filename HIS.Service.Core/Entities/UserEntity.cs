using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-28 14:47:51
/// 功能:
/// </summary>
namespace HIS.Service.Core.Entities
{
    public class UserEntity
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 用户工号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 用户类型
        /// </summary>
        public UserType UserType { get; set; }
        /// <summary>
        /// 用户性质
        /// </summary>
        public UserNature UserNature { get; set; }
        /// <summary>
        /// 教育程度
        /// </summary>
        public LongItem Education { get; set; }
        /// <summary>
        /// 机构信息
        /// </summary>
        public OrganizationInfo HosInfo { get; set; }
        /// <summary>
        /// 职称信息
        /// </summary>
        public TitleEntity Title { get; set; }
        /// <summary>
        /// 默认角色
        /// </summary>
        public RoleEntity Role { get; set; }
        /// <summary>
        /// 用户拥有的所有角色附加信息
        /// </summary>
        public List<RoleAdditionalEntity> RoleAdditions { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public DataStatus Status { get; set; }
        /// <summary>
        /// 检索码
        /// </summary>
        public string SearchCode { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var entity = obj as UserEntity;
            if (entity.Id == this.Id)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
