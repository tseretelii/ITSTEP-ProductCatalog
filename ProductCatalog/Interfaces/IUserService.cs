using Microsoft.AspNetCore.Identity;
using ProductCatalog.Models.VM.User;

namespace ProductCatalog.Interfaces
{
    public interface IUserService
    {
        Task<IdentityResult> Regsiter(UserRegisterViewModel model);
        Task Login(UserLoginViewModel model);
        Task LogOut();
    }
}
