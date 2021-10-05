using clientes.Context;
using clientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clientes.Controllers
{
    public class ClientesController : Controller
    {

        private EFContext context = new EFContext();

        // GET: Clientes
        public ActionResult Index()
        {
            return View(context.clientes.OrderBy(c => c.Nome));
        }

        // GET: Clientes
        public ActionResult Create()
            {
            return View();
            }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Cliente clientes)
            {
            context.clientes.Add(clientes);
            context.SaveChanges();
            return RedirectToAction("Index");
            }
        }
}