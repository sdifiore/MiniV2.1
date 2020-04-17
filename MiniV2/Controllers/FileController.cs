using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniV2.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Equivalentes()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "App_Data/Downloads/";
            byte[] fileBytes = System.IO.File.ReadAllBytes(path + "Equivalentes.pdf");
            string fileName = "Equivalentes.pdf";

            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public ActionResult Covid19()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "App_Data/Downloads/";
            byte[] fileBytes = System.IO.File.ReadAllBytes(path + "Nutricao_durante_Covid19_HCFMB.pdf");
            string fileName = "Nutricao_durante_Covid19_HCFMB.pdf";

            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    }
}