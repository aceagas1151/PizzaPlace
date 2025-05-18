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
            //Return all OrderDetail
            return await _context.OrderDetails.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetail>> GetOrderDetail(int id)
        {
            //Find OrderDetail based on Id
            var orderDetail = await _context.OrderDetails
               .FirstOrDefaultAsync(o => o.Id == id);

            if (orderDetail == null)
                return NotFound();

            return orderDetail;
        }
    }
}
