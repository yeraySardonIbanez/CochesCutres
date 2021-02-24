using CochesCutres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CochesCutres.Controllers
{
    public class VehiculosController : Controller
    {
        // GET: Vehiculos
        public ActionResult Index()
        {
            
            return View(new Vehiculos().recuperarTodos());
        }

        // GET: Vehiculos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vehiculos/Edit/5
        public ActionResult Edit(int id)
        {
            return View(new Vehiculos().recuperarVehiculo(id));
        }

        // POST: Vehiculos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Vehiculos vehiculo)
        {
            try
            {
                // TODO: Add update logic here
                new Vehiculos().actualizarVehiculo(vehiculo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(vehiculo);
            }
        }

        
    }
}
