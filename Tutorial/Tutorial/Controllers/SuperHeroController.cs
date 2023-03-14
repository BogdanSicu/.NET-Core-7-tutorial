using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tutorial.Models;
using Tutorial.Services.SuperHeroService;

namespace Tutorial.Controllers
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
        public ActionResult<List<SuperHero>> GetAllHeroes()
        {
            return Ok(_superHeroService.GetAllHeroes());
        }

        [HttpGet]
        [Route("/{id}")]
        public ActionResult<SuperHero> GetSingleHero(int id)
        {
            return Ok(_superHeroService.GetSingleHero(id));
        }

        [HttpPost]
        public ActionResult<List<SuperHero>> AddHero([FromBody] SuperHero hero)
        {
            return Ok(_superHeroService.AddHero(hero));
        }

        [HttpPut("{id}")]
        public ActionResult<List<SuperHero>> UpdateHero(int id, SuperHero requestBody)
        {
            return Ok(_superHeroService.UpdateHero(id, requestBody));
        }

        [HttpDelete("{id}")]
        public ActionResult<List<SuperHero>> DeleteHero(int id)
        {
           return Ok(_superHeroService.DeleteHero(id));
        }
    }
}
