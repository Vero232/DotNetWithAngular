using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
       
        [HttpGet]
        public async Task<ActionResult<List<Hero>>> GetHeroes()
        {
            List<Hero> heroes = new List<Hero>
            {
               new Hero { id=1, name="Batman" },
               new Hero { id=2, name="Superman" }
            };

            return heroes;
        }


    }
}
