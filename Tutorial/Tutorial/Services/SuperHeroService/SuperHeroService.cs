using Tutorial.Models;

namespace Tutorial.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
        {
            new SuperHero {Id = 1,
                Name = "Spider-man",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "New York City"
            },
             new SuperHero {Id = 2,
                Name = "Iron-man",
                FirstName = "Tony",
                LastName = "Stark",
                Place = "Malibu"
            }
        };

        public List<SuperHero> AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        public List<SuperHero> DeleteHero(int id)
        {
            var hero = superHeroes.FirstOrDefault(x => x.Id == id);
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

        public SuperHero GetSingleHero(int id)
        {
            return superHeroes.FirstOrDefault(x => x.Id == id);
        }

        public List<SuperHero> UpdateHero(int id, SuperHero requestBody)
        {
            var hero = superHeroes.FirstOrDefault(x => x.Id == id);
            if (hero == null)
            {
                return null;
            }

            hero.FirstName = requestBody.FirstName;
            hero.LastName = requestBody.LastName;
            hero.Name = requestBody.Name;
            hero.Place = requestBody.Place;

            return superHeroes;
        }
    }
}
