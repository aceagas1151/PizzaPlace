using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaPlaceProject.Data;
using PizzaPlaceProject.Entities;

namespace PizzaPlaceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaTypesController : ControllerBase
    {
        private readonly PizzaPlaceDbContext _context;

        public PizzaTypesController(PizzaPlaceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PizzaType>>> GetPizzaTypes()
        {
            //Return all PizzaType
            return await _context.PizzaTypes.ToListAsync();
        }
    }
}
