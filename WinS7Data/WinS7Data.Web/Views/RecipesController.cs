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

namespace WinS7Data.Web.Views
{
    public class RecipesController : Controller
    {
        private RecipeContext db = new RecipeContext();

        // GET: Recipes
        public ActionResult Index()
        {
            var recipes = db.Recipes.Include(r => r.DatConfig).Include(r => r.DatHE).Include(r => r.DatN2).Include(r => r.DatWerkzeug);
            return View(recipes.ToList());
        }

        // GET: Recipes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // GET: Recipes/Create
        public ActionResult Create()
        {
            ViewBag.DatConfigId = new SelectList(db.DatConfigs, "Id", "Id");
            ViewBag.DatHEId = new SelectList(db.DatHEs, "Id", "Id");
            ViewBag.DatN2Id = new SelectList(db.DatN2s, "Id", "Id");
            ViewBag.DatWerkzeugId = new SelectList(db.DatWerkzeugs, "Id", "Id");
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ToolCode,ToolName,DatHEId,DatConfigId,DatN2Id,DatWerkzeugId")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                db.Recipes.Add(recipe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DatConfigId = new SelectList(db.DatConfigs, "Id", "Id", recipe.DatConfigId);
            ViewBag.DatHEId = new SelectList(db.DatHEs, "Id", "Id", recipe.DatHEId);
            ViewBag.DatN2Id = new SelectList(db.DatN2s, "Id", "Id", recipe.DatN2Id);
            ViewBag.DatWerkzeugId = new SelectList(db.DatWerkzeugs, "Id", "Id", recipe.DatWerkzeugId);
            return View(recipe);
        }

        // GET: Recipes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            ViewBag.DatConfigId = new SelectList(db.DatConfigs, "Id", "Id", recipe.DatConfigId);
            ViewBag.DatHEId = new SelectList(db.DatHEs, "Id", "Id", recipe.DatHEId);
            ViewBag.DatN2Id = new SelectList(db.DatN2s, "Id", "Id", recipe.DatN2Id);
            ViewBag.DatWerkzeugId = new SelectList(db.DatWerkzeugs, "Id", "Id", recipe.DatWerkzeugId);
            return View(recipe);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ToolCode,ToolName,DatHEId,DatConfigId,DatN2Id,DatWerkzeugId")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DatConfigId = new SelectList(db.DatConfigs, "Id", "Id", recipe.DatConfigId);
            ViewBag.DatHEId = new SelectList(db.DatHEs, "Id", "Id", recipe.DatHEId);
            ViewBag.DatN2Id = new SelectList(db.DatN2s, "Id", "Id", recipe.DatN2Id);
            ViewBag.DatWerkzeugId = new SelectList(db.DatWerkzeugs, "Id", "Id", recipe.DatWerkzeugId);
            return View(recipe);
        }

        // GET: Recipes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipe recipe = db.Recipes.Find(id);
            db.Recipes.Remove(recipe);
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
