using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication3.Controllers
{
    public class ProductsController : Controller
    {
        demodbContext context = new demodbContext();
        public IActionResult Index()
        {
            var allProducts = context.Products.ToList();
            return View(allProducts);
        }
    }
}
