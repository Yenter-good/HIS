using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;

namespace HIS.Service
{
     public class EmpiPatientService : IEmpiPatientService
    {
        private IIdService _idService;

        public EmpiPatientService(IIdService idService)
        {
            _idService = idService;
        }
        /// <summary>
        /// 根据条件查询患者信息
        /// </summary>
        /// <param name="searchStr"></param>
        /// <returns></returns>
        public  List<PatientEntity> GetBySearchStr(string searchStr)
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<PatientEntity>>(DBHelper.Instance.HIS.From<Empi_PatientIndex>().
                    Where(p => p.SearchCode.Contains(searchStr) || p.Name.Contains(searchStr) || p.IdCard == searchStr || p.PhoneNo == searchStr)
                    .ToList());
        }
        /// <summary>
        /// 新增患者（注册）
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public DataResult<PatientEntity> AddPatient(PatientEntity entity)
        {
            try
            {
                entity.Id = _idService.CreateUUID();

                if (entity.RegisteredChannels != 1 && entity.IdCard.IsNullOrWhiteSpace())
                {
                    return DataResult.Fault<PatientEntity>("身份证号必填");
                }

                if (entity.Kinship == 1 && entity.ContactName.IsNullOrWhiteSpace())//替小孩注册
                {
                    return DataResult.Fault<PatientEntity>("儿童注册时必须填写监护人姓名");
                }
                List<PatientEntity> list = AutoMapperHelper.Instance.Mapper.Map<List<PatientEntity>>(DBHelper.Instance.HIS.From<Empi_PatientIndex>().
                    Where(p => p.IdCard == entity.IdCard.Trim() || p.Name == entity.Name.Trim()).ToList());

                if (list.Count > 0) 
                {
                    return DataResult.True<PatientEntity>(list[0]);
                }

                var model = entity.Mapper<Empi_PatientIndex>();
                model.SetCreationValues();
                DBHelper.Instance.HIS.Insert<Empi_PatientIndex>(model);

                return DataResult.True<PatientEntity>(entity);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<PatientEntity>(ex.Message);
            }
        }

        /// <summary>
        /// 修改患者信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<PatientEntity> UpdatePatient(long entityId, PatientEntity entity)
        {
            try
            {
                var modelModify = entity.Mapper<Empi_PatientIndex>();

                DBHelper.Instance.HIS.Update<Empi_PatientIndex>(modelModify, p => p.Id == modelModify.Id);

                return DataResult.True<PatientEntity>(entity);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<PatientEntity>(ex.Message);
            }
        }
    }
}
