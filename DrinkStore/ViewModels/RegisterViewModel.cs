using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStore.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="UserName")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",
            ErrorMessage ="Password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
