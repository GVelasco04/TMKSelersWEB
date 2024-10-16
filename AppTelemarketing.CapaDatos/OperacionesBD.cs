using System.Configuration;
using System.Data;
using System.Data.SqlClient;
//using AppTelemarketing.Servicios;


namespace AppTelemarketing.CapaDatos
{
    public class OperacionesBD
    {
        //se inicializan los campos a usar en los métodos
        private SqlConnection connection = null!;
        private SqlCommand command = null!;
        private SqlDataReader reader = null!;
        private DataTable data = null!;
        //readonly, para evitar la modificación accidental
        const string connectionString = "Server=sql.bsite.net\\MSSQL2016;User ID=callcenter_;Password=programacion2;Connect Timeout=30; TrustServerCertificate=True";
        //private ManejoMensajesServices manejoMensajes = new ManejoMensajesServices();

        // Es un Dictionary<string, string> que contiene los parámetros de la consulta SQL.
        // La clave del diccionario (string) representa el nombre del parámetro en la consulta SQL.
        //El valor del diccionario(string) representa el valor que se debe asignar a ese parámetro.
        public DataTable Seleccion(string SQL, Dictionary<string, string> parametros)
        // Ejemplo: new Dictionary<string, string> { { "@Edad", "18" } }
        {
            using (connection = new SqlConnection(@connectionString))
            {
                try
                {
                    connection.Open();
                    // Crear el SqlCommand
                    using (command = new SqlCommand(SQL, connection))
                    {
                        // Se verifica si el diccionario parametros no es null
                        if (parametros != null)
                        {
                            foreach (var prm in parametros)
                            {
                                command.Parameters.Add(new SqlParameter(prm.Key, prm.Value));
                            }
                        }

                        // Crear el SqlDataReader
                        using (reader = command.ExecuteReader())
                        {
                            data = new DataTable();
                            data.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                    //manejoMensajes.ManejarExcepcion(ex);
                }
            }
            return data;
        }

        public int Ejecutar(string SQLText, Dictionary<string, object> parametros)
        {
            int result = 0;
            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (command = new SqlCommand(SQLText, connection))
                    {
                        if (parametros != null)
                        {
                            foreach (var p in parametros)
                            {
                                command.Parameters.Add(new SqlParameter(p.Key, p.Value));
                            }
                        }
                        result = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.ToString());
                    // manejoMensajes.ManejarExcepcion(ex);
                }
            }
            return result;
        }
    }
 }