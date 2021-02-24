using CochesCutres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CochesCutres.Controllers
{
    public class CompraVentaController : Controller
    {
        // GET: CompraVenta
        public ActionResult Index()
        {
            return View(new CompraVenta().recuperarTodos());
        }        

        // GET: CompraVenta/Create
        public ActionResult Create(int tipo)
        {
            ViewBag.tipo = tipo;
            return View();
            
        }

        // POST: CompraVenta/Create
        [HttpPost]
        public ActionResult Create(CompraVenta compraVenta)
        {
            try
            {
                // TODO: Add insert logic here
                if (ViewBag.tipo == 0)  compraVenta.Tipo = Tipo.Compra; else compraVenta.Tipo=Tipo.Venta;
                new CompraVenta().añadirCompraVenta(compraVenta);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
