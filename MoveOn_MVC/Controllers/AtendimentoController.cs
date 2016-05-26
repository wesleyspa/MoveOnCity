using MoveOn.Domain;
using MoveOn.Infra.DataContext;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MoveOn_MVC.Controllers
{        
    public class AtendimentoController : Controller
    {
        // GET: Atendimento
        public ActionResult Index()
        {
            if (Session["funcionarioLogadoID"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            MoveOnDataContext db = new MoveOnDataContext();

            List<Atendimento> atendimentos = new List<Atendimento>();
            atendimentos = db.Atendimentos.Include("Cliente").Include("Servico").Where(x => x.MomConclusao == null).OrderBy(x => x.MomAbertura).ToList();
           
            return View(atendimentos);
        }


        // GET: Atendimento
        public ActionResult NovoAtendimento()
        {
            MoveOnDataContext dc = new MoveOnDataContext();

            ViewBag.Servicos = dc.Servicos.ToList().ToString();

            return View();
        }

        //public void NovoAtendimento(Atendimento atendimento)
        //{
        //    //-- Implementar inserção do atendimento no banco 

        //    RedirectToAction("Index", "Home");
        //}
    }
}