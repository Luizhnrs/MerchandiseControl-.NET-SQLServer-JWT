
namespace MerchandiseControl;

public class MerchandiseRepository : IMerchandiseRepository
{
    private readonly ConnectionContext _context = new ConnectionContext();
    public void add(Merchandise merchandise)
    {
        _context.Merchandises.Add(merchandise);
        _context.SaveChanges();
    }

    public List<Merchandise> get()
    {
        throw new NotImplementedException();
    }
}
