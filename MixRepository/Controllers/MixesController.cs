using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MixRepository.Models;
using System.ComponentModel.DataAnnotations; /*This loads the validation features*/

namespace MixRepository.Controllers
{
    public class MixesController : Controller
    {
        private MixDBContext db = new MixDBContext();

        // GET: Mixes
        public ActionResult Index()
        {
            return View(db.Mixes.ToList());
        }

        // GET: Mixes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mix mix = db.Mixes.Find(id);
            if (mix == null)
            {
                return HttpNotFound();
            }
            return View(mix);
        }

        // GET: Mixes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mixes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,CFx,SVO,Carbon,Binder,Ratio")] Mix mix)
        {
            if (ModelState.IsValid)
            {
                db.Mixes.Add(mix);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mix);
        }

        // GET: Mixes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mix mix = db.Mixes.Find(id);
            if (mix == null)
            {
                return HttpNotFound();
            }
            return View(mix);
        }

        // POST: Mixes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,CFx,SVO,Carbon,Binder")] Mix mix)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mix).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mix);
        }

        // GET: Mixes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mix mix = db.Mixes.Find(id);
            if (mix == null)
            {
                return HttpNotFound();
            }
            return View(mix);
        }

        // POST: Mixes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mix mix = db.Mixes.Find(id);
            db.Mixes.Remove(mix);
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
