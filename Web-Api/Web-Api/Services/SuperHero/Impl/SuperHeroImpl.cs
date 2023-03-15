
using Web_Api.Data;
using Web_Api.Models;
using Web_Api.Services.SuperHeroService;
using WebApi.reponsitory.imlp;

namespace Web_Api.Services.SuperHero.Impl
{
    public class SuperHeroImpl : Reponsitory<Models.SuperHero>, ISuperHero
    {
        public SuperHeroImpl(DataContext context) : base(context)
        {
        }
    }
}
