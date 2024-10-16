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

namespace TmkSelersWeb.Pages.ModeloRealizarLlamada
{
    public class EditModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;

        public EditModel(TmkSelersWeb.Data.TmkSelersWebContext context)
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

            var llamadosprospectos =  await _context.LlamadosProspectos.FirstOrDefaultAsync(m => m.IdLlamadosProspectos == id);
            if (llamadosprospectos == null)
            {
                return NotFound();
            }
            LlamadosProspectos = llamadosprospectos;
           ViewData["IdProspecto"] = new SelectList(_context.Prospecto, "IdProspecto", "Nombre");
           ViewData["CodRespuesta"] = new SelectList(_context.Respuestas, "CodRespuesta", "Respuesta");
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

            _context.Attach(LlamadosProspectos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LlamadosProspectosExists(LlamadosProspectos.IdLlamadosProspectos))
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

        private bool LlamadosProspectosExists(int id)
        {
          return (_context.LlamadosProspectos?.Any(e => e.IdLlamadosProspectos == id)).GetValueOrDefault();
        }
    }
}
