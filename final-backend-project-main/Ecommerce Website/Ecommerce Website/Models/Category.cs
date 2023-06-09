﻿namespace Ecommerce_Website.Models
{
    public class Category : BaseEntity<int>
    {
        public string Type { get; set; } = string.Empty;
        public virtual ICollection<Product> Products { get; set; }
    }
}
