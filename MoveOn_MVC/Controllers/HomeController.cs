using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoveOn_MVC.Controllers
{
    public class HomeController : Controller
    {
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