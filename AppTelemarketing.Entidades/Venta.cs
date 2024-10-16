using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppTelemarketing.Entidades
{
    [Table("Ventas")]
    public class Venta
    {

        [Key]
        public int IdCliente { get; set; }
        public int IdProspecto { get; set; }
        public int? TelSecundario { get; set; }  // Nullable
        public string Direccion { get; set; }
        public int IdLocalidad { get; set; }
        public int IdProvincia { get; set; }
        public string CP { get; set; }
        public DateTime FechaVenta { get; set; }
        public TimeSpan? HoraComienzo { get; set; }  // Nullable
        public TimeSpan? HoraFin { get; set; }  // Nullable
        public int CodigoProd { get; set; }
        public int? Total { get; set; }  // Nullable
        public string Mail { get; set; }
        public int IdMedioDePago { get; set; }
        public int UserId { get; set; }
        public string? ObsSobreVenta { get; set; }  // Nullable



        public Venta(int idCliente, int idProspecto, int telSecundario, string direccion, int idLocalidad, int idProvincia,
                  string cp, DateTime fechaVenta, TimeSpan horaComienzo, TimeSpan horaFin, int codigoProd,
                  int total, string mail, int idMedioDePago, int userId, string obsSobreVenta)
        {
            IdCliente = idCliente;
            IdProspecto = idProspecto;
            TelSecundario = telSecundario;
            Direccion = direccion;
            IdLocalidad = idLocalidad;
            IdProvincia = idProvincia;
            CP = cp;
            FechaVenta = fechaVenta;
            HoraComienzo = horaComienzo;
            HoraFin = horaFin;
            CodigoProd = codigoProd;
            Total = total;
            Mail = mail;
            IdMedioDePago = idMedioDePago;
            UserId = userId;
            ObsSobreVenta = obsSobreVenta;
        }

        public Venta(int idCliente, int idProspecto, int telSecundario, string direccion, int idLocalidad, int idProvincia,
                   string cp, DateTime fechaVenta, TimeSpan horaComienzo, TimeSpan horaFin, int codigoProd,
                   int total, string mail, int idMedioDePago, int userId)
        {
            IdCliente = idCliente;
            IdProspecto = idProspecto;
            TelSecundario = telSecundario;
            Direccion = direccion;
            IdLocalidad = idLocalidad;
            IdProvincia = idProvincia;
            CP = cp;
            FechaVenta = fechaVenta;
            HoraComienzo = horaComienzo;
            HoraFin = horaFin;
            CodigoProd = codigoProd;
            Total = total;
            Mail = mail;
            IdMedioDePago = idMedioDePago;
            UserId = userId;

        }

        public Venta(int idProspecto, int telSecundario, string direccion, int idLocalidad, int idProvincia,
                   string cp, DateTime fechaVenta, TimeSpan horaComienzo, TimeSpan horaFin, int codigoProd,
                   int total, string mail, int idMedioDePago, int userId)
        {
            //IdCliente = idCliente;
            IdProspecto = idProspecto;
            TelSecundario = telSecundario;
            Direccion = direccion;
            IdLocalidad = idLocalidad;
            IdProvincia = idProvincia;
            CP = cp;
            FechaVenta = fechaVenta;
            HoraComienzo = horaComienzo;
            HoraFin = horaFin;
            CodigoProd = codigoProd;
            Total = total;
            Mail = mail;
            IdMedioDePago = idMedioDePago;
            UserId = userId;

        }


        public Venta() { }

    }

}