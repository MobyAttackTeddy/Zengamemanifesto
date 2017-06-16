using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using zengamemanifesto.Models;

namespace zengamemanifesto.Controllers
{
    public class HomeController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.StartPagePostsSet.ToList());
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
