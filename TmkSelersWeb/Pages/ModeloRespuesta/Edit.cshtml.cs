using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppTelemarketing.Entidades;
using TmkSelersWeb.Data;

namespace TmkSelersWeb.Pages.ModeloRespuesta
{
    public class EditModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;

        public EditModel(TmkSelersWeb.Data.TmkSelersWebContext context)
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

            var respuestas =  await _context.Respuestas.FirstOrDefaultAsync(m => m.CodRespuesta == id);
            if (respuestas == null)
            {
                return NotFound();
            }
            Respuestas = respuestas;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Respuestas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RespuestasExists(Respuestas.CodRespuesta))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RespuestasExists(int id)
        {
          return (_context.Respuestas?.Any(e => e.CodRespuesta == id)).GetValueOrDefault();
        }
    }
}
