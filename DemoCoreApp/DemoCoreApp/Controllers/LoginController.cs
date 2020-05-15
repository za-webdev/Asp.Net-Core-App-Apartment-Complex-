using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoCoreApp.Models;
using DemoCoreApp.Services;
using DemoCoreApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoCoreApp.Controllers
{

    public class LoginController : Controller
    {
        private readonly IOwnerVehicleRepo _ownerVehicleRepo;
        private readonly IAppService _appService;

        public LoginController(IOwnerVehicleRepo owerVehicleRepo, IAppService appService)
        {
            _ownerVehicleRepo = owerVehicleRepo;
            _appService = appService;
        }

        [HttpGet]
        [Route("Login")]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult UserLogin(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.OwnerId = _appService.Login(viewModel.Email, viewModel.Password);
                if (viewModel.OwnerId >0)
                {
                    HttpContext.Session.SetInt32("ownerId", viewModel.OwnerId.Value);
                    return RedirectToAction("","Home");
                }
                else
                {

                    viewModel.Messages.Add("Eamil or password is incorrect");
                }
                return View("../Login/Login", viewModel);
            }
            else
            {
                return View("../Login/Login");
            }

        }
    }
}