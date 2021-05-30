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
    public class DatMWerkzeugsController : Controller
    {
        private readonly DisconnectedRepository _repo = new DisconnectedRepository();
        private RecipeContext db = new RecipeContext();

        // GET: DatMWerkzeugs
        public ActionResult Index()
        {
            List<List<DatMWerkzeug>> mwerkzeugsList = _repo.GetAllDatMWerkzeugs();
            //return View(db.DatMWerkzeugs.ToList());
            return View(mwerkzeugsList);
        }

        // GET: DatMWerkzeugs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatMWerkzeug datMWerkzeug = db.DatMWerkzeugs.Find(id);
            if (datMWerkzeug == null)
            {
                return HttpNotFound();
            }
            return View(datMWerkzeug);
        }

        // GET: DatMWerkzeugs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatMWerkzeugs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ToolCode,ToolName,MachineId,WerkzeughoeheA1,WerkzeughoeheA2,HeizelementhoeheObenA3,HeizelementhoeheUntenA3,WarmpositionA3,BestueckungspositionA1,BestueckungspositionA2,PruefpositionA1,PruefpositionA2,IRKameraTriggerpositionA3")] DatMWerkzeug datMWerkzeug)
        {
            if (ModelState.IsValid)
            {
                db.DatMWerkzeugs.Add(datMWerkzeug);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datMWerkzeug);
        }

        // GET: DatMWerkzeugs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatMWerkzeug datMWerkzeug = db.DatMWerkzeugs.Find(id);
            if (datMWerkzeug == null)
            {
                return HttpNotFound();
            }
            return View(datMWerkzeug);
        }

        // POST: DatMWerkzeugs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ToolCode,ToolName,MachineId,WerkzeughoeheA1,WerkzeughoeheA2,HeizelementhoeheObenA3,HeizelementhoeheUntenA3,WarmpositionA3,BestueckungspositionA1,BestueckungspositionA2,PruefpositionA1,PruefpositionA2,IRKameraTriggerpositionA3")] DatMWerkzeug datMWerkzeug)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datMWerkzeug).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datMWerkzeug);
        }

        // GET: DatMWerkzeugs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatMWerkzeug datMWerkzeug = db.DatMWerkzeugs.Find(id);
            if (datMWerkzeug == null)
            {
                return HttpNotFound();
            }
            return View(datMWerkzeug);
        }

        // POST: DatMWerkzeugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DatMWerkzeug datMWerkzeug = db.DatMWerkzeugs.Find(id);
            db.DatMWerkzeugs.Remove(datMWerkzeug);
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
