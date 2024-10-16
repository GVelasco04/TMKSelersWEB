using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTelemarketing.Entidades
{
    public class ArchivosBBDD
    {
        public int IdArchivo { get; }
        public string NombreArchivo { get; set; }
        public DateTime FechaCarga { get; set; }

        // Constructor para inicializar NombreArchivo y FechaCarga
        public ArchivosBBDD(string nombreArchivo, DateTime fechaCarga)
        {
            NombreArchivo = nombreArchivo;
            FechaCarga = fechaCarga;
        }

        // Constructor para inicializar todas las propiedades
        public ArchivosBBDD(int idArchivo, string nombreArchivo, DateTime fechaCarga)
        {
            IdArchivo = idArchivo;
            NombreArchivo = nombreArchivo;
            FechaCarga = fechaCarga;
        }

        public ArchivosBBDD()
        {

        }
    }
}
