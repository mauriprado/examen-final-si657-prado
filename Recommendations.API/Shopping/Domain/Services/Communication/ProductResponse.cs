using Recommendations.API.Shared.Domain.Services.Communication;
using Recommendations.API.Shopping.Domain.Models;

namespace Recommendations.API.Shopping.Domain.Services.Communication;

public class ProductResponse: BaseResponse<Product>
{
    public ProductResponse(string message) : base(message)
    {
    }

    public ProductResponse(Product resource) : base(resource)
    {
    }
}