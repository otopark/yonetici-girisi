using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcbir.Models.Entity;
using System.Web.Security;
namespace mvcbir.Controllers
{
    public class GÜVENLİKController : Controller
    {
        // GET: GÜVENLİK
        mvcporEntities db = new mvcporEntities();
        
        public ActionResult GİRİSYAP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GİRİSYAP(YÖNETİCİ pr)
        {
            var bilgiler = db.YÖNETİCİ.FirstOrDefault(x => x.yöneticiad == pr.yöneticiad && x.yöneticisifre == pr.yöneticisifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.yöneticiad, false);
                return RedirectToAction("Index", "PERSONEL");
            }
            else
            {
                return View();
            }

        }

        public ActionResult CIKISYAP()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("GİRİSYAP");
        }
    }
}