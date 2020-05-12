using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoCoreApp.Controllers
{
    public class OwnerController : Controller
    {
        public IActionResult OwnerDetails(int id)
        {

            return View();
        }
    }
}