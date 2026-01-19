using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvSVG.Models;

namespace MvSVG.Controllers
{
    public class ProductoController : Controller
    {
        private UsersContext db = new UsersContext();

        //
        // GET: /Producto/
        [Authorize]
        public ActionResult Index()
        {
            var productoes = db.Productoes.Include(p => p.Valvula);
            return View(productoes.ToList());
        }

        //
        // GET: /Producto/Details/5
        [Authorize]
        public ActionResult Details(int id = 0)
        {
            Producto producto = db.Productoes.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        //
        // GET: /Producto/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.ValvulaID = new SelectList(db.Valvulas, "ValvulaID", "Descripcion");
            return View();
        }

        //
        // POST: /Producto/Create

        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Productoes.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ValvulaID = new SelectList(db.Valvulas, "ValvulaID", "Descripcion", producto.ValvulaID);
            return View(producto);
        }

        //
        // GET: /Producto/Edit/5
        [Authorize]
        public ActionResult Edit(int id = 0)
        {
            Producto producto = db.Productoes.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            ViewBag.ValvulaID = new SelectList(db.Valvulas, "ValvulaID", "Descripcion", producto.ValvulaID);
            return View(producto);
        }

        //
        // POST: /Producto/Edit/5

        [HttpPost]
        public ActionResult Edit(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ValvulaID = new SelectList(db.Valvulas, "ValvulaID", "Descripcion", producto.ValvulaID);
            return View(producto);
        }

        //
        // GET: /Producto/Delete/5
        [Authorize]
        public ActionResult Delete(int id = 0)
        {
            Producto producto = db.Productoes.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        //
        // POST: /Producto/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Producto producto = db.Productoes.Find(id);
            db.Productoes.Remove(producto);
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