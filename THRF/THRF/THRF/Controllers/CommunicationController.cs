using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using THRF.Models;
using THRF.Models.DataContext;

namespace THRF.Controllers
{
    public class CommunicationController : Controller
    {
        private THRFDB1Context db = new THRFDB1Context();

        // GET: Communication
        public ActionResult Index()
        {
            return View(db.Communication.ToList());
        }

        // GET: Communication/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Communication communication = db.Communication.Find(id);
            if (communication == null)
            {
                return HttpNotFound();
            }
            return View(communication);
        }

        // GET: Communication/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Communication/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CommId,Address,Tel,Fax,Whatsapp,Facebook,Twitter,Instagram")] Communication communication)
        {
            if (ModelState.IsValid)
            {
                db.Communication.Add(communication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(communication);
        }

        // GET: Communication/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Communication communication = db.Communication.Find(id);
            if (communication == null)
            {
                return HttpNotFound();
            }
            return View(communication);
        }

        // POST: Communication/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CommId,Address,Tel,Fax,Whatsapp,Facebook,Twitter,Instagram")] Communication communication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(communication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(communication);
        }

        // GET: Communication/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Communication communication = db.Communication.Find(id);
            if (communication == null)
            {
                return HttpNotFound();
            }
            return View(communication);
        }

        // POST: Communication/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Communication communication = db.Communication.Find(id);
            db.Communication.Remove(communication);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
