using CadFuncionarios.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Drawing;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>
    (options => options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = CadFuncionariosDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate=False; Application Intent = ReadWrite; Multi Subnet Failover=False"));
                                      
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
