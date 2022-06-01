using AutoMapper;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Mappers
{
    class DicProfile : Profile
    {
        public DicProfile()
        {
            //生产厂家、供应商映射
            this.CreateMap<Dic_Merchants, MerchantsEntity>()
                .ReverseMap();

            //医嘱映射
            this.CreateMap<Dic_Advice, AdviceEntity>()
                .ReverseMap();

            //医嘱映射
            this.CreateMap<View_Advice, AdviceEntity>()
                .ForMember(dest => dest.Sample, opt => opt.MapFrom(src => src.SampleId == null ? null : new LongItem(src.SampleId.Value, src.SampleName, src.SampleCode)))
                .ForMember(dest => dest.Buret, opt => opt.MapFrom(src => src.BuretId == null ? null : new LongItem(src.BuretId.Value, src.BuretName, src.BuretCode)))
                .ForMember(dest => dest.Part, opt => opt.MapFrom(src => src.PartId == null ? null : new LongItem(src.PartId.Value, src.PartName, src.PartCode)))
                .ForMember(dest => dest.Modality, opt => opt.MapFrom(src => src.ModalityId == null ? null : new LongItem(src.ModalityId.Value, src.ModalityName, src.ModalityCode)))
                .ForMember(dest => dest.DataStatus, opt => opt.MapFrom(src => (DataStatus)src.DataStatus))
                .ReverseMap();

            //医嘱分类映射
            this.CreateMap<Dic_AdviceCategory, AdviceCategoryEntity>()
                .ForMember(dest => dest.Parent, opt => opt.MapFrom(src => new AdviceCategoryEntity() { Id = src.ParentId }))
                .ForMember(dest => dest.Dept, opt => opt.MapFrom(src => src.DeptId == null ? null : new DeptEntity() { Id = src.DeptId.Value }))
                .ReverseMap();


            //医嘱分类映射
            this.CreateMap<View_AdviceCategory, AdviceCategoryEntity>()
                .ForMember(dest => dest.Parent, opt => opt.MapFrom(src => new AdviceCategoryEntity() { Id = src.ParentId }))
                .ForMember(dest => dest.Dept, opt => opt.MapFrom(src => src.DeptId == null ? null : new DeptEntity() { Id = src.DeptId.Value, Name = src.DeptName, Code = src.DeptCode }))
                ;

            this.CreateMap<Dic_AdviceFeeItemMapper, AdviceFeeItemMapperEntity>()
                .ReverseMap();

            //用法映射
            this.CreateMap<Dic_Usage, UsageEntity>()
                ;

            //间隔映射
            this.CreateMap<Dic_Interval, IntervalEntity>()
                .ForMember(dest => dest.IntervalTimeText, opt => opt.MapFrom(src => src.IntervalTime))
                .ForMember(dest => dest.IntervalTime, opt => opt.Ignore())
                .ForMember(dest => dest.LoopTime, opt => opt.MapFrom(src => src.LoopTime == null ? TimeSpan.Zero : src.LoopTime.Value.TimeOfDay))
                ;

            //诊断映射
            this.CreateMap<View_ICD, DiagnosisEntity>()
                ;
            //诊断映射
            this.CreateMap<View_DiagnosisGroup, DiagnosisEntity>()
                ;

            //科室对应药房 保存
            this.CreateMap<DeptPharmacyEntity, Dic_DeptPharmacyMapper>();

            //科室对应药房 查询
            this.CreateMap<View_DeptPharmacyMapper, DeptPharmacyEntity>();

            //科室对应药房 查询
            this.CreateMap<View_DeptPharmacyMapper, DeptEntity>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.CategoryId == null ? null : new ItemEntity() { Id = src.CategoryId.Value, Value = src.CategoryName, Code = src.CategoryCode }))
                .ReverseMap();



        }


    }
}
