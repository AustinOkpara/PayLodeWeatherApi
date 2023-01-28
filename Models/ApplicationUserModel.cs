using Microsoft.AspNetCore.Identity;

namespace PaylodeWeatherAPI.Models
{
    public class ApplicationUserModel : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

    }
}
