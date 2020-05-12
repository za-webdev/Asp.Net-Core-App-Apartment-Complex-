using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreApp.Models
{
    public class MockOwnerRepo : IOwnerRepo
    {
        private readonly List<Owner> _owner;
        public MockOwnerRepo()
        {
            _owner = new List<Owner>()
            {
                new Owner() { FirstName="Ali",LastName="Jan",ApartmentNumber="2016",UnitNumber="8", Id=1},
                new Owner() { FirstName="Hareem",LastName="Baig",ApartmentNumber="987",UnitNumber="9", Id=2},

            };

        }
        public Owner GetOwner(int Id)
        {
            return _owner.FirstOrDefault(o => o.Id == Id);
        }
    }
}
