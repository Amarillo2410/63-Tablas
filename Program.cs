using Microsoft.EntityFrameworkCore;
using ModeloTransporta.src.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySqlDB"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySqlDB"))
    ));

var app = builder.Build();
app.Run();