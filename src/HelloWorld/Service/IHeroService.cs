using HelloWorld.Hero.Api.Models;

namespace HelloWorld.Hero.Api.Services
{
  public interface IHeroService
  {
    Task<Guid> Add(HeroModel hero);
  }
}