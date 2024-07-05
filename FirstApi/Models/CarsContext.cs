using Microsoft.EntityFrameworkCore;
namespace FirstAPI.Models;

public class CarsContext : DbContext
{
    public CarsContext(DbContextOptions<CarsContext> options) : base(options)
    {
    }
    public DbSet<Cars> Cars { get; set; } = null!;
}