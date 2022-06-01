using AutoMapper;
using HIS.Model;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Entities.Drug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Mappers
{
    class DrugProfile : Profile
    {
        public DrugProfile()
        {
            //药房盘点表
            this.CreateMap<Drug_PharmacyTakeStock, TakeStockEntity>()
           .ReverseMap();
            //药库盘点表
            this.CreateMap<Drug_WarehouseTakeStock, TakeStockEntity>()
           .ReverseMap();

            //药品采购计划
            this.CreateMap<Drug_Procurement, ProcurementPlanEntity>()
                .ReverseMap();

            //药品品种映射
            this.CreateMap<View_DrugClass, WholehospitalClassEntity>()
                .ForMember(dest => dest.PriceType,
                            opt => opt.MapFrom(src => new LongItem(src.PriceTypeId, src.PriceTypeName, "")))
                .ForMember(dest => dest.PharmacologyType,
                            opt => opt.MapFrom(src => new LongItem(src.PharmacologyTypeId, src.PharmacologyTypeName, "")))
                .ForMember(dest => dest.Drugfrom, opt =>
                            opt.MapFrom(src => new LongItem(src.DrugformId, src.DrugformName, "")))
                .ForMember(dest => dest.DispensingType,
                            opt => opt.MapFrom(src => new LongItem(src.DispensingTypeId, src.DispensingTypeName, "")))
                .ForMember(dest => dest.UseWay,
                            opt => opt.MapFrom(src => new UsageEntity() { Code = src.UseWayCode, Name = src.UseWayName }));

            this.CreateMap<WholehospitalClassEntity, Drug_WholehospitalClass>()
                .ForMember(dest => dest.PriceTypeId,
                            opt => opt.MapFrom(src => src.PriceType.Key))
                .ForMember(dest => dest.PharmacologyTypeId,
                            opt => opt.MapFrom(src => src.PharmacologyType.Key))
                .ForMember(dest => dest.DrugformId, opt =>
                            opt.MapFrom(src => src.Drugfrom.Key))
                .ForMember(dest => dest.DispensingTypeId,
                            opt => opt.MapFrom(src => src.DispensingType.Key))
                .ForMember(dest => dest.UseWayCode,
                            opt => opt.MapFrom(src => src.UseWay.Code));
            //药品规格映射
            this.CreateMap<Drug_WholehospitalSpecification, WholehospitalSpecificationEntity>().ReverseMap();

            //药房入出库单据映射
            this.CreateMap<View_PharmacyReceipt, PharmacyInOutInventoryEntity>()
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.TotalPrice))
                .ForMember(dest => dest.CreateUser, opt => opt.MapFrom(src => new UserEntity() { Id = src.CreatorUserId, Name = src.CreatorUserName, Code = src.CreatorUserCode }))
                .ForMember(dest => dest.AuditUser, opt => opt.MapFrom(src => src.AuditUserId == null ? null : new UserEntity() { Id = src.AuditUserId.Value, Name = src.AuditUserName, Code = src.AuditUserCode }))
                .ForMember(dest => dest.SourceDept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.SourceDeptId, Name = src.SourceDeptName, Code = src.SourceDeptCode }))
                .ForMember(dest => dest.TargetDept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.TargetDeptId, Name = src.TargetDeptName, Code = src.TargetDeptCode }));

            //药库入出库单据映射
            this.CreateMap<View_WarehouseReceipt, WarehouseInOutInventoryReceiptEntitiy>()
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.TotalPrice))
                .ForMember(dest => dest.CreateUser, opt => opt.MapFrom(src => new UserEntity() { Id = src.CreatorUserId, Name = src.CreatorUserName, Code = src.CreatorUserCode }))
                .ForMember(dest => dest.AuditUser, opt => opt.MapFrom(src => src.AuditUserId == null ? null : new UserEntity() { Id = src.AuditUserId.Value, Name = src.AuditUserName, Code = src.AuditUserCode }))
                .ForMember(dest => dest.Dept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.DeptId, Name = src.DeptName, Code = src.DeptCode }));

            //药品调价单据映射
            this.CreateMap<View_PriceChangedReceipt, PriceChangedReceiptEntity>()
                .ForMember(dest => dest.CreateUser, opt => opt.MapFrom(src => new UserEntity() { Id = src.CreatorUserId, Name = src.CreatorUserName, Code = src.CreatorUserCode }))
                .ForMember(dest => dest.AuditUser, opt => opt.MapFrom(src => src.AuditUserId == null ? null : new UserEntity() { Id = src.AuditUserId.Value, Name = src.AuditUserName, Code = src.AuditUserCode }))
                .ForMember(dest => dest.Dept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.DeptId, Name = src.DeptName, Code = src.DeptCode }));
            //药品调价单据明细映射
            this.CreateMap<View_PriceChangedReceiptDetail, PriceChangedReceiptDetailEntity>()
                .ForMember(dest => dest.Drug, opt => opt.MapFrom(src => new DrugEntity() { DrugName = src.DrugName, TradeName = src.TradeName, ClassCode = src.ClassCode, SpecificationCode = src.SpecificationCode, Manufacturer = src.Manufacturer, Specification = src.Specification }));


            //药库入出库单据映射
            this.CreateMap<View_WarehouseReceiptDetail, DrugEntity>()
                .ForMember(dest => dest.DrugName, opt => opt.MapFrom(src => src.DrugName));

            //药库入出库单据明细映射
            this.CreateMap<View_WarehouseReceiptDetail, WarehouseInOutInventoryReceiptDetailEntitiy>();

            //药房入出库单据映射
            this.CreateMap<View_InPharmacyReceiptDetail, DrugEntity>()
                .ForMember(dest => dest.DrugName, opt => opt.MapFrom(src => src.DrugName));

            //药房入出库单据明细映射
            this.CreateMap<View_InPharmacyReceiptDetail, PharmacyInOutInventoryDetailEntity>()
                ;
            //药房入出库单据映射
            this.CreateMap<View_OutPharmacyReceiptDetail, DrugEntity>()
                .ForMember(dest => dest.DrugName, opt => opt.MapFrom(src => src.DrugName));

            //药房入出库单据明细映射
            this.CreateMap<View_OutPharmacyReceiptDetail, PharmacyInOutInventoryDetailEntity>()
                ;

            //药库库存映射
            this.CreateMap<View_WarehouseDrugInventory, DrugInventoryEntity>()
                .ForMember(dest => dest.BigPackagePrice, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.BigPackageQuantity, opt => opt.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.Drugform, opt => opt.MapFrom(src => src.DrugformId == null ? null : new LongItem(src.DrugformId.Value, src.DrugformValue, src.DrugformCode)))
               ;
            //药库库存映射
            this.CreateMap<View_PharmacyDrugInventory, DrugInventoryEntity>()
                .ForMember(dest => dest.Drugform, opt => opt.MapFrom(src => src.DrugformId == null ? null : new LongItem(src.DrugformId.Value, src.DrugformValue, src.DrugformCode)))
                .ForMember(dest => dest.Dept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.DeptId, Name = src.DeptName, Code = src.DeptCode }))
               ;

            this.CreateMap<DrugEntity, DrugInventoryEntity>();

            //药库药品信息映射
            this.CreateMap<View_WarehouseDrugInfo, DrugEntity>()
                .ForMember(dest => dest.Usage, opt => opt.MapFrom(src => new UsageEntity() { Name = src.UseWayName, Code = src.UseWayCode }))
                .ForMember(dest => dest.PriceType, opt => opt.MapFrom(src => src.PriceTypeId == 0 ? null : new LongItem(src.PriceTypeId, src.PriceTypeValue, src.PriceTypeCode)))
                .ForMember(dest => dest.PharmacologyType, opt => opt.MapFrom(src => src.PharmacologyTypeId == 0 ? null : new LongItem(src.PharmacologyTypeId, src.PharmacologyTypeValue, src.PharmacologyTypeCode)))
                .ForMember(dest => dest.Drugform, opt => opt.MapFrom(src => src.DrugformId == 0 ? null : new LongItem(src.DrugformId, src.DrugformValue, src.DrugformCode)))
                .ForMember(dest => dest.DispensingType, opt => opt.MapFrom(src => src.DispensingTypeId == 0 ? null : new LongItem(src.DispensingTypeId, src.DispensingTypeValue, src.DispensingTypeCode)))
            ;

            this.CreateMap<WarehouseInOutInventoryReceiptEntitiy, Drug_WarehouseReceipt>()
                .ForMember(dest => dest.AuditUserId, opt => opt.MapFrom(src => src.AuditUser.Id))
                .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.DeptId, opt => opt.MapFrom(src => src.Dept.Id))
            ;

            this.CreateMap<WarehouseInOutInventoryReceiptDetailEntitiy, Drug_WarehouseReceiptDetail>()
               .ForMember(dest => dest.ClassCode, opt => opt.MapFrom(src => src.Drug.ClassCode))
               .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
               .ForMember(dest => dest.SpecificationCode, opt => opt.MapFrom(src => src.Drug.SpecificationCode))
               .ForMember(dest => dest.PurchasePrice, opt => opt.MapFrom(src => src.PurchasePrice))
               .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
               .ForMember(dest => dest.Production, opt => opt.MapFrom(src => src.Drug.Manufacturer.AsString("")))
               .ForMember(dest => dest.BatchNumber, opt => opt.MapFrom(src => src.BatchNumber))
               .ForMember(dest => dest.Memo, opt => opt.MapFrom(src => src.Memo))
           ;

            this.CreateMap<PharmacyInOutInventoryEntity, Drug_PharmacyReceipt>()
                .ForMember(dest => dest.AuditUserId, opt => opt.MapFrom(src => src.AuditUser.Id))
                .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.SourceDeptId, opt => opt.MapFrom(src => src.SourceDept.Id))
                .ForMember(dest => dest.TargetDeptId, opt => opt.MapFrom(src => src.TargetDept.Id))
            ;

            this.CreateMap<PharmacyInOutInventoryDetailEntity, Drug_PharmacyReceiptDetail>()
                .ForMember(dest => dest.ClassCode, opt => opt.MapFrom(src => src.Drug.ClassCode))
                .ForMember(dest => dest.SpecificationCode, opt => opt.MapFrom(src => src.Drug.SpecificationCode))
                ;
            this.CreateMap<View_PriceChangedDeptInfluence, PriceChangedDeptInfluenceEntity>()
                .ForMember(dest => dest.Dept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.DeptId.GetValueOrDefault(), Code = src.DeptCode, Name = src.DeptName }));

            this.CreateMap<ChangeInventoryReceiptEntity, Drug_ChangeInventoryReceipt>()
                .ForMember(dest => dest.AuditUserId, opt => opt.MapFrom(src => src.AuditUser.Id))
                .ForMember(dest => dest.DeptId, opt => opt.MapFrom(src => src.Dept.Id))
                ;

            this.CreateMap<ChangeInventoryReceiptDetailEntity, Drug_ChangeInventoryReceiptDetail>()
                .ForMember(dest => dest.ClassCode, opt => opt.MapFrom(src => src.Drug.ClassCode))
                .ForMember(dest => dest.SpecificationCode, opt => opt.MapFrom(src => src.Drug.SpecificationCode))
                ;

            //库存变更单据明细映射
            this.CreateMap<View_ChangeInventoryReceiptDetail, DrugEntity>()
                .ForMember(dest => dest.DrugName, opt => opt.MapFrom(src => src.DrugName));

            //库存变更单据明细映射
            this.CreateMap<View_ChangeInventoryReceiptDetail, ChangeInventoryReceiptDetailEntity>()
                ;

            //库存变更单据映射
            this.CreateMap<View_ChangeInventoryReceipt, ChangeInventoryReceiptEntity>()
                .ForMember(dest => dest.CreateUser, opt => opt.MapFrom(src => new UserEntity() { Id = src.CreatorUserId, Name = src.CreatorUserName, Code = src.CreatorUserCode }))
                .ForMember(dest => dest.AuditUser, opt => opt.MapFrom(src => src.AuditUserId == null ? null : new UserEntity() { Id = src.AuditUserId.Value, Name = src.AuditUserName, Code = src.AuditUserCode }))
                .ForMember(dest => dest.Dept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.DeptId, Name = src.DeptName, Code = src.DeptCode }));

            //药品调拨单据映射
            this.CreateMap<View_DrugTrasnferReceipt, DrugTransferReceipt>()
                .ForMember(dest => dest.CreateUser, opt => opt.MapFrom(src => new UserEntity() { Id = src.CreatorUserId, Name = src.CreatorUserName, Code = src.CreatorUserCode }))
                .ForMember(dest => dest.AuditUser, opt => opt.MapFrom(src => src.AuditUserId == null ? null : new UserEntity() { Id = src.AuditUserId.Value, Name = src.AuditUserName, Code = src.AuditUserCode }))
                .ForMember(dest => dest.ApplyDept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.ApplyDeptId, Name = src.ApplyDeptName, Code = src.ApplyDeptCode }))
                .ForMember(dest => dest.AcceptDept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.AcceptDeptId, Name = src.AcceptDeptName, Code = src.AcceptDeptCode }));

            //药品调拨单据明细映射
            this.CreateMap<View_DrugTransferReceiptDetailByPharmacy, DrugTransferDetailEntity>();
            //药品调拨单据明细映射
            this.CreateMap<View_DrugTransferReceiptDetailByWarehouse, DrugTransferDetailEntity>();
            //药品调拨单据明细映射
            this.CreateMap<View_DrugTransferReceiptDetailByPharmacy, DrugEntity>();
            //药品调拨单据明细映射
            this.CreateMap<View_DrugTransferReceiptDetailByWarehouse, DrugEntity>();

            this.CreateMap<DrugTransferReceipt, Drug_TransferReceipt>();
            this.CreateMap<DrugTransferDetailEntity, Drug_TransferReceiptDetail>()
                .ForMember(dest => dest.ClassCode, opt => opt.MapFrom(src => src.Drug.ClassCode))
                .ForMember(dest => dest.SpecificationCode, opt => opt.MapFrom(src => src.Drug.SpecificationCode));

        }
    }
}
