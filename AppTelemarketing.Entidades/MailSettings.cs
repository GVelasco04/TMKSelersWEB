using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTelemarketing.Entidades
{
    public class MailSettings // aca defino las caracteristicas de comunicacion con mi cleinte de coreo Gmail
    {
        //solo con el get, que se agreguen solo por el constructor. SOn variables SOLO LECTURA
        public string Server { get;  }
        public int Port { get; }
        public string FromName { get; } //Nombre que va a salir en el mail Ej Juan Perez
        public string FromEmail { get; } //Direccion de mail que esta detras del nombre de mail
        public string UserName { get; } 
        public string Password { get; }

        //genero el constructor para que reciba los datos desde la aplicacion solamente,
        //por eso le eliminamos el set a las caracteristicas anteriores
        public MailSettings(string server, int port, string fromName, string fromEmail, string userName, string password)
        {
            Server = server;
            Port = port;
            FromName = fromName;
            FromEmail = fromEmail;
            UserName = userName;
            Password = password;
        }
    }
}
