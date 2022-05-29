using demo_builder.Models;

namespace demo_builder.Interfaces
{
    public interface IBurgerService
    {
        BurgerModel CreateFirstBurgerMenu();

        BurgerModel CreateSecondBurgerMenu();
    }
}