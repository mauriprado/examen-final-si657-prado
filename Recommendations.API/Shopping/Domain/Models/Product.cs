namespace Recommendations.API.Shopping.Domain.Models;

public class Product
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Caracteristicas { get; set; }
    public float Precio { get; set; }
    public string Claves { get; set; }
    public string Url { get; set; }
    public string Categoria { get; set; }
    public string Subcategoria { get; set; }
}