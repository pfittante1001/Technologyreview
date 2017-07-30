using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Technologyreview.Models;

namespace Technologyreview.Controllers
{
    public class ReviewsController : Controller
    {
        private TechnologyreviewContext db = new TechnologyreviewContext();

        // GET: Reviews
        public ActionResult BrandReview()
        {
            var reviews = db.Reviews.Include(r => r.Category);
            return View(reviews.ToList());
        }
        public ActionResult HP()
        {
            var reviews = db.Reviews.Include(r => r.Category);
            return View(reviews.ToList());
        }
        public ActionResult Lenovo()
        {
            var reviews = db.Reviews.Include(r => r.Category);
            return View(reviews.ToList());
        }

        public ActionResult Apple()
        {
            var reviews = db.Reviews.Include(r => r.Category);
            return View(reviews.ToList());
        }
        public ActionResult Dell()
        {
            var reviews = db.Reviews.Include(r => r.Category);
            return View(reviews.ToList());
        }
        public ActionResult Acer()
        {
            var reviews = db.Reviews.Include(r => r.Category);
            return View(reviews.ToList());
        }
        public ActionResult Sony()
        {
            var reviews = db.Reviews.Include(r => r.Category);
            return View(reviews.ToList());
        }
        //public ActionResult HPInformation(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Review review = db.Reviews.Find(id);
        //    if (review == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return RedirectToAction("BrandReview");
        //}

        public ActionResult Index()
        {
            var reviews = db.Reviews.Include(r => r.Category);
            return View(reviews.ToList());
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Brand");
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReviewID,memSize,HardDrSize,Make,Model,Manufacture,CustReview,ReviewDate,CategoryID")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Brand", review.CategoryID);
            return View(review);
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Brand", review.CategoryID);
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReviewID,memSize,HardDrSize,Make,Model,Manufacture,CustReview,ReviewDate,CategoryID")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Brand", review.CategoryID);
            return View(review);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review = db.Reviews.Find(id);
            db.Reviews.Remove(review);
            db.SaveChanges();
            return RedirectToAction("Index");
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
