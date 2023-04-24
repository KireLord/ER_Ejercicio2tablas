using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ER_Ejercicio2tablas.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ER_Ejercicio2DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ER_Ejercicio2DbContext") ?? throw new InvalidOperationException("Connection string 'ER_Ejercicio2DbContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
