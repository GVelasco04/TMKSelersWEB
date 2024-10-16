using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTelemarketing.Entidades
{
    public class TipoUsuarios
    {
        [Key]
        public int IdTipoUsuario { get; set; }
        public string Descripcion { get; set; }

        // Constructor con parámetros
        public TipoUsuarios(int idTipoUsuario, string descripcion)
        {
            IdTipoUsuario = idTipoUsuario;
            Descripcion = descripcion;
        }



    }
}
