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
        public string Title { get; set; }
        [Required]
       // [RegularExpression("pattern", ErrorMessage = "error message")]
        public string Producer { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string PhotoPath { get; set; }
        public Cat? Category { get; set; }
    }
}
