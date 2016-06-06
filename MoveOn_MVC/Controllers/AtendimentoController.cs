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
            if (Session["logadoID"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            MoveOnDataContext db = new MoveOnDataContext();

            List<Atendimento> atendimentos = new List<Atendimento>();
            atendimentos = db.Atendimentos.Include("Cliente").Include("Servico").Where(x => x.MomConclusao == null).OrderBy(x => x.MomAbertura).ToList();

            return View(atendimentos);
        }

        public ActionResult Lista(int? cliId)
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            using (MoveOnDataContext db = new MoveOnDataContext())
            {
                List<Atendimento> atendimentos = new List<Atendimento>();
                if (cliId > 0)
                {
                    atendimentos = db.Atendimentos.Include("Servico").Where(x => x.ClienteId == cliId).ToList();
                }
                else
                {
                    atendimentos = db.Atendimentos.Include("Servico").ToList();
                }

                foreach (var item in atendimentos)
                {
                    ViewData[item.VeiculoCliente.ToString()] = db.Veiculos.Find(item.VeiculoCliente).ToString();
                }

                return View(atendimentos);
            };
        }


        // GET: Atendimento
        public ActionResult NovoAtendimento()
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            MoveOnDataContext dc = new MoveOnDataContext();

            ICollection<Servico> servicos = dc.Servicos.ToList();
            ViewBag.Servicos = servicos;

            var idCli = int.Parse(Session["logadoID"].ToString());

            ICollection<Veiculo> veiculos = dc.Veiculos.Where(x => x.Id == idCli).ToList();
            ViewBag.Veiculos = veiculos;

            return View();
        }

        [HttpPost]
        public ActionResult NovoAtendimento(Atendimento atendimento)
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            MoveOnDataContext dc = new MoveOnDataContext();

            atendimento.ClienteId = int.Parse(Session["logadoID"].ToString());
            //if (ModelState.IsValid)
            //{
                dc.Atendimentos.Add(atendimento);
                dc.SaveChanges();
                return RedirectToAction("Lista", new { cliId = atendimento.ClienteId });
            //}

            //return View(atendimento);
        }

        public ActionResult Status(int Id)
        {
            MoveOnDataContext dc = new MoveOnDataContext();
            var atend = dc.Atendimentos.Find(Id);

            if (atend.MomInicio == null)
            {
                atend.MomInicio = System.DateTime.Now;
            }
            else
            {
                atend.MomConclusao = System.DateTime.Now;
            }
            dc.Entry(atend).CurrentValues.SetValues(atend);
            dc.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Detalhes(Atendimento c)
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            MoveOnDataContext dc = new MoveOnDataContext();

            var original = dc.Atendimentos.Find(c.Id);

            if (original != null)
            {                
                c.MomAbertura = original.MomAbertura;

                dc.Entry(original).CurrentValues.SetValues(c);
                dc.SaveChanges();
            }

            return RedirectToAction("Lista");
        }

        public ActionResult Detalhes(int id)
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            MoveOnDataContext dc = new MoveOnDataContext();

            ICollection<Servico> servicos = dc.Servicos.ToList();
            ViewBag.Servicos = servicos;

            var result = dc.Atendimentos.Where(x => x.Id == id).FirstOrDefault();

            return View(result);
        }

    }
}