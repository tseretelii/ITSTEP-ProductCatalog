using Microsoft.AspNetCore.Identity;
using ProductCatalog.Interfaces;
using ProductCatalog.Models;
using ProductCatalog.Models.Entities;
using ProductCatalog.Models.VM.User;

namespace ProductCatalog.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public UserService(ApplicationDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public Task Login(UserLoginViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task LogOut()
        {
            throw new NotImplementedException();
        }

        public Task Regsiter(UserRegisterViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
