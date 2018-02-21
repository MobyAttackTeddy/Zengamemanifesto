using PagedList;
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

        public ViewResult Index(int? page = 1)
        {
            var startPagePost = db.StartPagePostsSet.OrderByDescending(o => o.Id).ToList();
            
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(startPagePost.ToPagedList(pageNumber, pageSize));
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
