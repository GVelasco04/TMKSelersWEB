using AppTelemarketing.CapaDatos;
using AppTelemarketing.Entidades;
using System.Data;


namespace AppTelemarketing.Servicios
{

    public class FileServices
    {
        OperacionesBD operaciones = new OperacionesBD();
        public bool CargarNombreArchivoBBDD(string nombreArchivo)
        {
            // Verificar si el archivo ya existe en la base de datos
            if (ExisteArchivoBBDD(nombreArchivo))
            {
                return false; // El archivo ya existe, no se carga nuevamente
            }

            string SQLInsert = "INSERT INTO ArchivosBBDD (NombreArchivo, FechaCarga) VALUES (@NombreArchivo, @FechaCarga)";
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@NombreArchivo", nombreArchivo },
                { "@FechaCarga", DateTime.Now }
            };

            try
            {
                int rowsAffected = operaciones.Ejecutar(SQLInsert, parametros);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool ExisteArchivoBBDD(string nombreArchivo)
        {
            string SQLSelect = "SELECT COUNT(*) FROM ArchivosBBDD WHERE NombreArchivo = @NombreArchivo";
            Dictionary<string, string> parametros = new Dictionary<string, string>
            {
                { "@NombreArchivo", nombreArchivo }
            };

            try
            {
                var result = operaciones.Seleccion(SQLSelect, parametros) as DataTable;

                if (result != null && result.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(result.Rows[0][0]);
                    return count > 0;
                }

                return false;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public List<ArchivosBBDD> ObtenerDatosArchivosBBDD()
        {
            string SQLSelect = "SELECT * FROM ArchivosBBDD";

            var result = operaciones.Seleccion(SQLSelect, null) as DataTable;

            List<ArchivosBBDD> archivos = new List<ArchivosBBDD>();
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    archivos.Add(new ArchivosBBDD
                    {
                        //IdArchivo = Convert.ToInt32(row["IdArchivo"]),
                        NombreArchivo = row["NombreArchivo"].ToString(),
                        FechaCarga = Convert.ToDateTime(row["FechaCarga"])
                    });
                }
            }

            return archivos;
        }

    }
}
