using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaPlaceProject.Data;
using PizzaPlaceProject.Entities;

namespace PizzaPlaceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly PizzaPlaceDbContext _context;
        public OrderDetailsController(PizzaPlaceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetail>>> GetOrderDetails()
        {
            return await _context.OrderDetails
                .Include(d => d.Pizza)
                .Include(d => d.Order)
                .ToListAsync();
        }
    }
}
