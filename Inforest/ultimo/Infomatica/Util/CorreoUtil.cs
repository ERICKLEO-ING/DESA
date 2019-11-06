using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infomatica.Util
{
    public class CorreoUtil
    {
        private readonly SmtpClient Cliente = new SmtpClient("smtp.gmail.com", 587)
        {
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("edelacruz@infomatica.pe", "2810921@")
        };
        private MailMessage email;

        /// <summary>
        /// Envio de correo especificando los valores de envioS SADASD ASDAS DAS
        /// </summary>
        public void EnviarCorreo(string destinatario, string asunto, string mensaje, bool esHtlm = false)
        {
            email = new MailMessage("edelacruz@infomatica.pe", destinatario, asunto, mensaje)
            {
                IsBodyHtml = esHtlm
            };
            Cliente.Send(email);
        }
        /// <summary>
        /// Envio de correo de una clase MailMessage
        /// </summary>
        public void EnviarCorreo(MailMessage message)
        {
            Cliente.Send(message);
        }
        /// <summary>
        /// Envio de correo Asincrono de una clase MailMessageAS AS DASDAS DASD AS
        /// </summary>
        public async Task EnviarCorreoAsync(MailMessage message) //Ola muundo
        {
            await Cliente.SendMailAsync(message);
        }
    }
}
