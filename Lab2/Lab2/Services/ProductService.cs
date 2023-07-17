using AutoMapper;
using Lab2.Data;
using Lab2.DTOs.Product;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Exceptions;
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
    
    private async Task ValidateSavingProduct(ProductDto productDto)
    {
        // Validate product code uniqueness
        if (!string.IsNullOrEmpty(productDto.ProductCode))
        {
           if (await _productRepository.IsExistAsync(p => p.ProductCode == productDto.ProductCode 
                                                           && p.Id != productDto.Id))
               throw new EntityValidationException($"Product code {productDto.ProductCode} is already existed"); 
        } 
    }

    public async Task<PagedResult<ProductDto>> GetListAsync(ProductQueryParameters pqp)
    {
        // 1. Get products based on filter and paging parameters
        // 2. Get total count for paging
        var (products, productCount) = await _productRepository.GetProductPagedListAsync(search: pqp.Search,
                                                                                         type: pqp.Type,
                                                                                         orderBy: pqp.OrderBy,
                                                                                         skip: (pqp.PageIndex - 1) * pqp.PageSize,
                                                                                         take: pqp.PageSize,
                                                                                         isDescending: pqp.IsDescending);
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
        await ValidateSavingProduct(productDto);
        
        var product = _mapper.Map<Product>(productDto);
        _productRepository.Add(product);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ProductDto>(product);
    }

    public async Task<ProductDto> UpdateAsync(ProductDto productDto)
    {
        // 1. Validate product code uniqueness
        await ValidateSavingProduct(productDto);
        // 2. Get product from database
        var product = await _productRepository.GetByIdAsync(productDto.Id);
        if (product == null)
            throw new EntityNotFoundException($"Product with id {productDto.Id} not found");
        // 3. Update product 
        _mapper.Map(productDto, product);
        await _unitOfWork.CommitAsync();
        return productDto;
    }

    public async Task DeleteAsync(int productId)
    {
        _productRepository.Delete(new Product { Id = productId });
        await _unitOfWork.CommitAsync();
    }
}
