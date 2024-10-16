using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace TmkSelersWeb.Pages.ModeloAgendado
{
    public class ListarModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;
        private readonly GestionDeLlamadosService _gestionDeLlamadosService;

        public ListarModel(TmkSelersWeb.Data.TmkSelersWebContext context, GestionDeLlamadosService gestionDeLlamadosService)
        {
            _context = context;
            _gestionDeLlamadosService = gestionDeLlamadosService;
        }

        public IList<Agendados> Agendados { get; set; } = default!;

        public async Task OnGetAsync(string? sortOrder)
        {
            // Si no se pasa el sortOrder, se asigna "asc" por defecto
            sortOrder = sortOrder ?? "asc";

            int userId = 1;
            var dataTable = _gestionDeLlamadosService.ObtenerAgendadosPorUsuario(userId, sortOrder);

            // Convertir el DataTable a una lista de Agendados
            Agendados = dataTable.AsEnumerable().Select(row => new Agendados
            {
                IdProspecto = row.Field<int>("IdProspecto"),
                FechaAgenda = row.Field<DateTime>("FechaAgenda"),
                HoraAgenda = row.Field<TimeSpan>("HoraAgenda"),
                ObsProspecto = row.Field<string>("ObsProspecto")
            }).ToList();
        }

    }
}
