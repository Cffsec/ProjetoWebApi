using ProjetoWebApi.Contexts;
using ProjetoWebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ProjetoContext,ProjetoContext>();
builder.Services.AddControllers();
builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();
builder.Services.AddTransient<UsuarioRepository, UsuarioRepository>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints=>
{
    endpoints.MapControllers();
});

app.Run();

