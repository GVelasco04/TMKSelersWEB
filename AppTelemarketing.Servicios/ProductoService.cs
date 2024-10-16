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
    public class ProductoService
    {
        OperacionesBD operaciones = new OperacionesBD();
        ManejoMensajesServices mensajesService = new ManejoMensajesServices();

        public List<Productos> ObtenerProductos()
        {
            List<Productos> productos = new List<Productos>();

            try
            {
                string SQLSelect = "SELECT * FROM Productos";

                var resultado = operaciones.Seleccion(SQLSelect, null);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                        int codProducto = row.Field<int>("CodigoProd");
                        string textoProducto = row.Field<string>("NombreProducto");
                        Productos producto = new Productos(codProducto, textoProducto);
                        productos.Add(producto);
                    }
                }
            }
            catch (Exception ex)
            {
                mensajesService.ManejarExcepcion(ex);
                throw;
            }

            return productos;
        }

        public List<Productos> ObtenerProducto(string nombreProd)
        {
            List<Productos> productoSel = new List<Productos>();

            try
            {
                string SQLSelect = "SELECT * FROM Productos WHERE NombreProducto=@NombreProducto";
                Dictionary<string, string> parametros = new Dictionary<string, string>
                {
                    {"@NombreProducto", nombreProd }
                };

                var resultado = operaciones.Seleccion(SQLSelect, parametros);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                        int codProducto = row.Field<int>("CodigoProd");
                        string textoProducto = row.Field<string>("NombreProducto");
                        decimal totalProd = row.Field<decimal>("Precio");
                        int stock = row.Field<int>("Stock");

                        Productos producto = new Productos(codProducto, textoProducto, totalProd, stock);
                        productoSel.Add(producto);
                    }
                }
            }
            catch (Exception ex)
            {
                mensajesService.ManejarExcepcion(ex);
                throw;
            }

            return productoSel;
        }
    }
}
