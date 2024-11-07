using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAPI.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Total { get; set; }
        public int OrderStatusId { get; set; }

        public List<OrderDetailDto> OrderDetails { get; set; } = [];
    }
}