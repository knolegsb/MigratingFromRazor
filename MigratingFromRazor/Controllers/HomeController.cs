using MigratingFromRazor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MigratingFromRazor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            IProductService service = new ProductService();
            ViewBag.Products = service.GetProducts();
            ViewBag.Featured = ViewBag.Products[new Random().Next(ViewBag.Products.Count)];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}