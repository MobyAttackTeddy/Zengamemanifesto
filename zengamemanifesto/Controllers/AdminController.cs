using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using zengamemanifesto.Models;
using zengamemanifesto.Models;

namespace zengamemanifesto.Controllers
{
    public class AdminController : Controller
    {
        private Entities1 db = new Entities1();
        private AdminModel am = new AdminModel();
        // GET: Admin
        [Authorize]
        public ActionResult List()
        {
            AdminModel am = new AdminModel();
            am.Books = db.BookSet.ToList();
            am.Home = db.StartPagePostsSet.ToList();
            am.Video = db.VideoSet.ToList();
            return View(am);
        }

        [Authorize]
        public ActionResult aEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StartPagePostsSet startPagePosts = db.StartPagePostsSet.Find(id);
            if (startPagePosts == null)
            {
                return HttpNotFound();
            }
            return View(startPagePosts);
        }

        [Authorize]
        public ActionResult aCreate()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult aCreate([Bind(Include = "Id,Heading,TextHtml,ImgLink")] StartPagePostsSet startPagePosts)
        {
            if (ModelState.IsValid)
            {
                db.StartPagePostsSet.Add(startPagePosts);
                db.SaveChanges();
                return RedirectToAction("List");
            }

            return View(startPagePosts);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult aEdit([Bind(Include = "Id,Heading,TextHtml,ImgLink")] StartPagePostsSet startPagePosts)
        {
            if (true)
            {
                db.Entry(startPagePosts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }

            am.Books = db.BookSet.ToList();
            am.Home = db.StartPagePostsSet.ToList();
            am.Video = db.VideoSet.ToList();
            return View(am);
            
        }

        [Authorize]
        public ActionResult vEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoSet videoPost = db.VideoSet.Find(id);
            if (videoPost == null)
            {
                return HttpNotFound();
            }
            return View(videoPost);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult vEdit([Bind(Include = "Id,Heading,PreText,EmbededUrl,Text,ImgUrl")] VideoSet video)
        {
            if (ModelState.IsValid)
            {
                db.Entry(video).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            am.Books = db.BookSet.ToList();
            am.Home = db.StartPagePostsSet.ToList();
            am.Video = db.VideoSet.ToList();
            return View(am);
        }

        [Authorize]
        public ActionResult vCreate()
        {
            return View();
        }

        // POST: Videos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult vCreate([Bind(Include = "Id,Heading,PreText,EmbededUrl,Text")] VideoSet video)
        {
            if (ModelState.IsValid)
            {
                db.VideoSet.Add(video);
                db.SaveChanges();
                return RedirectToAction("List");
            }

            return View(video);
        }
    }
}