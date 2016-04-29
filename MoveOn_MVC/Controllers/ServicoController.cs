using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoveOn_MVC.Controllers
{
    public class ServicoController : Controller
    {
        // GET: Servico
        public ActionResult ListaServicos()
        {
            return View();
        }
    }
}