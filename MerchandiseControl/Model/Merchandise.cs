using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace MerchandiseControl;
[Table("MerchandiseControl")]
public class Merchandise
{
    [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string expirationDate { get; set; }
        public float price { get; set; }

        public Merchandise(string name, string expirationDate, float price) 
        {
            this.name = name ?? throw new ArgumentNullException (nameof(name));
            this.expirationDate = expirationDate;
            this.price = price;
        
        }
}
