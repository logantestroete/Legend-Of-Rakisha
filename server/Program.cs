using Microsoft.EntityFrameworkCore;
using LoR.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DatabaseConnection"));
});

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
