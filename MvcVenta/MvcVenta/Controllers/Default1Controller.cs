using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcVenta.Models;

namespace MvcVenta.Controllers
{
    public class Default1Controller : Controller
    {
        private MvcVentaContext db = new MvcVentaContext();

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(db.TB_PRUEBA.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_PRUEBA tb_prueba = db.TB_PRUEBA.Find(id);
            if (tb_prueba == null)
            {
                return HttpNotFound();
            }
            return View(tb_prueba);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(TB_PRUEBA tb_prueba)
        {
            if (ModelState.IsValid)
            {
                db.TB_PRUEBA.Add(tb_prueba);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_prueba);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_PRUEBA tb_prueba = db.TB_PRUEBA.Find(id);
            if (tb_prueba == null)
            {
                return HttpNotFound();
            }
            return View(tb_prueba);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_PRUEBA tb_prueba)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_prueba).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_prueba);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_PRUEBA tb_prueba = db.TB_PRUEBA.Find(id);
            if (tb_prueba == null)
            {
                return HttpNotFound();
            }
            return View(tb_prueba);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_PRUEBA tb_prueba = db.TB_PRUEBA.Find(id);
            db.TB_PRUEBA.Remove(tb_prueba);
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