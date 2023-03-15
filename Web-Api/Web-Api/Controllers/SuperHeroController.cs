using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Services.SuperHeroService;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHero _superHeroService;

        public SuperHeroController(ISuperHero superHeroService)
        {
            _superHeroService = superHeroService;
        }
        [HttpGet("GetAllHeroes")]
        public dynamic GetAllHeroes()
        {
            return _superHeroService.getAll();
        }
       
    }
}
