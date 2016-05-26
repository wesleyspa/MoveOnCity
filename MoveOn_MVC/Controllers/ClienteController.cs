using MoveOn.Domain;
using MoveOn.Infra.DataContext;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MoveOn_MVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Lista()
        {
            using (MoveOnDataContext db = new MoveOnDataContext())
            {
                List<Cliente> clientes = new List<Cliente>();
                clientes = db.Clientes.Include("Endereco").ToList();
                return View(clientes);
            };
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(Cliente c)
        {
            MoveOnDataContext dc = new MoveOnDataContext();

            if (ModelState.IsValid)
            {
                dc.Clientes.Add(c);
                dc.SaveChanges();
                return RedirectToAction("Lista");
            }

            return View(c);
        }


        [HttpPost]
        public ActionResult Detalhe(Cliente c)
        {
            MoveOnDataContext dc = new MoveOnDataContext();

            var original = dc.Clientes.Where(x => x.Id == c.Id).FirstOrDefault();

            if (original != null)
            {
                c.EnderecoId = original.EnderecoId;
                c.VeiculoId = original.VeiculoId;


                dc.Entry(original).CurrentValues.SetValues(c);
                dc.SaveChanges();
            }

            return RedirectToAction("Lista");
        }

        public ActionResult Detalhes(int id)
        {
            MoveOnDataContext dc = new MoveOnDataContext();

            var result = dc.Clientes.Include("Veiculo").Include("Endereco").Where(x => x.Id == id).FirstOrDefault();

            return View(result);
        }


    }
}