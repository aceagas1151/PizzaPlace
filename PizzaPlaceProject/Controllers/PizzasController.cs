using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaPlaceProject.Data;
using PizzaPlaceProject.Entities;

namespace PizzaPlaceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly PizzaPlaceDbContext _context;

        public PizzasController(PizzaPlaceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pizza>>> GetPizzas()
        {
            //Return all Pizza
            return await _context.Pizzas.ToListAsync();
        }
    }
}
