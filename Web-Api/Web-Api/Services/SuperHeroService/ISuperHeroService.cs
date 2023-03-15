namespace Web_Api.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAllHeroes();
        SuperHero? GetSingleHeroes(int id);
        List<SuperHero> AddHeroes(SuperHero hero);
        List<SuperHero>? UpdateHero(int id, SuperHero request);
        List<SuperHero>? DeleteHero(int id);
    }
}
