using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using First.Models;


namespace First.Controllers
{
    public class HomeController : Controller
    {
        IList<Class> productList = new List<Class> {
            new Class(){name="lettuce",price= 10.5,quantity= 50,type= "Leafygreen" },
            new Class(){name = "cabbage", price=20,quantity=100,type=  "Cruciferous"},

            new Class() { name="pumpkin",price= 30,quantity= 30, type= "Marrow"},

            new Class() {name= "cauliflower", price=20 ,quantity=100, type= "Cruciferous"},

            new Class() {name= "zucchini",price= 20.5 ,quantity=50, type= "marrow"},

            new Class() { name="yam", price=30,quantity= 50,type=  "Root"},

            new Class() { name="spinach",price= 10,quantity= 100,type=  "leafygreen"},

            new Class() {name= "brocolli", price=20.2,quantity= 75,type=  "Cruciferous"},

            new Class() { name="Garlic", price=30 ,quantity=20,type=  "Leafygreen"},

            new Class() { name="silverbeet", price=10,quantity= 50, type= "Marrow"}
        };
        public ActionResult Index()
        {
            ViewBag.PrintNo = productList.Count();
            return View(productList);
        }
        public ActionResult Update(string name, double price, int quantity, string type)
        {
            var std = productList.Where(s => s.name == name).FirstOrDefault();
            std = productList.Where(d => d.price == price).FirstOrDefault();
            std = productList.Where(e => e.quantity == quantity).FirstOrDefault();
            std = productList.Where(w => w.type == type).FirstOrDefault();
            return View(std);
        }
        [HttpPost]
        public ActionResult Update([Bind(Include = "name, price,quantity,type")]Class std)
        {
            if (std == null)
            {
                throw new ArgumentNullException(nameof(std));
            }

            return RedirectToAction("index");
        }
        public ActionResult Add(string name, double price, int quantity, string type)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Class std)
        {
            
            return RedirectToAction("index");
        }
        public ActionResult Delete(string name, double price, int quantity, string type)
        {
            var std = productList.Where(s => s.name == name).FirstOrDefault();
            std = productList.Where(d => d.price == price).FirstOrDefault();
            std = productList.Where(e => e.quantity == quantity).FirstOrDefault();
            std = productList.Where(w => w.type == type).FirstOrDefault();
            return View(std);
        }
        [HttpPost]
        public ActionResult Delete(Class std)
        {
            productList.Clear();
            return RedirectToAction("index");
        }
    }
}
