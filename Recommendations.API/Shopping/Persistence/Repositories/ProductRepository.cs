using Microsoft.EntityFrameworkCore;
using Recommendations.API.Shared.Persistence.Context;
using Recommendations.API.Shared.Persistence.Repositories;
using Recommendations.API.Shopping.Domain.Models;
using Recommendations.API.Shopping.Domain.Repositories;

namespace Recommendations.API.Shopping.Persistence.Repositories;

public class ProductRepository: BaseRepository, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Product>> ListAsync()
    {
        return await Context.Products.ToListAsync();
    }

    public async Task AddAsync(Product product)
    {
        await Context.Products.AddAsync(product);
    }

    public async Task<Product> FindByUrlAsync(string url)
    {
        return await Context.Products.FirstOrDefaultAsync(p => p.Url == url);
    }

    public async Task<IEnumerable<Product>> ListBySubcategoriaAsync(string subcategoria)
    {
        return await Context.Products
            .Where(p => p.Subcategoria == subcategoria)
            .ToListAsync();
    }
}