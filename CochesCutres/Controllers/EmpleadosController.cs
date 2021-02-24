using CochesCutres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CochesCutres.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Index()
        {
            List<Empleados> empleados = new Empleados().recuperarTodos();
            return View(empleados);
        }

        // GET: Empleados/Details/5
        public ActionResult Details(int id)
        {
            return View(new Empleados().seleccionarEmpleado(id));
        }

        // GET: Empleados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
        [HttpPost]
        public ActionResult Create(Empleados empleado)
        {
            try
            {
                // TODO: Add insert logic here
                new Empleados().insertarEmpleados(empleado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleados/Edit/5
        public ActionResult Edit(int id)
        {
            List<Empleados> empleados = new Empleados().recuperarTodos();
            Empleados emplado = empleados.Where(cl => cl.Id == id).First();
            return View(emplado);
        }

        // POST: Empleados/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Empleados empleado)
        {
            if (ModelState.IsValid)
            {
                new Empleados().actualizarEmpleados(empleado);
                return RedirectToAction("Index");

            }
            return View(empleado);
        }

        // GET: Empleados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empleados/Delete/5
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
