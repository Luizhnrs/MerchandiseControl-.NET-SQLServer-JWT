using Microsoft.EntityFrameworkCore;

namespace MerchandiseControl;

public class ConnectionContext : DbContext
{
    public DbSet <Merchandise> Merchandises {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Initial Catalog= MerchandiseControl; TrustServerCertificate=True; Integrated Security=true; ");
}
