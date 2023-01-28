using System.ComponentModel.DataAnnotations;

namespace PaylodeWeatherAPI.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "First Name is required")]
        public string? FirstName { get; set; }


        [Required(ErrorMessage = "Last Name is required")]
        public string? LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]

        public string? Email { get; set; }

        [Required(ErrorMessage = "password is required")]
        [Compare("ConfirmPassword")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "you need to confirm password")]
        public string? ConfirmPassword { get; set; }

    }
}
