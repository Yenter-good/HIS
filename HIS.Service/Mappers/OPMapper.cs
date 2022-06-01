using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Model;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;

namespace HIS.Service.Mappers
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-28 11:07:45
    /// 描述:
    /// </summary>
    class OPMapper : Profile
    {
        public OPMapper()
        {
            //门诊病人诊断映射
            this.CreateMap<OP_PatientDiagnosis, PatientDiagnosisEntity>()
                .ForMember(dest => dest.Diagnosis, opt => opt.MapFrom(src => new DiagnosisEntity() { Code = src.Code, Name = src.Name, Type = (DiagnosisType)src.Type, Length = src.Name.Length }))
                .ForMember(dest => dest.CreatorUser, opt => opt.MapFrom(src => new UserEntity() { Id = src.CreatorUserId }))
                .ReverseMap()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Diagnosis.Code))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Diagnosis.Name))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Diagnosis.Type))
                ;
            //门诊患者映射
            this.CreateMap<IView_HIS_Outpatients, OutpatientEntity>()
                .ForMember(dest => dest.Dept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.DeptId, Code = src.DeptCode, Name = src.DeptName }))
                .ForMember(dest => dest.Doctor, opt => opt.MapFrom(src => new UserEntity() { Id = src.DoctorId, Code = src.DoctorCode, Name = src.DoctorName }))
                .ForMember(dest => dest.FirstAcceptDoctor, opt => opt.MapFrom(src => new UserEntity() { Id = src.FirstAcceptDoctorId, Code = src.FirstAcceptDoctorCode, Name = src.FirstAcceptDoctorName }))
                ;
            //诊疗及材料
            this.CreateMap<IOP_DealWithItem, DealWithItemEntity>()
                .ReverseMap();

            //诊疗及材料
            this.CreateMap<View_OPDealWithItem, DealWithItemEntity>()
                .ForMember(dest => dest.ExecDept, opt => opt.MapFrom(src => src.ExecDeptId == null ? null : new DeptEntity() { Id = src.ExecDeptId.Value, Code = src.ExecDeptCode, Name = src.ExecDeptName }))
                .ForMember(dest => dest.ItemType, opt => opt.MapFrom(src => src.ItemType))
                .ReverseMap();

            //医生套餐
            this.CreateMap<OP_PrescriptionGroup, PrescriptionGroupEntity>()
                .ReverseMap();

            //医生套餐明细 获取信息时
            this.CreateMap<View_OPGroupDetail, PrescriptionGroupDetailEntity>()
                .ReverseMap();

            //处方类型
            this.CreateMap<OP_PrescriptionType, PrescriptionTypeEntity>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.DrugCategory))
                ;

            //医生套餐明细 保存实体时
            this.CreateMap<PrescriptionGroupDetailEntity, OP_PrescriptionGroupDetail>()
                .ReverseMap();

            //病人处方
            this.CreateMap<View_Prescription, PrescriptionEntity>()
                .ForMember(dest => dest.Creator, opt => opt.MapFrom(src => new UserEntity() { Code = src.DoctorCode, Name = src.DoctorName }))
                .ForMember(dest => dest.Outpatient, opt => opt.MapFrom(src => new OutpatientEntity() { OutpatientNo = src.OutpatientNo, PatientName = src.PatientName }))
                .ForMember(dest => dest.Dept, opt => opt.MapFrom(src => new DeptEntity() { Code = src.DeptCode, Name = src.DeptName }))
                .ForMember(dest => dest.PrescriptionType, opt => opt.Ignore())
                .ForMember(dest => dest.Diagnosis, opt => opt.MapFrom(src => new DiagnosisEntity() { Code = src.DiagnosisCode, Name = src.DiagnosisName }))
                .ForMember(dest => dest.HerbalMedicineUsage, opt => opt.MapFrom(src => new UsageEntity() { Code = src.HerbalMedicineUsage }))
                ;

            //病人处方明细
            this.CreateMap<View_PrescriptionDetail, PrescriptionDetailEntity>()
                .ForMember(dest => dest.Usage, opt => opt.MapFrom(src => new UsageEntity() { Code = src.Usage, Name = src.UsageName }))
                .ForMember(dest => dest.Interval, opt => opt.MapFrom(src => new IntervalEntity() { Code = src.Interval, Name = src.IntervalName }))
                .ForMember(dest => dest.ExecDept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.ExecDeptId, Code = src.ExecDeptCode, Name = src.ExecDeptName }))
                ;

            //慢性病病种
            this.CreateMap<OP_ChronicDiseases, DiseasesEntity>().ReverseMap();


            //慢性病可开药品明细 查询
            this.CreateMap<View_OPDiseasesDetail, DiseasesMapperEntity>().ReverseMap();

            //慢性病可开药品明细 保存
            this.CreateMap<DiseasesMapperEntity, OP_ChronicDiseasesMapper>().ReverseMap();

            //门诊日志映射
            this.CreateMap<OP_Journal, PatientJournalEntity>()
                .ForMember(dest => dest.FirstAcceptDoctor, opt => opt.MapFrom(src => new UserEntity() { Id = src.FirstAcceptDoctorId.GetValueOrDefault(0) }))
                .ForMember(dest => dest.Dept, opt => opt.MapFrom(src => new DeptEntity() { Id = src.DeptId }))
                .ForMember(dest => dest.Doctor, opt => opt.MapFrom(src => new UserEntity() { Id = src.DoctorId }))
                .ForMember(dest => dest.Blood, opt => opt.MapFrom(src => new LongItem() { Key = src.BloodId }))
                .ForMember(dest => dest.Marry, opt => opt.MapFrom(src => new LongItem() { Key = src.MarryId }))
                .ForMember(dest => dest.Nationality, opt => opt.MapFrom(src => new LongItem() { Key = src.NationalityId }))
                .ForMember(dest => dest.Nation, opt => opt.MapFrom(src => new LongItem() { Key = src.NationId }))
                .ForMember(dest => dest.Knowlage, opt => opt.MapFrom(src => new LongItem() { Key = src.KnowlageId }))
                .ForMember(dest => dest.Job, opt => opt.MapFrom(src => new LongItem() { Key = src.JobId }))
                .ReverseMap()
                .ForMember(dest => dest.FirstAcceptDoctorId, opt => opt.MapFrom(src => src.FirstAcceptDoctor.Id))
                .ForMember(dest => dest.DeptId, opt => opt.MapFrom(src => src.Dept.Id))
                .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => src.Doctor.Id))
                .ForMember(dest => dest.BloodId, opt => opt.MapFrom(src => src.Blood.Key))
                .ForMember(dest => dest.MarryId, opt => opt.MapFrom(src => src.Marry.Key))
                .ForMember(dest => dest.NationalityId, opt => opt.MapFrom(src => src.Nationality.Key))
                .ForMember(dest => dest.NationId, opt => opt.MapFrom(src => src.Nation.Key))
                .ForMember(dest => dest.KnowlageId, opt => opt.MapFrom(src => src.Knowlage.Key))
                .ForMember(dest => dest.JobId, opt => opt.MapFrom(src => src.Job.Key))
                ;

            this.CreateMap<OP_DiagnosisGroup, DeptDiagnosisEntity>().ReverseMap();

            this.CreateMap<DrugInventoryEntity, PrescriptionDrugEntity>()
                .ForMember(dest => dest.ExecDept, opt => opt.MapFrom(src => src.Dept))
                .ForMember(dest => dest.Dose, opt => opt.MapFrom(src => src.MinDose))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.BigPackagePrice))
                ;

            //门诊大模板映射
            this.CreateMap<OP_BigTemplate, BigTemplateEntity>().ReverseMap();
            //门诊数据源映射
            this.CreateMap<OP_DataElement, DataElementEntity>().ReverseMap();

            //门诊处方映射
            this.CreateMap<PrescriptionEntity, OP_Prescription>()
                .ForMember(dest => dest.DoctorCode, opt => opt.MapFrom(src => src.Creator.Code))
                .ForMember(dest => dest.OutpatientNo, opt => opt.MapFrom(src => src.Outpatient.OutpatientNo))
                .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Outpatient.PatientName))
                .ForMember(dest => dest.PrescriptionType, opt => opt.MapFrom(src => src.PrescriptionType.Code))
                .ForMember(dest => dest.DeptId, opt => opt.MapFrom(src => src.Dept.Id))
                .ForMember(dest => dest.DeptCode, opt => opt.MapFrom(src => src.Dept.Code))
                .ForMember(dest => dest.DiagnosisCode, opt => opt.MapFrom(src => src.Diagnosis.Code))
                .ForMember(dest => dest.HerbalMedicineUsage, opt => opt.MapFrom(src => src.HerbalMedicineUsage.Code))
                ;

            //门诊处方明细映射
            this.CreateMap<PrescriptionDetailEntity, OP_PrescriptionDetail>()
                .ForMember(dest => dest.ExecDeptId, opt => opt.MapFrom(src => src.ExecDept.Id))
                .ForMember(dest => dest.ExecDeptCode, opt => opt.MapFrom(src => src.ExecDept.Code))
                .ForMember(dest => dest.Interval, opt => opt.MapFrom(src => src.Interval.Code))
                .ForMember(dest => dest.Usage, opt => opt.MapFrom(src => src.Usage.Code))
                ;

            //处方明细实体转处方明细药品实体
            this.CreateMap<PrescriptionDetailEntity, PrescriptionDrugEntity>()
                .ForMember(dest => dest.PatientSkinTestFlag, opt => opt.MapFrom(src => src.SkinTestFlag))
                .ForMember(dest => dest.SkinTestFlag, opt => opt.Ignore())
                .ForMember(dest => dest.DrugName, opt => opt.MapFrom(src => src.ItemName))
                ;

            this.CreateMap<PrescriptionDrugEntity, PrescriptionDetailEntity>()
                .ForMember(dest => dest.ItemName, opt => opt.MapFrom(src => src.DrugName))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.BigPackageFlag ? src.BigPackagePrice : src.SmallPackagePrice))
                .ForMember(dest => dest.SkinTestFlag, opt => opt.MapFrom(src => src.PatientSkinTestFlag))
                .ForMember(dest => dest.PackageUnit, opt => opt.MapFrom(src => src.BigPackageFlag ? src.BigPackageUnit : src.SmallPackageUnit))
                .ForMember(dest => dest.DoseUnit, opt => opt.MapFrom(src => src.MinDoseUnit))
                ;

            //治疗项目实体转处方明细药品实体
            this.CreateMap<DealWithItemEntity, PrescriptionDrugEntity>()
                 .ForMember(dest => dest.SpecificationCode, opt => opt.MapFrom(src => src.Code))
                 .ForMember(dest => dest.DrugName, opt => opt.MapFrom(src => src.Name))
                 .ForMember(dest => dest.BigPackagePrice, opt => opt.MapFrom(src => src.Price))
                 .ForMember(dest => dest.BigPackageUnit, opt => opt.MapFrom(src => src.PackageUnit))
                 .ForMember(dest => dest.SearchCode, opt => opt.MapFrom(src => src.SearchCode))
                 .ForMember(dest => dest.WubiCode, opt => opt.MapFrom(src => src.WubiCode))
                 .ForMember(dest => dest.CustomPriceFlag, opt => opt.MapFrom(src => src.Price == 0 ? true : false))
                 ;

            this.CreateMap<AdviceEntity, PrescriptionDrugEntity>()
                .ForMember(dest => dest.DrugName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.BigPackagePrice, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.SpecificationCode, opt => opt.MapFrom(src => src.Code))
                ;
            //模板范文映射
            this.CreateMap<OP_TemplateSample, TemplateSampleEntity>().ReverseMap();
            //子模板映射
            this.CreateMap<OP_SubTemplateSample, SubTemplateSampleEntity>().ReverseMap(); 
            this.CreateMap<AdviceEntity, PrescriptionAdviceEntity>();
            //病历映射
            this.CreateMap<OP_MedicalRecord, MedicalRecordEntity>().ReverseMap();
        }
    }
}
