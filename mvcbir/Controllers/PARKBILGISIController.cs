using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcbir.Models.Entity;

namespace mvcbir.Controllers
{
    public class PARKBILGISIController : Controller
    {
        mvcporEntities db = new mvcporEntities();
       

        // GET: PARKBILGISI
        public ActionResult Index()
        {
            var degerler = db.PARKBILGISI.ToList();
            return View(degerler);
        }
    }
}