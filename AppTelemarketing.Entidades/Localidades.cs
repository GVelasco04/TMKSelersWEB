using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTelemarketing.Entidades
{
    public class Localidades
    {
        public int IdLocalidad { get; set; }
        public string Localidad { get; set; }
        public int IdProvincia { get; set; }
        public int CodPostal { get; set; }
        public Localidades(int idLocalidad, string localidad, int codPostal)
        {
            IdLocalidad = idLocalidad;
            Localidad = localidad;
            CodPostal = codPostal;
        }
    }
}
