using Microsoft.AspNetCore.Identity;

namespace MerchandiseControl;

public class MerchandiseViewModel
{
    public required string Name { get; set; }
    public string Brand { get; set; }
    public string ExpirationDate {get; set;}
}
