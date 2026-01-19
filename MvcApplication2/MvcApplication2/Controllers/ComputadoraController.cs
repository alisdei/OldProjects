using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;
namespace MvcApplication2.Controllers
{
    public class ComputadoraController : Controller
    {
        //
        // GET: /Computadora/
        VENTA_COMPUTADORASEntities obj = new VENTA_COMPUTADORASEntities();
        public ActionResult Index()
        {
            return View(obj.TBL_PRODUCTOS);
        }

        //
        // GET: /Computadora/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Computadora/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Computadora/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Computadora/Edit/5

        public ActionResult Edit(int id)
        {
            //TBL_PRODUCTOS Entidad = new TBL_PRODUCTOS();
            object Entidad = (from c in obj.TBL_PRODUCTOS where c.IDPRODUCTO == id select c).First();
            return View(Entidad);
        }

        //
        // POST: /Computadora/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Computadora/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Computadora/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
