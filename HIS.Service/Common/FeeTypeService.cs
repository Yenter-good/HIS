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

namespace HIS.Service
{
    public class FeeTypeService : IFeeTypeService
    {
        /// <summary>
        /// 获取全部费用类型
        /// </summary>
        /// <returns></returns>
        public DataResult<List<FeeTypeEntity>> GetAll()
        {
            try
            {
                List<FeeTypeEntity> results = DBHelper.Instance.HIS.From<Dic_FeeType>()
                      .Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus != (int)DataStatus.Delete)
                      .OrderBy(d => d.No)
                      .ToList<Dic_FeeType>()
                      .Mapper<List<FeeTypeEntity>>();

                return DataResult.True<List<FeeTypeEntity>>(results);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<List<FeeTypeEntity>>(ex.Message);
            }
        }

        /// <summary>
        /// 费用类型编码是否存在
        /// </summary>
        /// <param name="code">编码</param>
        /// <returns></returns>
        public bool CodeExists(string code)
        {
            bool codeExists = DBHelper.Instance.HIS.Exists<Dic_FeeType>(d => d.Code == code && d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus != (int)DataStatus.Delete);

            return codeExists;
        }

        /// <summary>
        /// 添加费用类型
        /// </summary>
        /// <param name="feeTypeEntity">费用类型实体</param>
        /// <returns></returns>
        public DataResult Add(FeeTypeEntity feeTypeEntity)
        {
            try
            {
                Dic_FeeType feeType = feeTypeEntity.Mapper<Dic_FeeType>();
                feeType.SetCreationValues();

                DBHelper.Instance.HIS.Insert<Dic_FeeType>(feeType);

                return DataResult.True();

            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新收费类型
        /// </summary>
        /// <param name="feeTypeEntity"></param>
        /// <returns></returns>
        public DataResult Update(FeeTypeEntity feeTypeEntity)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Dic_FeeType>();
                updateValue[Dic_FeeType._.Name] = feeTypeEntity.Name;
                updateValue[Dic_FeeType._.SearchCode] = feeTypeEntity.SearchCode;
                updateValue[Dic_FeeType._.DataStatus] = feeTypeEntity.DataStatus.AsBoolean();

                DBHelper.Instance.HIS.Update<Dic_FeeType>(updateValue, d => d.Id == feeTypeEntity.Id && d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
