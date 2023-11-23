namespace MerchandiseControl;

public interface IMerchandiseRepository
{
    void add (Merchandise merchandise);
    List<Merchandise> get();
}
