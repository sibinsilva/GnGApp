using System.ComponentModel.DataAnnotations;

namespace GnGApp.Models
{
    public class ProductGroup
    {
        [Key]
        public int ID { get; set; }
        public string ParentGroup { get; set; }
        public string SubGroup { get; set; }

        //Relationships
        public List<Product> Products { get; set; }
    }
}
