using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace mymvcapp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Enter Your Username..")]
        [Display(Name = "UserName")]
        public string? Username { get; set; }

      

        [Required(ErrorMessage = "Please Enter Your Email")]
        [Display( Name = "Email")]
        public string ? Email { get; set; }



        [Required(ErrorMessage = "Please Enter Your Password..")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password Again To Confirm..")]
        [Display(Name = "Confirm-Password")]
        [DataType (DataType.Password)]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Select Gender..")]
        [Display(Name = "Gender")]
        public string? Gender { get; set; }
    }
}
