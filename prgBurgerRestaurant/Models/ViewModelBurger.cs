namespace prgBurgerRestaurant.Models
{
    public class ViewModelBurger
    {
        private int id;
        private string toppings = "";
        private string bun = "";
        private string condiments = "";
        private string patty = "";

        public ViewModelBurger() { }
        public ViewModelBurger(IBurger bu)
        {
            this.Toppings = bu.getToppings();
            this.Bun = bu.getBun();
            this.Condiments = bu.getCondiments();
            this.Patty = bu.getPatty();
        }
        public string Toppings { get => toppings; set => toppings = value; }
        public string Bun { get => bun; set => bun = value; }
        public string Condiments { get => condiments; set => condiments = value; }
        public string Patty { get => patty; set => patty = value; }
        public int Id { get => id; set => id = value; }
    }
}
