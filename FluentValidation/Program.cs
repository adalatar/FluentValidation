using FluentValidation;
using FluentValidation.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.

builder.Services.AddServices(config);
var app = builder.Build();

// Configure the HTTP request pipeline.



app.MapControllers();

app.Run();
