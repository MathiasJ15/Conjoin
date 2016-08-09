using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Conjoin.Models;

namespace Conjoin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductDescription()
        {



            ViewBag.Foo = "Produkter.";

            return View();
        }

        public JsonResult GetData(Product product)
        {
            // Insert data product from json object
            return Json(product.Name, JsonRequestBehavior.AllowGet);
        }
    }
}