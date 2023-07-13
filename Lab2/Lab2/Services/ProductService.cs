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
        int skip = (pqp.PageIndex - 1) * pqp.PageSize;
        int take = pqp.PageSize;
        var products = await _productRepository.GetListAsync(null, pqp.OrderBy, skip, take, pqp.IsDescending);
        var productCount = await _productRepository.CountAsync();
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
        var product = _mapper.Map<Product>(productDto);
        _productRepository.Update(product);
        await _unitOfWork.CommitAsync();
        return productDto;
    }

    public async Task<bool> DeleteAsync(int productId)
    {
        _productRepository.Delete(new Product { Id = productId });
        return await _unitOfWork.CommitAsync() > 0;
    }
}
