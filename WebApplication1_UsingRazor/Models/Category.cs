using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication1_UsingRazor.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Invalid Number")]
        public int DisplayOrder { get; set; }
    }
}
