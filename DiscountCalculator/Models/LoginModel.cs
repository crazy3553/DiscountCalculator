using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountCalculator.Models
{
    public class LoginModel
    {
        [Display(Name ="User Name")]
        [Required(ErrorMessage ="Please Fill the User Name")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage ="Please Fill the Password")]
        public string Password { get; set; }
    }
    public class LoginStoreDetails {
      public string UserName { get; set; }
      public string password { get; set; }
    }
    public class DiscountModel
    {
        [Required(ErrorMessage = "Please Fill the Gold Price")]
        public string GoldPrice { get; set; }

        [Required(ErrorMessage = "Please Fill the Weight")]
        public string Weight { get; set; }

        [Required(ErrorMessage = "Please Fill the Discount")]
        public string Discount { get; set; }
    }
}
