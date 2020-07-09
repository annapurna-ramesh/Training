using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingViewModel.Models;
namespace HandsOnMVCUsingViewModel.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> list = new List<Product>();
        public IActionResult Index()
        {
            
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            //adding project data to list
            list.Add(p);
            return RedirectToAction("Index"); //redirects to Index Action
        }
       
    }
}
