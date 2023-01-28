using System.ComponentModel.DataAnnotations;

namespace PaylodeWeatherAPI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required to proceed")] 
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required to proceed")]

        public string? Password { get; set; }


    }
}
