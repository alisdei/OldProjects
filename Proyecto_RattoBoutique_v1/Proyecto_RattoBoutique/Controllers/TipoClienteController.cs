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
    public class TipoClienteController : Controller
    {
        private UsersContext db = new UsersContext();

        //
        // GET: /TipoCliente/

        public ActionResult Index()
        {
            return View(db.TipoClienteModels.ToList());
        }

        //
        // GET: /TipoCliente/Details/5

        public ActionResult Details(int id = 0)
        {
            TipoClienteModels tipoclientemodels = db.TipoClienteModels.Find(id);
            if (tipoclientemodels == null)
            {
                return HttpNotFound();
            }
            return View(tipoclientemodels);
        }

        //
        // GET: /TipoCliente/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoCliente/Create

        [HttpPost]
        public ActionResult Create(TipoClienteModels tipoclientemodels)
        {
            if (ModelState.IsValid)
            {
                db.TipoClienteModels.Add(tipoclientemodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoclientemodels);
        }

        //
        // GET: /TipoCliente/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TipoClienteModels tipoclientemodels = db.TipoClienteModels.Find(id);
            if (tipoclientemodels == null)
            {
                return HttpNotFound();
            }
            return View(tipoclientemodels);
        }

        //
        // POST: /TipoCliente/Edit/5

        [HttpPost]
        public ActionResult Edit(TipoClienteModels tipoclientemodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoclientemodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoclientemodels);
        }

        //
        // GET: /TipoCliente/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TipoClienteModels tipoclientemodels = db.TipoClienteModels.Find(id);
            if (tipoclientemodels == null)
            {
                return HttpNotFound();
            }
            return View(tipoclientemodels);
        }

        //
        // POST: /TipoCliente/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoClienteModels tipoclientemodels = db.TipoClienteModels.Find(id);
            db.TipoClienteModels.Remove(tipoclientemodels);
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