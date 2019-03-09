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

        public ActionResult Receitas_rapidas_para_detox_30_jan_2019()
        {
            ViewBag.Title = "Receitas rápidas para detox 30-jan-2019";

            return View();
        }

        public ActionResult Receitas_rapidas_para_detox_13_fev_2019()
        {
            ViewBag.Title = "Receitas rápidas para detox 18-fev-2019";

            return View();
        }

        public ActionResult Receitas_e_intestino_saudavel_22_fev_2019()
        {
            ViewBag.Title = "Receitas e intestino saudável 22 de fevereiro de 2019";

            return View();
        }
    }
}