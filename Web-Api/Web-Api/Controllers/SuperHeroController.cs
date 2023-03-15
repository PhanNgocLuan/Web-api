using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Services.SuperHeroService;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return _superHeroService.GetAllHeroes();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHeroes(int id)
        {
            var result = _superHeroService.GetSingleHeroes(id);
            if (result == null)
                return NotFound("404");
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHeroes(SuperHero hero)
        {
            var result = _superHeroService.AddHeroes(hero);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero request)
        {
            var result = _superHeroService.UpdateHero(id, request);
            if (result == null)
                return NotFound("404");
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var result = _superHeroService.DeleteHero(id);
            if (result == null)
                return NotFound("404");
            return Ok(result);
        }
    }
}
