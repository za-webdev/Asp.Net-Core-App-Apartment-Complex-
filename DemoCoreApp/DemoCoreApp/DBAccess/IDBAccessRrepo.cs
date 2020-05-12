using DemoCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreApp.DBAccess
{
    public  interface IDBAccessRrepo 
    {
        List<Vehicle> GetAllVehicles();
    }
}
