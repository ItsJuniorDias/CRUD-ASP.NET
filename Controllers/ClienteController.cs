using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ECommerce.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace ECommerce.Controllers
{
    public class ClienteController : Controller
    {
        // campo (Field)
        private static List<Cliente> clientes = new List<Cliente>();
        private static int contador = 1;

        [HttpGet]
        public ActionResult Index()
        {
            return View(clientes);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //using Microsoft.AspNetCore.Http;
        [HttpPost]
        public ActionResult Create(IFormCollection form)
        {
            var novoCliente = new Cliente();
            novoCliente.Nome = form["nome"]; // <input name="nome"...
            novoCliente.Email = form["email"]; // <input name="email"...
            novoCliente.IdCliente = contador++;

            clientes.Add(novoCliente);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            // TODO: Apagar cliente da lista a partir do id.
            // foreach(var c in clientes)
            // {
            //     if(c.IdCliente == id)
            //     {
            //         clientes.Remove(c);
            //         break;
            //     }
            // }

            var cliente = clientes.Single(c => c.IdCliente == id);
            clientes.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}