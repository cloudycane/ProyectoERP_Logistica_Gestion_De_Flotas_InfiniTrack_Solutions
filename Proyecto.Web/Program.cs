using Microsoft.EntityFrameworkCore;
using Proyecto.Aplicacion.Common.Mappings;
using Proyecto.Infraestructura.Persistence.DataAccess;
using AutoMapper;
using Proyecto.Aplicacion.Interfaces;
using Proyecto.Aplicacion.Services;
using Proyecto.Core.Interfaces;
using Proyecto.Infraestructura.Persistence.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<IActivosService, ActivosService>();


builder.Services.AddScoped<ICategoriaActivosRepositorio, CategoriaActivosRepositorio>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{area=Cliente}/{controller=Home}/{action=Index}/{id?}");

app.Run();
