using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using SampleMVCwebAPP.Models;

namespace SampleMVCwebAPP.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetAllProduct()
        {
            List<Product> productlist = new List<Product>()
            {
                new Product { Id=1, Name="Laptop",Company="Dell",Price=34500},
                new Product { Id=2, Name="Laptop",Company="Lenovo",Price=36500},
                new Product { Id=3, Name="Laptop",Company="Hp",Price=37500},
                new Product { Id=4, Name="Keyboard",Company="Dell",Price=500},
                new Product { Id=5, Name="Mouse",Company="Dell",Price=450},
            };
            ViewBag.ProductList = productlist;
            return View();
        }

        public IActionResult AddNew()
        {
            return View();
        }

        public IActionResult ModifyProduct()
        {
            return View();
        }

        public IActionResult DeleteProduct()
        {
            return View();
        }
    }
}
