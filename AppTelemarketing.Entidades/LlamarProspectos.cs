using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTelemarketing.Entidades
{
    [Table("LlamadosProspectos")]
    public class LlamadosProspectos
    {
        [Key]
        public int IdLlamadosProspectos { get; set; }

        // Foreign key for Prospectos
        [ForeignKey("Prospecto")]
        public int IdProspecto { get; set; }

        // Foreign key for Respuestas
        [ForeignKey("Respuesta")]
        public int CodRespuesta { get; set; }

        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string Observacion { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public virtual Prospecto Prospecto { get; set; }
        public virtual Respuestas Respuesta { get; set; }

        // Constructor
        public LlamadosProspectos(int idProspecto, int codRespuesta, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, string observacion, int userId)
        {
            IdProspecto = idProspecto;
            CodRespuesta = codRespuesta;
            Fecha = fecha;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            Observacion = observacion;
            UserId = userId;
        }

        public LlamadosProspectos()
        {
        }
    }
}