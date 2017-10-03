using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageGalery.Models;

namespace ImageGalery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ImageModel> list = new List<ImageModel>
            {
                new ImageModel {Path = "~/Content/Images/1.jpg", Description = "Some Text 1"},
                new ImageModel {Path = "~/Content/Images/2.jpg", Description = "Some Text 2"},
                new ImageModel {Path = "~/Content/Images/3.jpg", Description = "Some Text 3"},
                new ImageModel {Path = "~/Content/Images/4.jpg", Description = "Some Text 4"}
            };
            return View(list);
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

        [ChildActionOnly]
        public ActionResult Image(string path)
        {
            return File(path, "image/jpg");
        }
    }
}