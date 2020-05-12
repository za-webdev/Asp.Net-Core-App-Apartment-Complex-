using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreApp.Models
{
    public class MockVehicleRepo 
    {
        private readonly List<Vehicle> _vehicles;
        public MockVehicleRepo()
        {
            _vehicles = new List<Vehicle>()
            {
                new Vehicle() { VehicleId=1,RegistrationNumber="1234",Make="2016",Model="Honda",Color="Red"},
                new Vehicle() { VehicleId=2,RegistrationNumber="45676",Make="2018",Model="Civic",Color="Silver"},

            };

        }
        //public Vehicle GetVehicle(int Id)
        //{
        //    return _vehicles.FirstOrDefault(v => v.VehicleId == Id);
        //}

        public List<Vehicle> GetAllVehicles()
        {
            return _vehicles;
        }
    }
}
