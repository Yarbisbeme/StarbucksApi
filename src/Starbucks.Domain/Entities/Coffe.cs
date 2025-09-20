
namespace Starbucks.Domain.Entities;

public class Coffe : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Category { get; set; }
    public string? Imagen { get; set; }
}
