namespace prgBurgerRestaurant.Models
{
    public class ChickenBurger : IBurger
    {
        public string getBun()
        {
            return "Sesame";
        }

        public string getCondiments()
        {
            return "Mostard";
        }

        public string getPatty()
        {
            return "Chicken, closed range!";
        }

        public string getToppings()
        {
            return "None";
        }
    }
}
