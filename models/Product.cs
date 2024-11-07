using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAPI.models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required double Price { get; set; }
        public DateTime CreatedAt { get; set; }

        //Foreign Key//
        public int CategoryId { get; set; }
        public Category? Category { get; set; } 

        public List<ProductImage> ProductImages { get; set; } = [];

        public List<OrderDetail> OrderDetails { get; set; } = [];
    }
}