using System.Web.Mvc;

namespace MiniV2.Controllers
{
    public class DicasController : Controller
    {
        // GET: Dicas
        public ActionResult Index()
        {
            ViewBag.Title = "Biblioteca da Manu: Texto";
            ViewBag.Content = "As 10 leis do bom alimento, FOODMAPS, O que manter na despensa e na geladeira, Campanhas";

            return View();
        }

        public ActionResult Acucares_baixo_FODMAP()
        {
            ViewBag.Title = "Açúcares pobres em FODMAPS";

            return View();
        }

        public ActionResult As_10_leis_do_bom_alimento()
        {
            ViewBag.Title = "As 10 leis do bom alimento";

            return View();
        }

        public ActionResult Campanhas()
        {
            ViewBag.Title = "Campanhas";
            ViewBag.Content = "Campanhas";

            return View();
        }

        public ActionResult COVID19()
        {
            ViewBag.Title = "COVID-19: Sua imunidade depende do seu intestino";
            ViewBag.Content = "COVID-19: Sua imunidade depende do seu intestino";

            return View();
        }

        public ActionResult Bebidas()
        {
            ViewBag.Title = "Bebidas ricas em FODMAPS";

            return View();
        }

        public ActionResult Bebidas_baixos_FODMAPS()
        {
            ViewBag.Title = "Bebidas pobres em FODMAPS";

            return View();
        }

        public ActionResult BibliotecaVideo()
        {
            ViewBag.Title = "Biblioteca da Manu: Vídeo";

            return View();
        }

        public ActionResult Condimentos_baixo_FODMAP()
        {
            ViewBag.Title = "Condimentos pobres em FODMAPS";

            return View();
        }
        public ActionResult Condimentos_e_acucares()
        {
            ViewBag.Title = "Condimentos e açucares ricos em FODMAPS";

            return View();
        }

        public ActionResult FODMAPS()
        {
            ViewBag.Title = "Massas ricas em FODMAPS";

            return View();
        }

        public ActionResult Frutas()
        {
            ViewBag.Title = "Frutas ricas em FODMAPS";

            return View();
        }

        public ActionResult Frutas_baixo_FODMAP()
        {
            ViewBag.Title = "Frutas pobres em FODMAPS";

            return View();
        }

        public ActionResult Gorduras()
        {
            ViewBag.Title = "Gorduras e óleos permitidos na restrição de FODMAPS";

            return View();
        }

        public ActionResult Industrializados()
        {
            ViewBag.Title = "Atenção nos ingredientes de produtos industrializados!!";

            return View();
        }

        public ActionResult Leguminosas_oleaginosas_graos_sementes()
        {
            ViewBag.Title = "Leguminosas, oleaginosas, grãos e sementes ricas em FODMAPS";

            return View();
        }

        public ActionResult Leguminosas_oleaginosas_graos_sementes_baixo_FODMAP()
        {
            ViewBag.Title = "Leguminosas, oleaginosas, grãos e sementes pobres em FODMAPS";

            return View();
        }

        public ActionResult Leite_e_Derivados()
        {
            ViewBag.Title = "Leite e derivados ricos em FODMAPS";

            return View();
        }

        public ActionResult Massas()
        {
            ViewBag.Title = "Massas com baixos valores em FODMAPS";

            return View();
        }

        public ActionResult Omega_3()
        {
            ViewBag.Title = "Ômega 3";

            return View();
        }

        public ActionResult O_que_manter_na_despensa_e_na_geladeira()
        {
            ViewBag.Title = "O que manter na despensa e na geladeira";

            return View();
        }

        public ActionResult Substitutos_do_leite()
        {
            ViewBag.Title = "Substitutos de leite e derivados ricos em FODMAPS";

            return View();
        }

        public ActionResult Substitutos_do_leite_baixo_FODMAP()
        {
            ViewBag.Title = "Substitutos de leite e derivados pobres em FODMAPS";

            return View();
        }

        public ActionResult Vegetais()
        {
            ViewBag.Title = "Vegetais ricos em FODMAPS";

            return View();
        }

        public ActionResult Vegetais_baixo_FODMAPS()
        {
            ViewBag.Title = "Vegetais pobres em FODMAPS";

            return View();
        }
    }
}