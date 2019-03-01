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
            ViewBag.Title = "Manuela Ibi Nutrição Integrada";
            ViewBag.Description = "Mini é o espaço onde você encontra (minhas) receitas fáceis e saudáveis acumuladas ao longo de anos de cozinha e orientações de pacientes em consultório. Além disso você encontra meus cursos de gastronomia para leigos e um contato direto com minha linha de trabalho em consultório, onde alio nutrição funcional, fitoterapia, medicina tradicional chinesa & a modulação intestinal";
            ViewBag.Content = "Manuela Ibi, Nutricionista Botucatu, Nutricionista Vegetariana Botucatu, Nutricionista Vegana Botucatu, Nutricionista em Botucatu, Nutricionista Vegetariana em Botucatu, Nutricionista Vegana em Botucatu, Botucatu, Melhor nutricionista, Melhor nutricionista Botucatu, Melhor nutricionista vegetariana Botucatu, Melhor nutricionista vegana Botucatu";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sobre Manuela Ibi Nutrição Integrada";

            return View();
        }

        public ActionResult Curriculo_Lattes()
        {
            ViewBag.Message = "Currículo Lattes";

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