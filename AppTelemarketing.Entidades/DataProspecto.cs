using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTelemarketing.Entidades
{
    [Table("Prospectos")]
    public class Prospecto
    {
        [Key]
        public int IdProspecto { get; set; }
        public long TelefonoPrincipal { get; set; }
        public string? Apellido { get; set; }
        public string Nombre { get; set; }
        public bool? Llamado { get; set; }
        public bool? Venta { get; set; }
        public string? ObsProspecto { get; set; }

        //constructor para poder modificarlos
        public Prospecto(int idProspecto, long telefonoPrincipal,
                        string apellido, string nombre, bool? llamado,
                        bool? venta, string obsProspecto)
        {
            IdProspecto = idProspecto;
            TelefonoPrincipal = telefonoPrincipal;
            Apellido = apellido;
            Nombre = nombre;
            Llamado = llamado;
            Venta = venta;
            ObsProspecto = obsProspecto;
        }
        public Prospecto(string nombre, string apellido, long telefonoPrincipal)
        {
            TelefonoPrincipal = telefonoPrincipal;
            Apellido = apellido;
            Nombre = nombre;
        }
        public Prospecto()
        {

        }
    }




}