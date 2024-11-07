using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaAPI.db;
using PruebaAPI.Dtos;
using PruebaAPI.models;

namespace PruebaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<ActionResult<OrderDto>> GetAll()
        {
            var orders = await _db.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .ToListAsync();

            var orderDtos = orders.Select(o => new OrderDto
            {
                Id = o.Id,
                Total = o.Total,
                UserId = o.UserId,
                OrderStatusId = o.OrderStatusId,
                OrderDetails = o.OrderDetails.Select(od => new OrderDetailDto
                {
                    ProductId = od.ProductId,
                    ProductName = od.Product.Name,
                    ProductPrice = od.Product.Price,
                    Quantity = od.Quantity,
                }).ToList()
            }).ToList();

            return Ok(orderDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetOrderById(int id)
        {
            var order = await _db.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            var orderDto = new OrderDto
            {
                Id = order.Id,
                Total = order.Total,
                UserId = order.UserId,
                OrderStatusId = order.OrderStatusId,
                OrderDetails = order.OrderDetails.Select(od => new OrderDetailDto
                {
                    ProductId = od.ProductId,
                    ProductName = od.Product.Name,
                    ProductPrice = od.Product.Price,
                    Quantity = od.Quantity,
                }).ToList()
            };

            return Ok(orderDto);
        }

        [HttpPost]
        public async Task<ActionResult<OrderDto>> CreateOrder(CreateOrderDto createOrderDto)
        {
            var order = new Order
            {
                Total = createOrderDto.Total,
                UserId = createOrderDto.UserId,
                OrderStatusId = 1,
                OrderDetails = createOrderDto.OrderDetails.Select(od => new OrderDetail
                {
                    ProductId = od.ProductId,
                    Quantity = od.Quantity
                }).ToList()
            };

            _db.Orders.Add(order);
            await _db.SaveChangesAsync();

            var createdOrder = await _db.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .FirstOrDefaultAsync(o => o.Id == order.Id);


            if (createdOrder == null)
            {
                return NotFound();
            }

            var createdOrderDto = new OrderDto
            {
                Id = createdOrder.Id,
                Total = createdOrder.Total,
                UserId = createdOrder.UserId,
                OrderStatusId = createdOrder.OrderStatusId,
                OrderDetails = createdOrder.OrderDetails.Select(od => new OrderDetailDto
                {
                    ProductId = od.ProductId,
                    ProductName = od.Product.Name,
                    ProductPrice = od.Product.Price,
                    Quantity = od.Quantity,
                }).ToList()
            };

            return CreatedAtAction(nameof(GetOrderById), new { id = createdOrderDto.Id }, createdOrderDto);
        }


    [HttpDelete]
    public async Task<ActionResult> DeleteOrder(int id)
    {
        var order = await _db.Orders.FindAsync(id);

        if (order == null)
        {
            return NotFound();
        }

        _db.Orders.Remove(order);
        await _db.SaveChangesAsync();

        return NoContent();
    }

    }
}