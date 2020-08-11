using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise02
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string ProductName { get; set; }

        public int CategoryID { get; set; }

        // public Category Category { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "smallint")]
        public int UnitsInStock { get; set; }

        [Column(TypeName = "smallint")]
        public int UnitsOnOrder { get; set; }

        [Column(TypeName = "smallint")]
        public int ReorderLevel { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool Discontinued { get; set; }
    }
}
