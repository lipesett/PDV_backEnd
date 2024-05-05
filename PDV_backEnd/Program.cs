using Microsoft.EntityFrameworkCore;
using PDV_backEnd.Data;
using PDV_backEnd.Repositories;
using PDV_backEnd.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddEntityFrameworkNpgsql().AddDbContext<PDVDbContext>(
//    options => options.UseNpgsql(builder.Configuration.GetConnectionString("PDV_Postgres")));

var connectionString = builder.Configuration.GetConnectionString("PDV_MySql");
builder.Services.AddDbContext<PDVDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


builder.Services.AddScoped<IKartodromoRepositorio, KartodromoRepositorio>();
builder.Services.AddScoped<IStatusRepositorio, StatusRepositorio>();
builder.Services.AddScoped<ITemporadaRepositorio, TemporadaRepositorio>();


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
