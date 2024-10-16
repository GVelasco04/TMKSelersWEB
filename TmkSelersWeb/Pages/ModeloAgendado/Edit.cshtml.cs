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

namespace TmkSelersWeb.Pages.ModeloAgendado
{
    public class EditModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;

        public EditModel(TmkSelersWeb.Data.TmkSelersWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Agendados Agendados { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Agendados == null)
            {
                return NotFound();
            }

            var agendados =  await _context.Agendados.FirstOrDefaultAsync(m => m.IdAgendado == id);
            if (agendados == null)
            {
                return NotFound();
            }
            Agendados = agendados;
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

            _context.Attach(Agendados).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgendadosExists(Agendados.IdAgendado))
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

        private bool AgendadosExists(int id)
        {
          return (_context.Agendados?.Any(e => e.IdAgendado == id)).GetValueOrDefault();
        }
    }
}
