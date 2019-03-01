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
    }
}