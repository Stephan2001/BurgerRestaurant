namespace prgBurgerRestaurant.Models
{
    public class BurgerFactory
    {
        public IBurger returnInstance;
        public IBurger getBurger(string BurgerType)
        {
            if (BurgerType.ToLower().Equals("chicken"))
            {
                returnInstance = new ChickenBurger();
            }
            else if (BurgerType.ToLower().Equals("cheese"))
            {
                returnInstance = new CheeseBurger();
            }
            else if (BurgerType.ToLower().Equals("fish"))
            {
                returnInstance = new FishBurger();
            }
            else
                returnInstance = new PlainBurger();

            return returnInstance;
        }
    }
}
