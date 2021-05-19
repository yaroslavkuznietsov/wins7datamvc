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
    public class DatConfigsController : Controller
    {
        private readonly DisconnectedRepository _repo = new DisconnectedRepository();
        private RecipeContext db = new RecipeContext();

        // GET: DatConfigs
        public ActionResult Index()
        {
            List<DatConfig> configs = _repo.GetAllDatConfigs();
            //return View(db.DatConfigs.ToList());
            return View(configs);
        }

        // GET: DatConfigs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatConfig datConfig = db.DatConfigs.Find(id);
            if (datConfig == null)
            {
                return HttpNotFound();
            }
            return View(datConfig);
        }

        // GET: DatConfigs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatConfigs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ToolCode,ToolName")] DatConfig datConfig)
        {
            if (ModelState.IsValid)
            {
                db.DatConfigs.Add(datConfig);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datConfig);
        }

        // GET: DatConfigs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatConfig datConfig = db.DatConfigs.Find(id);
            if (datConfig == null)
            {
                return HttpNotFound();
            }
            return View(datConfig);
        }

        // POST: DatConfigs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ToolCode,ToolName")] DatConfig datConfig)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datConfig).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datConfig);
        }

        // GET: DatConfigs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatConfig datConfig = db.DatConfigs.Find(id);
            if (datConfig == null)
            {
                return HttpNotFound();
            }
            return View(datConfig);
        }

        // POST: DatConfigs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DatConfig datConfig = db.DatConfigs.Find(id);
            db.DatConfigs.Remove(datConfig);
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
