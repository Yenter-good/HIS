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
    /// 创建时间:2021-02-20 11:16:44
    /// 描述:
    /// </summary>
    public class OPDataElementService : IOPDataElementService
    {
        IIdService idService;
        public OPDataElementService(IIdService idService)
        {
            this.idService = idService;
        }
        /// <summary>
        /// 获取数据源
        /// </summary>
        /// <returns></returns>
        public List<DataElementEntity> GetList()
        {
            return DBHelper.Instance.HIS.From<OP_DataElement>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus == (int)DataStatus.Enable)
                   .Select(OP_DataElement._.Id, OP_DataElement._.Code, OP_DataElement._.Name)
                   .ToList<OP_DataElement>()
                   .OrderBy(d => d.No)
                   .Mapper<List<DataElementEntity>>();
        }
        /// <summary>
        /// 检查编码是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CodeExists(string code)
        {
            return DBHelper.Instance.HIS.Exists<OP_DataElement>(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Code == code && d.DataStatus == (int)DataStatus.Enable);
        }

        /// <summary>
        /// 添加数据源
        /// </summary>
        /// <param name="dataElementEntity">数据源实体</param>
        /// <returns></returns>
        public DataResult Insert(DataElementEntity dataElementEntity)
        {
            try
            {
                dataElementEntity.Id = this.idService.CreateUUID();

                var ormEntity = dataElementEntity.Mapper<OP_DataElement>();
                ormEntity.SetCreationValues();

                DBHelper.Instance.HIS.Insert<OP_DataElement>(ormEntity);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }

        /// <summary>
        /// 修改数据源
        /// </summary>
        /// <param name="code">编码</param>
        /// <param name="name">名称</param>
        /// <param name="id">Id</param>
        /// <returns></returns>
        public DataResult Update(string code, string name, long id)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<OP_DataElement>();
                modify[OP_DataElement._.Code] = code;
                modify[OP_DataElement._.Name] = name;
                DBHelper.Instance.HIS.Update<OP_DataElement>(modify, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }

        /// <summary>
        /// 删除数据源
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        public DataResult Delete(long id)
        {
            try
            {
                var modify = AuditionHelper.GetDeletionValues<OP_DataElement>();
                DBHelper.Instance.HIS.Update<OP_DataElement>(modify, d => d.Id == id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
