using Recommendations.API.Shopping.Domain.Models;
using Recommendations.API.Shopping.Domain.Services.Communication;

namespace Recommendations.API.Shopping.Domain.Services;

public interface IProductService
{
    Task<IEnumerable<Product>> ListAsync();
    Task<IEnumerable<Product>> ListBySubcategoriaAsync(string subcategoria);
    Task<ProductResponse> FindByUrlAsync(string url);
    Task<ProductResponse> SaveAsync(Product product);
}