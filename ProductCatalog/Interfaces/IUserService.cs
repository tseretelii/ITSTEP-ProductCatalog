using ProductCatalog.Models.VM.User;

namespace ProductCatalog.Interfaces
{
    public interface IUserService
    {
        Task Regsiter(UserRegisterViewModel model);
        Task Login(UserLoginViewModel model);
        Task LogOut();
    }
}
