using System.ComponentModel.DataAnnotations;

namespace Recommendations.API.Shopping.Resources;

public class SaveUserResource
{
    [Required]
    public string Nombre { get; set; }
}