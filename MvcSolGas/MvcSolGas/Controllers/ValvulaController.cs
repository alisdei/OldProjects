using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSolGas.Models;

namespace MvcSolGas.Controllers
{
    public class ValvulaController : Controller
    {
        private MvcSolGasDataBaseContext db = new MvcSolGasDataBaseContext();

        //
        // GET: /Valvula/

        public ActionResult Index()
        {
            return View(db.Valvulas.ToList());
        }

        //
        // GET: /Valvula/Details/5

        public ActionResult Details(int id = 0)
        {
            Valvula valvula = db.Valvulas.Find(id);
            if (valvula == null)
            {
                return HttpNotFound();
            }
            return View(valvula);
        }

        //
        // GET: /Valvula/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Valvula/Create

        [HttpPost]
        public ActionResult Create(Valvula valvula)
        {
            if (ModelState.IsValid)
            {
                db.Valvulas.Add(valvula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(valvula);
        }

        //
        // GET: /Valvula/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Valvula valvula = db.Valvulas.Find(id);
            if (valvula == null)
            {
                return HttpNotFound();
            }
            return View(valvula);
        }

        //
        // POST: /Valvula/Edit/5

        [HttpPost]
        public ActionResult Edit(Valvula valvula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(valvula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(valvula);
        }

        //
        // GET: /Valvula/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Valvula valvula = db.Valvulas.Find(id);
            if (valvula == null)
            {
                return HttpNotFound();
            }
            return View(valvula);
        }

        //
        // POST: /Valvula/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Valvula valvula = db.Valvulas.Find(id);
            db.Valvulas.Remove(valvula);
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