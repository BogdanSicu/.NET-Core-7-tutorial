using Microsoft.EntityFrameworkCore;
using Tutorial.Data;
using Tutorial.Models;

namespace Tutorial.Services.SuperHeroService
{
    public class SuperHeroDBService : ISuperHeroService
    {
        private readonly DataContext _dbContext;

        public SuperHeroDBService(DataContext context)
        {
            _dbContext = context;
        }

        public List<SuperHero> AddHero(SuperHero hero)
        {
            _dbContext.Add(hero);
            _dbContext.SaveChanges();
            return _dbContext.SuperHeroes.ToList();
        }

        public List<SuperHero> DeleteHero(int id)
        {
            _dbContext.Remove(id);
            _dbContext.SaveChanges();
            return _dbContext.SuperHeroes.ToList();
        }

        public List<SuperHero> GetAllHeroes()
        {
            return _dbContext.SuperHeroes.ToList();
        }

        public SuperHero GetSingleHero(int id)
        {
            return _dbContext.SuperHeroes.FirstOrDefault(x => x.Id == id);
        }

        public List<SuperHero> UpdateHero(int id, SuperHero requestBody)
        {
            var hero = _dbContext.SuperHeroes.FirstOrDefault(x => x.Id == id);
            if (hero == null)
            {
                return null;
            }

            hero.FirstName = requestBody.FirstName;
            hero.LastName = requestBody.LastName;
            hero.Name = requestBody.Name;
            hero.Place = requestBody.Place;

            _dbContext.SaveChanges();

            return _dbContext.SuperHeroes.ToList();
        }
    }
}
