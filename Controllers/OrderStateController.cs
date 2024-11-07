using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaAPI.db;
using PruebaAPI.Dtos;

namespace PruebaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderStateController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public OrderStateController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderStatusDto>>> GetStates()
        {
            var states = await _db.OrderStatuses.ToListAsync();

            var statesDto = states.Select(state => new OrderStatusDto
            {
                Id = state.Id,
                Status = state.Status
            });

            return Ok(statesDto);
        }
    }
}