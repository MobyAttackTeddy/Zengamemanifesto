using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using zengamemanifesto.Models;
using PagedList;

namespace zengamemanifesto.Controllers
{
    public class VideosController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: VideoSets


        public ViewResult Index( int? page = 1)
        {
           var videoPost = from s in db.VideoSet
                          select s;
            videoPost = videoPost.OrderBy(d => d.Id);
           int pageSize = 5;
           int pageNumber = (page ?? 1);
           return View(videoPost.ToPagedList(pageNumber, pageSize));
        }

        // GET: VideoSets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoSet videoSet = db.VideoSet.Find(id);
            if (videoSet == null)
            {
                return HttpNotFound();
            }
            return View(videoSet);
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
