using MoveOn_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoveOn_MVC.Controllers
{
    public class AtendimentoController : Controller
    {
        // GET: Atendimento
        public ActionResult NovoAtendimento()
        {
            return View();
        }

        //public void NovoAtendimento(Atendimento atendimento)
        //{
        //    //-- Implementar inserção do atendimento no banco 

        //    RedirectToAction("Index", "Home");
        //}
    }
}