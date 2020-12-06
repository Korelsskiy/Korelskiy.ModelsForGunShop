using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Korelskiy.ModelsForGunShop
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50), MinLength(2)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50), MinLength(2)]
        // [RegularExpression("pattern", ErrorMessage = "error message")]
        public string Producer { get; set; }
        [Required]
        [MaxLength(50), MinLength(2)]
        public string Country { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string PhotoPath { get; set; }
        public Cat? Category { get; set; }
    }
}
