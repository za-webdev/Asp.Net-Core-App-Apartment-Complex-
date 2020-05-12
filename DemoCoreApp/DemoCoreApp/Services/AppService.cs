using DemoCoreApp.Models;
using DemoCoreApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreApp.Services
{
    public class AppService : IAppService
    {
        private readonly IOwnerVehicleRepo _ownerVehicleRepo;
        public AppService(IOwnerVehicleRepo owerVehicleRepo)
        {
            _ownerVehicleRepo = owerVehicleRepo;
        }

        public List<Vehicle> GetAllVehicles()
        {
           return _ownerVehicleRepo.GetAllVehicles();
        }

        public void UpSertOwenrInfo(Owner owner)
        {
            _ownerVehicleRepo.UpSertOwenrInfo(owner);
        }

        public int ValidateOwnerInfo(string email, string apartmentNum)
        {
          return  _ownerVehicleRepo.ValidateOwnerInfo(email,apartmentNum);
        }

        public void UpsertVehicleInfo(Vehicle vehicle, int ownerId)
        {
            _ownerVehicleRepo.UpsertVehicleInfo(vehicle,ownerId);
        }

        public OwnerVehicleViewModel GetOwnerVehicleInfo(string registrationNumber)
        {
            return _ownerVehicleRepo.GetOwnerVehicleInfo(registrationNumber);
        }

        public  Vehicle GetVehicleInfo(int vehicleId)
        {
            return _ownerVehicleRepo.GetVehicleInfo(vehicleId);
        }

        public int Login(string email, string password)
        {
            return _ownerVehicleRepo.Login(email, password);
        }
    }
}
