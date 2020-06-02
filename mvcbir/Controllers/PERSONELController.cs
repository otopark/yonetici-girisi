using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcbir.Models.Entity;
namespace mvcbir.Controllers
{
    public class PERSONELController : Controller
    {
        // GET: PERSONEL
        mvcporEntities db = new mvcporEntities();
        [Authorize]
        public ActionResult Index()
        {
          
            var degerler = db.PERSONEL.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YENİPERSONEL()
        {
           
            return View();
        }


        [HttpPost]
        public ActionResult YENİPERSONEL(PERSONEL p2)
        {
            
            db.PERSONEL.Add(p2);
            db.SaveChanges();
            return View();
        }
        public ActionResult SİL(int id)
        {
            var personel = db.PERSONEL.Find(id);
            db.PERSONEL.Remove(personel);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        public ActionResult PERSONELGETİR(int id)
        {
            var perso = db.PERSONEL.Find(id);
            return View("PERSONELGETİR", perso);
        }
        public ActionResult GÜNCELLE(PERSONEL p1)
        {
            var prs = db.PERSONEL.Find(p1.personelid);
            prs.personelad = p1.personelad;
            prs.personelsoyad = p1.personelsoyad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}