﻿using Microsoft.AspNetCore.Mvc;
using WorkingWithVisualStudio.Models;
using System.Linq;

namespace WorkingWithVisualStudio.Controllers {
    public class HomeController : Controller {

        SimpleRepository Repository = SimpleRepository.SharedRepository;

        public IActionResult Index()
            => View(SimpleRepository.SharedRepository.Products
                        .Where(p => p?.Price < 50));

        [HttpGet]
        public IActionResult AddProduct() => View(new Product());

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            Repository.AddProduct(p);
            return  RedirectToAction("Index");
        }
    }
}
