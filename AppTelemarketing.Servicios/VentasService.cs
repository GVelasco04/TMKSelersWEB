using AppTelemarketing.CapaDatos;
using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTelemarketing.Servicios
{
    public class VentasService
    {
        OperacionesBD operaciones = new OperacionesBD();
        //Venta venta = null!;

        ManejoMensajesServices manejoMensajesServices = new ManejoMensajesServices();

        public bool CargarVenta(Venta venta)
        {
            bool exito = false;

            string SQLInsert = @"INSERT INTO Ventas (IdProspecto, TelSecundario, Direccion, IdLocalidad, IdProvincia, CP, FechaVenta, CodigoProd, Total, Mail, IdMedioDePago, UserId, ObsSobreVenta)
                                VALUES (@IdProspecto, @TelSecundario, @Direccion, @IdLocalidad, @IdProvincia,
                            @CP, @FechaVenta, @CodigoProd, @Total, @Mail, @IdMedioDePago, @UserId, @ObsSobreVenta)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@IdProspecto", venta.IdProspecto },
                { "@TelSecundario", venta.TelSecundario },
                { "@Direccion", venta.Direccion },
                { "@IdLocalidad", venta.IdLocalidad },
                { "@IdProvincia", venta.IdProvincia },
                { "@CP", venta.CP },
                { "@FechaVenta", venta.FechaVenta },
                //{ "@HoraComienzo", venta.HoraComienzo },
                //{ "@HoraFin", venta.HoraFin },
                { "@CodigoProd", venta.CodigoProd },
                { "@Total", venta.Total },
                { "@Mail", venta.Mail },
                { "@IdMedioDePago", venta.IdMedioDePago },
                { "@UserId", venta.UserId },
                { "@ObsSobreVenta", venta.ObsSobreVenta }
            };

            try
            {
                int rowsAffected = operaciones.Ejecutar(SQLInsert, parametros);

                if (rowsAffected > 0)
                {
                    var resultado = manejoMensajesServices.ManejarResultado(true, "Se insertó correctamente el prospecto en la base de datos.");
                    exito = resultado.Exito;
                }
                else
                {
                    var resultado = manejoMensajesServices.ManejarResultado(false, "Error al insertar el prospecto en la base de datos.");
                    exito = resultado.Exito;
                }
            }
            catch (Exception ex)
            {
                var resultado = manejoMensajesServices.ManejarResultado(false, "Error al ejecutar la consulta: " + ex.Message);
            }

            return exito;
        }

        public DataTable ObtenerVentas(int userId)
        {
            string SQLSelect = @"
                SELECT 
                    v.IdCliente, 
                    v.FechaVenta, 
                    v.ObsSobreVenta,
                    p.Nombre, 
                    p.Apellido, 
                    u.UserId, 
                    m.Descripcion, 
                    prod.NombreProducto, 
                    prod.Precio
                FROM 
                    Ventas v
                INNER JOIN 
                    Prospectos p ON v.IdProspecto = p.IdProspecto
                INNER JOIN 
                    Usuarios u ON v.UserId = u.UserId
                INNER JOIN 
                    MedioDePago m ON v.IdMedioDePago = m.IdMedioDePago
                INNER JOIN 
                    Productos prod ON v.CodigoProd = prod.CodigoProd
                WHERE 
                    v.UserId = @UserId";

            Dictionary<string, string> parametros = new Dictionary<string, string>
            {
                { "@UserId", userId.ToString () }
            };

            DataTable dataTable = null!;

            try
            {
                dataTable = operaciones.Seleccion(SQLSelect, parametros);
                manejoMensajesServices.ManejarResultado(true, "Se listaron correctamente las ventas.");
            }
            catch (Exception ex)
            {
                manejoMensajesServices.ManejarExcepcion(ex);
            }

            return dataTable ?? new DataTable();
        }
        public DataTable ObtenerVentasAdmin()
        {
            string query = @"
                SELECT 
                    v.IdCliente, 
                    v.FechaVenta, 
                    v.ObsSobreVenta, 
                 
                    p.Nombre, 
                    p.Apellido, 
                    u.UserId, 
                    m.Descripcion, 
                    prod.NombreProducto, 
                    prod.Precio
                FROM 
                    Ventas v
                INNER JOIN 
                    Prospectos p ON v.IdProspecto = p.IdProspecto
                INNER JOIN 
                    Usuarios u ON v.UserId = u.UserId
                INNER JOIN 
                    MedioDePago m ON v.IdMedioDePago = m.IdMedioDePago
                INNER JOIN 
                    Productos prod ON v.CodigoProd = prod.CodigoProd
               ";

            DataTable dataTable = null!;

            try
            {
                dataTable = operaciones.Seleccion(query, null!);
                manejoMensajesServices.ManejarResultado(true, "Se listaron correctamente los agendados.");
            }
            catch (Exception ex)
            {
                manejoMensajesServices.ManejarExcepcion(ex);
            }

            return dataTable ?? new DataTable();
        }
    }
}
