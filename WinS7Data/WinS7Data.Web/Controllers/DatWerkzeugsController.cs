using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WinS7Data.DataLibrary.Models;
using WinS7Data.DataModel;

namespace WinS7Data.Web.Controllers
{
    public class DatWerkzeugsController : Controller
    {
        private readonly DisconnectedRepository _repo = new DisconnectedRepository();
        private RecipeContext db = new RecipeContext();

        // GET: DatWerkzeugs
        public ActionResult Index()
        {
            List<DatWerkzeug> werkzeugs = _repo.GetAllDatWerkzeugs();
            //return View(db.DatWerkzeugs.ToList());
            return View(werkzeugs);
        }

        // GET: DatWerkzeugs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatWerkzeug datWerkzeug = db.DatWerkzeugs.Find(id);
            if (datWerkzeug == null)
            {
                return HttpNotFound();
            }
            return View(datWerkzeug);
        }

        // GET: DatWerkzeugs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatWerkzeugs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ToolCode,ToolName")] DatWerkzeug datWerkzeug)
        {
            if (ModelState.IsValid)
            {
                db.DatWerkzeugs.Add(datWerkzeug);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datWerkzeug);
        }

        // GET: DatWerkzeugs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatWerkzeug datWerkzeug = db.DatWerkzeugs.Find(id);
            if (datWerkzeug == null)
            {
                return HttpNotFound();
            }
            return View(datWerkzeug);
        }

        // POST: DatWerkzeugs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ToolCode,ToolName")] DatWerkzeug datWerkzeug)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datWerkzeug).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datWerkzeug);
        }

        // GET: DatWerkzeugs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatWerkzeug datWerkzeug = db.DatWerkzeugs.Find(id);
            if (datWerkzeug == null)
            {
                return HttpNotFound();
            }
            return View(datWerkzeug);
        }

        // POST: DatWerkzeugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DatWerkzeug datWerkzeug = db.DatWerkzeugs.Find(id);
            db.DatWerkzeugs.Remove(datWerkzeug);
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
