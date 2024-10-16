using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTelemarketing.Entidades
{
    public class MailData //propiedades que me va a identificar propiedades para mandar un correo electronico
    {
        public string Mailto { get; set; } 
        public string Subject { get; set; }
        public string Body { get; set; }

    }
}
