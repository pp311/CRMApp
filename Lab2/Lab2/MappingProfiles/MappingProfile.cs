using AutoMapper;
using Lab2.DTOs.Account;
using Lab2.DTOs.Contact;
using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.Product;
using Lab2.Entities;

namespace Lab2.MappingProfiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();

        CreateMap<Account, AccountDto>().ReverseMap();

        CreateMap<Lead, LeadDto>().ReverseMap();
        CreateMap<AddLeadDto, Lead>();

        CreateMap<Contact, ContactDto>().ReverseMap();

        CreateMap<Deal, DealDto>().ReverseMap();
        CreateMap<Deal, GetDealDto>().ForMember(dto => dto.EstimatedRevenue, opt => opt.MapFrom(deal => deal.Lead!.EstimatedRevenue));

        CreateMap<AddDealProductDto, DealProduct>();
        CreateMap<DealProduct, GetDealProductDto>()
            .ForMember(dto => dto.TotalAmount, opt => opt.MapFrom(dp => dp.Quantity * dp.PricePerUnit))
            .ForMember(dto => dto.ProductCode, opt => opt.MapFrom(dp => dp.Product!.ProductCode))
            .ForMember(dto => dto.Name, opt => opt.MapFrom(dp => dp.Product!.Name));
    }
}
