using AppTelemarketing.CapaDatos;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AppTelemarketing.Servicios

{
    public class GestionDeLlamadosService
    {
        OperacionesBD operaciones = new OperacionesBD();
        ManejoMensajesServices servicioMensajes = new ManejoMensajesServices();

        //modificar los campos Llamado y Venta cuando tocamos Aceptar
        // Implementar el procedimiento para marcar los campos LLAMADO y VENTA
        public void MarcarLlamadoYVenta(int prospectoActual, int tipoRespuesta)
        {
            string SQLUpdate = "UPDATE Prospectos SET Llamado = 1 WHERE IdProspecto = @IdProspecto";

            //creo el diccionario
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@IdProspecto", prospectoActual }
            };

            try
            {
                int rowsAffected = operaciones.Ejecutar(SQLUpdate, parametros);
                if (rowsAffected > 0)
                {
                    var resultado = servicioMensajes.ManejarResultado(true, "Se actualizó el campo Llamado correctamente.");
                }
                else
                {
                    var resultado = servicioMensajes.ManejarResultado(false, "No se encontró el prospecto especificado.");
                }

                // Si tipoRespuesta es 4, también actualizar Venta
                if (tipoRespuesta == 4)
                {
                    string SQLUpdateVenta = "UPDATE Prospectos SET Venta = 1 WHERE IdProspecto = @IdProspecto";

                    int rowsAffectedVenta = operaciones.Ejecutar(SQLUpdateVenta, parametros);

                    if (rowsAffectedVenta > 0)
                    {
                        var resultado = servicioMensajes.ManejarResultado(true, "Se actualizó el campo Venta correctamente.");
                    }
                    else
                    {
                        var resultado = servicioMensajes.ManejarResultado(false, "No se encontró el prospecto para actualizar el campo Venta.");
                    }
                }
            }
            catch (Exception ex)
            {
                var resultado = servicioMensajes.ManejarExcepcion(ex);
            }
        }



        //Aca vamos a llenar la BBDD LlamadosProspectos
        public void LlenarLlamadosProspectos(int idProspectoActual, int Respuesta, DateTime fechaBotonAceptar, DateTime horaBotonAceptar, string Observaciones, int UserId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            string SQLInsert = @"
            INSERT INTO LlamadosProspectos (IdProspecto, CodRespuesta, Fecha, HoraInicio, HoraFin, Observacion, UserId) 
            VALUES (@IdProspecto, @CodRespuesta, @Fecha, @HoraInicio, @HoraFin, @Observacion, @UserId)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@IdProspecto", idProspectoActual },
                { "@CodRespuesta", Respuesta },
                { "@Fecha", fechaBotonAceptar.ToString("yyyy-MM-dd") },
                { "@HoraInicio", horaBotonAceptar.ToString("HH:mm:ss") },
                { "@HoraFin", DateTime.Now.ToString("HH:mm:ss") }, // Ajustado para convertir la hora actual a string
                { "@Observacion", Observaciones },
                { "@UserId", UserId }
            };

            try
            {
                // Se ejecuta la consulta de inserción
                int rowsAffected = operaciones.Ejecutar(SQLInsert, parametros);
                if (rowsAffected > 0)
                {
                    //Se maneja el resultado usando ManejoMensajesServices
                    var resultado = servicioMensajes.ManejarResultado(true, "Se insertó correctamente el registro en la tabla LlamadosProspectos.");
                }
                else
                {
                    //Se maneja el resultado usando ManejoMensajesServices
                    var resultado = servicioMensajes.ManejarResultado(false, "Error al insertar el registro en la tabla LlamadosProspectos.");
                }
            }
            catch (Exception ex)
            {
                // Se maneja la excepción utilizando ManejoMensajesServices
                var resultado = servicioMensajes.ManejarExcepcion(ex);
            }
        }


        //llenar la tabla Agendados 
        public void LlenarAgendados(int idProspectoActual, DateTime fechaAgenda, TimeSpan horaAgenda, string obsProspecto, int userId)
        {


            // Consulta SQL para insertar un nuevo registro en la tabla Agendados
            string SQLInsert = "INSERT INTO Agendados (IdProspecto, FechaAgenda, HoraAgenda, ObsProspecto, UserId) VALUES (@IdProspecto, @FechaAgenda, @HoraAgenda, @ObsProspecto,@UserId)";

            // Asignar los valores de los parámetros creando un diccionario
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@IdProspecto", idProspectoActual.ToString() },
                { "@FechaAgenda", fechaAgenda.ToString("yyyy-MM-dd") },
                { "@HoraAgenda", horaAgenda.ToString() },
                { "@ObsProspecto", obsProspecto },
                { "@UserId",userId }
            };

            try
            {

                // Ejecutar la consulta de inserción
                int rowsAffected = operaciones.Ejecutar(SQLInsert, parametros);
                if (rowsAffected > 0)
                {
                    // Manejo del resultado usando ManejoMensajesServices
                    var resultado = servicioMensajes.ManejarResultado(true, "Se insertó correctamente el registro en la tabla Agendados.");
                }
                else
                {
                    // Manejo del resultado usando ManejoMensajesServices
                    var resultado = servicioMensajes.ManejarResultado(false, "Error al insertar el registro en la tabla Agendados.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepción utilizando ManejoMensajesServices
                var resultado = servicioMensajes.ManejarExcepcion(ex);
            }
        }


        public DataTable ListarLosLlamadosAdmin()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            string query = @"SELECT P.Apellido, P.Nombre, P.TelefonoPrincipal, R.Respuesta AS Respuestas, LP.Fecha, LP.Observacion, LP.CodRespuesta, LP.UserId
                             FROM Prospectos P
                             INNER JOIN LlamadosProspectos LP ON P.IdProspecto = LP.IdProspecto
                             INNER JOIN Respuestas R ON LP.CodRespuesta = R.CodRespuesta";

            DataTable dataTable = new DataTable();

            try
            {
                dataTable = operaciones.Seleccion(query, null);
                servicioMensajes.ManejarResultado(true, "Se listaron correctamente los llamados.");
            }
            catch (Exception ex)
            {
                servicioMensajes.ManejarExcepcion(ex);
                // En caso de error, retornamos un DataTable vacío para evitar referencia nula
                return new DataTable();
            }

            return dataTable;
        }
        public DataTable ListarLosLlamados(int userId)
        {
            // Consulta SQL ajustada para incluir el filtro por UserId
            string SQLSelect = @"
            SELECT 
                
                P.Apellido, 
                P.Nombre, 
                P.TelefonoPrincipal, 
                R.Respuesta AS Respuestas, 
                LP.Fecha, 
                LP.Observacion, 
                LP.CodRespuesta
            FROM 
                Prospectos P
            INNER JOIN 
                LlamadosProspectos LP ON P.IdProspecto = LP.IdProspecto
            INNER JOIN 
                Respuestas R ON LP.CodRespuesta = R.CodRespuesta
            WHERE 
                (@UserId = 0 OR LP.UserId = @UserId)"; // Filtro por UserId si no es 0

            DataTable dataTable = new DataTable();
            try
            {

                Dictionary<string, string> parametros = new Dictionary<string, string>
                {
                 { "@UserId", userId.ToString() }
                };

                dataTable = operaciones.Seleccion(SQLSelect, parametros);

                // Verificamos si el DataTable está vacío
                if (dataTable.Rows.Count == 0)
                {
                    servicioMensajes.ManejarResultado(false, "No se encontraron registros para el UserId especificado.");
                }
                else
                {
                    servicioMensajes.ManejarResultado(true, "Se listaron correctamente los llamados.");
                }
            }
            catch (Exception ex)
            {
                servicioMensajes.ManejarExcepcion(ex);
                // En caso de error, retornamos un DataTable vacío para evitar referencia nula
                return new DataTable();
            }
            return dataTable; //aca tambien puede ir un datatable vacio
        }



        //Consultar Agendados
        public DataTable ListarAgendadosAdmin()
        {


            string query = @"SELECT P.IdProspecto, P.Nombre, P.Apellido, P.TelefonoPrincipal, A.FechaAgenda, A.HoraAgenda, A.ObsProspecto, A.UserId
                            FROM Prospectos P
                            INNER JOIN Agendados A ON P.IdProspecto = A.IdProspecto";

            DataTable dataTable = null!;

            try
            {
                dataTable = operaciones.Seleccion(query, null!);
                servicioMensajes.ManejarResultado(true, "Se listaron correctamente los agendados.");
            }
            catch (Exception ex)
            {
                servicioMensajes.ManejarExcepcion(ex);
            }

            return dataTable ?? new DataTable();// nos aseguramos que devuelva un DataTable auque este vacio
        }

        //control de listar agendados por ususario logueado
        public DataTable ObtenerAgendadosPorUsuario(int userId, string sortOrder)
        {
            try
            {
                DataTable agendados = ListarAgendados(userId, sortOrder);
                if (agendados.Rows.Count == 0)
                {
                    servicioMensajes.ManejarResultado(false, "No se encontraron agendados para el usuario especificado.");
                }
                return agendados;
            }
            catch (Exception ex)
            {
                servicioMensajes.ManejarExcepcion(ex);
                return new DataTable(); // Retornar un DataTable vacío en caso de error
            }
        }



        //Consultar Agendados
        public DataTable ListarAgendados(int userId, string sortOrder)
        {
            string SQLSelect = @"
        SELECT 
            P.IdProspecto, 
            P.Nombre, 
            P.Apellido, 
            P.TelefonoPrincipal, 
            A.FechaAgenda, 
            A.HoraAgenda, 
            A.ObsProspecto
        FROM 
            Prospectos P
        INNER JOIN 
            Agendados A ON P.IdProspecto = A.IdProspecto
        WHERE 
            A.UserId = @UserId";

            // Añadir ordenamiento
            if (sortOrder == "asc")
            {
                SQLSelect += " ORDER BY A.FechaAgenda ASC";
            }
            else if (sortOrder == "desc")
            {
                SQLSelect += " ORDER BY A.FechaAgenda DESC";
            }

            DataTable dataTable = new DataTable();

            try
            {
                Dictionary<string, string> parametros = new Dictionary<string, string>
                {
                    { "@UserId", userId.ToString() }
                };

                dataTable = operaciones.Seleccion(SQLSelect, parametros);
                servicioMensajes.ManejarResultado(true, "Se listaron correctamente los agendados.");
            }
            catch (Exception ex)
            {
                servicioMensajes.ManejarExcepcion(ex);
            }

            return dataTable ?? new DataTable();
        }

        public void EliminarAgendado(int idProspecto)
        {
            string SQLDelete = "DELETE FROM Agendados WHERE IdProspecto = @IdProspecto";
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@IdProspecto", idProspecto.ToString() }
            };
            operaciones.Ejecutar(SQLDelete, parametros);
        }

    }
}
