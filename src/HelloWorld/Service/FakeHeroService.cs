using HelloWorld.Hero.Api.Models;

namespace HelloWorld.Hero.Api.Services
{
  public class FakeHomeService : IHeroService
  {
    public FakeHomeService()
    {

    }

    public Task<Guid> Add(HeroModel home)
    {
      return Task.FromResult(Guid.NewGuid());
    }
  }
}