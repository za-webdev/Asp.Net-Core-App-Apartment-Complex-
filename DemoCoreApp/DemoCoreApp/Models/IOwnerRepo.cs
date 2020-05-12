using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreApp.Models
{
    public interface IOwnerRepo
    {
        Owner GetOwner(int id);
    }
}
