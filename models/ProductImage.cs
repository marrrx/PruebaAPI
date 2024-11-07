using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAPI.models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public required string Url { get; set; }
        public DateTime CreatedAt { get; set; }

        //Foreign key
        public int ProductId { get; set; }
        public Product Product { get; set; }=null!;
    }
}