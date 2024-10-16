using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AppTelemarketing.Entidades;
using TmkSelersWeb.Data;
using AppTelemarketing.Servicios;

namespace TmkSelersWeb.Pages.ModeloRealizarLlamada
{
    public class CreateModel : PageModel
    {
        private readonly TmkSelersWebContext _context;
        private readonly ProspectoService _prospectoService;
        private readonly GestionDeLlamadosService _gestionDeLlamadosService;

        public CreateModel(TmkSelersWebContext context,
                           ProspectoService prospectoService,
                           GestionDeLlamadosService gestionDeLlamadosService)
        {
            _context = context;
            _prospectoService = prospectoService;
            _gestionDeLlamadosService = gestionDeLlamadosService;
        }

        public IActionResult OnGet()
        {

            // Inicializar la instancia de LlamadosProspectos
            LlamadosProspectos = new LlamadosProspectos();

            // Asegúrate de que este método devuelva una colección de prospectos
            var prospectos = _prospectoService.ProspectoNoLlamado(0);
            var prospectosSelectList = prospectos.Select(p => new SelectListItem
            {
                Value = p.IdProspecto.ToString(),
                Text = $"{p.Nombre} {p.Apellido} - {p.TelefonoPrincipal}"
            }).ToList();

            ViewData["IdProspecto"] = new SelectList(prospectosSelectList, "Value", "Text");
            ViewData["CodRespuesta"] = new SelectList(_context.Respuestas, "CodRespuesta", "Respuesta");

            LlamadosProspectos.Fecha = DateTime.Now.Date;
            LlamadosProspectos.HoraInicio = DateTime.Now.TimeOfDay;

            return Page();
        }

        [BindProperty]
        public LlamadosProspectos LlamadosProspectos { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            _gestionDeLlamadosService.MarcarLlamadoYVenta(LlamadosProspectos.IdProspecto, LlamadosProspectos.CodRespuesta);


            return RedirectToPage("./Index");
        }
    }
}
