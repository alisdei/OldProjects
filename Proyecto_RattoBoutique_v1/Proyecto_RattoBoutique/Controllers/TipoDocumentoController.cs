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
    public class TipoDocumentoController : Controller
    {
        private UsersContext db = new UsersContext();

        //
        // GET: /TipoDocumento/

        public ActionResult Index(string Sorting_Order, string Search_Data)
        {
            ViewBag.SortingName = String.IsNullOrEmpty(Sorting_Order) ? "Descripcion" : "";
            //ViewBag.SortingDate = Sorting_Order == "Date_Enroll" ? "Date_Description" : "Date";

            var TipoDocumentos = from stu in db.TipoDocumentoModels select stu;
            if (!string.IsNullOrEmpty(Search_Data))
            {
                TipoDocumentos = TipoDocumentos.Where(stu => stu.Descripcion.ToUpper().Contains(Search_Data.ToUpper()));
            }
            switch (Sorting_Order)
            {
                case "Descripcion":
                    TipoDocumentos = TipoDocumentos.OrderByDescending(stu => stu.Descripcion);
                    break;
                default:
                    TipoDocumentos = TipoDocumentos.OrderBy(stu => stu.Descripcion);
                    break;
            }
            return View(TipoDocumentos.ToList());
        }

        //
        // GET: /TipoDocumento/Details/5

        public ActionResult Details(int id = 0)
        {
            TipoDocumentoModels tipodocumentomodels = db.TipoDocumentoModels.Find(id);
            if (tipodocumentomodels == null)
            {
                return HttpNotFound();
            }
            return View(tipodocumentomodels);
        }

        //
        // GET: /TipoDocumento/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoDocumento/Create

        [HttpPost]
        public ActionResult Create(TipoDocumentoModels tipodocumentomodels)
        {
            if (ModelState.IsValid)
            {
                db.TipoDocumentoModels.Add(tipodocumentomodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipodocumentomodels);
        }

        //
        // GET: /TipoDocumento/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TipoDocumentoModels tipodocumentomodels = db.TipoDocumentoModels.Find(id);
            if (tipodocumentomodels == null)
            {
                return HttpNotFound();
            }
            return View(tipodocumentomodels);
        }

        //
        // POST: /TipoDocumento/Edit/5

        [HttpPost]
        public ActionResult Edit(TipoDocumentoModels tipodocumentomodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipodocumentomodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipodocumentomodels);
        }

        //
        // GET: /TipoDocumento/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TipoDocumentoModels tipodocumentomodels = db.TipoDocumentoModels.Find(id);
            if (tipodocumentomodels == null)
            {
                return HttpNotFound();
            }
            return View(tipodocumentomodels);
        }

        //
        // POST: /TipoDocumento/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoDocumentoModels tipodocumentomodels = db.TipoDocumentoModels.Find(id);
            db.TipoDocumentoModels.Remove(tipodocumentomodels);
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