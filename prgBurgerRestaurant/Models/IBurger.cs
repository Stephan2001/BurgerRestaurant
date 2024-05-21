namespace prgBurgerRestaurant.Models
{
    public interface IBurger
    {
        string getBun();
        string getPatty();
        string getCondiments();
        string getToppings();
    }
}
