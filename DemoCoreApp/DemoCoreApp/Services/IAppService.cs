﻿using DemoCoreApp.Models;
using DemoCoreApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreApp.Services
{
   public interface IAppService
    {
        List<Vehicle> GetAllVehicles();
        void UpSertOwenrInfo(Owner owner);
        int ValidateOwnerInfo(string email, string apartmentNum);
        void UpsertVehicleInfo(Vehicle vehicle, int ownerId);
        OwnerVehicleViewModel GetOwnerVehicleInfo(string registrationNumber);
        Vehicle GetVehicleInfo(int vehicleId);
        int Login(string email, string password);

    }
}
