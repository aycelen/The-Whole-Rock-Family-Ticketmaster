using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Services.Description;
using THRF.Models.DataContext;
using System.IO;
using THRF.Models.Model;
using System.Net;
using Service = THRF.Models.Model.Service;
using System.Data.Entity;
using System.Web.UI.WebControls;
using System.Runtime.Remoting.Messaging;

namespace THRF.Controllers
{
    public class ServiceController : Controller
    {
        private THRFDB1Context db = new THRFDB1Context();
        // GET: Service
        public ActionResult Index()
        {
            return View(db.Service.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Models.Model.Service service)
        {
            if (ModelState.IsValid)
            {
                db.Service.Add(service);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(service);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                ViewBag.Uyari = "Güncellencek bişi yok";
            }
            var service = db.Service.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int? id, Service service)

        {
            if (ModelState.IsValid)
            {
                db.Entry(service).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View();
        }
        public ActionResult Delete(int id)
        {
               if(id==null)
            {
                return HttpNotFound();
            }
            var service = db.Service.Find(id);
            if(service==null)
            {
                return HttpNotFound();
            }
            db.Service.Remove(service);
            db.SaveChanges();
            return RedirectToAction("Index");

            }




}
}
   