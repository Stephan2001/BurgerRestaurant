namespace prgBurgerRestaurant.Models
{
    public class CheeseBurger : IBurger
    {
        public string getBun()
        {
            return "Cheesy bun";
        }

        public string getCondiments()
        {
            return "Cheesy cheese sause";
        }

        public string getPatty()
        {
            return "Cheesy Beef";
        }

        public string getToppings()
        {
            return "Many Cheeses";
        }
    }
}
