using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using AutoMapper;
using Lab2.Data;
using Lab2.DTOs.Product;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;
using Lab2.Services.Interfaces;

namespace Lab2.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PagedResult<ProductDto>> GetListAsync(ProductQueryParameters pqp)
    {
        // 1. Get products based on filter function and paging parameters
        // 2. Get total count for paging
        var (products, productCount) = await _productRepository.GetProductPagedListAsync(pqp);
        // 3. Map and return
        var result = _mapper.Map<List<ProductDto>>(products);
        return new PagedResult<ProductDto>(result, productCount, pqp.PageIndex, pqp.PageSize);
    }

    public async Task<ProductDto?> GetByIdAsync(int id)
    {
        return _mapper.Map<ProductDto>(await _productRepository.GetByIdAsync(id));
    }

    public async Task<ProductDto> CreateAsync(ProductDto productDto)
    {
        var product = _mapper.Map<Product>(productDto);
        _productRepository.Add(product);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ProductDto>(product);
    }

    public async Task<ProductDto> UpdateAsync(ProductDto productDto)
    {
        // 1. Get product from database
        var product = await _productRepository.GetByIdAsync(productDto.Id);
        // 2. Update product 
        _mapper.Map(productDto, product);
        await _unitOfWork.CommitAsync();
        return productDto;
    }

    public async Task<bool> DeleteAsync(int productId)
    {
        _productRepository.Delete(new Product { Id = productId });
        return await _unitOfWork.CommitAsync() > 0;
    }
}
