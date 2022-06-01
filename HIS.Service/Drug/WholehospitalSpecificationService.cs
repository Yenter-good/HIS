using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Core;
using HIS.Service.Core.Enums;
using HIS.Utility;

namespace HIS.Service
{
    public class WholehospitalSpecificationService : IWholehospitalSpecificationService
    {
        private IIdService _idService;
        public WholehospitalSpecificationService(IIdService idService)
        {
            this._idService = idService;
        }
        /// <summary>
        /// 根据药典编码获取药品规格列表
        /// </summary>
        /// <param name="classCode">药典编码</param>
        /// <param name="includeDisable">是否包含停用的数据</param>
        /// <returns></returns>
        public DataResult<List<WholehospitalSpecificationEntity>> GetListByClassCode(string classCode, bool includeDisable = false)
        {
            try
            {
                List<WholehospitalSpecificationEntity> ggs = null;
                if (includeDisable)
                    ggs = DBHelper.Instance.HIS.From<Drug_WholehospitalSpecification>().Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id
                        && d.ClassCode == classCode && d.DataStatus != (int)DataStatus.Delete)
                        .OrderBy(d => d.No)
                        .ToList<Drug_WholehospitalSpecification>()
                        .Mapper<List<WholehospitalSpecificationEntity>>();
                else
                    ggs = DBHelper.Instance.HIS.From<Drug_WholehospitalSpecification>().Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id
                        && d.ClassCode == classCode && d.DataStatus == (int)DataStatus.Enable)
                        .OrderBy(d => d.No)
                        .ToList<Drug_WholehospitalSpecification>()
                        .Mapper<List<WholehospitalSpecificationEntity>>();

                return DataResult.True(ggs);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<List<WholehospitalSpecificationEntity>>(ex.Message);
            }
        }

        /// <summary>
        /// 根据规格编码获取序号
        /// </summary>
        /// <param name="code">药典编码</param>
        /// <returns></returns>
        public int GetNo(string classCode)
        {
            int maxNo = DBHelper.Instance.HIS.From<Drug_WholehospitalSpecification>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.ClassCode == classCode && d.DataStatus != (int)DataStatus.Delete)
                .Select(Drug_WholehospitalSpecification._.No.Max())
                .ToScalar<int>();

            return maxNo + 1;
        }
        /// <summary>
        /// 添加药品规格
        /// </summary>
        /// <param name="newEntity">药品规格实体</param>
        /// <returns></returns>
        public DataResult Add(WholehospitalSpecificationEntity newEntity)
        {
            try
            {
                var drugSpecification = newEntity.Mapper<Drug_WholehospitalSpecification>().SetCreationValues();
                drugSpecification.Id = this._idService.CreateUUID();
                newEntity.Id = drugSpecification.Id;
                drugSpecification.DataStatus = (int)newEntity.DataStatus;
                drugSpecification.ChargeType = (int)newEntity.DrugChargeType;

                DBHelper.Instance.HIS.Insert<Drug_WholehospitalSpecification>(drugSpecification);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 检查药品规格编码是否存在
        /// </summary>
        /// <param name="code">规格编码</param>
        /// <returns></returns>
        public bool CodeExists(string code)
        {
            bool codeExists = DBHelper.Instance.HIS.Exists<Drug_WholehospitalSpecification>(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id
                                                && d.Code == code
                                                && d.DataStatus != (int)DataStatus.Delete);
            return codeExists;
        }
        /// <summary>
        /// 更新药品规格状态
        /// </summary>
        /// <param name="entity">药品规格实体</param>
        /// <param name="dataStatus">数据状态</param>
        /// <returns></returns>
        public DataResult UpdateDataStatus(WholehospitalSpecificationEntity entity, DataStatus dataStatus)
        {
            bool exists = DBHelper.Instance.HIS.Exists<Drug_WarehouseInventory>(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id
                            && d.Quantity > 0
                            && d.ClassCode == entity.ClassCode
                            && d.SpecificationCode == entity.Code);
            if (exists)
                return DataResult.Fault("该药品在药库中有库存,无法停用！");

            exists = DBHelper.Instance.HIS.Exists<Drug_PharmacyInventory>(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id
                              && (d.BigPackageQuantity > 0 || d.SmallPackageQuantity > 0)
                              && d.ClassCode == entity.ClassCode
                              && d.SpecificationCode == entity.Code);
            if (exists)
                return DataResult.Fault("该药品在药房中有库存,无法停用！");

            var tran = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                var modifyGG = AuditionHelper.GetModificationValues<Drug_WholehospitalSpecification>();
                modifyGG[Drug_WholehospitalSpecification._.DataStatus] = (int)dataStatus;
                tran.Update<Drug_WholehospitalSpecification>(modifyGG, d => d.Id == entity.Id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                var modifyYKKC = AuditionHelper.GetModificationValues<Drug_WarehouseInventory>();
                modifyGG[Drug_WarehouseInventory._.DataStatus] = (int)dataStatus;
                tran.Update<Drug_WarehouseInventory>(modifyYKKC, d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Quantity == 0 && d.ClassCode == entity.ClassCode && d.SpecificationCode == entity.Code);

                var modifyYFKC = AuditionHelper.GetModificationValues<Drug_PharmacyInventory>();
                modifyYFKC[Drug_PharmacyInventory._.DataStatus] = (int)dataStatus;
                tran.Update<Drug_PharmacyInventory>(modifyYFKC, d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.BigPackageQuantity == 0 && d.SmallPackageQuantity == 0 && d.ClassCode == entity.ClassCode && d.SpecificationCode == entity.Code);

                tran.Commit();
                return DataResult.True();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return DataResult.Fault(ex.Message);
            }
            finally
            {
                if (tran != null)
                    tran.Close();
            }
        }
        /// <summary>
        /// 修改药品规格
        /// </summary>
        /// <param name="modifyEntity">药品规格实体</param>
        /// <returns></returns>
        public DataResult Update(WholehospitalSpecificationEntity modifyEntity)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Drug_WholehospitalSpecification>();
                modify[Drug_WholehospitalSpecification._.Specification] = modifyEntity.Specification;
                modify[Drug_WholehospitalSpecification._.TradeName] = modifyEntity.TradeName;
                modify[Drug_WholehospitalSpecification._.PackageNumber] = modifyEntity.PackageNumber;
                modify[Drug_WholehospitalSpecification._.BigPackageUnit] = modifyEntity.BigPackageUnit;
                modify[Drug_WholehospitalSpecification._.SmallPackageUnit] = modifyEntity.SmallPackageUnit;
                modify[Drug_WholehospitalSpecification._.MinDose] = modifyEntity.MinDose;
                modify[Drug_WholehospitalSpecification._.MinDoseUnit] = modifyEntity.MinDoseUnit;
                modify[Drug_WholehospitalSpecification._.DDD] = modifyEntity.DDD;
                modify[Drug_WholehospitalSpecification._.DDDSpecification] = modifyEntity.DDDSpecification;
                modify[Drug_WholehospitalSpecification._.BarCode] = modifyEntity.BarCode;
                modify[Drug_WholehospitalSpecification._.ChargeType] = (int)modifyEntity.DrugChargeType;
                modify[Drug_WholehospitalSpecification._.Manufacturer] = modifyEntity.Manufacturer;
                modify[Drug_WholehospitalSpecification._.ApprovalNumber] = modifyEntity.ApprovalNumber;
                modify[Drug_WholehospitalSpecification._.SearchCode] = modifyEntity.SearchCode;
                modify[Drug_WholehospitalSpecification._.WubiCode] = modifyEntity.WubiCode;
                modify[Drug_WholehospitalSpecification._.UpperLimit] = modifyEntity.UpperLimit;
                modify[Drug_WholehospitalSpecification._.LowerLimit] = modifyEntity.LowerLimit;

                DBHelper.Instance.HIS.Update<Drug_WholehospitalSpecification>(modify, d => d.Id == modifyEntity.Id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }

    }
}
