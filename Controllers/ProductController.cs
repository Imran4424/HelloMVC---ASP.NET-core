using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ShowAll()
        {
            


            return View(Products);
        }

    }
}