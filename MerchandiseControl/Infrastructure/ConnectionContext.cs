using Microsoft.EntityFrameworkCore;

namespace MerchandiseControl;

public class ConnectionContext : DbContext
{
    public DbSet <Merchandise> Merchandises {get; set;}
}
