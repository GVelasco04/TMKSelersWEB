using AppTelemarketing.CapaDatos;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace AppTelemarketing.Servicios
{
    public class ValidacionesService
    {
        //ValidacionesService validarMensaje = new ValidacionesService();
        private OperacionesBD operaciones = new OperacionesBD();


        public ManejoMensajesServices.ResultadoAlta ActualizarContraseña(string nombredeUsuario, string nuevaContraseña)
        {
            var resultado = new ManejoMensajesServices.ResultadoAlta();



            string SQLUpdate = "UPDATE Usuarios SET Clave = @nuevaContraseña WHERE UserName = @nombredeUsuario";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@nuevaContraseña", nuevaContraseña },
                { "@nombredeUsuario", nombredeUsuario }
            };


            try
            {
                int filasAfectadas = operaciones.Ejecutar(SQLUpdate, parametros);

                if (filasAfectadas > 0)
                {
                    resultado.Exito = true;
                    resultado.MensajeExitoOError = "La contraseña ha sido actualizada con éxito.";
                }
                else
                {
                    resultado.Exito = false;
                    resultado.MensajeExitoOError = "No se pudo actualizar la contraseña.";
                }
            }
            catch (SqlException sqlEx)
            {
                resultado.Exito = false;
                resultado.MensajeExitoOError = $"Error SQL: {sqlEx.Message}";
            }
            catch (Exception ex)
            {
                resultado.Exito = false;
                resultado.MensajeExitoOError = $"Error : {ex.Message}";
            }

            return resultado;
        }


        //PREGUNTAR AL PROFE COMO VALIDAR EL EMAIL
        public bool IsValidEmail(string email)
        {
            // Expresión regular para validar el formato de correo electrónico
            Regex expr = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            return expr.IsMatch(email);
        }

        //validacion de formato de telefono

        public Dictionary<string, object> ValidarTelefono(long telefono)
        {
            var resultado = new Dictionary<string, object>();

            // Verificamos si el número de teléfono es cero o negativo
            if (telefono <= 0)
            {
                resultado["esValido"] = false;
                resultado["mensaje"] = "El número de teléfono no puede ser cero o negativo.";
                return resultado;
            }

            // Convertimos el número de teléfono a una cadena para contar los dígitos
            string telefonoString = telefono.ToString();

            // Verificamos si el número de teléfono tiene exactamente 10 dígitos
            if (telefonoString.Length != 10)
            {
                resultado["esValido"] = false;
                resultado["mensaje"] = "El número de teléfono debe contener exactamente 10 dígitos.";
                return resultado;
            }

            // Si todas las validaciones pasan, el número de teléfono es válido
            resultado["esValido"] = true;
            resultado["mensaje"] = "El número de teléfono es válido.";

            return resultado;
        }
    }
}


        