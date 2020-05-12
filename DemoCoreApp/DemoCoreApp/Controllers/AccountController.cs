using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoCoreApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DemoCoreApp.Models;

namespace DemoCoreApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Owner> userManager;
        private readonly SignInManager<Owner> signInManager;

        public AccountController(UserManager<Owner> userManager, SignInManager<Owner> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var owner = new Owner(){Email = model.Email};
                var result = await userManager.CreateAsync(owner, model.Password);

                if (result.Succeeded)
                {
                   await signInManager.SignInAsync(owner, isPersistent: false);
                    return RedirectToAction("Index","Home");
                }

                foreach(var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
            }
            return View(model);
        }

    }
}