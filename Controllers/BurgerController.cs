using Microsoft.AspNetCore.Mvc;
using prgBurgerRestaurant.Models;

namespace prgBurgerRestaurant.Controllers
{
    public class BurgerController : Controller
    {
        BurgerContext b = new BurgerContext();
        public IActionResult Index()
        {
            return View(BurgerContext.burgerObject);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Burger temp)
        {
            Burger bu = temp;
            if (bu.Bun == null || bu.Patty == null || bu.Sauce == null || bu.Toppings == null)
            {
                ViewBag.Error = "Please enter all the required fields";
                return View();
            }
            else
            {
                int i = BurgerContext.burgerObject.Count;
                bu.Id = i + 1;
                BurgerContext.burgerObject.Add(bu);
                return RedirectToAction("Index");
            }
        }
    }
}
