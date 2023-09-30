using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunzking.Models
{
    public class Product
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Brand { get; set; }

        [Required]
        [Range(1, 1000)]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Current Price")]
        [Range(1, 1000)]
        public double CurrentPrice { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [ValidateNever]
        public Category Category { get; set; }

        [ValidateNever]
        public string ImageUrl { get; set; }


    }
}
