using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using THRF.Models.DataContext;

namespace THRF.Controllers
{
    public class HomeController : Controller
    {
        private THRFDB1Context db = new THRFDB1Context();
        // GET: Home
        public ActionResult Index()
            
        {
            ViewBag.Services = db.Service.ToList().OrderByDescending(x=>x.SerId);
            ViewBag.Sliders = db.Slider.ToList().OrderByDescending(x => x.SliderId);
            ViewBag.AboutUs = db.About.ToList().OrderByDescending(x => x.AboutId);
            ViewBag.Blogs = db.Blog.ToList().OrderByDescending(x => x.BlogId);
            ViewBag.Categories = db.Category.ToList().OrderByDescending(x => x.CatId);
            ViewBag.Comm = db.Communication.ToList().OrderByDescending(x => x.CommId);



            return View();
        }

     

    }
}