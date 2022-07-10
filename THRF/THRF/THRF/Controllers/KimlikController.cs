using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using THRF.Models.DataContext;
using THRF.Models.Model;

namespace THRF.Controllers
{
    public class KimlikController : Controller
    {
        THRFDB1Context db = new THRFDB1Context();
        // GET: Kimlik
        public ActionResult KIndex()
        {
            return View(db.Kimlik.ToList());
        }

 
        // GET: Kimlik/Edit/5
        public ActionResult Edit(int id)
        {
            var kimlik = db.Kimlik.Where(x => x.KimlikId == id).SingleOrDefault();
            return View(kimlik);
        }

        // POST: Kimlik/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit(int id, Kimlik kimlik,HttpPostedFileBase LogoUrl)
        {
            if(ModelState.IsValid)
            {
                var k = db.Kimlik.Where(x => x.KimlikId == id).SingleOrDefault();
             
              if(LogoUrl !=null)
                {
                    if(System.IO.File.Exists(Server.MapPath(kimlik.LogoUrl)))
                    {
                        System.IO.File.Delete(Server.MapPath(kimlik.LogoUrl));
                    }

                    WebImage img = new WebImage(LogoUrl.InputStream);
                    FileInfo imginfo = new FileInfo(LogoUrl.FileName);

                    string logoname = LogoUrl.FileName + imginfo.Extension;
                    img.Resize(300, 200);
                    img.Save("~/Uploads/Kimlik/" + logoname);

                    k.LogoUrl = "/Uploads/Kimlik/" + logoname;
                }

                k.Title = kimlik.Title;
                k.Keywords = kimlik.Keywords;
                k.Decription = kimlik.Decription;
                k.Unvan = kimlik.Unvan;
                db.Entry(k).State = EntityState.Modified;

                db.SaveChanges();
                return RedirectToAction("KIndex");
            }
            return View(kimlik);
        }



    }
}
