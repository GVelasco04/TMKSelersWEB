using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTelemarketing.Entidades
{
    public class Provincias
    {
        public int IdProvincia { get; set; }
        public string Provincia { get; set; }
      
        public Provincias(int idProvincia, string provincia) { 

            IdProvincia = idProvincia;
            Provincia = provincia;

        }
    }
}
