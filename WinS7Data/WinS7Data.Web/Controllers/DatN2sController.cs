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
    public class DatN2sController : Controller
    {
        private readonly DisconnectedRepository _repo = new DisconnectedRepository();
        private RecipeContext db = new RecipeContext();

        // GET: DatN2s
        public ActionResult Index()
        {
            List<DatN2> n2s = _repo.GetAllDatN2s();
            //return View(db.DatN2s.ToList());
            return View(n2s);
        }

        // GET: DatN2s/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatN2 datN2 = db.DatN2s.Find(id);
            if (datN2 == null)
            {
                return HttpNotFound();
            }
            return View(datN2);
        }

        // GET: DatN2s/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatN2s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ToolCode,ToolName,Propventil01,Propventil02,Propventil03,Propventil04,Propventil05,Propventil06,Propventil07,Propventil08,Propventil09,Propventil10,Propventil11,Propventil12,Propventil13,Propventil14,Propventil15,Propventil16,Propventil17,Propventil18,Propventil19,Propventil20,Propventil21,Propventil22,Propventil23,Propventil24,Propventil25,Propventil26,Propventil27,Propventil28,Propventil29,Propventil30,Propventil31,Propventil32,Propventil33,Propventil34,Propventil35,Propventil36,Propventil37,Propventil38,Propventil39,Propventil40,Propventil41,Propventil42,Propventil43,Propventil44,Propventil45,Propventil46,Propventil47,Propventil48,Propventil49,Propventil50,Propventil51,Propventil52,Propventil53,Propventil54,Propventil55,Propventil56,Propventil57,Propventil58,Propventil59,Propventil60")] DatN2 datN2)
        {
            if (ModelState.IsValid)
            {
                db.DatN2s.Add(datN2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datN2);
        }

        // GET: DatN2s/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatN2 datN2 = db.DatN2s.Find(id);
            if (datN2 == null)
            {
                return HttpNotFound();
            }
            return View(datN2);
        }

        // POST: DatN2s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ToolCode,ToolName,Propventil01,Propventil02,Propventil03,Propventil04,Propventil05,Propventil06,Propventil07,Propventil08,Propventil09,Propventil10,Propventil11,Propventil12,Propventil13,Propventil14,Propventil15,Propventil16,Propventil17,Propventil18,Propventil19,Propventil20,Propventil21,Propventil22,Propventil23,Propventil24,Propventil25,Propventil26,Propventil27,Propventil28,Propventil29,Propventil30,Propventil31,Propventil32,Propventil33,Propventil34,Propventil35,Propventil36,Propventil37,Propventil38,Propventil39,Propventil40,Propventil41,Propventil42,Propventil43,Propventil44,Propventil45,Propventil46,Propventil47,Propventil48,Propventil49,Propventil50,Propventil51,Propventil52,Propventil53,Propventil54,Propventil55,Propventil56,Propventil57,Propventil58,Propventil59,Propventil60")] DatN2 datN2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datN2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datN2);
        }

        // GET: DatN2s/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatN2 datN2 = db.DatN2s.Find(id);
            if (datN2 == null)
            {
                return HttpNotFound();
            }
            return View(datN2);
        }

        // POST: DatN2s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DatN2 datN2 = db.DatN2s.Find(id);
            db.DatN2s.Remove(datN2);
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
