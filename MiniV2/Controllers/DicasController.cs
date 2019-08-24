using System.Web.Mvc;

namespace MiniV2.Controllers
{
    public class DicasController : Controller
    {
        // GET: Dicas
        public ActionResult Index()
        {
            ViewBag.Title = "Dicas da Manu";

            return View();
        }

        public ActionResult As_10_leis_do_bom_alimento()
        {
            ViewBag.Title = "As 10 leis do bom alimento";

            return View();
        }

        public ActionResult FODMAPS()
        {
            ViewBag.Title = "FODMAPS";

            return View();
        }

        public ActionResult O_que_manter_na_despensa_e_na_geladeira()
        {
            ViewBag.Title = "O que manter na despensa e na geladeira";

            return View();
        }
    }
}