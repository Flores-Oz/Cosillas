using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstAPI.Controllers
{
    [Route("Beer")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private BarContext _context;
        public BeerController(BarContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Beer> Get() => _context.Beers.ToList();
        
    }
}
