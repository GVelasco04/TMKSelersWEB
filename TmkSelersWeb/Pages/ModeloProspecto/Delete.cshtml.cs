using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppTelemarketing.Entidades;
using TmkSelersWeb.Data;

namespace TmkSelersWeb.Pages.ModeloProspecto
{
    public class DeleteModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;

        public DeleteModel(TmkSelersWeb.Data.TmkSelersWebContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Prospecto Prospecto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Prospecto == null)
            {
                return NotFound();
            }

            var prospecto = await _context.Prospecto.FirstOrDefaultAsync(m => m.IdProspecto == id);

            if (prospecto == null)
            {
                return NotFound();
            }
            else 
            {
                Prospecto = prospecto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Prospecto == null)
            {
                return NotFound();
            }
            var prospecto = await _context.Prospecto.FindAsync(id);

            if (prospecto != null)
            {
                Prospecto = prospecto;
                _context.Prospecto.Remove(Prospecto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
