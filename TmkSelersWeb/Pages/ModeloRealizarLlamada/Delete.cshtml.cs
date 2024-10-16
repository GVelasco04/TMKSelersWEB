using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppTelemarketing.Entidades;
using TmkSelersWeb.Data;

namespace TmkSelersWeb.Pages.ModeloRealizarLlamada
{
    public class DeleteModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;

        public DeleteModel(TmkSelersWeb.Data.TmkSelersWebContext context)
        {
            _context = context;
        }

        [BindProperty]
      public LlamadosProspectos LlamadosProspectos { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.LlamadosProspectos == null)
            {
                return NotFound();
            }

            var llamadosprospectos = await _context.LlamadosProspectos.FirstOrDefaultAsync(m => m.IdLlamadosProspectos == id);

            if (llamadosprospectos == null)
            {
                return NotFound();
            }
            else 
            {
                LlamadosProspectos = llamadosprospectos;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.LlamadosProspectos == null)
            {
                return NotFound();
            }
            var llamadosprospectos = await _context.LlamadosProspectos.FindAsync(id);

            if (llamadosprospectos != null)
            {
                LlamadosProspectos = llamadosprospectos;
                _context.LlamadosProspectos.Remove(LlamadosProspectos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
