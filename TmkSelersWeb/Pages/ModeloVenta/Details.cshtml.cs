using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppTelemarketing.Entidades;
using TmkSelersWeb.Data;

namespace TmkSelersWeb.Pages.ModeloVenta
{
    public class DetailsModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;

        public DetailsModel(TmkSelersWeb.Data.TmkSelersWebContext context)
        {
            _context = context;
        }

      public Venta Venta { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Venta == null)
            {
                return NotFound();
            }

            var venta = await _context.Venta.FirstOrDefaultAsync(m => m.IdCliente == id);
            if (venta == null)
            {
                return NotFound();
            }
            else 
            {
                Venta = venta;
            }
            return Page();
        }
    }
}
