using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.OP
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-03-01 10:13:47
    /// 描述:
    /// </summary>
    public class OPTemplateSampleService : IOPTemplateSampleService
    {
        private readonly IIdService _idService;
        public OPTemplateSampleService(IIdService idService)
        {
            this._idService = idService;
        }
        /// <summary>
        /// 获取范文
        /// </summary>
        /// <returns></returns>
        public List<TemplateSampleEntity> GetList(long deptId)
        {
            return DBHelper.Instance.HIS.From<OP_TemplateSample>()
                  .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id
                    && (d.OwnerId == deptId || d.OwnerId == App.Instance.RuntimeSystemInfo.UserInfo.Id)
                    && d.DataStatus == (int)DataStatus.Enable)
                  .Select(OP_TemplateSample._.Id,
                          OP_TemplateSample._.HosId,
                          OP_TemplateSample._.DataStatus,
                          OP_TemplateSample._.No,
                          OP_TemplateSample._.ParentId,
                          OP_TemplateSample._.NodeType,
                          OP_TemplateSample._.Level,
                          OP_TemplateSample._.Name,
                          OP_TemplateSample._.SearchCode,
                          OP_TemplateSample._.WubiCode,
                          OP_TemplateSample._.OwnerId)
                  .ToList()
                  .OrderBy(d => d.No)
                  .Mapper<List<TemplateSampleEntity>>();
        }
        /// <summary>
        /// 删除范文
        /// </summary>
        /// <param name="id">范文Id</param>
        /// <returns></returns>
        public DataResult Delete(long id)
        {
            try
            {
                string sql = @"with temp as (
 select Id from OP_TemplateSample where Id=@Id
 union all
 select c.Id from OP_TemplateSample AS c, temp t where c.ParentId=t.Id
)  update OP_TemplateSample set DataStatus=@DataStatus,DeleterUserId=@DeleterUserId,DeletionTime=GETDATE() where Id in(select Id from temp)";
                DBHelper.Instance.HIS.FromSql(sql)
                    .AddInParameter("@Id", System.Data.DbType.Int64, id)
                    .AddInParameter("@DataStatus", System.Data.DbType.Int32, (int)DataStatus.Delete)
                    .AddInParameter("@DeleterUserId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.UserInfo.Id)
                    .ExecuteNonQuery();
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 添加范文
        /// </summary>
        /// <param name="sampleEntity">范文实体</param>
        /// <returns></returns>
        public DataResult Insert(TemplateSampleEntity sampleEntity)
        {
            try
            {
                sampleEntity.No = this.GetNo(sampleEntity.Level);
                sampleEntity.Id = this._idService.CreateUUID();
                var entity = sampleEntity.Mapper<OP_TemplateSample>();
                var model = entity.SetCreationValues<OP_TemplateSample>();
                DBHelper.Instance.HIS.Insert<OP_TemplateSample>(model);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 获取顺序号
        /// </summary>
        /// <param name="level">节点等级</param>
        /// <returns></returns>
        public int GetNo(Level level)
        {
            int maxNo = DBHelper.Instance.HIS.From<OP_TemplateSample>()
                  .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Level == (int)level)
                  .Select(OP_TemplateSample._.No.Max())
                  .ToScalar<int>();

            return maxNo + 1;
        }
        /// <summary>
        /// 更新范文名称
        /// </summary>
        /// <param name="id">范文Id</param>
        /// <param name="name">范文名称</param>
        /// <returns></returns>
        public DataResult UpdateName(long id, string name)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<OP_TemplateSample>();
                modify[OP_TemplateSample._.Name] = name;
                modify[OP_TemplateSample._.SearchCode] = SpellHelper.GetSpells(name);
                modify[OP_TemplateSample._.WubiCode] = SpellHelper.GetWuBis(name);
                DBHelper.Instance.HIS.Update<OP_TemplateSample>(modify, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新范文内容
        /// </summary>
        /// <param name="id">范文Id</param>
        /// <param name="content">范文内容</param>
        /// <returns></returns>
        public DataResult UpdateContent(long id, string content)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<OP_TemplateSample>();
                modify[OP_TemplateSample._.Content] = content;
                DBHelper.Instance.HIS.Update<OP_TemplateSample>(modify, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 获取范文内容
        /// </summary>
        /// <param name="id">范文Id</param>
        /// <returns></returns>
        public DataResult<string> GetContent(long id)
        {
            try
            {
                string content = DBHelper.Instance.HIS.From<OP_TemplateSample>()
                      .Where(d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                      .Select(d => d.Content)
                      .ToScalar<string>();
                return DataResult.True<string>(content);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<string>(ex.Message);
            }
        }
    }
}
