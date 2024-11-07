using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAPI.models
{
    public class OrderDetail
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Foreign Key//
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public required int Quantity { get; set; }



    }
}