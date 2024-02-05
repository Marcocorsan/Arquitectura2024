using Microsoft.EntityFrameworkCore;
using Aplicacion.Entities;
using Aplicacion;
using Aplicacion.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MarcacionesContext>(opts => {
    opts.UseSqlServer(
    builder.Configuration["ConnectionStrings:DefaultConnection"]);
});
builder.Services.AddScoped<IMarcacionesRepository, EFMarcaciones>();   
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();