using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
        public async Task Login(UserLoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password,isPersistent:false,lockoutOnFailure:false);

        }

        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> Regsiter(UserRegisterViewModel model)
        {
            User user = new User()
            {
                UserName = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            //Console.WriteLine(result.ToString());
            return result;
            //throw new NotImplementedException();
        }
    }
}
