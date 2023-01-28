using Microsoft.AspNetCore.Identity;
using PaylodeWeatherAPI.Models;

namespace PaylodeWeatherAPI.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> RegisterAsync(RegisterModel registerModel);

        Task<string> LoginAsync(LoginModel loginModel);

    }
}
