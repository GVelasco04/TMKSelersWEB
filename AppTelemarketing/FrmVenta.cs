using WinFormsApp2;
using AppTelemarketing.Servicios;
using AppTelemarketing.Entidades;
using Timer = System.Windows.Forms.Timer;
namespace AppTelemarketing
{
    public partial class frmVenta : Form
    {

        //variables para cronometro y hora de venta
        private DateTime inicioFormulario;
        private TimeOnly comienzo;
        private TimeOnly fin;
        private Timer ventaCronometro;
        private TimeSpan tiempoTranscurrido;
        private TimeSpan tiempoTranscurridoInicial;

        Venta venta = new Venta();
        VentasService ventaService = new VentasService();
        MedioDePagoService medioDePagoService_ = new MedioDePagoService();
        UbicacionClienteService ubicacionClienteService_= new UbicacionClienteService();
        ProductoService productoService_ = new ProductoService();
        ValidacionesService validacionesService = new ValidacionesService();
        public frmVenta(string nombreProducto, string apellido, string nombre, long telefono, TimeSpan tiempoTranscurridoInicial)
        {
            InitializeComponent();
            tiempoTranscurrido = tiempoTranscurridoInicial;
            //tiempoTranscurridoInicial = FrmRealizarLlamada.tiempoTranscurrido;
            // Captura la hora al abrir el formulario
            comienzo = TimeOnly.FromDateTime(DateTime.Now);


            LlenarComboMedioPago();
            LlenarComboPronvincia();

            // Inicializamos el cronómetro
            ventaCronometro = new Timer();
            ventaCronometro.Interval = 1000; // Intervalo en milisegundos (1 segundo)
            ventaCronometro.Tick += VentaCronometro_Tick;

            // Guardamos el tiempo de llamado que se trajo del otro formulario
            inicioFormulario = DateTime.Now.Subtract(tiempoTranscurridoInicial);

            // Iniciamos el cronómetro
            ventaCronometro.Start();

            cmbProvincia.SelectedIndexChanged += CmbProvincia_SelectedIndexChanged;
            cmbLocalidad.SelectedIndexChanged += CmbLocalidad_SelectedIndexChanged;

            // Configuramos los ComboBox para permitir la escritura y búsqueda rápida
            cmbProvincia.DropDownStyle = ComboBoxStyle.DropDown;
            cmbProvincia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProvincia.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDown;
            cmbLocalidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLocalidad.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Se Cargan los datos en los textbox
            txtTelefono.Text = telefono.ToString();
            txtApellido.Text = apellido;
            txtNombre.Text = nombre;
            txtProducto.Text = nombreProducto;

            // Obtener datos del producto seleccionado
            var productoSel = productoService_.ObtenerProducto(nombreProducto);
            if (productoSel.Count > 0)
            {
                var productoSeleccionado = productoSel.First();
                txtTotal.Text = productoSeleccionado.Precio.ToString();
            }
            else
            {
                MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void VentaCronometro_Tick(object sender, EventArgs e)
        {
            // Calculamos el tiempo transcurrido desde la apertura del formulario más el tiempo transcurrido inicial
            tiempoTranscurrido = DateTime.Now.Subtract(inicioFormulario).Add(tiempoTranscurridoInicial);

            // Mostramos el tiempo transcurrido en un Label
            lblTiempoTranscurrido.Text = $"{tiempoTranscurrido.Hours:00}:{tiempoTranscurrido.Minutes:00}:{tiempoTranscurrido.Seconds:00}";
        }
        private void CmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincia.SelectedValue != null)
            {
                int idProvincia = (int)cmbProvincia.SelectedValue;
                LlenarComboLocalidad(idProvincia);
            }
        }

        private void CmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocalidad.SelectedValue != null)
            {
                // Aquí se debe obtener el código postal correspondiente a la localidad seleccionada
                int idLocalidad = (int)cmbLocalidad.SelectedValue;
                var localidad = ubicacionClienteService_.ObtenerLocalidadPorId(idLocalidad);
                if (localidad != null)
                {
                    txtCodigoPostal.Text = localidad.CodPostal.ToString();
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Detener y liberar el cronómetro al cerrar el formulario
            ventaCronometro.Stop();
            ventaCronometro.Dispose();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // Detener y liberar el cronómetro al cerrar el formulario
            ventaCronometro.Stop();
            ventaCronometro.Dispose();

            // Guardar los datos y realizar otras operaciones aquí...
            bool mail = false;
            // Verificamos que los valores seleccionados no sean null
            if (cmbProvincia.SelectedValue == null || cmbLocalidad.SelectedValue == null || cmbMedioPago.SelectedValue == null)
            {
                MessageBox.Show("Seleccione todos los valores requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mail = validacionesService.IsValidEmail(txtMail.Text);
            if (!mail)
            {
                MessageBox.Show("Formato de correo electrónico no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int user = FrmLogin.idUser;
            int CodProspecto = FrmRealizarLlamada.idProspectoActual;
            var productos = productoService_.ObtenerProducto(txtProducto.Text);
            if (productos == null || productos.Count == 0)
            {
                MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int CodProducto = productos.First().CodigoProd;
            decimal total = productos.First().Precio;

            int idProvincia = (int)cmbProvincia.SelectedValue;
            int idLocalidad = (int)cmbLocalidad.SelectedValue;
            int idMedioPago = (int)cmbMedioPago.SelectedValue;

            int TelSecundario = 0;
            string Direccion = txtDirrecion.Text;
            if (string.IsNullOrEmpty(Direccion))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCodigoPostal.Text, out int CP))
            {
                MessageBox.Show("Código Postal no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime FechaVenta = DateTime.Now;
            fin = TimeOnly.FromDateTime(DateTime.Now); // Captura la hora al presionar el botón Guardar

            string Mail = txtMail.Text;
            string ObsSObreVenta = "";

            //Venta venta = new Venta(CodProspecto, TelSecundario, Direccion, idLocalidad, idProvincia, CP, FechaVenta, comienzo, fin, CodProducto, total, Mail, idMedioPago, user, ObsSObreVenta);

            bool exito = ventaService.CargarVenta(venta);

            if (exito)
            {
                MessageBox.Show("Venta cargada con éxito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                this.Close(); // Esto cerrará el frmVenta y activará el evento FormClosed en FrmRealizarLlamada
            }
            else
            {
                MessageBox.Show("Error al cargar la venta.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LlenarComboPronvincia()
        {
            cmbProvincia.DataSource = null;
            cmbProvincia.DisplayMember = "Provincia";
            cmbProvincia.ValueMember = "IdProvincia";
            cmbProvincia.DataSource = ubicacionClienteService_.ObtenerProvincias();
        }
        private void LlenarComboLocalidad(int idProvincia)
        {
            cmbLocalidad.DataSource = null;
            cmbLocalidad.DisplayMember = "Localidad";
            cmbLocalidad.ValueMember = "IdLocalidad";
            cmbLocalidad.DataSource = ubicacionClienteService_.ObtenerLocalidadesPorProvincia(idProvincia);
        }
        private void LlenarComboMedioPago()
        {
            cmbMedioPago.DataSource = null;
            cmbMedioPago.DisplayMember = "Descripcion";
            cmbMedioPago.ValueMember = "IdMedioDePago";
            cmbMedioPago.DataSource = medioDePagoService_.ObtenerMedioDePagos();

        }

        private void LimpiarCampos()
        {
            txtMail.Clear();
            txtCodigoPostal.Clear();
            txtDirrecion.Clear();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            // Cualquier código adicional de carga
        }


    }
}
