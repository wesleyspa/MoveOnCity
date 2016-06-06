using MoveOn.Infra.DataContext;
using System.Linq;
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
        public ActionResult LogOn(FormCollection f)
        {

            string cpf = f["CPF"];
            string senha = f["Senha"];

            if (ModelState.IsValid)
            {
                MoveOnDataContext dc = new MoveOnDataContext();
                var result = dc.Funcionarios.Where(x => x.CPF_CNPJ == cpf && x.Senha == senha).FirstOrDefault();

                if (result != null)
                {
                    Session["logadoId"] = result.Id;                    
                    Session["logadoNome"] = result.Nome.ToString(); ;
                    Session["FuncOrCliente"] = "F";
                    return RedirectToAction("Index", "Atendimento");
                }
                else
                {
                    var result2 = dc.Clientes.Where(x => x.CPF_CNPJ == cpf && x.Senha == senha).FirstOrDefault();

                    if (result2 != null)
                    {
                        Session["logadoId"] = result2.Id;
                        Session["logadoNome"] = result2.Nome.ToString();
                        Session["FuncOrCliente"] = "C";
                        return RedirectToAction("NovoAtendimento", "Atendimento");
                    }
                }
            }
            return View();
        }


        // GET: Home
        public ActionResult Index()
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            return RedirectToAction("Index", "Atendimento");
        }

        public ActionResult MapaAtendimentos()
        {
            if (Session["logadoId"] == null)
            {
                return RedirectToAction("LogOn", "Home");
            }

            return RedirectToAction("MapaAtendimentos");
        }

        public ActionResult Mapa()
        {
            return View();
        }
    }
}