using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Blush.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Product Category")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display order must between 1-100")      ]
        public int DisplayOrder  { get; set; }

    }
}
