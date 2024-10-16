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
    public class DeleteModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;

        public DeleteModel(TmkSelersWeb.Data.TmkSelersWebContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Respuestas Respuestas { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Respuestas == null)
            {
                return NotFound();
            }

            var respuestas = await _context.Respuestas.FirstOrDefaultAsync(m => m.CodRespuesta == id);

            if (respuestas == null)
            {
                return NotFound();
            }
            else 
            {
                Respuestas = respuestas;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Respuestas == null)
            {
                return NotFound();
            }
            var respuestas = await _context.Respuestas.FindAsync(id);

            if (respuestas != null)
            {
                Respuestas = respuestas;
                _context.Respuestas.Remove(Respuestas);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
