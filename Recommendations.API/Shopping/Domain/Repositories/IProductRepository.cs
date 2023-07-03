using Recommendations.API.Shopping.Domain.Models;

namespace Recommendations.API.Shopping.Domain.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> ListAsync();
    Task AddAsync(Product product);
    Task<Product> FindByUrlAsync(string url);
    Task<IEnumerable<Product>> ListBySubcategoriaAsync(string subcategoria);
}