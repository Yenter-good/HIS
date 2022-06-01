using AutoMapper;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Mappers
{
    /// <summary>
    /// 系统配置
    /// </summary>
    class SysProfile : Profile
    {
        public SysProfile()
        {
            //系统映射
            this.CreateMap<SysDicDetailEntity, LongItem>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                ;

            //系统映射
            this.CreateMap<Sys_App, AppEntity>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => (DataStatus)src.DataStatus))
                .ReverseMap();

            //系统参数明细映射
            this.CreateMap<Sys_Dic_Details, SysDicDetailEntity>()
                .ReverseMap()
                ;

            this.CreateMap<SysDicDetailEntity, ItemEntity>()
                ;

            this.CreateMap<Sys_Dic, SysDicEntity>().ReverseMap();

            //菜单映射
            this.CreateMap<Sys_Menu, MenuEntity>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Text))
                .ForMember(dest => dest.Assmely, opt => opt.MapFrom(src => src.AssemblyName))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.FormName))
                .ForMember(dest => dest.Style, opt => opt.ConvertUsing(new MenuStyleValueConverter(), src => src.OpenStyle))
                .ForMember(dest => dest.Parent, opt => opt.MapFrom(src => new MenuEntity() { Id = src.ParentId }))
                .ForMember(dest => dest.AppInfo, opt => opt.MapFrom(src => new AppEntity() { Id = src.AppId }))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => (DataStatus)src.DataStatus))
                .ReverseMap()
                .ForPath(dest => dest.OpenStyle, opt => opt.MapFrom(src => src.Style != null ? Enum.GetName(typeof(MenuStyle), src.Style) : ""))
                .ForPath(dest => dest.DataStatus, opt => opt.MapFrom(src => (int)src.Status))
                .ForPath(dest => dest.ParentId, opt => opt.MapFrom(src => src.Parent.Id))
                .ForPath(dest => dest.AppId, opt => opt.MapFrom(src => src.AppInfo.Id))
                ;
            //机构映射
            this.CreateMap<Sys_Org, OrganizationInfo>();
            //科室映射
            this.CreateMap<Sys_Dept, DeptEntity>()
                .ForMember(dest => dest.Parent, opt => opt.MapFrom(src => new DeptEntity() { Id = src.ParentId }))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => new ItemEntity() { Id = src.CategoryId }))
                .ReverseMap()
                ;

            //科室实体-科室视图
            this.CreateMap<View_Dept, DeptEntity>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.CategoryId == null ? null : new ItemEntity() { Id = src.CategoryId.Value, Code = src.CategoryCode, Value = src.CategoryName }))
                 .ForMember(dest => dest.Parent, opt => opt.MapFrom(src => new DeptEntity() { Id = src.ParentId, Name = src.ParentName, Code = src.ParentCode }))
                 ;

            //科室实体-科室表
            this.CreateMap<DeptEntity, Sys_Dept>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.AliasName, opt => opt.MapFrom(src => src.AliasName))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.Id))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.Parent == null ? 0 : src.Parent.Id))
                .ForMember(dest => dest.SearchCode, opt => opt.MapFrom(src => src.SearchCode))
                 ;

            //角色映射
            this.CreateMap<Sys_Role, RoleEntity>()
                .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.RoleLevel))
                ;

            //用户映射
            this.CreateMap<Sys_User, UserEntity>()
                 .ForMember(dest => dest.UserType, opt => opt.MapFrom(src => (UserType)src.UserType))
                .ForMember(dest => dest.HosInfo, opt => opt.MapFrom(src => new OrganizationInfo() { Id = src.HosId }))
                .ForMember(dest => dest.Education, opt => opt.MapFrom(src => src.EducationId == null ? null : new LongItem(src.EducationId.Value, "", "")))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.RoleId == null ? null : new RoleEntity() { Id = src.RoleId.Value }))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.DataStatus))
                ;
            //用户映射
            this.CreateMap<UserEntity, Sys_User>()
                 .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                 .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                 .ForMember(dest => dest.UserType, opt => opt.MapFrom(src => (int)src.UserType))
                 .ForMember(dest => dest.TitleId, opt => opt.MapFrom(src => src.Title.TitleId))
                 .ForMember(dest => dest.UserNature, opt => opt.MapFrom(src => (int)src.UserNature))
                 .ForMember(dest => dest.EducationId, opt => opt.MapFrom(src => src.Education.Key))
                 .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.Role.Id))
                 .ForMember(dest => dest.IDCard, opt => opt.MapFrom(src => src.IDCard))
                 .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => src.Birthday))
                 .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                 .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                ;

            //用户映射
            this.CreateMap<UserEntity, Sys_User>()
                .ForMember(dest => dest.EducationId, opt => opt.MapFrom(src => src.Education == null ? -1 : src.Education.Key))
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.Role == null ? -1 : Convert.ToInt64(src.Role.Id)))
                ;
            //字典映射
            this.CreateMap<Sys_Dic_Details, ItemEntity>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => (DataStatus)src.DataStatus))
                ;

            //用户视图 用户映射
            this.CreateMap<View_User, UserEntity>()
                .ForMember(dest => dest.UserType, opt => opt.MapFrom(src => (UserType)src.UserType))
                .ForMember(dest => dest.HosInfo, opt => opt.MapFrom(src => new OrganizationInfo() { Id = src.HosId, Name = src.HosName, Code = src.HosCode }))
                .ForMember(dest => dest.Education, opt => opt.MapFrom(src => src.EducationId == null ? null : new LongItem(src.EducationId.Value, src.EducationValue, "")))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => new TitleEntity() { TitleLevel = src.TitleLevel, TitleName = src.TitleName, TitleId = src.TitleId }))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.DefaultRoleId == null ? null : new RoleEntity() { Id = src.DefaultRoleId.Value, Name = src.DefaultRoleName, Code = src.DefaultRoleCode }))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.DataStatus))
                ;

            //职级映射
            this.CreateMap<Dic_Position, PositionEntity>()
                .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.PostionLevel))
                .ReverseMap();

            //角色附加信息映射
            this.CreateMap<View_RoleAddition, RoleAdditionalEntity>()
                .ForMember(dest => dest.AllowStartTime, opt => opt.MapFrom(src => src.AllowStartTime))
                .ForMember(dest => dest.AllowEndTime, opt => opt.MapFrom(src => src.AllowEndTime))
                .ForMember(dest => dest.DefaultDept, opt => opt.MapFrom(src => src.DefaultDeptId == null ? null : new DeptEntity() { Id = src.DefaultDeptId.Value, Code = src.DefaultDeptCode, Name = src.DefaultDeptName }))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.RoleId == null ? null : new RoleEntity() { Id = src.RoleId.Value, Code = src.RoleCode, Name = src.RoleName }))
                .ForMember(dest => dest.Teacher, opt => opt.MapFrom(src => src.TeacherId == null ? null : new UserEntity() { Id = src.TeacherId.Value, Code = src.TeacherCode, Name = src.TeacherName }));
            //系统参数映射
            this.CreateMap<Sys_Parameter, SysParameterEntity>();
            //用户参数映射
            this.CreateMap<Sys_UserParameter, UserParameterEntity>();
            //费用类型映射
            this.CreateMap<Dic_FeeType, FeeTypeEntity>().ReverseMap();
            //物价项目映射
            this.CreateMap<Dic_FeeItem, FeeItemEntity>().ReverseMap();
            //字典目录映射
            this.CreateMap<Dic_Catalog, CatalogEntity>().ReverseMap();
            //流水号映射
            this.CreateMap<Dic_SerialNumber, SerialNumberEntity>().ReverseMap();
        }
    }

    class MenuStyleValueConverter : IValueConverter<string, MenuStyle?>
    {
        public MenuStyle? Convert(string sourceMember, ResolutionContext context)
        {
            MenuStyle style = MenuStyle.Tab;
            if (Enum.TryParse<MenuStyle>(sourceMember, true, out style))
                return style;
            return null;
        }
    }
}
