using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GnGApp.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        //ProductGroup
        public int ProductGroupID { get; set; }
        [ForeignKey("ProductGroupID")]
        public ProductGroup ProductGroup { get; set; }
    }
}
