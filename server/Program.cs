using Microsoft.EntityFrameworkCore;
using LoR.Data;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DatabaseConnection"));
});

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

var app = builder.Build();

app.MapControllers();

app.Run();
