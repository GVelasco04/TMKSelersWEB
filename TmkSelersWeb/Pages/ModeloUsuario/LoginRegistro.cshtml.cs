using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AppTelemarketing.Servicios.AppTelemarketing.Servicios;

namespace TmkSelersWeb.Pages.ModeloUsuario
{
    public class LoginRegistroModel : PageModel
    {
        //readonly significa que solo se puede asignar en el constructor
        // y no cambiará después. Así siempre usamos la misma instancia en la clase.
        private readonly UsuarioService _usuarioService;
        private readonly SecurityService _securityService;
        private readonly MailServices _mailService;

        // Propiedades para enlazar con los formularios de login y registro
        [BindProperty] //usar la entidad para los campos
        public Usuario Usuario { get; set; }
        public List<string> ErrorMessagesLogin { get; set; } = new List<string>();
        public List<string> ErrorMessagesRegister { get; set; } = new List<string>();
        public string SuccessMessage { get; set; }

        // Lista de tipos de usuarios disponibles
        public IList<TipoUsuarios> TiposUsuarios { get; set; }

        // Constructor para inyectar los servicios
        public LoginRegistroModel(SecurityService securityService, UsuarioService usuarioService, MailServices mailService)
        {
            _securityService = securityService;
            _usuarioService = usuarioService;
            _mailService = mailService;
        }

        // Método GET para cargar los tipos de usuarios
        public void OnGet()
        {
            TiposUsuarios = _usuarioService.ObtenerTipoUsuarios();
        }

        // Manejo de inicio de sesión,  define qué tipo de respuesta devolverá una acción 
        public IActionResult OnPostLogin()
        {
            // Limpiar la lista de errores antes de la validación
            ErrorMessagesLogin.Clear();
           
            // Remover validaciones no necesarias para el login
            ModelState.Remove("Usuario.Nombre");
            ModelState.Remove("Usuario.Apellido");
            ModelState.Remove("Usuario.Correo");
            ModelState.Remove("Usuario.TipoUsuariosNavigation");

            if (ModelState.IsValid)
            {
                // Verificar credenciales del usuario
                if (_securityService.UsuarioValido(Usuario.UserName, Usuario.Clave, Usuario.TipoUsuario))
                {
                    int userId = _usuarioService.TraerUserId(Usuario.UserName);
                    HttpContext.Session.SetInt32("UserId", userId);

                    // Obtener información completa del usuario
                    Usuario usuario = _usuarioService.ObtenerUsuarioPorId(userId);
                    HttpContext.Session.SetString("UserName", usuario.UserName);
                   

                    HttpContext.Session.SetInt32("TipoUsuario", usuario.TipoUsuario); // Almacenar TipoUsuario

                    // Redirigir a una página específica después del login
                    return RedirectToPage("/Privacy");
                }
                else
                {
                    // Agregar mensaje de error si las credenciales no son válidas
                    ErrorMessagesLogin.Add("Usuario o contraseña incorrectos.");
                }
            }
            else
            {
                // Capturar los errores de validación
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    ErrorMessagesLogin.Add(error.ErrorMessage);
                    Debug.WriteLine(error.ErrorMessage);
                }
            }

            // Limpiar el ModelState para evitar mantener los datos incorrectos
            ModelState.Clear();
            TiposUsuarios = _usuarioService.ObtenerTipoUsuarios();
            return Page();
        }

        // Manejo del registro de nuevos usuarios
        public IActionResult OnPostRegister()
        {
            // Limpiar la lista de errores antes de la validación
            ErrorMessagesRegister.Clear();
            SuccessMessage = string.Empty;

            // Remover validaciones no necesarias para el registro
            ModelState.Remove("Usuario.TipoUsuariosNavigation");
            ModelState.Remove("Usuario.Clave");

            if (ModelState.IsValid)
            {
                // Crear un nuevo usuario con datos proporcionados
                var nuevoUsuario = new Usuario
                {
                    UserName = Usuario.UserName,
                    Nombre = Usuario.Nombre,
                    Apellido = Usuario.Apellido,
                    Correo = Usuario.Correo,
                    TipoUsuario = Usuario.TipoUsuario,
                    Clave = new Random().Next(100000, 999999).ToString(), // Generar clave temporal aleatoria
                    AceptadoXAdmin = 0
                };

                var resultado = _usuarioService.AgregarUsuario(nuevoUsuario);

                if (resultado.Exito)
                {
                    string templatePath;
                    if (Usuario.TipoUsuario == 1) // Administrador
                    {
                        templatePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "EmailTemplates", "templateAdmin.html");
                    }
                    else if (Usuario.TipoUsuario == 2) // Telemarketer
                    {
                        templatePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "EmailTemplates", "templateTelemarketer.html");
                    }
                    else
                    {
                        return Page(); 
                    }
                    string cuerpoCorreo = System.IO.File.ReadAllText(templatePath);

                    cuerpoCorreo = cuerpoCorreo.Replace("{{Nombre}}", nuevoUsuario.Nombre);
                    cuerpoCorreo = cuerpoCorreo.Replace("{{UserName}}", nuevoUsuario.UserName);
                    cuerpoCorreo = cuerpoCorreo.Replace("{{Clave}}", nuevoUsuario.Clave);

                    var mailData = new MailData
                    {
                        Mailto = nuevoUsuario.Correo,
                        Subject = "Registro de usuarios sistema de Telemarketing",
                        Body = cuerpoCorreo
                    };
                    _mailService.SendMail(mailData);

                    SuccessMessage = "Usuario registrado exitosamente.";

                    Usuario = new Usuario();

                    // Limpiar el ModelState para que los campos se vacíen en la vista
                    ModelState.Clear();

                    // Recargar los tipos de usuarios
                    TiposUsuarios = _usuarioService.ObtenerTipoUsuarios();

                    // Mantener el formulario de registro visible
                    return Page();


                }
                else
                {
                    ErrorMessagesRegister.Add(resultado.MensajeExitoOError);
                }
            }
            else
            {
                // Capturar los errores de validación
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    ErrorMessagesRegister.Add(error.ErrorMessage);
                    Debug.WriteLine(error.ErrorMessage);
                }
            }

            // Volver a cargar los tipos de usuarios en caso de error
            TiposUsuarios = _usuarioService.ObtenerTipoUsuarios();
            return Page();
        }
    }
}