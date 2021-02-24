using CochesCutres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CochesCutres.Controllers
{
    
    public class ClientesController : Controller
    {
        // GET: Clientes
        
        public ActionResult Index()
        {
            List<Clientes> clientes = new Clientes().recuperarTodos();
            return View(clientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View(new Clientes().seleccionarCliente(id));
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Clientes cliente)
        {
            try
            {
                // TODO: Add insert logic here
                new Clientes().insertarCliente(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            List<Clientes> clientes = new Clientes().recuperarTodos();
            Clientes cliente = clientes.Where(cl => cl.Id == id).First();
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")]int id, Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                new Clientes().actualizarClientes(cliente);
                return RedirectToAction("Index");

            }
            return View(cliente);

        }
    }
}
