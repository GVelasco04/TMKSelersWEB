using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppTelemarketing.Entidades;
using TmkSelersWeb.Data;

namespace TmkSelersWeb.Pages.ModeloUsuario
{
    public class ListarModel : PageModel
    {
        private readonly TmkSelersWeb.Data.TmkSelersWebContext _context;

        public ListarModel(TmkSelersWeb.Data.TmkSelersWebContext context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; } = default!;

        public async Task OnGetAsync()
        {
            // Utilizar Include para cargar los datos relacionados de TipoUsuarios
            Usuario = await _context.Usuario
                                    .Include(u => u.TipoUsuariosNavigation) // Incluir los detalles del TipoUsuario
                                    .ToListAsync();
        }
    }
}
