using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAPI.models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public required string Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public IEnumerable<Order> Orders { get; set; } = [];
    }
}