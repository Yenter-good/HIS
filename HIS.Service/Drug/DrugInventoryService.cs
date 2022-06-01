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

namespace HIS.Service.Drug
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-14 15:10:37
    /// 描述:
    /// </summary>
    public class DrugInventoryService : IDrugInventoryService
    {
        private readonly ISysDictQueryService _dictQueryService;
        private readonly IIdService _idService;

        public DrugInventoryService(ISysDictQueryService dictQueryService, IIdService idService)
        {
            this._dictQueryService = dictQueryService;
            this._idService = idService;
        }

        /// <summary>
        /// 获取指定科室所有药品库存
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public List<DrugInventoryEntity> WarehouseGetAllInventory(long deptId)
        {
            var models = DBHelper.Instance.HIS.From<View_WarehouseDrugInventory>().Where(p => p.DeptId == deptId).ToList();
            var drugProperties = _dictQueryService.GetDrugProperty();

            var result = models.Mapper<List<DrugInventoryEntity>>();
            foreach (var model in models)
            {
                var propertyCodes = model.PropertyCodes.AsString("").Split(';');
                var properties = drugProperties.Where(p => p.Code._In(propertyCodes)).ToList();
                var entity = result.Find(p => p.SpecificationCode == model.SpecificationCode && p.ClassCode == model.ClassCode);
                if (entity != null)
                    entity.Properties = properties;
            }

            return result;
        }
        /// <summary>
        /// 获取指定科室指定检索码的药品库存
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="searchCode"></param>
        /// <returns></returns>
        public List<DrugInventoryEntity> WarehouseGetInventory(long deptId, string searchCode, int number = 0)
        {
            List<View_WarehouseDrugInventory> models;

            if (number == 0)
                models = DBHelper.Instance.HIS.From<View_WarehouseDrugInventory>().Where(p => p.DeptId == deptId && (p.SearchCode.Contains(searchCode) || p.DrugName.Contains(searchCode))).ToList();
            else
                models = DBHelper.Instance.HIS.From<View_WarehouseDrugInventory>().Where(p => p.DeptId == deptId && (p.SearchCode.Contains(searchCode) || p.DrugName.Contains(searchCode))).Top(number).ToList();

            var drugProperties = _dictQueryService.GetDrugProperty();

            var result = models.Mapper<List<DrugInventoryEntity>>();
            foreach (var model in models)
            {
                var propertyCodes = model.PropertyCodes.AsString("").Split(';');
                var properties = drugProperties.Where(p => p.Code._In(propertyCodes)).ToList();
                var entity = result.Find(p => p.SpecificationCode == model.SpecificationCode && p.ClassCode == model.ClassCode);
                if (entity != null)
                    entity.Properties = properties;
            }

            return result;
        }

        /// <summary>
        /// 获取指定科室的药品库存
        /// </summary>
        /// <param name="deptId">科室ID</param>
        /// <returns></returns>
        public List<DrugInventoryEntity> PharmacyGetInventory(long deptId, bool includeDisable = false)
        {
            List<View_PharmacyDrugInventory> models;
            if (includeDisable)
                models = DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.DeptId == deptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList();
            else
                models = DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.DeptId == deptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.DataStatus == DataStatus.Enable.AsInt()).ToList();

            var drugProperties = _dictQueryService.GetDrugProperty();

            var result = models.Mapper<List<DrugInventoryEntity>>();
            foreach (var model in models)
            {
                var propertyCodes = model.PropertyCodes.AsString("").Split(';');
                var properties = drugProperties.Where(p => p.Code._In(propertyCodes)).ToList();
                var entity = result.Find(p => p.SpecificationCode == model.SpecificationCode && p.ClassCode == model.ClassCode);
                if (entity != null)
                    entity.Properties = properties;
            }

            return result;
        }
        /// <summary>
        /// 获取指定科室的药品库存
        /// </summary>
        /// <param name="deptId">科室ID</param>
        /// <returns></returns>
        public List<DrugInventoryEntity> PharmacyGetInventory(long deptId, bool includeDisable = false, params DrugType[] drugType)
        {
            int[] drugTypes = drugType.Select(p => (int)p).ToArray();

            List<View_PharmacyDrugInventory> models;

            if (includeDisable)
                models = DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.DeptId == deptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.DrugType.In(drugTypes)).ToList();
            else
                models = DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.DeptId == deptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.DrugType.In(drugTypes) && p.DataStatus == DataStatus.Enable.AsInt()).ToList();

            var drugProperties = _dictQueryService.GetDrugProperty();

            var result = models.Mapper<List<DrugInventoryEntity>>();
            foreach (var model in models)
            {
                var propertyCodes = model.PropertyCodes.AsString("").Split(';');
                var properties = drugProperties.Where(p => p.Code._In(propertyCodes)).ToList();
                var entity = result.Find(p => p.SpecificationCode == model.SpecificationCode && p.ClassCode == model.ClassCode);
                if (entity != null)
                    entity.Properties = properties;
            }

            return result;
        }
        /// <summary>
        /// 获取指定科室的药品库存
        /// </summary>
        /// <param name="deptId">科室ID</param>
        /// <returns></returns>
        public List<DrugInventoryEntity> PharmacyGetInventory(long deptId, string searchCode, int number = 0)
        {
            List<View_PharmacyDrugInventory> models;
            if (number == 0)
                models = DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.DeptId == deptId && (p.SearchCode.Contains(searchCode) || p.DrugName.Contains(searchCode))).ToList();
            else
                models = DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.DeptId == deptId && (p.SearchCode.Contains(searchCode) || p.DrugName.Contains(searchCode))).Top(number).ToList();

            var drugProperties = _dictQueryService.GetDrugProperty();

            var result = models.Mapper<List<DrugInventoryEntity>>();
            foreach (var model in models)
            {
                var propertyCodes = model.PropertyCodes.AsString("").Split(';');
                var properties = drugProperties.Where(p => p.Code._In(propertyCodes)).ToList();
                var entity = result.Find(p => p.SpecificationCode == model.SpecificationCode && p.ClassCode == model.ClassCode);
                if (entity != null)
                    entity.Properties = properties;
            }

            return result;
        }
        /// <summary>
        /// 根据ID获取药品
        /// </summary>
        /// <param name="id">药品ID</param>
        /// <returns></returns>
        public DrugInventoryEntity PharmacyGetInventoryById(long inventoryId, bool includeDisable = false)
        {
            View_PharmacyDrugInventory model;

            if (includeDisable)
                model = DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.InventoryId == inventoryId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First();
            else
                model = DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.InventoryId == inventoryId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.DataStatus == DataStatus.Enable.AsInt()).First();

            var drugProperties = _dictQueryService.GetDrugProperty();

            var result = model.Mapper<DrugInventoryEntity>();

            if (result != null)
            {
                var propertyCodes = model.PropertyCodes.AsString("").Split(';');
                var properties = drugProperties.Where(p => p.Code._In(propertyCodes)).ToList();
                result.Properties = properties;
            }

            return result;
        }

        /// <summary>
        /// 获取全院级别的 药品信息
        /// </summary>
        /// <returns></returns>
        public List<DrugInventoryEntity> WholehospitalDrugInfoGetAll()
        {

            string sql = @"SELECT ClassCode,SpecificationCode,DrugName,Specification,TradeName,
                            Manufacturer,PropertyCodes,PrescriptionType,SkinTestFlag,DangerFlage,
                            NewFlag,TumorFlag,DrugformId,DrugformCode,DrugformValue,ToxicType,AntibioticType,
                            UseWayCode,UseWayName,StandardCode,DrugType,PackageNumber,BigPackageUnit,
                            SmallPackageUnit,MinDose,MinDoseUnit,ChargeType,PurchasePrice,SmallPackagePrice,
                            BigPackagePrice,SmallPackageQuantity,BigPackageQuantity,SearchCode,WubiCode
                             FROM View_PharmacyDrugInventory WHERE HosId = @HosId
                             GROUP BY  ClassCode,SpecificationCode,DrugName,Specification,TradeName,
                            Manufacturer,PropertyCodes,PrescriptionType,SkinTestFlag,DangerFlage,
                            NewFlag,TumorFlag,DrugformId,DrugformCode,DrugformValue,ToxicType,AntibioticType,
                            UseWayCode,UseWayName,StandardCode,DrugType,PackageNumber,BigPackageUnit,
                            SmallPackageUnit,MinDose,MinDoseUnit,ChargeType,PurchasePrice,SmallPackagePrice,
                            BigPackagePrice,SmallPackageQuantity,BigPackageQuantity,SearchCode,WubiCode";

            return AutoMapperHelper.Instance.Mapper.Map<List<DrugInventoryEntity>>(DBHelper.Instance.HIS.FromSql(sql)
                .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                               .ToList<View_PharmacyDrugInventory>());
        }

    }
}
