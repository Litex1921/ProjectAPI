using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesSizeConverter;
using WebApplicationShoeSizeConverter.Models;

namespace WebApplicationShoeSizeConverter.Controllers
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
        [HttpPost]
        public ActionResult Convert(ShoeSizeViewModel Model)
        {
            IShoesSizeConverter Converter = new UkShoeSizeConverter();
     

            var shoe= Converter.GetForCentimeters(Model.SizeInCentimeters, ShoeCategories.Men);
            

            return View("ConvertDetails", new ShoeSizeViewModel(shoe.Name, shoe.SizeInCentimeters));
        }

        [HttpGet]
        public ActionResult Convert()
        {
            IShoesSizeConverter Converter = new UsShoeSizeConverter();
            return View("ConvertEdit");
        }
    }
}