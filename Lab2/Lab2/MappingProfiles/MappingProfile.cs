using System.Xml;
using AutoMapper;
using Lab2.DomainModels;
using Lab2.DTOs.Account;
using Lab2.DTOs.Contact;
using Lab2.DTOs.Deal;
using Lab2.DTOs.DealProduct;
using Lab2.DTOs.Lead;
using Lab2.DTOs.Product;
using Lab2.DTOs.User;
using Lab2.Entities;

namespace Lab2.MappingProfiles;

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
        CreateMap<LeadStatistics, LeadStatisticsDto>();

        CreateMap<UpsertContactDto, Contact>();
        CreateMap<Contact, GetContactDto>()
            .ForMember(dto => dto.AccountName, opt => opt.MapFrom(c => c.Account!.Name));

        CreateMap<Deal, GetDealDto>();
        CreateMap<Deal, GetDealDetailDto>()
            .ForMember(dto => dto.EstimatedRevenue, opt => opt.MapFrom(deal => deal.Lead!.EstimatedRevenue))
            .ForMember(dto => dto.AccountName, opt => opt.MapFrom(deal => deal.Lead!.Account!.Name))
            .ForMember(dto => dto.AccountId, opt => opt.MapFrom(deal => deal.Lead!.AccountId));
        CreateMap<UpdateDealDto, Deal>();
        CreateMap<DealStatistics, DealStatisticsDto>();

        CreateMap<AddDealProductDto, DealProduct>();
        CreateMap<UpdateDealProductDto, DealProduct>();
        CreateMap<DealProduct, GetDealProductDto>()
            .ForMember(dto => dto.TotalAmount, opt => opt.MapFrom(dp => dp.Quantity * dp.PricePerUnit))
            .ForMember(dto => dto.ProductCode, opt => opt.MapFrom(dp => dp.Product!.ProductCode))
            .ForMember(dto => dto.Name, opt => opt.MapFrom(dp => dp.Product!.Name));

        CreateMap<User, GetUserDto>();
        CreateMap<CreateUserDto, User>()
            .ForMember(u => u.UserName, opt => opt.MapFrom(dto => dto.Email));
        CreateMap<UpdateUserDto, User>()
            .ForMember(u => u.UserName, opt => opt.MapFrom(dto => dto.Email));
    }
}
