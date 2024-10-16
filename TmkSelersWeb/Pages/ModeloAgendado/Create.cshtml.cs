using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TmkSelersWeb.Pages.ModeloAgendado
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
        public Agendados Agendados { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Agendados == null || Agendados == null)
            {
                return Page();
            }

            _context.Agendados.Add(Agendados);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
