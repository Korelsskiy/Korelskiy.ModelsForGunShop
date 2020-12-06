using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Korelskiy.ModelsForGunShop
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50), MinLength(2)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50), MinLength(2)]
        [
            RegularExpression
            (@"^([a - z0 - 9_ -] +\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$",
            ErrorMessage ="Введите валидный емайл(example@exam.ru)")
        ]
        public string Email { get; set; }
        [Required]
        [MaxLength(50), MinLength(2)]
        public string Password { get; set; }
    }
}
