using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTelemarketing.Entidades
{
    public class MediosDePago
    {
        public int IdMedioDePago { get; set; }
        public string Descripcion { get; set; }
        public string Observacion { get; set; }


        public MediosDePago(int idMedioDePago, string descripcion) 
        {
            IdMedioDePago = idMedioDePago;
            Descripcion = descripcion;

        }

    }
}
