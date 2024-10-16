using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace TmkSelersWeb.Pages.ModeloProspecto
{
    public class ListarModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;
        private readonly ProspectoService _prospectoService;

        public ListarModel(TmkSelersWeb.Data.TmkSelersWebContext context, ProspectoService prospectoService)
        {
            _context = context;
            _prospectoService = prospectoService;
        }

        public IList<Prospecto> Prospecto { get; set; } = default!;
        public string SortOrder { get; set; } = string.Empty; // Agregar esta línea

        public async Task OnGetAsync(string sortOrder)
        {
            // Asignar un valor predeterminado si sortOrder es nulo
            sortOrder ??= "asc";

            // Usar el servicio para obtener los prospectos ordenados
            Prospecto = _prospectoService.ObtenerProspectosOrdenados(sortOrder);
        }
    }

}
