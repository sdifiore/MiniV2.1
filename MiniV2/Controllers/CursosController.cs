using System.Web.Mvc;

namespace MiniV2.Controllers
{
    public class CursosController : Controller
    {
        // GET: Cursos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Petiscos_de_verão_9_outubro_2019()
        {
            ViewBag.Title = "Petiscos de verão – 9 de outubro de 2019";

            return View();
        }

        public ActionResult Aniversário_1_ano_Clinica_Lis()
        {
            ViewBag.Title = "Aniversário Clínica Lis: 1 ano – 5 de outubro de 2019";

            return View();
        }

        public ActionResult Cardapio_saudavel_18_setembro_2019()
        {
            ViewBag.Title = "Aprenda a montar o seu cardápio saudável – 18 de setembro de 2019";

            return View();
        }

        public ActionResult Cardapio_saudavel_21_agosto_2019()
        {
            ViewBag.Title = "Aprenda a montar o seu cardápio saudável – 21 de agosto de 2019";

            return View();
        }

        public ActionResult Sopas_17_julho_2019()
        {
            ViewBag.Title = "Sopas – 17 de julho de 2019";

            return View();
        }

        public ActionResult Sopas_16_junho_2019()
        {
            ViewBag.Title = "Sopas – 16 de junho de 2019";

            return View();
        }

        public ActionResult Lanches_22_maio_2019()
        {
            ViewBag.Title = "Estratégias para lanches doces e salgados – 22 de maio de 2019";

            return View();
        }

        public ActionResult Receitas_e_intestino_saudavel_10_mar_2019()
        {
            ViewBag.Title = "Receitas e intestino saudável 10 de março de 2019";

            return View();
        }

        public ActionResult Receitas_e_intestino_saudavel_22_fev_2019()
        {
            ViewBag.Title = "Receitas e intestino saudável 22 de fevereiro de 2019";

            return View();
        }

        public ActionResult Receitas_rapidas_para_detox_13_fev_2019()
        {
            ViewBag.Title = "Receitas rápidas para detox 13-fev-2019";

            return View();
        }

        public ActionResult Receitas_rapidas_para_detox_30_jan_2019()
        {
            ViewBag.Title = "Receitas rápidas para detox 30-jan-2019";

            return View();
        }
    }
}