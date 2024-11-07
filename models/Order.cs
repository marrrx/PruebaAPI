using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAPI.models
{
    public class Order
    {
        public int Id { get; set; }
        public required double Total { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Foreign Key//
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; } = null!;

        public IEnumerable<OrderDetail> OrderDetails { get; set; } = [];

    }
}