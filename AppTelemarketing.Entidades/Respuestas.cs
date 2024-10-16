using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using
System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTelemarketing.Entidades
{
    [Table("Respuestas")]
    public class Respuestas
    {

      [Key]
      public int CodRespuesta { get; set; }
      public string Respuesta { get; set; }

      // Constructor con parámetros
      public Respuestas(int codRespuesta, string respuesta)
        {
            CodRespuesta = codRespuesta;
            Respuesta = respuesta;
        }

       public  Respuestas(string respuesta) {
            Respuesta = respuesta;
        }
    }
}
