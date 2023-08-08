using AutoMapper;
using Lab2.Application.DTOs.Account;
using Lab2.Application.DTOs.Contact;
using Lab2.Application.DTOs.Deal;
using Lab2.Application.DTOs.DealProduct;
using Lab2.Application.DTOs.Lead;
using Lab2.Application.DTOs.Product;
using Lab2.Application.DTOs.Role;
using Lab2.Application.DTOs.User;
using Lab2.Application.Permissions;
using Lab2.Domain.DomainModels;
using Lab2.Domain.Entities;
using Lab2.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace Lab2.Infrastructure.MappingProfiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, GetProductDto>();
        CreateMap<UpsertProductDto, Product>();

        CreateMap<UpsertAccountDto, Account>();
        CreateMap<Account, GetAccountDto>();

        CreateMap<Lead, GetLeadDto>()
            .ForMember(dto => dto.AccountName, opt => opt.MapFrom(lead => lead.Account!.Name));
        CreateMap<UpdateLeadDto, Lead>();
        CreateMap<AddLeadDto, Lead>();
        CreateMap<LeadStatisticsModel, LeadStatisticsDto>();

        CreateMap<UpsertContactDto, Contact>();
        CreateMap<Contact, GetContactDto>()
            .ForMember(dto => dto.AccountName, opt => opt.MapFrom(c => c.Account!.Name));

        CreateMap<Deal, GetDealDto>();
        CreateMap<Deal, GetDealDetailDto>()
            .ForMember(dto => dto.EstimatedRevenue, opt => opt.MapFrom(deal => deal.Lead!.EstimatedRevenue))
            .ForMember(dto => dto.AccountName, opt => opt.MapFrom(deal => deal.Lead!.Account!.Name))
            .ForMember(dto => dto.AccountId, opt => opt.MapFrom(deal => deal.Lead!.AccountId));
        CreateMap<UpdateDealDto, Deal>();
        CreateMap<DealStatisticsModel, DealStatisticsDto>();

        CreateMap<AddDealProductDto, DealProduct>();
        CreateMap<UpdateDealProductDto, DealProduct>();
        CreateMap<DealProduct, GetDealProductDto>()
            .ForMember(dto => dto.TotalAmount, opt => opt.MapFrom(dp => dp.Quantity * dp.PricePerUnit))
            .ForMember(dto => dto.ProductCode, opt => opt.MapFrom(dp => dp.Product!.ProductCode))
            .ForMember(dto => dto.Name, opt => opt.MapFrom(dp => dp.Product!.Name));

        CreateMap<User, GetUserDto>();
        CreateMap<ApplicationUser, User>().ReverseMap()
            .ForMember(u => u.UserName, opt => opt.MapFrom(dto => dto.Email))
            .ForMember(u => u.UserName, opt => opt.MapFrom(dto => dto.Email));
        CreateMap<CreateUserDto, User>();
        CreateMap<UpdateUserDto, User>();
        
        CreateMap<UpdateRoleDto, Role>()
            .ForMember(r => r.Claims, opt => opt.MapFrom(dto => dto.Permissions.Select(p => new RoleClaim{ClaimType = CustomClaimTypes.Permission, ClaimValue = p})));
        CreateMap<Role, GetRoleDto>()
            .ForMember(dto => dto.Permissions, opt => opt.MapFrom(role => role.Claims.Select(p => p.ClaimValue)));
        CreateMap<ApplicationRole, Role>().ReverseMap();
        CreateMap<IdentityRoleClaim<int>, RoleClaim>().ReverseMap();
    }
}
