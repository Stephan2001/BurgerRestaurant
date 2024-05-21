using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using prgBurgerRestaurant.Models;
using System.Collections.Generic;
using System.Linq;

namespace prgBurgerRestaurant.Controllers
{
    public class BurgerController : Controller
    {
        public static List<ViewModelBurger> burgerObject = new List<ViewModelBurger>();
        public List<BurgerChoices> BurgerChoices = new List<BurgerChoices>();

        public IActionResult Index()
        {
            BurgerChoices.Clear();
            return View(burgerObject);
        }

        public IActionResult Create()
        {
            BurgerChoices b = new BurgerChoices();
            b.Choice = "Plain";
            BurgerChoices.Add(b);
            b = new BurgerChoices();
            b.Choice = "Cheese";
            BurgerChoices.Add(b);
            b = new BurgerChoices();
            b.Choice = "Chicken";
            BurgerChoices.Add(b);
            b = new BurgerChoices();
            b.Choice = "Fish";
            BurgerChoices.Add(b);
            SelectList s = new SelectList(BurgerChoices, "Choice", "Choice");
            ViewBag.UserChoices = s;
            return View();
        }

        [HttpPost]
        public IActionResult Create(BurgerChoices temp)
        {
            if (temp.Choice == "")
            {
                ViewBag.Error = "Please enter all the required fields";
                return View();
            }
            else
            {
                BurgerFactory bf = new BurgerFactory();
                ViewModelBurger vm = new ViewModelBurger(bf.getBurger(temp.Choice));
                int id = burgerObject.Count();
                vm.Id = id;
                burgerObject.Add(vm);
                return RedirectToAction("Index");
            }
        }

        public IActionResult Delete(int id)
        {
            ViewModelBurger temp = burgerObject.Where(x => x.Id == id).FirstOrDefault();
            return View(temp);
        }
        [HttpPost]
        public IActionResult Delete(ViewModelBurger s)
        {
            ViewModelBurger temp = burgerObject.Where(x => x.Id == s.Id).FirstOrDefault();
            burgerObject.Remove(temp);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewModelBurger temp = burgerObject.Where(x => x.Id == id).FirstOrDefault();
            return View(temp);
        }
        [HttpPost]
        public IActionResult Edit(ViewModelBurger temp)
        {
            ViewModelBurger s = temp;
            if (s.Condiments == null || s.Id < 0 || s.Bun == null || s.Patty == null || s.Toppings == null)
            {
                return View();
            }
            else
            {
                (from p in burgerObject where p.Id == temp.Id select p).ToList().ForEach(x =>
                {
                    x.Condiments = temp.Condiments;
                    x.Id = temp.Id;
                    x.Patty = temp.Patty;
                    x.Toppings = temp.Toppings;
                    x.Bun = temp.Bun;
                });

                return RedirectToAction("Index");
            }
        }
    }
}
