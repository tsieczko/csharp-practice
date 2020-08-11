using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise02
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(15)")]
        public string CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        // public virtual ICollection<Product> Products { get; set;}

        public Category()
        {
            // Products = new List<Product>();
        }
    }
}
