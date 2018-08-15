using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RemTask.DAL;
using RemTask.Models;

namespace RemTask.Controllers
{
    public class TaskDController : Controller
    {
        private BusinessContext db = new BusinessContext();

        // GET: TaskD
        public ActionResult Index()
        {
            var taskDs = db.TaskDs.Include(t => t.Profile);
            return View(taskDs.ToList());
        }

        // GET: TaskD/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskD taskD = db.TaskDs.Find(id);
            if (taskD == null)
            {
                return HttpNotFound();
            }
            return View(taskD);
        }

        // GET: TaskD/Create
        public ActionResult Create()
        {
            ViewBag.ProfileID = new SelectList(db.Profiles, "ID", "Email");
            return View();
        }

        // POST: TaskD/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ProfileID,Category,Event,Due,Freq,Assign,Location,Purpose")] TaskD taskD)
        {
            if (ModelState.IsValid)
            {
                db.TaskDs.Add(taskD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProfileID = new SelectList(db.Profiles, "ID", "Email", taskD.ProfileID);
            return View(taskD);
        }

        // GET: TaskD/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskD taskD = db.TaskDs.Find(id);
            if (taskD == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProfileID = new SelectList(db.Profiles, "ID", "Email", taskD.ProfileID);
            return View(taskD);
        }

        // POST: TaskD/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ProfileID,Category,Event,Due,Freq,Assign,Location,Purpose")] TaskD taskD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProfileID = new SelectList(db.Profiles, "ID", "Email", taskD.ProfileID);
            return View(taskD);
        }

        // GET: TaskD/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskD taskD = db.TaskDs.Find(id);
            if (taskD == null)
            {
                return HttpNotFound();
            }
            return View(taskD);
        }

        // POST: TaskD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaskD taskD = db.TaskDs.Find(id);
            db.TaskDs.Remove(taskD);
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
