using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_RattoBoutique.Models;

namespace Proyecto_RattoBoutique.Controllers
{
    public class TipoTallaController : Controller
    {
        private UsersContext db = new UsersContext();

        //
        // GET: /TipoTalla/

        public ActionResult Index()
        {
            return View(db.TipoTallaModels.ToList());
        }

        //
        // GET: /TipoTalla/Details/5

        public ActionResult Details(int id = 0)
        {
            TipoTallaModels tipotallamodels = db.TipoTallaModels.Find(id);
            if (tipotallamodels == null)
            {
                return HttpNotFound();
            }
            return View(tipotallamodels);
        }

        //
        // GET: /TipoTalla/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoTalla/Create

        [HttpPost]
        public ActionResult Create(TipoTallaModels tipotallamodels)
        {
            if (ModelState.IsValid)
            {
                db.TipoTallaModels.Add(tipotallamodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipotallamodels);
        }

        //
        // GET: /TipoTalla/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TipoTallaModels tipotallamodels = db.TipoTallaModels.Find(id);
            if (tipotallamodels == null)
            {
                return HttpNotFound();
            }
            return View(tipotallamodels);
        }

        //
        // POST: /TipoTalla/Edit/5

        [HttpPost]
        public ActionResult Edit(TipoTallaModels tipotallamodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipotallamodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipotallamodels);
        }

        //
        // GET: /TipoTalla/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TipoTallaModels tipotallamodels = db.TipoTallaModels.Find(id);
            if (tipotallamodels == null)
            {
                return HttpNotFound();
            }
            return View(tipotallamodels);
        }

        //
        // POST: /TipoTalla/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoTallaModels tipotallamodels = db.TipoTallaModels.Find(id);
            db.TipoTallaModels.Remove(tipotallamodels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}