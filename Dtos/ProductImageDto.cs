using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAPI.Dtos
{
    public class ProductImageDto
    {
        public int Id { get; set; }
        public required string Url { get; set; }

    }
}