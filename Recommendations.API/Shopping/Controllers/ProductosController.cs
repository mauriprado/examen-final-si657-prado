using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Recommendations.API.Shared.Extensions;
using Recommendations.API.Shopping.Domain.Models;
using Recommendations.API.Shopping.Domain.Services;
using Recommendations.API.Shopping.Resources;

namespace Recommendations.API.Shopping.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class ProductosController: ControllerBase
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;


    public ProductosController(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }
    [HttpGet("{data}")]
    public async Task<IActionResult> GetAllOrFindByUrlAsync(string data)
    {

        if (data == "all")
        {
            var products = await _productService.ListAsync();
            return Ok(products);
        }
        
        var result = await _productService.FindByUrlAsync(data);
        
        if (!result.Success)
            return BadRequest(result.Message);

        return Ok(result.Resource);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveProductResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var product = _mapper.Map<SaveProductResource, Product>(resource);
        var result = await _productService.SaveAsync(product);
        if (!result.Success)
            return BadRequest(result.Message);

        return Created(nameof(PostAsync), result.Resource);
    }
}