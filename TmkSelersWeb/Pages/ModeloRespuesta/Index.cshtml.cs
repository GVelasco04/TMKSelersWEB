using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppTelemarketing.Entidades;
using TmkSelersWeb.Data;

namespace TmkSelersWeb.Pages.ModeloRespuesta
{
    public class IndexModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;

        public IndexModel(TmkSelersWeb.Data.TmkSelersWebContext context)
        {
            _context = context;
        }

        public IList<Respuestas> Respuestas { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Respuestas != null)
            {
                Respuestas = await _context.Respuestas.ToListAsync();
            }
        }
    }
}
