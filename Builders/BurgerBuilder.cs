using demo_builder.Interfaces;
using demo_builder.Models;

namespace demo_builder.Builders
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private BurgerModel _burger = new BurgerModel();

        public BurgerModel GetBurger()
        {
           return _burger;
        }

        public void WithBacon()
        {
            _burger.Bacon = true;
        }

        public void WithBurgerPattie()
        {
            _burger.BurgerPattie = true;
        }

        public void WithCheese()
        {
            _burger.Cheese = true;
        }

        public void WithEgg()
        {
            _burger.Egg = true;
        }

        public void WithHam()
        {
            _burger.Ham = true;
        }

        public void WithLettuce()
        {
            _burger.Lettuce = true;
        }

        public void WithOnion()
        {
            _burger.Onion = true;
        }

        public void WithPickles()
        {
            _burger.Pickles = true;
        }

        public void WithTomato()
        {
            _burger.Tomato = true;
        }
    }
}