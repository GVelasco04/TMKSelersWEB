using AppTelemarketing.CapaDatos;
using AppTelemarketing.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTelemarketing.Servicios
{
    public class MedioDePagoService
    {
        OperacionesBD operaciones = new OperacionesBD();
        ManejoMensajesServices mensajesService = new ManejoMensajesServices();

        public List<MediosDePago> ObtenerMedioDePagos()
        {
            //defino la lista que voy a devolver
            List<MediosDePago> mediosDePagos = new List<MediosDePago>();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
                string SQLSelect = "SELECT * FROM MedioDePago";

                var resultado = operaciones.Seleccion(SQLSelect, null);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                        short idMedioPago = row.Field<short>("IdMedioDePago");
                        string textoDescripcion = row.Field<string>("Descripcion");

                       MediosDePago medioDePago = new MediosDePago(idMedioPago, textoDescripcion);
                       mediosDePagos.Add(medioDePago);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                mensajesService.ManejarExcepcion(ex);

                throw;
            }

            return mediosDePagos;// devuelve la lista
        }

    }
}
