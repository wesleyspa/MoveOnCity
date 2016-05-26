using MoveOn.Domain;
using MoveOn.Infra.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoveOn_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult LogOn()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOn(Funcionario f)
        {
            if (ModelState.IsValid)
            {
                MoveOnDataContext dc = new MoveOnDataContext();
                var result = dc.Funcionarios.Where(x => x.CPF_CNPJ == f.CPF_CNPJ && x.Senha == f.Senha).FirstOrDefault();

                if (result != null)
                {
                    Session["funcionarioLogadoID"] = result.Id;                    
                    Session["funcionarioLogadoNome"] = result.Nome.ToString(); ;
                    return RedirectToAction("Index", "Atendimento");
                }
            }
            return View(f);
        }


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home
        public ActionResult NovoAtendimento()
        {
            return View();
        }

        public ActionResult MapaAtendimentos()
        {
            return View();
        }
    }
}