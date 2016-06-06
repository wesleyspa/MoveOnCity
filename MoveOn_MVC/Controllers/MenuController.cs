using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoveOn_MVC.Controllers
{
    public class MenuController : Controller
    {
        [ChildActionOnly]
        public ActionResult Header()
        {
           
            if (Session["FuncOrCliente"].ToString() == "F")
            {
                return View("~/Views/Shared/_MenuFuncionario.cshtml");
            }
            else
            {
                return View("~/Views/Shared/_MenuCliente.cshtml");
            }

        }
    }
}