using Dos.ORM;
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

namespace HIS.Service
{
    public class RegFeeTypeService : IRegFeeTypeService
    {
        private IIdService _idService;
        public RegFeeTypeService(IIdService idService)
        {
            _idService = idService;
        }

        /// <summary>
        /// 新增号费
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<RegFeeType> AddFeeType(RegFeeType entity)
        {
            try
            {
                entity.Id = _idService.CreateUUID();

                var model = entity.Mapper<Reg_RegisteredFeeType>();
                model.SetCreationValues();
                DBHelper.Instance.HIS.Insert<Reg_RegisteredFeeType>(model);

                return DataResult.True<RegFeeType>(entity);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<RegFeeType>(ex.Message);
            }

        }

        /// <summary>
        /// 更改票据信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<RegFeeType> UpdateFeeType(long entityId, RegFeeType entity)
        {
            try
            {
                var modelModify = entity.Mapper<Reg_RegisteredFeeType>();

                DBHelper.Instance.HIS.Update<Reg_RegisteredFeeType>(modelModify, p => p.Id == modelModify.Id);

                return DataResult.True<RegFeeType>(entity);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<RegFeeType>(ex.Message);
            }
        }

        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public DataResult<RegFeeType> DeleteFeeType(long entityId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Reg_RegisteredFeeType>(Reg_RegisteredFeeType._.Id == entityId);

                return DataResult.True<RegFeeType>(null);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<RegFeeType>(ex.Message);
            }

        }
        /// <summary>
        /// 获取所有号费信息
        /// </summary>
        /// <returns></returns>
        public List<RegFeeType> GetAll()
        {
           return AutoMapperHelper.Instance.Mapper.Map<List<RegFeeType>>(DBHelper.Instance.HIS.From<Reg_RegisteredFeeType>()
                      .Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                      .ToList());

        }
    }
}
