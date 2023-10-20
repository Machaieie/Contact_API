using Contacto.Data;
using Contacto.Repositorys;
using Contacto.Repositorys.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer("Data source=OLOGA_PROGRAMS\\SQLEXPRESS;initial catalog=MeuSistema; integrated security=false; User ID=OLOGA_Programs\\EDWIN-OLOGA;Password=;Trusted_Connection=True;TrustServerCertificate=True;"));
builder.Services.AddScoped<IContacto, ContactoRepository>();
builder.Services.AddScoped<IUsuario, UsuarioRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
