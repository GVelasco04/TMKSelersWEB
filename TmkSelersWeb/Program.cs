using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;
using AppTelemarketing.Servicios.AppTelemarketing.Servicios;
using Microsoft.EntityFrameworkCore;
using TmkSelersWeb.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// Configura el contexto de la base de datos
builder.Services.AddDbContext<TmkSelersWebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TmkSelersWebContext") ?? throw new InvalidOperationException("Connection string 'TmkSelersWebContext' not found.")));

// Configura la sesión
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Tiempo de expiración de la sesión
    options.Cookie.HttpOnly = true; // Solo accesible vía HTTP (no JS)
    options.Cookie.IsEssential = true; // Necesario para el funcionamiento del sitio
});


builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<SecurityService>();
builder.Services.AddScoped<ValidacionesService>();
builder.Services.AddScoped<ProspectoService>();
builder.Services.AddScoped<GestionDeLlamadosService>();
builder.Services.AddScoped<MailServices>();
builder.Services.AddScoped<RespuestasService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapRazorPages();

// Configura la página de inicio
app.MapGet("/", context =>
{
    context.Response.Redirect("/ModeloUsuario/LoginRegistro");
    return Task.CompletedTask;
});

app.Run();
