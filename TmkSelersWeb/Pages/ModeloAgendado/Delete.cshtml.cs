﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppTelemarketing.Entidades;
using TmkSelersWeb.Data;

namespace TmkSelersWeb.Pages.ModeloAgendado
{
    public class DeleteModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;

        public DeleteModel(TmkSelersWeb.Data.TmkSelersWebContext context)
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

            var agendados = await _context.Agendados.FirstOrDefaultAsync(m => m.IdAgendado == id);

            if (agendados == null)
            {
                return NotFound();
            }
            else 
            {
                Agendados = agendados;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Agendados == null)
            {
                return NotFound();
            }
            var agendados = await _context.Agendados.FindAsync(id);

            if (agendados != null)
            {
                Agendados = agendados;
                _context.Agendados.Remove(Agendados);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
