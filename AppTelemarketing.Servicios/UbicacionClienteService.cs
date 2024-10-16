using AppTelemarketing.CapaDatos;
using AppTelemarketing.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTelemarketing.Servicios
{
    public class UbicacionClienteService
    {
        OperacionesBD operaciones = new OperacionesBD();
        ManejoMensajesServices mensajesService = new ManejoMensajesServices();

        public List<Localidades> ObtenerLocalidad()
        {
            //defino la lista que voy a devolver
            List<Localidades> localidades = new List<Localidades>();

            try
            {

                string SQLSelect = "SELECT * FROM Localidades";

                var resultado = operaciones.Seleccion(SQLSelect, null);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                        int idLocalidad = row.Field<int>("IdLocalidad");
                        string textoLocalidad = row.Field<string>("Localidad");
                        int codigoPostal = row.Field<int>("CodPostal");

                        Localidades localidad = new Localidades(idLocalidad, textoLocalidad, codigoPostal);
                        localidades.Add(localidad);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                mensajesService.ManejarExcepcion(ex);

                throw;
            }

            return localidades;// devuelve la lista
        }

        public List<Provincias> ObtenerProvincias()
        {
            //defino la lista que voy a devolver
            List<Provincias> provincias = new List<Provincias>();

            try
            {

                string SQLSelect = "SELECT * FROM Provincias";

                var resultado = operaciones.Seleccion(SQLSelect, null);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                        int idProvincia = row.Field<int>("IdProvincia");
                        string textoProvincia = row.Field<string>("Provincia");

                        Provincias provincia = new Provincias(idProvincia, textoProvincia);
                        provincias.Add(provincia);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                mensajesService.ManejarExcepcion(ex);

                throw;
            }

            return provincias;// devuelve la lista
        }

        public List<Localidades> ObtenerLocalidadesPorProvincia(int idProvincia)
        {
            // Defino la lista que voy a devolver
            List<Localidades> localidades = new List<Localidades>();

            try
            {

                string SQLSelect = "SELECT * FROM Localidades WHERE IdProvincia = @IdProvincia";
                Dictionary<string, string> parametros = new Dictionary<string, string>
        {
             { "@IdProvincia", idProvincia.ToString() }
        };


                var resultado = operaciones.Seleccion(SQLSelect, parametros);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                        int codProvincia = row.Field<int>("IdProvincia");
                        int idLocalidad = row.Field<int>("IdLocalidad");
                        string textoLocalidad = row.Field<string>("Localidad");
                        int codigoPostal = row.Field<int>("CodPostal");

                        Localidades localidad = new Localidades(idLocalidad, textoLocalidad, codigoPostal);
                        localidades.Add(localidad);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                mensajesService.ManejarExcepcion(ex);

                throw;
            }

            return localidades; // devuelve la lista
        }

        public Localidades ObtenerLocalidadPorId(int idLocalidad)
        {
            Localidades localidad = null!;

            try
            {
                string SQLSelect = "SELECT * FROM Localidades WHERE IdLocalidad = @IdLocalidad";
                Dictionary<string, string> parametros = new Dictionary<string, string>
                {
                    { "@IdLocalidad", idLocalidad.ToString() }
                };

                var resultado = operaciones.Seleccion(SQLSelect, parametros);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    var row = resultado.Rows[0];
                    int codigoPostal = row.Field<int>("CodPostal");
                    string textoLocalidad = row.Field<string>("Localidad");
                    int idProvincia = row.Field<int>("IdProvincia");

                    localidad = new Localidades(idLocalidad, textoLocalidad, codigoPostal);
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                mensajesService.ManejarExcepcion(ex);
                throw;
            }

            return localidad; // Devuelve la localidad
        }
    }
}



 