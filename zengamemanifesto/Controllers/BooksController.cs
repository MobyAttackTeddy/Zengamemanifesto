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
    public class BooksController : Controller
    {
        private Entities1 db = new Entities1();

        
        public ActionResult Index()
        {
            return View(db.BookSet.ToList());
        }

        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookSet bookSet = db.BookSet.Find(id);
            if (bookSet == null)
            {
                return HttpNotFound();
            }
            return View(bookSet);
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
