using AppTelemarketing.Entidades;
using System.Collections.Specialized;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

namespace AppTelemarketing.Servicios
{
    //aqui construyo el servicio para enviar/recibir un correo electronico
    //Necesito los datos de la configuracion y del mail que voy a enviar, 
    //los servicios necesitan las entidades, los uno

    namespace AppTelemarketing.Servicios
    {
        public class MailServices
        {
            private readonly MailSettings settingsMail;

            public MailServices(IConfiguration configuration)
            {
                var section = configuration.GetSection("MailSettings");
                settingsMail = new MailSettings(
                    section["Server"], int.Parse(section["Port"]), section["FromName"], section["FromEmail"],
                    section["UserName"], section["Password"]);
            }

            public void SendMail(MailData dataMail)
            {
                try
                {
                    var mail = new MailMessage();
                    mail.To.Add(dataMail.Mailto);
                    mail.Subject = dataMail.Subject;
                    mail.From = new MailAddress(settingsMail.FromEmail, settingsMail.FromName);
                    mail.IsBodyHtml = true;
                    mail.Body = dataMail.Body;

                    var client = new SmtpClient();
                    client.Host = settingsMail.Server;
                    client.Port = settingsMail.Port;
                    client.Credentials = new NetworkCredential(settingsMail.UserName, settingsMail.Password);
                    client.EnableSsl = true;

                    client.Send(mail);
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it as needed
                    Console.WriteLine($"Error sending email: {ex.Message}");
                }
            }
        }
    }
}

