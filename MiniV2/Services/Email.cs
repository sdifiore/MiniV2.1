using MiniV2.Core;
using MiniV2.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MiniV2.Services
{
    public class Email : IEmail
    {
        public object DisposeAttachment { get; private set; }

        public async Task SendAsync(Contato contato)
        {
            SmtpClient smtpClient = null;

            try
            {
                var manuelaIbiEmail = new ManuelaIbiEmail
                {
                    
                };

                smtpClient = new SmtpClient
                {
                    Host = "smtp.manuelaibi.com.br",
                    Port = 587,
                    EnableSsl = false,
                    Credentials = new NetworkCredential(manuelaIbiEmail.Username, manuelaIbiEmail.Password)
                };

                string corpo = contato.Comentario + "\n\r Nome: " + contato.Nome
                                                  + "\n\r Telefone: " + contato.Telefone
                                                  + "\n\r E-Mail: " + contato.Email;

                using (var message = new MailMessage(manuelaIbiEmail.Username, "manuelaibi66@gmail.com")
                {
                    Subject = "Email de Manuela Ibi Nutrição Integrada",
                    Body = corpo
                })
                {
                    await smtpClient.SendMailAsync(message);
                }
            }

            finally
            {
                smtpClient.Dispose();
            }
        }
    }
}