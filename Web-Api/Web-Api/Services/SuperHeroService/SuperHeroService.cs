using Web_Api.Models;

namespace Web_Api.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Test",
                    FirstName = "Test",
                    LastName = "Test",
                    Place = "Test"
                },
                 new SuperHero
                {
                    Id = 2,
                    Name = "Test2",
                    FirstName = "Test2",
                    LastName = "Test2",
                    Place = "Test2"
                }
            };

        public List<SuperHero> AddHeroes(SuperHero hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        public List<SuperHero>? DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null)
            {
                return null;
            }
            superHeroes.Remove(hero);
            return superHeroes;
        }

        public List<SuperHero> GetAllHeroes()
        {
            return superHeroes;
        }

        public SuperHero? GetSingleHeroes(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null)
            {
                return null;
            }
            return hero;
        }

        public List<SuperHero>? UpdateHero(int id, SuperHero request)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null)
            {
                return null;
            }
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Name = request.Name;
            hero.Place = request.Place;
            return superHeroes;
        }
    }
}
