using demo_builder.Models;

namespace demo_builder.Interfaces
{
    public interface IBurgerBuilder
    {
        void WithBacon();

        void WithCheese();

        void WithOnion();

        void WithLettuce();

        void WithTomato();

        void WithEgg();

        void WithHam();

        void WithPickles();

        void WithBurgerPattie();

        BurgerModel GetBurger();
    }
}