using AppTelemarketing.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TmkSelersWeb.Pages.ModeloUsuario
{
    public class CambiarContraseñaModel : PageModel
    {
        private readonly SecurityService _securityService;
        private readonly ValidacionesService _validacionesService;

        [BindProperty]
        public string ContraseñaActual { get; set; }

        [BindProperty]
        public string NuevaContraseña { get; set; }

        public CambiarContraseñaModel(SecurityService securityService, ValidacionesService validacionesService)
        {
            _securityService = securityService;
            _validacionesService = validacionesService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
          
            string nombredeUsuario = HttpContext.Session.GetString("UserName");

            // Validar la contraseña actual
            if (_securityService.UsuarioValido(nombredeUsuario, ContraseñaActual))
            {
                // Actualizar la contraseña
                var resultado = _validacionesService.ActualizarContraseña(nombredeUsuario, NuevaContraseña);

                if (resultado.Exito)
                {
                    TempData["Mensaje"] = "Contraseña actualizada exitosamente.";
                }
                else
                {
                    TempData["Mensaje"] = resultado.MensajeExitoOError;
                }
            }
            else
            {
                TempData["Mensaje"] = "La contraseña actual es incorrecta.";
            }

            ContraseñaActual = string.Empty;
            NuevaContraseña = string.Empty;

            return RedirectToPage(); 
        }
    }
}
