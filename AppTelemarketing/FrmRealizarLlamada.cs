using AppTelemarketing;
using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp2
{
    public partial class FrmRealizarLlamada : Form
    {
        // Inicializo el cronómetro
        private DateTime inicioFormulario;
        private Timer llamadoCronometro;
        private Stopwatch stopwatch;

        public static TimeSpan tiempoTranscurrido { get; set; }

        private int userId = FrmLogin.idUser;
        private string cronometro;

        // Definimos para preservar los datos hasta FrmVenta
        private string telefonoProspecto = null!;
        private string apellidoProspecto = null!;
        private string nombreProspecto = null!;
        private int prospectoId = 0;

        private List<Prospecto> ListProspectos = new List<Prospecto>();
        public static int idProspectoActual { get; set; } // Para almacenar el dato actual
        private RespuestasService respuestasService = new RespuestasService();
        private List<int> listaCodigosRespuestas;

        ProspectoService prospectoService = new ProspectoService();
        GestionDeLlamadosService GestionDeLlamadosService_ = new GestionDeLlamadosService();
        ProductoService productoService_ = new ProductoService();
        private bool isFormLoading = true;
        Prospecto prospecto;
        // Constructor con parametros en caso de necesitarse
        public FrmRealizarLlamada(int idProspecto/*, string nombre, string apellido, int telefono, string observaciones*/)
        {
            InitializeComponent();
            CargarRespuestasEnComboBox();
            CargarServiciosEnComboBox();
    

            llamadoCronometro = new Timer();
            llamadoCronometro.Interval = 1000;
            llamadoCronometro.Tick += llamadoCronometro_Tick;

            stopwatch = new Stopwatch();

            inicioFormulario = DateTime.Now;
            llamadoCronometro.Start();
            stopwatch.Start();

            prospecto = prospectoService.ObtenerSiguienteProspectoNoLlamado(idProspecto);
            txtTelefPro.Text = prospecto.TelefonoPrincipal.ToString();
            txtApePro.Text = prospecto.Apellido;
            txtNombrePro.Text = prospecto.Nombre;
            ObservacionesPro.Text = prospecto.ObsProspecto;
            idProspectoActual = idProspecto;

            comboBoxRespuesta.DropDown += new EventHandler(comboBoxRespuesta_DropDown);
            listaCodigosRespuestas = new List<int>();
            isFormLoading = false;


        }

        // Constructor sobrecargado sin parámetros
        public FrmRealizarLlamada()
        {
            InitializeComponent();
            cronometro = "";
            stopwatch = new Stopwatch();
            CargarRespuestasEnComboBox();
            CargarServiciosEnComboBox();
            

            comboBoxRespuesta.DropDown += new EventHandler(comboBoxRespuesta_DropDown);
            listaCodigosRespuestas = new List<int>();
            isFormLoading = false;

            llamadoCronometro = new Timer();
            llamadoCronometro.Interval = 1000;
            llamadoCronometro.Tick += llamadoCronometro_Tick;

            stopwatch = new Stopwatch();

            llamadoCronometro.Start();
            stopwatch.Start();

        }
        public TimeSpan ObtenerTiempoTranscurrido()
        {
            return stopwatch.Elapsed;
        }

        private void llamadoCronometro_Tick(object sender, EventArgs e)
        {
            tiempoTranscurrido = stopwatch.Elapsed;
            tiempoDeLlamado.Text = $"{tiempoTranscurrido.Hours:00}:{tiempoTranscurrido.Minutes:00}:{tiempoTranscurrido.Seconds:00}";
        }
        private void comboBoxRespuesta_DropDown(object? sender, EventArgs? e)
        {
            // Volver a cargar las respuestas en el ComboBox cuando se despliega
            CargarRespuestasEnComboBox();
        }

        // Apenas ingresa a este formulario se cargan los datos de la BBDD
        private void FrmRealizarLlamada_Load(object sender, EventArgs e)
        {
            if (isFormLoading)
            {
                txtTelefPro.Text = prospecto.TelefonoPrincipal.ToString();
                txtApePro.Text = prospecto.Apellido;
                txtNombrePro.Text = prospecto.Nombre;
                ObservacionesPro.Text = prospecto.ObsProspecto;
                return;
            }


            /*if (idProspectoActual == 0) // Si no hay prospecto cargado, obtener uno nuevo
            {
                CargarProspecto();
            }
            else // Si ya hay un prospecto cargado, mostrarlo
            {
                Prospecto prospecto = prospectoService.TraerIdProspecto(idProspectoActual); // Necesitas implementar este método si no existe
                if (prospecto != null)
                {
                    MostrarProspectoEnControles(prospecto);
                }
                else
                {
                    CargarProspecto(); // Si el prospecto no se encuentra, obtener uno nuevo
                }
            }
            isFormLoading = false;
            */

            //CargarRespuestasEnComboBox();
            if (idProspectoActual == 0)
            {
                CargarProspecto();
            }
            isFormLoading = false;
        }


        private void CargarProspecto()
        {
            Prospecto prospecto = prospectoService.ObtenerSiguienteProspectoNoLlamado(0);

            // Verificar si se encontró un prospecto
            if (prospecto != null)
            {
                // Mostrar los datos del prospecto en los controles del formulario
                MostrarProspectoEnControles(prospecto);
                idProspectoActual = prospecto.IdProspecto;
                // Guardar los datos en las propiedades para poder acceder desde fuera del formulario
                DatosGlobales.TelefonoProspecto = prospecto.TelefonoPrincipal.ToString() ?? "";
                DatosGlobales.ApellidoProspecto = prospecto.Apellido;
                DatosGlobales.NombreProspecto = prospecto.Nombre;
            }
            else
            {
                MessageBox.Show("No hay prospectos cargados.", "Falta de Prospectos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    
    private void CargarRespuestasEnComboBox()
        {
            comboBoxRespuesta.DataSource = null;
            comboBoxRespuesta.DataSource = respuestasService.ObtenerRespuestas();
            comboBoxRespuesta.DisplayMember = "Respuesta";
            comboBoxRespuesta.ValueMember = "CodRespuesta";
        }

        private void CargarServiciosEnComboBox()
        {
            comboBoxProductos.DataSource = null;
            comboBoxProductos.DataSource = productoService_.ObtenerProductos();
            comboBoxProductos.DisplayMember = "NombreProducto";
            comboBoxProductos.ValueMember = "CodigoProd";
        }
        // Mostrar en pantalla los datos de la base de dato
        private void MostrarProspectoEnControles(Prospecto prospecto)
        {
            txtTelefPro.Text = prospecto.TelefonoPrincipal.ToString() ?? "";
            txtApePro.Text = prospecto.Apellido;
            txtNombrePro.Text = prospecto.Nombre;
            ObservacionesPro.Text = prospecto.ObsProspecto;
        }



        // Botón Aceptar
        // Botón Aceptar
        private void btnVolver_Click(object sender, EventArgs e)
        {
            llamadoCronometro.Stop();
            llamadoCronometro.Dispose();
            stopwatch.Stop();

            Respuestas opcionSeleccionada = comboBoxRespuesta.SelectedItem as Respuestas;
            DateTime horaBotonAceptar = DateTime.Now;
            DateTime fechaBotonAceptar = DateTime.Today;
            Productos productoSeleccionado = comboBoxProductos.SelectedItem as Productos;
            string nombreProducto = productoSeleccionado.NombreProducto;
            // Implementar el procedimiento para marcar los campos LLAMADO y VENTA
            GestionDeLlamadosService_.MarcarLlamadoYVenta(idProspectoActual, opcionSeleccionada.CodRespuesta);

            bool mostrarMensaje = true;

            // Implementar el procedimiento para cargar datos en BBDD: LlamadosProspectos, Ventas y Volver a llamar
            if (opcionSeleccionada.Respuesta == "Volver a llamar")
            {
                DateTime fechaSeleccionada = fecha.Value;
                TimeSpan horaSeleccionada = hora.Value.TimeOfDay;
                string observaciones = ObservacionesPro.Text;
                GestionDeLlamadosService_.LlenarAgendados(idProspectoActual, fechaSeleccionada, horaSeleccionada, observaciones, userId);
            }
            else if (opcionSeleccionada.Respuesta == "Venta")
            {
                mostrarMensaje = false;
                // Dentro del método btnVolver_Click en FrmRealizarLlamada
                frmMenu menuForm = this.ParentForm as frmMenu;
                if (menuForm != null)
                {
                    frmVenta ventaForm = new frmVenta(nombreProducto, txtApePro.Text, txtNombrePro.Text, long.Parse(txtTelefPro.Text), ObtenerTiempoTranscurrido());
                    ventaForm.FormClosed += (s, args) =>
                    {
                        // Aquí recargas los datos después de que se cierra frmVenta
                        CargarProspecto();
                        menuForm.AbrirFormInPanel(this); // Reabrir FrmRealizarLlamada en el subpanel
                        ReiniciarCronometro();
                    };
                    menuForm.AbrirFormInPanel(ventaForm);
                }
                else
                {
                    MessageBox.Show("No se puede abrir Formulario", "Información", MessageBoxButtons.OK);
                }
            }

            // Llenar la tabla de llamados a los prospectos
            GestionDeLlamadosService_.LlenarLlamadosProspectos(idProspectoActual, opcionSeleccionada.CodRespuesta, fechaBotonAceptar, horaBotonAceptar, ObservacionesPro.Text, userId);

            // Obtener el siguiente prospecto no llamado y mostrarlo en los controles
            Prospecto siguienteProspecto = prospectoService.ObtenerSiguienteProspectoNoLlamado(0);
            if (siguienteProspecto != null)
            {
                MostrarProspectoEnControles(siguienteProspecto);
                idProspectoActual = siguienteProspecto.IdProspecto;
                llamadoCronometro.Start();
                stopwatch.Start();
            }
            else
            {
                LimpiarControles();
            }

            if (opcionSeleccionada.Respuesta != "Venta")
            {
                ReiniciarCronometro();
            }

            if (mostrarMensaje)
            {
                MessageBox.Show("Llamado prospecto cargado con éxito");
            }
        }



        // Limpiar los controles TextBox y el control de observaciones
        private void LimpiarControles()
        {
            txtTelefPro.Text = "";
            txtApePro.Text = "";
            txtNombrePro.Text = "";
            ObservacionesPro.Text = "";
        }

        private void comboBoxRespuesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Respuestas respuestaSeleccionada = comboBoxRespuesta.SelectedItem as Respuestas;

            if (respuestaSeleccionada != null && respuestaSeleccionada.Respuesta == "Volver a llamar")
            {
                fecha.Value = DateTime.Today;
                hora.Value = DateTime.Now;

                fecha.Visible = true;
                fecha.BringToFront();
                hora.Visible = true;
                hora.BringToFront();
            }
            else
            {
                fecha.Visible = false;
                hora.Visible = false;
            }

            if (respuestaSeleccionada != null && respuestaSeleccionada.Respuesta == "Venta")
            {
                comboBoxProductos.Visible = true;
                comboBoxProductos.BringToFront();
            }
            else
            {
                comboBoxProductos.Visible = false;
            }
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoading) return;

            Productos productoSeleccionado = comboBoxProductos.SelectedItem as Productos;
            if (productoSeleccionado != null)
            {
                switch (productoSeleccionado.NombreProducto)
                {
                    case "TV Cable":
                        FrmServicio1 frmServicio1 = new FrmServicio1();
                        frmServicio1.Visible = true;
                        break;
                    case "Telefono":
                        FrmServicio2 frmServicio2 = new FrmServicio2();
                        frmServicio2.Visible = true;
                        break;
                    case "Internet":
                        FrmServicio3 frmServicio3 = new FrmServicio3();
                        frmServicio3.Visible = true;
                        break;
                    case "Pack TV-Int-Tel":
                        FrmServicio4 frmServicio4 = new FrmServicio4();
                        frmServicio4.Visible = true;
                        break;
                    case "Pack Int-Tel":
                        FrmServicio5 frmServicio5 = new FrmServicio5();
                        frmServicio5.Visible = true;
                        break;
                    case "Pack Int-Tv Cable":
                        FrmServicio6 frmServicio6 = new FrmServicio6();
                        frmServicio6.Visible = true;
                        break;
                    case "Pack Tv Cable - Telefono":
                        FrmServicio7 frmServicio7 = new FrmServicio7();
                        frmServicio7.Visible = true;
                        break;
                }
            }
        }

        private void linkGuia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSpeech frmSpeech = new FrmSpeech();
            frmSpeech.Show();
        }
        private void ReiniciarCronometro()
        {
            llamadoCronometro.Stop();
            inicioFormulario = DateTime.Now;
            stopwatch.Reset();
            stopwatch.Start();
            llamadoCronometro.Start();
        }

       
    }
}



