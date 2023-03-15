global using Web_Api.Models;
using System.Configuration;
using Web_Api.Data;
using Web_Api.Services.SuperHero.Impl;
using Web_Api.Services.SuperHeroService;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISuperHero, SuperHeroImpl>();
builder.Services.AddDbContext<DataContext>(options =>
            options.UseOracle(configuration.GetConnectionString("defaultconnection")));



var app = builder.Build();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
