using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcbir.Models.Entity;
namespace mvcbir.Controllers
{
    public class ÜCRETController : Controller
    {
        // GET: ÜCRET
        mvcporEntities db = new mvcporEntities();
     
        public ActionResult Index()
        {
            var degerler = db.ÜCRET.ToList();
            return View(degerler);
        }
    }
}