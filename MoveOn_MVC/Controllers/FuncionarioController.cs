using MoveOn.Domain;
using MoveOn.Infra.DataContext;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MoveOn_MVC.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Cliente
        public ActionResult Lista()
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            using (MoveOnDataContext db = new MoveOnDataContext())
            {
                List<Funcionario> funcionarios = new List<Funcionario>();
                funcionarios = db.Funcionarios.ToList();
                return View(funcionarios);
            };
        }

        public ActionResult Criar()
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Criar(Funcionario c)
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            MoveOnDataContext dc = new MoveOnDataContext();

            if (ModelState.IsValid)
            {
                dc.Funcionarios.Add(c);
                dc.SaveChanges();
                return RedirectToAction("Lista");
            }

            return View(c);
        }


        [HttpPost]
        public ActionResult Detalhe(Funcionario c)
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            MoveOnDataContext dc = new MoveOnDataContext();

            var original = dc.Funcionarios.Find(c.Id);

            if (original != null)
            {
                c.FunEnderecoId = original.FunEnderecoId;
                
                dc.Entry(original).CurrentValues.SetValues(c);
                dc.SaveChanges();
                return RedirectToAction("Lista");
            }

            return View(c);
        }

        public ActionResult Detalhes(int id)
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            MoveOnDataContext dc = new MoveOnDataContext();

            var result = dc.Funcionarios.Include("FunEndereco").Where(x => x.Id == id).FirstOrDefault();

            return View(result);
        }

        public ActionResult Deletar(int id)
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            MoveOnDataContext dc = new MoveOnDataContext();

            var result = dc.Funcionarios.Find(id);
            dc.Funcionarios.Remove(result);
            dc.SaveChanges();

            return RedirectToAction("Lista");
        }

    }
}