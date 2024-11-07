using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAPI.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<ProductImageDto>? ProductImages { get; set; } = [];
        public CategoryDto? Category { get; set; }

    }
}