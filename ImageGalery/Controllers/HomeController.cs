using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageGalery.Models;
using PagedList;

namespace ImageGalery.Controllers
{
    public class HomeController : Controller
    {
        private List<ImageModel> list;
        private int pageSize = 4;
        public HomeController()
        {
            list = new List<ImageModel>();
            for (int i = 1; i <= 16; i++)
            {
                list.Add(new ImageModel{ Path = $"~/Content/Images/{i}.jpg", Description = $"Some Text {i}" });
            }

        }
        public ActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;
            return View(list.ToPagedList(pageNumber, pageSize));
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