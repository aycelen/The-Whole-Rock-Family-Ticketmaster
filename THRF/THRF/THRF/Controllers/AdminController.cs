using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using THRF.Models;
using THRF.Models.DataContext;
using THRF.Models.Model;

namespace THRF.Controllers
{
    public class AdminController : Controller
    {
        THRFDB1Context db = new THRFDB1Context();
        
        // GET: Admin
        public ActionResult AIndex()
        {
            var sorgu = db.Category.ToList();

            return View(sorgu);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)

        {
            var login = db.Admin.Where(x => x.Email == admin.Email).SingleOrDefault();
            if(login.Email==admin.Email && login.Password==admin.Password)
            {
                Session["adminid"] = login.AdminId;
                Session["Email"] = login.Email;
                return RedirectToAction("AIndex", "Admin");
            }
            ViewBag.Uyari = "Kullanıcı Adı yada Şifre Yanlış";
            return View(admin);
        }
        public ActionResult Logout()
        {
            Session["adminid"] = null;
            Session["Email"] = null;
            Session.Abandon();
            return RedirectToAction("AIndex", "Admin");
        }
    }
}