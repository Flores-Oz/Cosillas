using Microsoft.EntityFrameworkCore;
using WebAppMovies.Data;
using MudBlazor.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Configuración de la base de datos con el contexto de EF Core
builder.Services.AddDbContextFactory<WebAppMoviesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebAppMoviesContext") ?? throw new InvalidOperationException("Connection string 'WebAppMoviesContext' not found.")));

// Configuración de MudBlazor para la UI
builder.Services.AddMudServices();

// Agregar el servicio de QuickGrid (si estás usando QuickGrid en tu proyecto)
builder.Services.AddQuickGridEntityFrameworkAdapter(); // Si realmente estás usando QuickGrid en la aplicación

// Configuración de la página de excepción de la base de datos (solo para desarrollo)
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Agregar componentes interactivos si estás utilizando Blazor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Crear la aplicación
var app = builder.Build();

// Configuración de la cadena de middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();  // Página de excepciones en desarrollo
}
else
{
    app.UseExceptionHandler("/Error");  // Página de errores para producción
    app.UseHsts();  // Seguridad adicional para producción
}

app.UseHttpsRedirection();  // Forzar redirección HTTPS
app.UseStaticFiles();  // Archivos estáticos (como imágenes, CSS, JS)
app.UseAntiforgery();  // Protección contra ataques CSRF

// Mapear Razor Components (si usas componentes interactivos)
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();  // Modo de renderizado interactivo en el servidor

// Iniciar la aplicación
app.Run();
