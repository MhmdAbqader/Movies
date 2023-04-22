using DevCreedApi_Net6Movies.Models;

namespace DevCreedApi_Net6Movies.Services
{
    public interface IAuthSevice
    {
        Task<AuthModel> Register(RegisterModel registerModel);
        Task<AuthModel> GetLogin(LoginModel loginModel);
    }
}
