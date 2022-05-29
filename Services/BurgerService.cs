using demo_builder.Interfaces;
using demo_builder.Models;

namespace demo_builder.Services
{
    public class BurgerService : IBurgerService
    {
        private readonly IBurgerBuilder _burgerBuilder;

        public BurgerService(IBurgerBuilder burgerBuilder)
        {
            _burgerBuilder = burgerBuilder;
        }

        public BurgerModel CreateFirstBurgerMenu()
        {
            _burgerBuilder.WithOnion();
            _burgerBuilder.WithLettuce();
            _burgerBuilder.WithCheese();
            _burgerBuilder.WithBurgerPattie();
            _burgerBuilder.WithTomato();

            return _burgerBuilder.GetBurger();
        }

        public BurgerModel CreateSecondBurgerMenu()
        {
            _burgerBuilder.WithBurgerPattie();
            _burgerBuilder.WithCheese();
            _burgerBuilder.WithTomato();
            _burgerBuilder.WithBacon();

            return _burgerBuilder.GetBurger();
        }
    }
}