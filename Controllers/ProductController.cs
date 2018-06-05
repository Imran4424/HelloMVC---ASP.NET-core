using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ShowAll()
        {
            ViewData["Heading"] = "All Products";

            var Products = new List<Product>();

            Products.Add(new Product{ ID = 101, Name = "Apple", Price = 1.1});

            Products.Add(new Product{ ID = 102, Name = "Bike", Price = 2.2});

            Products.Add(new Product{ ID = 103, Name = "Calculator", Price = 3.3});

            return View(Products);
        }

    }
}