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

        public ActionResult Vegetais()
        {
            ViewBag.Title = "Vegetais ricos em FODMAPS";

            return View();
        }

        public ActionResult Frutas()
        {
            ViewBag.Title = "Frutas ricas em FODMAPS";

            return View();
        }

        public ActionResult Leite_e_Derivados()
        {
            ViewBag.Title = "Leite e derivados ricos em FODMAPS";

            return View();
        }

        public ActionResult Substitutos_do_leite()
        {
            ViewBag.Title = "Substitutos de leite e derivados ricos em FODMAPS";

            return View();
        }

        public ActionResult Leguminosas_oleaginosas_graos_sementes()
        {
            ViewBag.Title = "Leguminosas, oleaginosas, gr&atilde;os e sementes ricas em FODMAPS";

            return View();
        }

        public ActionResult Bebidas()
        {
            ViewBag.Title = "Bebidas ricas em FODMAPS";

            return View();
        }

        public ActionResult Condimentos_e_acucares()
        {
            ViewBag.Title = "Condimentos e a&ccedil;&uacute;cares ricos em FODMAPS";

            return View();
        }

        public ActionResult Industrializados()
        {
            ViewBag.Title = "Aten&ccedil;&atilde;o nos ingredientes de produtos industrializados!!";

            return View();
        }

        public ActionResult O_que_manter_na_despensa_e_na_geladeira()
        {
            ViewBag.Title = "O que manter na despensa e na geladeira";

            return View();
        }
    }
}