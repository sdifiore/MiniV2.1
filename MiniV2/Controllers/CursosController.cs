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