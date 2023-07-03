using AutoMapper;
using Recommendations.API.Shopping.Domain.Models;
using Recommendations.API.Shopping.Resources;

namespace Recommendations.API.Shopping.Mapping;

public class ResourceToModelProfile: Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveUserResource, User>();
        CreateMap<SaveProductResource, Product>();
    }
}