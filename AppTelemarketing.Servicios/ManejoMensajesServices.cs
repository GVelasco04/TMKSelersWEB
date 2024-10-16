namespace AppTelemarketing.Servicios
{
    public class ManejoMensajesServices
    {
        public class ResultadoAlta
        {
            public bool Exito { get; set; }
            public string MensajeExitoOError { get; set; }

            public ResultadoAlta()
            {
                MensajeExitoOError = "";
            }
        }
        public ResultadoAlta ManejarExcepcion(Exception ex)
        {
            // Aquí puedes personalizar cómo deseas manejar la excepción
            return new ResultadoAlta
            {
                Exito = false,
                MensajeExitoOError = "Ocurrió un error: " + ex.Message
            };
        }
        public ResultadoAlta ManejarResultado(bool exito, string mensaje)
        {
            return new ResultadoAlta
            {
                Exito = exito,
                MensajeExitoOError = mensaje
            };
        }

        public String MensajeError()
        {
            String mensajeDeError = "Error - Verifique datos";
            return mensajeDeError;
        }

     }
}   
