using AppTelemarketing.CapaDatos;
using System.Configuration;


namespace AppTelemarketing.Servicios
{

    public class SecurityService
    {
        OperacionesBD operaciones = new OperacionesBD();

        public bool UsuarioValido(string username, string clave, int tipoUsuario)
        {
            bool valido = false;
            //asumimos que el usuario no es válido hasta que se demuestre lo contrario.
            string ConnectionString = "Server=sql.bsite.net\\MSSQL2016;User ID=callcenter_;Password=programacion2;Connect Timeout=30; TrustServerCertificate=True";
            string SQLSelect = "SELECT * FROM Usuarios WHERE UserName=@username AND Clave=@clave AND IdTipoUsuario=@tipoUsuario";

            // Crear un diccionario para los parámetros
            var parametros = new Dictionary<string, string>
            {
                { "@username", username },
                { "@clave", clave },
                { "@tipoUsuario", tipoUsuario.ToString() }
            };

            try
            {
                var resultado = operaciones.Seleccion(SQLSelect, parametros);
                //Si resultado contiene datos(al menos una fila), se establece valido como true.
                if (resultado != null && resultado.Rows.Count > 0)
                {
                    // Si encontramos al menos una fila, el usuario es válido
                    valido = true;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al acceder a la base de datos.", ex);
            }

            return valido;
        }
        // Sobrecarga del método para solo usuario y clave (utilizada en FrmCambiarContrasena)
        public bool UsuarioValido(string username, string clave)
        {
            bool valido = false;
            string ConnectionString = "Server=sql.bsite.net\\MSSQL2016;User ID=callcenter_;Password=programacion2;Connect Timeout=30; TrustServerCertificate=True";
            string SQLSelect = "SELECT * FROM Usuarios WHERE UserName=@username AND Clave=@clave";

            var parametros = new Dictionary<string, string>
        {
            { "@username", username },
            { "@clave", clave }
        };

            try
            {
                var resultado = operaciones.Seleccion(SQLSelect, parametros);
                if (resultado != null && resultado.Rows.Count > 0)
                {
                    valido = true;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al acceder a la base de datos.", ex);
            }

            return valido;
        }
    }
}
