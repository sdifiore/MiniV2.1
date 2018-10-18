using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniV2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sobre Manuela Ibi Nutrição Integrada";

            return View();
        }

        public ActionResult Atendimento()
        {
            return View();
        }

        public ActionResult Fitoterapia()
        {
            return View();
        }

        public ActionResult Servicos()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contato.";

            return View();
        }
    }
}