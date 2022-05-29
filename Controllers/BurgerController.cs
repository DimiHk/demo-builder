using demo_builder.Interfaces;
using demo_builder.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_builder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BurgerController : ControllerBase
    {
        private readonly IBurgerService _burgerService;

        public BurgerController(IBurgerService burgerService)
        {
            _burgerService = burgerService;
        }

        [HttpGet]
        [Route("createFirstBurgerMenu")]
        public BurgerModel CreateFirstBurgerMenu()
        {
            return _burgerService.CreateFirstBurgerMenu();
        }

        [HttpGet]
        [Route("createSecondBurgerMenu")]
        public BurgerModel CreateSecondBurgerMenu()
        {
            return _burgerService.CreateSecondBurgerMenu();
        }
    }
}