using MoveOn_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoveOn_MVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult ListaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            Cliente cliente = new Cliente()
            {
                ClienteId = 1,
                Nome = "Wesley",
                Email = "WEsley1@gmail.com.br",
                CNH = "11111",
                CPF_CNPJ = "399.877.838-13",
                EstadoCivil = "S"
            };

            clientes.Add(cliente);

            return View(clientes);
        }
    }
}