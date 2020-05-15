using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoCoreApp.Models;
using DemoCoreApp.Services;
using DemoCoreApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoCoreApp.Controllers
{
    [Route("[controller]")]
    public class VehicleController : Controller
    {
        
        private readonly IOwnerVehicleRepo _ownerVehicleRepo;
        private readonly IAppService _appService;

        public VehicleController(IOwnerVehicleRepo vehicleRepo, IAppService appService)
        {
            _ownerVehicleRepo = vehicleRepo;
            _appService = appService;
        }

        [HttpGet]
        [Authorize]
        [Route("Register")]
        public ViewResult Register()
        {
            return View("../Vehicle/RegisterVehicle");
        }

        [HttpGet]
        [Route("Edit/{Id?}")]
        public ViewResult EditVehicelInfo(int Id)
        {
            var vehicle = _appService.GetVehicleInfo(Id);
            var viewModel = new VehicleViewModel()
            {
                VehicleOwnerId = vehicle.VehicleOwnerId,
                VehicleId = vehicle.VehicleId,
                Make = vehicle.Make,
                Model = vehicle.Model,
                Color = vehicle.Color,
                RegistrationNumber = vehicle.RegistrationNumber
            };
            return View("../Vehicle/EditVehicle", viewModel);
        }

        [HttpPost]
        [Route("Edit")]
        public ViewResult Edit(VehicleViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var vehicle = new Vehicle()
                {
                    VehicleOwnerId = viewModel.VehicleOwnerId,
                    VehicleId = viewModel.VehicleId,
                    Make = viewModel.Make,
                    Model = viewModel.Model,
                    Color = viewModel.Color,
                    RegistrationNumber = viewModel.RegistrationNumber
                };
                _appService.UpsertVehicleInfo(vehicle, vehicle.VehicleOwnerId.Value);
                return View("../Vehicle/VehicleInfo", vehicle);
            }
            else
            {
                return View("../Vehicle/EditVehicle", viewModel);
            }
        }

        [HttpPost]
        [Authorize]
        [Route("RegisterVehicle")]
        public IActionResult RegisterVehicle(VehicleViewModel viewModel)
        {
            if (ModelState.IsValid) {
                var vehicle = new Vehicle()
                {
                    VehicleId = viewModel.VehicleId,
                    Make = viewModel.Make,
                    Model = viewModel.Model,
                    Color = viewModel.Color,
                    RegistrationNumber = viewModel.RegistrationNumber
                };
                var ownerId = HttpContext.Session.GetInt32("ownerId");
                _appService.UpsertVehicleInfo(vehicle, ownerId.Value);
                return RedirectToAction("", "Home");
            }
            else
            {
                return View("../Vehicle/RegisterVehicle");
            }
        }
        //public string VehicleInfo()
        //{
        //  return  _vehicleRepo.GetVehicle(1).RegistrationNumber;
        //}

        //public ViewResult VehicleInfo()
        //{
        //    Vehicle vehicleModel =  _vehicleRepo.GetVehicle(1);
        //    return View("../Home/About", vehicleModel); // relative path no file extention if View/Home/About.cshtml
        //}
        //[Route("VehicleInfo/{vid?}")]

        //public ViewResult VehicleInfo(int vid)
        //{
        //    OwnerVehicleViewModel viewModel = new OwnerVehicleViewModel()
        //    {
        //        Vehicle = _vehicleRepo.GetVehicle(vid)
        //        //Owner = _ownerRepo.GetOwner(oid)
        //    };
        //    //Vehicle vehicleModel = _vehicleRepo.GetVehicle(1);
        //    //Owner owenerModel = _ownerRepo.GetOwner(1);

        //    //ViewBag.RegistrationNumber = vehicleModel.RegistrationNumber;
        //    //ViewData["Vehicle"] = vehicleModel; // passing losely type Viewdata dynamically resolved at on run time.
        //    return View(viewModel);
        //}

        [Route("GetAll")]
        public ViewResult GetAllVehicles()
        {
            List<Vehicle> vehicles = _appService.GetAllVehicles();
            return View("../Home/About", vehicles);
        }
    }
}