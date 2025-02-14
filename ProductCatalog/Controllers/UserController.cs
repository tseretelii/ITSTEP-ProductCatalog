using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Interfaces;

namespace ProductCatalog.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService service)
        {
            _userService = service;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
