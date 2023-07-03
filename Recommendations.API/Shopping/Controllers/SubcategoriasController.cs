using Microsoft.AspNetCore.Mvc;
using Recommendations.API.Shopping.Domain.Models;
using Recommendations.API.Shopping.Domain.Services;

namespace Recommendations.API.Shopping.Controllers;

[ApiController]
[Route("/api/v1/[controller]/{subcategoria}")]
public class SubcategoriasController: ControllerBase
{
    private readonly IProductService _productService;

    public SubcategoriasController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IEnumerable<Product>> GetAllBySubcategoriaAsync(string subcategoria)
    {
        var products = await _productService.ListBySubcategoriaAsync(subcategoria);
        return products;
    }
}