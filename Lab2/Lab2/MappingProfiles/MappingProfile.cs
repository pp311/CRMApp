using AutoMapper;
using Lab2.DTOs.Account;
using Lab2.DTOs.Product;
using Lab2.Entities;

namespace Lab2.MappingProfiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Account, AccountDto>().ReverseMap();
    }
}
