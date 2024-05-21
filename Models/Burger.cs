using System.Diagnostics.Contracts;

namespace prgBurgerRestaurant.Models
{
    public class Burger
    {
        public Burger() { }
        private string bun;
        private int id;
        private string patty;
        private string toppings;
        private string sauce;

        public Burger(string bun, string patty, string toppings, string sauce, int id)
        {
            this.id = id;
            this.bun = bun;
            this.patty = patty;
            this.toppings = toppings;
            this.sauce = sauce;
        }

        public string Bun { get => bun; set => bun = value; }
        public int Id { get => id; set => id = value; }
        public string Patty { get => patty; set => patty = value; }
        public string Toppings { get => toppings; set => toppings = value; }
        public string Sauce { get => sauce; set => sauce = value; }
    }
}
