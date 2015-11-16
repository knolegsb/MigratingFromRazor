using MigratingFromRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MigratingFromRazor.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        [Route("order/{id:int}")]
        public ActionResult Index(int id)
        {
            ViewBag.Title = "Place Your Order";
            IProductsService service = new ProductsService();
            OrderFormModel model = new OrderFormModel
            {
                Product = service.GetProduct(id)
            };
            return View(model);
        }
    }
}