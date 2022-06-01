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
    public class OPSubTemplateSampleService : IOPSubTemplateSampleService
    {
        private readonly IIdService _idService;
        public OPSubTemplateSampleService(IIdService idService)
        {
            this._idService = idService;
        }
        /// <summary>
        /// 获取子模板
        /// </summary>
        /// <returns></returns>
        public List<SubTemplateSampleEntity> GetList(long deptId)
        {
            return DBHelper.Instance.HIS.From<OP_SubTemplateSample>()
                  .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id
                    && (d.OwnerId == deptId || d.OwnerId == App.Instance.RuntimeSystemInfo.UserInfo.Id)
                    && d.DataStatus == (int)DataStatus.Enable)
                  .Select(OP_SubTemplateSample._.Id,
                          OP_SubTemplateSample._.HosId,
                          OP_SubTemplateSample._.DataStatus,
                          OP_SubTemplateSample._.No,
                          OP_SubTemplateSample._.ParentId,
                          OP_SubTemplateSample._.NodeType,
                          OP_SubTemplateSample._.Level,
                          OP_SubTemplateSample._.Name,
                          OP_SubTemplateSample._.TemplateNodeId,
                          OP_SubTemplateSample._.SearchCode,
                          OP_SubTemplateSample._.WubiCode,
                          OP_SubTemplateSample._.OwnerId)
                  .ToList()
                  .OrderBy(d => d.No)
                  .Mapper<List<SubTemplateSampleEntity>>();
        }
        /// <summary>
        /// 删除子模板
        /// </summary>
        /// <param name="id">子模板Id</param>
        /// <returns></returns>
        public DataResult Delete(long id)
        {
            try
            {
                string sql = @"with temp as (
 select Id from OP_SubTemplateSample where Id=@Id
 union all
 select c.Id from OP_SubTemplateSample AS c, temp t where c.ParentId=t.Id
)  update OP_SubTemplateSample set DataStatus=@DataStatus,DeleterUserId=@DeleterUserId,DeletionTime=GETDATE() where Id in(select Id from temp)";
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
        /// 添加子模板
        /// </summary>
        /// <param name="sampleEntity">子模板实体</param>
        /// <returns></returns>
        public DataResult Insert(SubTemplateSampleEntity sampleEntity)
        {
            try
            {
                sampleEntity.No = this.GetNo(sampleEntity.Level);
                sampleEntity.Id = this._idService.CreateUUID();
                var entity = sampleEntity.Mapper<OP_SubTemplateSample>();
                var model = entity.SetCreationValues<OP_SubTemplateSample>();
                DBHelper.Instance.HIS.Insert<OP_SubTemplateSample>(model);

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
            int maxNo = DBHelper.Instance.HIS.From<OP_SubTemplateSample>()
                  .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Level == (int)level)
                  .Select(OP_SubTemplateSample._.No.Max())
                  .ToScalar<int>();

            return maxNo + 1;
        }
        /// <summary>
        /// 更新子模板名称
        /// </summary>
        /// <param name="id">子模板Id</param>
        /// <param name="name">子模板名称</param>
        /// <returns></returns>
        public DataResult UpdateName(long id, string name)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<OP_SubTemplateSample>();
                modify[OP_SubTemplateSample._.Name] = name;
                DBHelper.Instance.HIS.Update<OP_SubTemplateSample>(modify, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新子模板内容
        /// </summary>
        /// <param name="id">子模板Id</param>
        /// <param name="content">子模板内容</param>
        /// <returns></returns>
        public DataResult UpdateContent(long id, string content, long templateNodeId)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<OP_SubTemplateSample>();
                modify[OP_SubTemplateSample._.Content] = content;
                modify[OP_SubTemplateSample._.TemplateNodeId] = templateNodeId;
                DBHelper.Instance.HIS.Update<OP_SubTemplateSample>(modify, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 获取子模板内容
        /// </summary>
        /// <param name="id">子模板Id</param>
        /// <returns></returns>
        public DataResult<string> GetContent(long id)
        {
            try
            {
                string content = DBHelper.Instance.HIS.From<OP_SubTemplateSample>()
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
