using Microsoft.EntityFrameworkCore;

namespace LoR.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(
        DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }
}