﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_Website.Models;

public class Product: BaseEntity<int>
{
    public string Name { get; set; } 
    public decimal Price { get; set; }
    public decimal Star { get;set; }
    public string? Image { get; set; }
    public string? Decription { get; set; }
    public int CategoryId { get; set; }
    public int ProductColorId { get; set; }
    
    public virtual Category Category { get; set; }
    public virtual ProductColor ProductColor { get; set; }
}
