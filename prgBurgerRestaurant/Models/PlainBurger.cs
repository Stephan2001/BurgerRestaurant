namespace prgBurgerRestaurant.Models
{
    public class PlainBurger : IBurger
    {
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "Mustard";
        }

        public string getPatty()
        {
            return "Cow, free range";
        }

        public string getToppings()
        {
            return "Tomatoes";
        }

    }
}
