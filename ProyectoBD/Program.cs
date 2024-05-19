using Microsoft.EntityFrameworkCore;
using ProyectoBD.Client.Pages; 
using ProyectoBD.Components;
using ProyectoBD.Data;

var builder = WebApplication.CreateBuilder(args);

// Agrega servicios al contenedor de servicios
builder.Services.AddDbContext<RegistroDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Agrega el servicio de repositorio al contenedor de servicios
builder.Services.AddScoped<IRepositorio, Repositorio>();
builder.Services.AddScoped<IRepositorio_Mascota, Repositorio_Mascota>();
builder.Services.AddScoped<IRepositorio_Servicio, Repositorio_Servicio>();

// Agrega servicios de la aplicación
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(ProyectoBD.Client._Imports).Assembly);

app.Run();
