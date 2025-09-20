using System;

namespace Starbucks.Domain.Entities;

public class Ingredient : BaseEntity
{   
    public required string Name { get; set; }
}
