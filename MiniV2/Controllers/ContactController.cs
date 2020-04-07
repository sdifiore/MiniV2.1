using MiniV2.Models;
using MiniV2.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MiniV2.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Mapa()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            if (Request.Cookies["EmailEnviado"] != null)
            {
                if (Request.Cookies["EmailEnviado"].Value == "true")
                    ViewBag.Message = "<div class='alert alert-success' role='alert'>Mensagem enviada com sucesso!</div>";
            }

            else
                ViewBag.Message = "";

            return View(new Contato());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(Contato contato)
        {
            var response = Request["g-recaptcha-response"];
            var secretKey = "6LefnOUUAAAAAHUY4PWXmTaefzbs--eW9ezqMqDS";
            var cliente = new WebClient();
            var resultado = cliente.DownloadString(
                $"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={response}");
            var obj = JObject.Parse(resultado);

            if (!(bool)obj.SelectToken("success"))
            {
                ViewBag.Message = "<div class='alert alert-danger' role='alert'>Captcha inválido!</div>";

                return View(new Contato());
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Message = "<div class='alert alert-danger' role='alert'>Os campos Nome, E-mail e Contato são obrigatórios</div>";

                return View(new Contato());
            }

            if (!IsValidEmail(contato.Email))
            {
                ViewBag.Message = "<div class='alert alert-danger' role='alert'>Forneça um endereço válido para o e-mail</div>";

                return View(new Contato());
            }

            try
            {
                var email = new Email();
                await email.SendAsync(contato);
            }
            catch
            {
                ViewBag.Message = "<div class='alert alert-danger' role='alert'>Ocorreu um erro desconhecido. Tente novamente</div>";

                return View(new Contato());
            }

            Response.Cookies["EmailEnviado"].Value = "true";
            Response.Cookies["EmailEnviado"].Expires = DateTime.Now.AddSeconds(30);

            return RedirectToAction("Contact");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
