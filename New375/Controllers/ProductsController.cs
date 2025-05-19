using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using New375.Data;

namespace New375.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductContext _context;

        public ProductsController(ProductContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            var items = await _context.Products.ToListAsync();

            return Ok(items);

        }
        [HttpGet("return")]
        public IActionResult gett()
        {
            return Ok("works");
        }
    }

}
