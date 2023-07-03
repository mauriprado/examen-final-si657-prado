using Recommendations.API.Shared.Domain.Repositories;
using Recommendations.API.Shopping.Domain.Models;
using Recommendations.API.Shopping.Domain.Repositories;
using Recommendations.API.Shopping.Domain.Services;
using Recommendations.API.Shopping.Domain.Services.Communication;

namespace Recommendations.API.Shopping.Services;

public class ProductService: IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Product>> ListAsync()
    {
        return await _productRepository.ListAsync();
    }

    public async Task<IEnumerable<Product>> ListBySubcategoriaAsync(string subcategoria)
    {
        return await _productRepository.ListBySubcategoriaAsync(subcategoria);
    }

    public async Task<ProductResponse> FindByUrlAsync(string url)
    {
        var existingProduct = await _productRepository.FindByUrlAsync(url);
        return existingProduct == null ? new ProductResponse("Invalid product") : new ProductResponse(existingProduct);
    }

    public async Task<ProductResponse> SaveAsync(Product product)
    {
        var existingProduct = await _productRepository.FindByUrlAsync(product.Url);
        if (existingProduct != null)
        {
            return new ProductResponse("Product with url exists.");
        }

        try
        {
            await _productRepository.AddAsync(product);
            await _unitOfWork.CompleteAsync();
            return new ProductResponse(product);
        }
        catch (Exception e)
        {
            return new ProductResponse($"An error occurred while saving the product: {e.Message}");
        }
    }
}