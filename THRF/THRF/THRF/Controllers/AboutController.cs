using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using THRF.Models.DataContext;
using THRF.Models.Model;

namespace THRF.Controllers
{
    public class AboutController : Controller
    {
        THRFDB1Context db = new THRFDB1Context();
        // GET: About
        public ActionResult AbIndex()
        {
            var h = db.About.ToList();

            return View(h); // veri tabanından gelen kayıtlar
        }

        public ActionResult Edit(int id)
        {
            var h = db.About.Where(x => x.AboutId == id).FirstOrDefault();
            return View(h);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)] // ceditor hatası
        public ActionResult Edit(int id, About h)
        {
            if (ModelState.IsValid)
            {
                var hakkimizda = db.About.Where(x => x.AboutId == id).SingleOrDefault();
                hakkimizda.AbExp = h.AbExp;
                db.SaveChanges();
                return RedirectToAction("AbIndex");
            }
            return View(h);
        }
    }
}