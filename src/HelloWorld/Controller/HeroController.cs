using HelloWorld.Hero.Api.Services;
using HelloWorld.Hero.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Hero.Api.Controllers
{

  [Route("api/heroes")]
  [ApiController]
  public class HeroController : ControllerBase
  {

    private readonly ILogger<HeroController> _logger;
    private readonly IHeroService _heroService;

    public HeroController(ILogger<HeroController> logger, IHeroService heroService)
    {
      _logger = logger;
      _heroService = heroService;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] HeroModel heroModel)
    {
      var heroId = await _heroService.Add(heroModel);
      return Created("/api/heroes/{heroId}", null);
    }
  }
}