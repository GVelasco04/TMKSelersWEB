using AppTelemarketing.CapaDatos;
using AppTelemarketing.Entidades;
using System.Configuration;
using System.Data;

namespace AppTelemarketing.Servicios
{
    public class RespuestasService
    {
        OperacionesBD operaciones = new OperacionesBD();
        ManejoMensajesServices mensajesService = new ManejoMensajesServices();
     

        public List<Respuestas> ObtenerRespuestas()
        {
            //defino la lista que voy a devolver
            List<Respuestas> respuestas = new List<Respuestas>();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
                string SQLSelect = "SELECT * FROM Respuestas";

                var resultado = operaciones.Seleccion(SQLSelect, null);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                        int codRespuesta = row.Field<int>("CodRespuesta");
                        string textoRespuesta = row.Field<string>("Respuesta");

                        Respuestas respuesta = new Respuestas(codRespuesta, textoRespuesta);
                        respuestas.Add(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                mensajesService.ManejarExcepcion(ex);

                throw;
            }

            return respuestas;// devuelve la lista
        }


        //devolver listado de solo los codigos de respuesta
        public List<int> ObtenerCodigoRespuestas()
        {
            List<int> codigosRespuestas = new List<int>();


            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
                string SQLSelect = "SELECT CodRespuesta FROM Respuestas";

                var resultado = operaciones.Seleccion(SQLSelect, null);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                        int codRespuesta = row.Field<int>("CodRespuesta");
                        codigosRespuestas.Add(codRespuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                mensajesService.ManejarExcepcion(ex);
                throw;
            }

            return codigosRespuestas;
        }

        public bool CargarRespuestaNueva(Respuestas respuesta)
        {
            bool exito = false;

            string SQLInsert = "INSERT INTO Respuestas (Respuesta) " +
                               "VALUES (@Respuesta)";

            // cargo los parametros del diccionario
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@Respuesta", respuesta.Respuesta },
                
            };

            try
            {
                int rowsAffected = operaciones.Ejecutar(SQLInsert, parametros);

                if (rowsAffected > 0)
                {
                    var resultado = mensajesService.ManejarResultado(true, "Se insertó correctamente el prospecto en la base de datos.");
                    exito = resultado.Exito;
                }
                else
                {
                    var resultado = mensajesService.ManejarResultado(false, "Error al insertar el prospecto en la base de datos.");
                    exito = resultado.Exito;
                }
            }
            catch (Exception ex)
            {
                var resultado = mensajesService.ManejarResultado(false, "Error al ejecutar la consulta: " + ex.Message);
                //Console.WriteLine(resultado.MensajeExitoOError);
            }

            return exito;
        }
      

        public DataTable ListarTiposRespuestas()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            string SQlSelect = @"SELECT * FROM Respuestas";

            DataTable resultado = new DataTable();

            try
            {
                resultado = operaciones.Seleccion(SQlSelect, null!);

                // Verificar si la columna 'CodRespuesta' permite DBNull.Value
                if (!resultado.Columns["CodRespuesta"].AllowDBNull)
                {
                    // Si la columna no permite valores nulos, cambiar la propiedad AllowDBNull
                    resultado.Columns["CodRespuesta"].AllowDBNull = true;
                }

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    DataRow totalRow = resultado.NewRow();
                    totalRow["CodRespuesta"] = DBNull.Value;
                    //totalRow["Respuesta"] = "Respuesta";
                    resultado.Rows.Add(totalRow);
                }
            }
            catch (Exception ex)
            {
                mensajesService.ManejarExcepcion(ex);
            }

            return resultado ?? new DataTable(); // Para que devuelva una tabla aunque esté vacía
        }

        public void EliminarRespuesta(int codRespuesta)
        {
            string SQLDelete = "DELETE FROM Respuestas WHERE CodRespuesta = @CodRespuesta";
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@CodRespuesta", codRespuesta.ToString() }
            };
            operaciones.Ejecutar(SQLDelete, parametros);
        }

        public List<Usuario> ObtenerTelemarketer()
        {
            //defino la lista que voy a devolver
            List<Usuario> tipoUsuarios = new List<Usuario>();

            try
            {
               
                string SQLSelect = @"SELECT * FROM Usuarios WHERE IdTipoUsuario=2";

                var resultado = operaciones.Seleccion(SQLSelect, null);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                        int userId = row.Field<int>("UserId");
                        string textoUserName = row.Field<string>("UserName");

                        Usuario tipoUsuario = new Usuario(userId, textoUserName);
                        tipoUsuarios.Add(tipoUsuario);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                mensajesService.ManejarExcepcion(ex);

                throw;
            }

            return tipoUsuarios;// devuelve la lista
        }

       /* public List<Usuario> ObtenerAprobacion()
        {
            // Defino la lista que voy a devolver
            List<Usuario> valoresAceptadoXAdmin = new List<Usuario>();

            try
            {
                string SQLSelect = @"SELECT DISTINCT AceptadoXAdmin FROM Usuarios";
                var resultado = operaciones.Seleccion(SQLSelect, null);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                      
                        short aceptadoXAdmin = row.Field<short>("AceptadoXAdmin");
                        Usuario valoresAceptadoXAdmi = new Usuario( aceptadoXAdmin);
                        valoresAceptadoXAdmin.Add(valoresAceptadoXAdmi);
                       
                    }
                }
            }
            catch (Exception ex)
            {
                mensajesService.ManejarExcepcion(ex);
                throw;
            }

            return valoresAceptadoXAdmin;
        }*/
       public List<short> ObtenerAprobacion()
{
    List<short> valoresAceptadoXAdmin = new List<short>();

    try
    {
        string SQLSelect = @"SELECT DISTINCT AceptadoXAdmin FROM Usuarios";
        var resultado = operaciones.Seleccion(SQLSelect, null);

        if (resultado != null && resultado.Rows.Count > 0)
        {
            foreach (DataRow row in resultado.Rows)
            {
                short aceptadoXAdmin = row.Field<short>("AceptadoXAdmin");
                valoresAceptadoXAdmin.Add(aceptadoXAdmin);
            }
        }
    }
    catch (Exception ex)
    {
        mensajesService.ManejarExcepcion(ex);
        throw;
    }

    return valoresAceptadoXAdmin;
}

    }
}
