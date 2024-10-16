using AppTelemarketing.CapaDatos;
using System;
using System.Configuration;
using System.Data;
using System.Linq;

using AppTelemarketing.CapaDatos;
using System;
using System.Configuration;
using System.Data;
using System.Linq;

namespace AppTelemarketing.Servicios
{
    public class InformesService
    {
        OperacionesBD operaciones = new OperacionesBD();
        private ManejoMensajesServices servicioMensajes = new ManejoMensajesServices();

        public DataTable ListarLlamadosProspectosAdmin()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            string SQlSelect = @"SELECT LP.CodRespuesta, R.Respuesta, COUNT(*) AS TotalLlamadas, LP.UserId
                         FROM LlamadosProspectos LP
                         INNER JOIN Respuestas R ON LP.CodRespuesta = R.CodRespuesta
                         GROUP BY LP.CodRespuesta, R.Respuesta, LP.UserId";

            DataTable resultado = new DataTable();

            try
            {
                resultado = operaciones.Seleccion(SQlSelect, null!);

                if (resultado != null)
                {
                    // Asegúrate de que la columna 'CodRespuesta' permite valores nulos
                    if (resultado.Columns.Contains("CodRespuesta") && !resultado.Columns["CodRespuesta"].AllowDBNull)
                    {
                        resultado.Columns["CodRespuesta"].AllowDBNull = true;
                    }

                    if (resultado.Rows.Count > 0)
                    {
                        int totalGeneral = resultado.AsEnumerable().Sum(row => row.Field<int>("TotalLlamadas"));

                        DataRow totalRow = resultado.NewRow();
                        totalRow["CodRespuesta"] = DBNull.Value;
                        totalRow["Respuesta"] = "Total General";
                        totalRow["TotalLlamadas"] = totalGeneral;
                        resultado.Rows.Add(totalRow);
                    }
                }
            }
            catch (Exception ex)
            {
                servicioMensajes.ManejarExcepcion(ex);
            }

            return resultado ?? new DataTable(); // Para que devuelva una tabla aunque esté vacía
        }
        public DataTable ListarLlamadosProspectos(int userId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            string SQlSelect = @"
                    SELECT LP.CodRespuesta, R.Respuesta, COUNT(*) AS TotalLlamadas
                    FROM LlamadosProspectos LP
                    INNER JOIN Respuestas R ON LP.CodRespuesta = R.CodRespuesta
                    WHERE LP.UserId = @UserId
                    GROUP BY LP.CodRespuesta, R.Respuesta";

            DataTable resultado = new DataTable();
            Dictionary<string, string> parametros = new Dictionary<string, string>
            {
                { "@UserId", userId.ToString() }
            };

            try
            {
                resultado = operaciones.Seleccion(SQlSelect, parametros);

                // Asegúrate de que la columna 'CodRespuesta' permite valores nulos
                if (!resultado.Columns["CodRespuesta"].AllowDBNull)
                {
                    resultado.Columns["CodRespuesta"].AllowDBNull = true;
                }

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    int totalGeneral = resultado.AsEnumerable().Sum(row => row.Field<int>("TotalLlamadas"));

                    DataRow totalRow = resultado.NewRow();
                    totalRow["CodRespuesta"] = DBNull.Value;
                    totalRow["Respuesta"] = "Total General";
                    totalRow["TotalLlamadas"] = totalGeneral;
                    resultado.Rows.Add(totalRow);
                }
            }
            catch (Exception ex)
            {
                servicioMensajes.ManejarExcepcion(ex);
                Console.WriteLine(ex.Message); // Agrega esto para ver el mensaje de error
            }

            return resultado ?? new DataTable();
        }

    }
}




// List<MostrarLlamadas> listaLlamadas = new List<MostrarLlamadas>();

/*try
{

    DataTable resultado = operaciones.Seleccion(SQlSelect,null!);

    if (resultado != null && resultado.Rows.Count > 0)
    {
        int totalgral = 0;

        foreach (DataRow row in resultado.Rows)
        {
            totalgral += Convert.ToInt32(row["TotalLlamadas"]);

            MostrarLlamadas mostrarLlamadas_ = new MostrarLlamadas()
            {
                idRespuesta = Convert.ToInt32(row["CodRespuesta"]),
                Respuesta = row["Respuesta"]?.ToString() ?? string.Empty,
                totales = Convert.ToInt32(row["TotalLlamadas"]),
                totalGral = totalgral
            };

            listaLlamadas.Add(mostrarLlamadas_);
        }
    }
}
catch (Exception ex)
{
    servicioMensajes.ManejarExcepcion(ex);
}

return listaLlamadas;
}*/

