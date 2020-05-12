using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoCoreApp.Models;
using DemoCoreApp.DBAccess;
using Microsoft.AspNetCore.Http;
using DemoCoreApp.ViewModels;
using DemoCoreApp.Services;

namespace DemoCoreApp.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IOwnerVehicleRepo _ownerVehicleRepo;
        private readonly IAppService _appService;

        public HomeController(IOwnerVehicleRepo owerVehicleRepo, IAppService appService)
        {
            _ownerVehicleRepo = owerVehicleRepo;
            _appService = appService;

        }
        [Route("")]
        [Route("~/")]
        
        public ViewResult Index()
        {
            var id = HttpContext.Session.GetInt32("ownerId");
            if ( HttpContext.Session.GetInt32("ownerId") != null)
            {
                return View();
            }
            else
            {
                return View("../Login/Login");
            }
        }

        //[HttpGet]
        //[Route("Login")]
        //public ViewResult Login()
        //{
        //    return View("../Home/Login");
        //}

        [HttpGet]
        [Route("About")]
        public IActionResult About()
        {
            var listOfVehicles = _appService.GetAllVehicles();

            return View(listOfVehicles);
        }

        [HttpGet]
        [Route("Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        //[HttpPost]
        //[Route("Login")]
        //public IActionResult UserLogin(Owner owner)
        //{
        //    if (ModelState.IsValid)
        //    {
        //       var isValid = _ownerVehicleRepo.Login(owner.Email, owner.Password);
        //        if (isValid)
        //        {
        //            HttpContext.Session.SetInt32("ownerId", owner.Id);
        //            ViewBag.IsValid = "Login Successful";
        //        }
        //        else
        //        {
        //            ViewBag.IsValid = "Eamil or password is incorrect";
        //        }
        //        return RedirectToAction("", "Home");
        //    }
        //    else
        //    {
        //        return View("../Home/Login");
        //    }
            
        //}

        [HttpGet]
        [Route("CreateAccount")]
        public ViewResult CreateAccount()
        {
            return View("../Owner/AddEditOwner");
        }

        [HttpPost]
        [Route("AddUpdateAccount")]
        public RedirectToActionResult AddUpdateAccount(Owner owner)
        {
           _appService.UpSertOwenrInfo(owner);
            //ViewBag.Success = isSuccessful; 
           return RedirectToAction("");
        }

        [HttpPost]
        [Route("ValidateOwner")]
        public RedirectToActionResult ValidateOwner(Owner owner)
        {
            if (!string.IsNullOrWhiteSpace(owner.Email) && !string.IsNullOrWhiteSpace(owner.ApartmentNumber))
            {
                owner.Id = _appService.ValidateOwnerInfo(owner.Email, owner.ApartmentNumber);
            }

           HttpContext.Session.SetInt32("ownerId", owner.Id);
            return RedirectToAction("Register","Vehicle");
        }

        [HttpPost]
        [Route("FindVehicle")]
        public ViewResult SearchForVehicle(Vehicle vehicle)
        {
            var viewModel = new OwnerVehicleViewModel();
            if (!string.IsNullOrWhiteSpace(vehicle.RegistrationNumber))
            {
               viewModel = _appService.GetOwnerVehicleInfo(vehicle.RegistrationNumber);
            }
            return View("../Vehicle/VehicleInfo",viewModel);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
