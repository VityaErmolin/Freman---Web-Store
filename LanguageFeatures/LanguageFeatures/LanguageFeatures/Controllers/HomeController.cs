using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Model;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            var product = new [] {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
            };

            return View(product.Select(p=>$"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }

        //public async Task<ViewResult> Index()
        //{
        //    long? lenght = await MyAsyncMethods.GetPageLength();
        //    return View(new string[] {$"Lenght: {lenght}"});
        //}
        //public ViewResult Index()
        //{
        //    IProductSelection cart = new ShoppingCart(
        //        new Product {Name = "Kayak", Price = 275M},
        //        new Product {Name = "Lifejacket", Price = 48.95M},
        //        new Product {Name = "Soccer ball", Price = 19.50M},
        //        new Product {Name = "Corner flag", Price = 34.95M});

        //    return View(cart.Names);
        //}
        //{
        //    var names = new[] {"Kayak", "Lifejacket", "Soccer ball"};
        //    return View(names);
        //}
        //{
        //return View(Product.GetProducts().Select(p => p?.Name));
        //Product[] productArray = {
        //    new Product {Name = "Kayak", Price = 275M},
        //    new Product {Name = "Lifejacket", Price = 48.95M},
        //    new Product {Name = "Soccer ball", Price = 19.50M},
        //    new Product {Name = "Corner flag", Price = 34.95M}
        //};

        //decimal priceFilterTotal = productArray.Filter(p=>(p?.Price??0)>=20).TotalPrices();

        //decimal nameFilterTotal = productArray.Filter(p=>p?.Name[0] == 'S').TotalPrices();

        //return View("Index", new string[]
        //{
        //    $"Price Total: {priceFilterTotal:C2}",
        //    $"Name Total: {nameFilterTotal:C2}"
        //});

        //  }
    }
}
