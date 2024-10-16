using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using AppTelemarketing.CapaDatos;
using AppTelemarketing.Entidades;


namespace AppTelemarketing.Servicios
{
    public class UsuarioService
    {
        OperacionesBD operaciones = new OperacionesBD();
        //creamos una instancia de ManejoMensajesServices
        //en el constructor de UsuarioService para poder acceder a ResultadoAlta.

        private ManejoMensajesServices _servicioMensajes;
        ManejoMensajesServices mensajesService = new ManejoMensajesServices();
        public UsuarioService()//para que no de error de NOACAPTA NULL
        {
            _servicioMensajes = new ManejoMensajesServices();
        }


        public ManejoMensajesServices.ResultadoAlta AgregarUsuario(Usuario usuario)
        {
            var resultado = new ManejoMensajesServices.ResultadoAlta();

            // Preparar la Query
            string SQLinsert = "INSERT INTO Usuarios (UserName, Nombre, Apellido, Correo, Clave, IdTipoUsuario) " +
                               "VALUES (@UserName, @Nombre, @Apellido, @Correo, @Clave, @TipoUsuario)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
    {
        { "@UserName", usuario.UserName },
        { "@Nombre", usuario.Nombre },
        { "@Apellido", usuario.Apellido },
        { "@Correo", usuario.Correo },
        { "@Clave", usuario.Clave },
        { "@TipoUsuario", usuario.TipoUsuario }
    };

            try
            {
                int rowsAffected = operaciones.Ejecutar(SQLinsert, parametros);

                if (rowsAffected > 0)
                {
                    resultado.Exito = true;
                    resultado.MensajeExitoOError = "El Usuario se Agregó correctamente";
                }
                else
                {
                    resultado.Exito = false;
                    resultado.MensajeExitoOError = "No se pudo insertar el Usuario en la base de datos.";
                }
            }
            catch (SqlException sqlEx)
            {
                resultado.Exito = false;
                resultado.MensajeExitoOError = $"Error SQL: {sqlEx.Message} (Código: {sqlEx.Number})";

                // Log detallado
                Console.WriteLine($"Error SQL: {sqlEx.Message}");
                Console.WriteLine($"Código de Error: {sqlEx.Number}");
                Console.WriteLine($"Stack Trace: {sqlEx.StackTrace}");
            }
            catch (Exception ex)
            {
                resultado.Exito = false;
                resultado.MensajeExitoOError = $"Error: {ex.Message}";

                // Log detallado
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            }

            return resultado;
        }



        public List<TipoUsuarios> ObtenerTipoUsuarios()
        {
            //defino la lista que voy a devolver
            List<TipoUsuarios> tipoUsuarios = new List<TipoUsuarios>();

            try
            {
                string connectionString = "Server=sql.bsite.net\\MSSQL2016;User ID=callcenter_;Password=programacion2;Connect Timeout=30; TrustServerCertificate=True";
                string SQLSelect = "SELECT * FROM TipoUsuarios";

                var resultado = operaciones.Seleccion(SQLSelect, null);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                        int idTipoUsuarios = row.Field<int>("IdTipoUsuario");
                        string textoDescripcion = row.Field<string>("Descripcion");

                        TipoUsuarios tipoUsuario = new TipoUsuarios(idTipoUsuarios, textoDescripcion);
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

        public int TraerUserId(string nombreUsuario)
        {
            int usuarioId = 0;

            try
            {
                string SQLSelect = "SELECT *  FROM Usuarios WHERE UserName=@UserName";

                Dictionary<string, string> parametros = new Dictionary<string, string>
                {
                    {"@UserName", nombreUsuario}
                };
                var result = operaciones.Seleccion(SQLSelect, parametros);
                if (result != null && result.Rows.Count > 0)
                {
                    usuarioId = Convert.ToInt32(result.Rows[0]["UserId"]);
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                _servicioMensajes.ManejarExcepcion(ex);
                throw;

            }
            return usuarioId;

        }
        public List<Usuario> MostrarUsuarios()
        {
            string SQLSelect = "SELECT * FROM Usuarios WHERE IdTipoUsuario=2";
            var ListUsuarios = new List<Usuario>();

            var DataReturn = operaciones.Seleccion(SQLSelect, null);

            if (DataReturn != null && DataReturn.Rows.Count > 0)
            {
                foreach (DataRow row in DataReturn.Rows)
                {
                    // Inicializa el objeto Usuario con todos los campos necesarios
                    var usuario = new Usuario
                    (
                        row["UserId"] != DBNull.Value ? Convert.ToInt32(row["UserId"]) : 0, // UserId puede ser 0 si es NULL
                        row["UserName"].ToString(),
                        row["Nombre"].ToString(),
                        row["Apellido"].ToString(),
                        row["Correo"].ToString(),
                        row["Clave"].ToString(),
                        row["IdTipoUsuario"] != DBNull.Value ? Convert.ToInt32(row["IdTipoUsuario"]) : 0,
                        row["AceptadoXAdmin"] != DBNull.Value ? Convert.ToInt32(row["AceptadoXAdmin"]) : 0
                    );

                    ListUsuarios.Add(usuario);
                }
            }

            return ListUsuarios;
        }

        public bool EliminarUsuario(int userId)
        {
            bool Result = false;
            string SQLDelete = "DELETE FROM Usuarios WHERE UserId = @UserId";

            Dictionary<string, object> Parametros = new Dictionary<string, object>
    {
        { "@UserId", userId }
    };

            var Ejecuto = operaciones.Ejecutar(SQLDelete, Parametros);

            Result = Ejecuto > 0;
            return Result;
        }



        public Usuario AprobarUsuario(int userId)
        {
            string SQLUpdate = "UPDATE Usuarios SET AceptadoXAdmin = 1 WHERE UserId = @UserId";
            Dictionary<string, object> parametros = new Dictionary<string, object>
{
    { "@UserId", userId }
};

            int resultado = operaciones.Ejecutar(SQLUpdate, parametros);

            if (resultado > 0)
            {
                return ObtenerUsuarioPorId(userId);
            }
            return null;
        }




        public Usuario ObtenerUsuarioPorId(int userId)
        {
            Usuario usuario = null;
            string SQLSelect = "SELECT UserName, Correo, Clave, IdTipoUsuario FROM Usuarios WHERE UserId = @UserId";

            Dictionary<string, string> parametros = new Dictionary<string, string>
            {
                { "@UserId", userId.ToString() } // Convertir el entero a string
            };

            var dataReturn = operaciones.Seleccion(SQLSelect, parametros);

            if (dataReturn != null && dataReturn.Rows.Count > 0)
            {
                DataRow row = dataReturn.Rows[0];
                usuario = new Usuario

            (
                userId,
                row["UserName"].ToString(),
                string.Empty, // Nombre
                string.Empty, // Apellido
                row["Correo"].ToString(),
                row["Clave"].ToString(),
                Convert.ToInt32(row["IdTipoUsuario"]), // Aquí se toma el tipo desde la BD
                1 // AceptadoXAdmin ya está actualizado
            );


            }

            return usuario;
        }




    }


}

