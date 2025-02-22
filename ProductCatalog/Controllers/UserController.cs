﻿using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Interfaces;
using ProductCatalog.Models.VM.User;

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
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _userService.Regsiter(model);
            }
            return RedirectToAction("Index", "Home");
            //return redirect
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _userService.Login(model);
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> LogOut()
        {
            await _userService.LogOut();

            return RedirectToAction("Index", "Home");
        }
    }
}
