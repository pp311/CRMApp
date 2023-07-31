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
    
    public async Task<PagedResult<GetProductDto>> GetListAsync(ProductQueryParameters pqp)
    {
        var (products, productCount) = await _productRepository.GetProductPagedListAsync(search: pqp.Search,
                                                                                         type: pqp.Type,
                                                                                         orderBy: pqp.OrderBy,
                                                                                         skip: (pqp.PageIndex - 1) * pqp.PageSize,
                                                                                         take: pqp.PageSize,
                                                                                         isDescending: pqp.IsDescending);
        var result = _mapper.Map<List<GetProductDto>>(products);
        return new PagedResult<GetProductDto>(result, productCount, pqp.PageIndex, pqp.PageSize);
    }
    
    public async Task<GetProductDto?> GetByIdAsync(int id)
    {
        return _mapper.Map<GetProductDto>(await _productRepository.GetByIdAsync(id));
    }

    public async Task<GetProductDto> CreateAsync(UpsertProductDto productDto)
    {
        await ValidateSavingProduct(productDto);
        
        var product = _mapper.Map<Product>(productDto);
        _productRepository.Add(product);
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<GetProductDto>(product);
    }

    public async Task<GetProductDto> UpdateAsync(int productId, UpsertProductDto productDto)
    {
        // 1. Validate product code uniqueness
        await ValidateSavingProduct(productDto, productId);
        
        // 2. Get product from database
        var product = await _productRepository.GetByIdAsync(productId)
            ?? throw new EntityNotFoundException($"Product with id {productId} not found");
        
        // 3. Update product 
        _mapper.Map(productDto, product);
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<GetProductDto>(product);
    }

    public async Task DeleteAsync(int productId)
    {
        if (!await _productRepository.IsProductExistAsync(productId))
            throw new EntityNotFoundException($"Product with id {productId} not found");
        
        _productRepository.Delete(new Product { Id = productId });
        await _unitOfWork.SaveChangesAsync();
    }
    
    // Product validation
    private async Task ValidateSavingProduct(UpsertProductDto productDto, int productId = 0) 
    { 
        // Validate product code uniqueness
        if (!string.IsNullOrEmpty(productDto.ProductCode) 
            && await _productRepository.IsProductCodeExistAsync(productDto.ProductCode, productId))
        {
               throw new EntityValidationException($"Product code {productDto.ProductCode} is already existed"); 
        } 
    }
}
