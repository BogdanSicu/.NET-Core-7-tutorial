using Microsoft.AspNetCore.Mvc;
using System.Net;
using Tutorial.Models;

namespace Tutorial.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAllHeroes();
        SuperHero GetSingleHero(int id);
        List<SuperHero> AddHero(SuperHero hero);
        List<SuperHero> UpdateHero(int id, SuperHero requestBody);
        List<SuperHero> DeleteHero(int id);
    }
}
