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
    /// <summary>
    /// 药品品种定义实现类
    /// </summary>
    public class WholehospitalClassService : IWholehospitalClassService
    {
        private readonly IIdService _idService;

        public WholehospitalClassService(IIdService idService)
        {
            this._idService = idService;
        }
        /// <summary>
        /// 药品品种定义服务
        /// </summary>
        /// <param name="includeDisable">是否包含停用的数据</param>
        /// <returns></returns>
        public DataResult<List<WholehospitalClassEntity>> GetListByDrugType(int drugType, bool includeDisable = false)
        {
            try
            {
                List<WholehospitalClassEntity> value = null;
                if (includeDisable)
                    value = DBHelper.Instance.HIS.From<View_DrugClass>()
                        .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DrugType == drugType && d.DataStatus != (int)DataStatus.Delete)
                        .ToList<View_DrugClass>()
                        .Mapper<List<WholehospitalClassEntity>>();
                else
                    value = DBHelper.Instance.HIS.From<View_DrugClass>()
                        .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DrugType == drugType && d.DataStatus != (int)DataStatus.Delete)
                        .ToList<View_DrugClass>()
                        .Mapper<List<WholehospitalClassEntity>>();

                return DataResult.True(value);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<List<WholehospitalClassEntity>>(ex.Message);
            }
        }
        /// <summary>
        /// 检查药品编码是否存在
        /// </summary>
        /// <param name="code">药品编码</param>
        /// <returns></returns>
        public bool CodeExists(string code)
        {
            bool codeExists = DBHelper.Instance.HIS.Exists<Drug_WholehospitalClass>(d => d.Code == code && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus != (int)DataStatus.Delete);

            return codeExists;
        }
        /// <summary>
        /// 获取序号
        /// </summary>
        /// <param name="drugType">所属药品类型</param>
        /// <returns></returns>
        public int GetNo(int drugType)
        {
            int maxNo = DBHelper.Instance.HIS.From<Drug_WholehospitalClass>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DrugType == drugType && d.DataStatus != (int)DataStatus.Delete)
                .Select(Drug_WholehospitalClass._.No.Max())
                .ToScalar<int>();

            return maxNo + 1;
        }
        /// <summary>
        /// 添加药品品种
        /// </summary>
        /// <param name="entity">药品品种实体</param>
        /// <returns></returns>
        public DataResult Add(WholehospitalClassEntity entity)
        {
            try
            {
                Drug_WholehospitalClass drugClass = entity.Mapper<Drug_WholehospitalClass>().SetCreationValues();
                drugClass.Id = this._idService.CreateUUID();
                entity.Id = drugClass.Id;
                drugClass.PrescriptionType = (int)entity.PrescriptionType;
                drugClass.ToxicType = (int)entity.ToxicType;
                drugClass.AntibioticType = (int)entity.AntibioticType;
                drugClass.DrugType = (int)entity.DrugType;

                DBHelper.Instance.HIS.Insert<Drug_WholehospitalClass>(drugClass);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 药品修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult Update(WholehospitalClassEntity entity)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> modify = AuditionHelper.GetModificationValues<Drug_WholehospitalClass>();
                modify[Drug_WholehospitalClass._.DataStatus] = (int)entity.DataStatus;
                modify[Drug_WholehospitalClass._.No] = entity.No;
                modify[Drug_WholehospitalClass._.Name] = entity.Name;
                modify[Drug_WholehospitalClass._.PropertyCodes] = null;
                modify[Drug_WholehospitalClass._.PriceTypeId] = entity.PriceType.Key;
                modify[Drug_WholehospitalClass._.GMP] = entity.GMP;
                modify[Drug_WholehospitalClass._.PharmacologyTypeId] = entity.PharmacologyType.Key;
                modify[Drug_WholehospitalClass._.PrescriptionType] = (int)entity.PrescriptionType;
                modify[Drug_WholehospitalClass._.SkinTestFlag] = entity.SkinTestFlag;
                modify[Drug_WholehospitalClass._.DangerFlage] = entity.DangerFlage;
                modify[Drug_WholehospitalClass._.BasicDrugFlag] = entity.BasicDrugFlag;
                modify[Drug_WholehospitalClass._.NewFlag] = entity.NewFlag;
                modify[Drug_WholehospitalClass._.TumorFlag] = entity.TumorFlag;
                modify[Drug_WholehospitalClass._.DrugformId] = entity.Drugfrom.Key;
                modify[Drug_WholehospitalClass._.ToxicType] = (int)entity.ToxicType;
                modify[Drug_WholehospitalClass._.AntibioticType] = (int)entity.AntibioticType;
                modify[Drug_WholehospitalClass._.UseWayCode] = entity.UseWay?.Code;
                modify[Drug_WholehospitalClass._.DispensingTypeId] = entity.DispensingType.Key;
                modify[Drug_WholehospitalClass._.StandardCode] = entity.StandardCode;
                modify[Drug_WholehospitalClass._.OPCanSplit] = entity.OPCanSplit;
                modify[Drug_WholehospitalClass._.IPCanSplit] = entity.IPCanSplit;
                modify[Drug_WholehospitalClass._.DrugType] = (int)entity.DrugType;
                modify[Drug_WholehospitalClass._.SearchCode] = entity.SearchCode;
                modify[Drug_WholehospitalClass._.WubiCode] = entity.WubiCode;

                DBHelper.Instance.HIS.Update<Drug_WholehospitalClass>(modify, d => d.Id == entity.Id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
