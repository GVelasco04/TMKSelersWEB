using Microsoft.EntityFrameworkCore;
using AppTelemarketing.Entidades;

namespace TmkSelersWeb.Data
{
    public class TmkSelersWebContext : DbContext
    {
        public TmkSelersWebContext(DbContextOptions<TmkSelersWebContext> options)
            : base(options)
        {
        }

        public DbSet<AppTelemarketing.Entidades.Prospecto> Prospecto { get; set; } = default!;

        public DbSet<AppTelemarketing.Entidades.Respuestas> Respuestas { get; set; } = default!;

        public DbSet<AppTelemarketing.Entidades.Agendados> Agendados { get; set; } = default!;

        public DbSet<AppTelemarketing.Entidades.Venta> Venta { get; set; } = default!;

        public DbSet<AppTelemarketing.Entidades.Usuario> Usuario { get; set; } = default!;

        public DbSet<AppTelemarketing.Entidades.TipoUsuarios> TipoUsuarios { get; set; }

        public DbSet<AppTelemarketing.Entidades.LlamadosProspectos> LlamadosProspectos { get; set; } = default!;
    }
}
