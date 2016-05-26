using MoveOn.Domain;
using MoveOn.Infra.DataContext;
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
            using (MoveOnDataContext db = new MoveOnDataContext())
            {
                List<Servico> servicos = new List<Servico>();
                servicos = db.Servicos.ToList();
                return View(servicos);
            };

        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(Servico s)
        {
            MoveOnDataContext dc = new MoveOnDataContext();

            if (ModelState.IsValid)
            {
                dc.Servicos.Add(s);
                try
                {
                    dc.SaveChanges();
                    return RedirectToAction("ListaServicos");
                }
                catch
                {
                }

            }

            return View(s);
        }


        [HttpPost]
        public ActionResult Detalhe(Servico s)
        {
            MoveOnDataContext dc = new MoveOnDataContext();

            var original = dc.Servicos.Where(x => x.Id == s.Id).FirstOrDefault();

            if (original != null)
            {
                dc.Entry(original).CurrentValues.SetValues(s);
                dc.SaveChanges();
            }

            return RedirectToAction("ListaServicos");
        }

        public ActionResult Detalhes(int id)
        {
            MoveOnDataContext dc = new MoveOnDataContext();

            var result = dc.Servicos.Where(x => x.Id == id).FirstOrDefault();

            return View(result);
        }

    }
}