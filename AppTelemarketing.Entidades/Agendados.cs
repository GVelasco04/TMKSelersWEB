using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppTelemarketing.Entidades
{
    [Table("Agendados")]
    public class Agendados
    {
        [Key]
        public int IdAgendado { get; set; }

        public int IdProspecto { get; set; }
        public DateTime FechaAgenda { get; set; }
        public TimeSpan HoraAgenda { get; set; }
        public string? ObsProspecto { get; set; }

       

        // Constructor con parámetros
        public Agendados(int idProspecto, DateTime fechaAgenda, TimeSpan horaAgenda, string? obsProspecto = null)
        {
            IdProspecto = idProspecto;
            FechaAgenda = fechaAgenda;
            HoraAgenda = horaAgenda;
            ObsProspecto = obsProspecto;
        }

        public Agendados()
        {

        }
    }
}
