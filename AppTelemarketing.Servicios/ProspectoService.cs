using AppTelemarketing.CapaDatos;
using AppTelemarketing.Entidades;
using System.Data;

namespace AppTelemarketing.Servicios
{//servicios para manejar todo lo referente a los prospectos (baja, alta, modificacion y listado)
    public class ProspectoService
    {
        OperacionesBD operaciones = new OperacionesBD();

        ManejoMensajesServices manejoMensajesServices = new ManejoMensajesServices();
        // Clase para devolver los resultados de la carga de prospectos
        public class CargarProspectosResultado
        {
            public int ContSi { get; set; }
            public int ContNo { get; set; }
        }

        public Prospecto ObtenerSiguienteProspectoNoLlamado(int idProspecto)
        {
            string SQLSelect = string.Empty;
            Prospecto prospecto = null!;
            if (idProspecto == 0)
            {
                // Consulta SQL para obtener el siguiente prospecto con Llamado = false
                SQLSelect = "SELECT TOP 1 * FROM Prospectos WHERE Llamado = 0";
            }
            else
            {
                SQLSelect = "SELECT * FROM Prospectos WHERE IdProspecto=@IdProspecto";
            }
            Dictionary<string, string> parametros = new Dictionary<string, string>
            {
                { "@IdProspecto", idProspecto.ToString() }
            };
            var result = operaciones.Seleccion(SQLSelect, parametros) as DataTable;

            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                prospecto = new Prospecto(
                    Convert.ToInt32(row["IdProspecto"]),
                    (long)(row["TelefonoPrincipal"] != DBNull.Value ? Convert.ToInt64(row["TelefonoPrincipal"]) : (long?)null),
                    row["Apellido"].ToString(),
                    row["Nombre"].ToString(),
                    row["Llamado"] != DBNull.Value ? Convert.ToBoolean(row["Llamado"]) : (bool?)null,
                    row["Venta"] != DBNull.Value ? Convert.ToBoolean(row["Venta"]) : (bool?)null,
                    row["ObsProspecto"].ToString()
                );
            }

            return prospecto;
        }

        // Método para verificar si un prospecto ya existe basado en el teléfono principal
        public bool ExisteProspecto(long telefonoPrincipal)
        {
            string SQLSelect = "SELECT COUNT(*) FROM Prospectos WHERE TelefonoPrincipal = @TelefonoPrincipal";
            Dictionary<string, string> parametros = new Dictionary<string, string>
            {
                { "@TelefonoPrincipal", telefonoPrincipal.ToString() }
            };

            try
            {
                var result = operaciones.Seleccion(SQLSelect, parametros);
                if (result != null && result is DataTable dataTable)
                {
                    return Convert.ToInt32(dataTable.Rows[0][0]) > 0;
                }
            }
            catch (Exception ex)
            {
                manejoMensajesServices.ManejarResultado(false, "Error al verificar la existencia del prospecto: " + ex.Message);
            }

            return false;
        }

        // DAR DE ALTA UN PROSPECTO
        public bool CargarProspectoNuevo(Prospecto prospecto)
        {
            // Verificar si el prospecto ya existe
            if (ExisteProspecto(prospecto.TelefonoPrincipal))
            {
                manejoMensajesServices.ManejarResultado(false, "El prospecto con el teléfono " + prospecto.TelefonoPrincipal + " ya existe.");
                return false;
            }

            bool exito = false;

            string SQLInsert = "INSERT INTO Prospectos (TelefonoPrincipal, Apellido, Nombre, Llamado, Venta, ObsProspecto) " +
                               "VALUES (@TelefonoPrincipal, @Apellido, @Nombre, @Llamado, @Venta, @ObsProspecto)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@TelefonoPrincipal", prospecto.TelefonoPrincipal.ToString() ?? string.Empty },
                { "@Apellido", prospecto.Apellido },
                { "@Nombre", prospecto.Nombre },
                { "@Llamado", "0" },
                { "@Venta", "0" },
                { "@ObsProspecto", string.IsNullOrEmpty(prospecto.ObsProspecto) ? DBNull.Value.ToString() : prospecto.ObsProspecto }
            };

            try
            {
                int rowsAffected = operaciones.Ejecutar(SQLInsert, parametros);

                if (rowsAffected > 0)
                {
                    var resultado = manejoMensajesServices.ManejarResultado(true, "Se insertó correctamente el prospecto en la base de datos.");
                    exito = resultado.Exito;
                }
                else
                {
                    var resultado = manejoMensajesServices.ManejarResultado(false, "Error al insertar el prospecto en la base de datos.");
                    exito = resultado.Exito;
                }
            }
            catch (Exception ex)
            {
                manejoMensajesServices.ManejarResultado(false, "Error al ejecutar la consulta: " + ex.Message);
            }

            return exito;
        }

        public Prospecto TraerIdProspecto(long telefono)
        {
            Prospecto prospecto = null!;
            string SQLSelect = "SELECT * FROM Prospectos WHERE TelefonoPrincipal=@TelefonoPrincipal";
            Dictionary<string, string> parametros = new Dictionary<string, string>
            {
                { "@TelefonoPrincipal", telefono.ToString() }
            };
            var result = operaciones.Seleccion(SQLSelect, parametros) as DataTable;

            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                prospecto = new Prospecto(
                Convert.ToInt32(row["IdProspecto"]),
                (long)(row["TelefonoPrincipal"] != DBNull.Value ? Convert.ToInt64(row["TelefonoPrincipal"]) : (long?)null),
                row["Apellido"].ToString(),
                row["Nombre"].ToString(),
                row["Llamado"] != DBNull.Value ? Convert.ToBoolean(row["Llamado"]) : (bool?)null,
                row["Venta"] != DBNull.Value ? Convert.ToBoolean(row["Venta"]) : (bool?)null,
                row["ObsProspecto"].ToString()
                );
            }

            return prospecto;
        }
        //listar prospectos
        public IList<Prospecto> ObtenerProspectosOrdenados(string sortOrder)
        {
            string SQLSelect = "SELECT * FROM Prospectos";

            if (sortOrder == "desc")
            {
                SQLSelect += " ORDER BY IdProspecto DESC";
            }
            else // asc
            {
                SQLSelect += " ORDER BY IdProspecto ASC";
            }

            var result = operaciones.Seleccion(SQLSelect, new Dictionary<string, string>()) as DataTable;

            IList<Prospecto> prospectos = new List<Prospecto>();
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    var prospecto = new Prospecto(
                        Convert.ToInt32(row["IdProspecto"]),
                        (long)(row["TelefonoPrincipal"] != DBNull.Value ? Convert.ToInt64(row["TelefonoPrincipal"]) : (long?)null),
                        row["Apellido"].ToString(),
                        row["Nombre"].ToString(),
                        row["Llamado"] != DBNull.Value ? Convert.ToBoolean(row["Llamado"]) : (bool?)null,
                        row["Venta"] != DBNull.Value ? Convert.ToBoolean(row["Venta"]) : (bool?)null,
                        row["ObsProspecto"].ToString()
                    );
                    prospectos.Add(prospecto);
                }
            }
            return prospectos;
        }

        public CargarProspectosResultado CargarProspectosDesdeArchivo(string rutaArchivo)
        {
            int contSi = 0;
            int contNo = 0;
            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        if (datos.Length == 3)
                        {
                            long telefonoPrincipal = Convert.ToInt64(datos[0]);

                            // Verificar si el prospecto ya existe antes de cargarlo
                            if (ExisteProspecto(telefonoPrincipal))
                            {
                                manejoMensajesServices.ManejarResultado(false, "El prospecto con el teléfono " + telefonoPrincipal + " ya existe.");
                                contNo++;
                                continue; // Saltar a la siguiente línea
                            }

                            Prospecto prospecto = new Prospecto
                            {
                                TelefonoPrincipal = telefonoPrincipal,
                                Apellido = datos[1],
                                Nombre = datos[2],
                                Llamado = false,
                                Venta = false,
                                ObsProspecto = string.Empty
                            };
                            bool exito = CargarProspectoNuevo(prospecto);

                            if (exito) { contSi++; }
                            else { contNo++; }
                        }
                    }
                }
                manejoMensajesServices.ManejarResultado(true, "Prospectos cargados correctamente desde el archivo.");
            }
            catch (Exception ex)
            {
                manejoMensajesServices.ManejarResultado(false, "Error al cargar prospectos desde el archivo: " + ex.Message);
            }
            return new CargarProspectosResultado { ContSi = contSi, ContNo = contNo };
        }
        public List<Prospecto> ProspectoNoLlamado(int idProspecto)
        {
            string SQLSelect = string.Empty;
            List<Prospecto> prospectos = new List<Prospecto>();

            if (idProspecto == 0)
            {
                // Consulta SQL para obtener el siguiente prospecto con Llamado = false
                SQLSelect = "SELECT TOP 1 * FROM Prospectos WHERE Llamado = 0";
            }
            else
            {
                SQLSelect = "SELECT * FROM Prospectos WHERE IdProspecto=@IdProspecto";
            }

            Dictionary<string, string> parametros = new Dictionary<string, string>
    {
        { "@IdProspecto", idProspecto.ToString() }
    };

            var result = operaciones.Seleccion(SQLSelect, parametros) as DataTable;

            if (result != null && result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    var prospecto = new Prospecto(
                        Convert.ToInt32(row["IdProspecto"]),
                        (long)(row["TelefonoPrincipal"] != DBNull.Value ? Convert.ToInt64(row["TelefonoPrincipal"]) : (long?)null),
                        row["Apellido"].ToString(),
                        row["Nombre"].ToString(),
                        row["Llamado"] != DBNull.Value ? Convert.ToBoolean(row["Llamado"]) : (bool?)null,
                        row["Venta"] != DBNull.Value ? Convert.ToBoolean(row["Venta"]) : (bool?)null,
                        row["ObsProspecto"].ToString()
                    );
                    prospectos.Add(prospecto);
                }
            }

            return prospectos;
        }
    }
}
