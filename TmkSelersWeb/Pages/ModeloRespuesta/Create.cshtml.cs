using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AppTelemarketing.Entidades;
using TmkSelersWeb.Data;

namespace TmkSelersWeb.Pages.ModeloRespuesta
{
    public class CreateModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;

        public CreateModel(TmkSelersWeb.Data.TmkSelersWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Respuestas Respuestas { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Respuestas == null || Respuestas == null)
            {
                return Page();
            }

            _context.Respuestas.Add(Respuestas);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
