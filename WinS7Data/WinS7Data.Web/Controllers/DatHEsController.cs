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
    public class DatHEsController : Controller
    {
        private readonly DisconnectedRepository _repo = new DisconnectedRepository();
        private RecipeContext db = new RecipeContext();

        // GET: DatHEs
        public ActionResult Index()
        {
            List<DatHE> hes =_repo.GetAllDatHEs();
            //return View(db.DatHEs.ToList());
            return View(hes);
        }

        // GET: DatHEs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatHE datHE = db.DatHEs.Find(id);
            if (datHE == null)
            {
                return HttpNotFound();
            }
            return View(datHE);
        }

        // GET: DatHEs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatHEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,HK01,HK02,HK03,HK04,HK05,HK06,HK07,HK08,HK09,HK10,HK11,HK12,HK13,HK14,HK15,HK16,HK17,HK18,HK19,HK20,HK21,HK22,HK23,HK24")] DatHE datHE)
        {
            if (ModelState.IsValid)
            {
                db.DatHEs.Add(datHE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datHE);
        }

        // GET: DatHEs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatHE datHE = db.DatHEs.Find(id);
            if (datHE == null)
            {
                return HttpNotFound();
            }
            return View(datHE);
        }

        // POST: DatHEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,HK01,HK02,HK03,HK04,HK05,HK06,HK07,HK08,HK09,HK10,HK11,HK12,HK13,HK14,HK15,HK16,HK17,HK18,HK19,HK20,HK21,HK22,HK23,HK24")] DatHE datHE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datHE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datHE);
        }

        // GET: DatHEs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatHE datHE = db.DatHEs.Find(id);
            if (datHE == null)
            {
                return HttpNotFound();
            }
            return View(datHE);
        }

        // POST: DatHEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DatHE datHE = db.DatHEs.Find(id);
            db.DatHEs.Remove(datHE);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Refresh()
        {
            _repo.GetAllRecipes();
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
