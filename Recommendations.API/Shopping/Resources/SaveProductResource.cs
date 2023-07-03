using System.ComponentModel.DataAnnotations;

namespace Recommendations.API.Shopping.Resources;

public class SaveProductResource
{
    [Required]
    public string Id { get; set; }
    [Required]
    public string Nombre { get; set; }
    [Required]
    public string Descripcion { get; set; }
    [Required]
    public string Caracteristicas { get; set; }
    [Required]
    public float Precio { get; set; }
    [Required]
    public string Claves { get; set; }
    [Required]
    public string Url { get; set; }
    [Required]
    public string Categoria { get; set; }
    [Required]
    public string Subcategoria { get; set; }
}