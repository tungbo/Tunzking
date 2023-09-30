using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunzking.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Category Name")]
        [RegularExpression("^(?=.*[a-zA-Z])[a-zA-Z0-9-]+$", ErrorMessage = "Category Name must contain at least on letter")]
        public string Name { get; set; }
        public string? Description { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
