﻿namespace ProductCatalog.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required decimal Price { get; set; }
        public string? ProductImageURL { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
