using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TmkSelersWeb.Data;

namespace TmkSelersWeb.Pages.ModeloProspecto
{
    public class CreateModel : PageModel
    {
        private readonly TmkSelersWebContext _context;
        private readonly ValidacionesService _validacionesService;
        private readonly ProspectoService _prospectoService; // Añadir esta línea

        public CreateModel(TmkSelersWebContext context, ValidacionesService validacionesService, ProspectoService prospectoService) // Añadir el servicio aquí
        {
            _context = context;
            _validacionesService = validacionesService;
            _prospectoService = prospectoService; // Asignar el servicio
        }

        [BindProperty]
        public Prospecto Prospecto { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Limpia los mensajes anteriores en ViewData
            ViewData["TelefonoError"] = null;
            ViewData["NombreError"] = null;
            ViewData["ApellidoError"] = null;

            // Validar el número de teléfono
            var resultadoValidacion = _validacionesService.ValidarTelefono(Prospecto.TelefonoPrincipal);
            bool esTelefonoValido = (bool)resultadoValidacion["esValido"];
            string mensajeErrorTelefono = (string)resultadoValidacion["mensaje"];

            if (!esTelefonoValido)
            {
                ViewData["TelefonoError"] = mensajeErrorTelefono; // Guardar en ViewData
            }

            // Validar nombre y apellido
            if (string.IsNullOrWhiteSpace(Prospecto.Nombre))
            {
                ViewData["NombreError"] = "El nombre es requerido.";
            }

            if (string.IsNullOrWhiteSpace(Prospecto.Apellido))
            {
                ViewData["ApellidoError"] = "El apellido es requerido.";
            }

            // Verificar si hay algún error
            if (ViewData["TelefonoError"] != null || ViewData["NombreError"] != null || ViewData["ApellidoError"] != null)
            {
                return Page(); // Si hay errores, retorna la página sin guardar
            }

            // Verificar si el prospecto ya existe
            if (_prospectoService.ExisteProspecto(Prospecto.TelefonoPrincipal))
            {
                ViewData["TelefonoError"] = "El prospecto con el teléfono " + Prospecto.TelefonoPrincipal + " ya existe.";
                return Page(); // Retorna la página si el prospecto ya existe
            }

            // Guardar el prospecto en la base de datos si todo está bien
            _context.Prospecto.Add(Prospecto);
            await _context.SaveChangesAsync();

            // Usar TempData para mostrar un mensaje de éxito
            TempData["SuccessMessage"] = "El prospecto se ha guardado con éxito.";

            // Redirigir para limpiar el formulario
            return RedirectToPage(); // Redirigir a la misma página
        }
    }
}





