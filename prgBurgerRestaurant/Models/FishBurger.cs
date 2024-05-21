namespace prgBurgerRestaurant.Models
{
    public class FishBurger : IBurger
    {
        public string getBun()
        {
            return "No, bun (Sies)";
        }

        public string getCondiments()
        {
            return "Ta ta sauce";
        }

        public string getPatty()
        {
            return "fish, free range!";
        }

        public string getToppings()
        {
            return "pickles";
        }
    }
}
