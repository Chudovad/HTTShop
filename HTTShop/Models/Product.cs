using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HTTShop.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
        public bool available { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
