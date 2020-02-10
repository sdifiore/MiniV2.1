using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniV2.Services;
using MiniV2.ViewModels;

namespace MiniV2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Manuela Ibi Nutrição Integrada";
            ViewBag.Content = "Manuela Ibi, Nutricionista Botucatu, Nutri Botucatu, Nutricionista Vegetariana Botucatu, Nutricionista Vegana Botucatu, Nutricionista em Botucatu, Nutricionista Vegetariana em Botucatu, Nutricionista Vegana em Botucatu, Botucatu, Melhor nutricionista, Melhor nutricionista Botucatu, Melhor nutricionista vegetariana Botucatu, Melhor nutricionista vegana Botucatu";

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

        public ActionResult PopUp()
        {
            List<String> paths = new List<string>
            {
                "Aqui_tem_Alimentacao_personalizada_400.jpg",
                "Aqui_tem_beneficios_400.jpg",
                "Aqui_tem_De_forma_integrada_400.jpg",
                "Aqui_tem_Descomplica_a_cozinha_400.jpg",
                "Aqui_tem_Foco_e_atualizada_400.jpg",
                "Aqui_tem_Modulacao_intestinal_400.jpg",
                "Aqui_tem_nutri_que_escuta_400.jpg",
                "Aqui_tem_Perto_de_voce_400.jpg",
                "Aqui_tem_Te_conhece_400.jpg"
            };

            return View(new PopUpViewModel { Image = $"~/Images/Campanhas/Aqui_tem/{paths[IntUtils.RandomInt(0, 8)]}" });
        }
    }
}