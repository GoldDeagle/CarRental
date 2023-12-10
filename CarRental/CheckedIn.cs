using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class CheckedIn
    {
        public Vehicle CheckedInVehicle { get; set; }
        public Employee CheckedInBy { get; set; }
        public DateTime CheckedInDate { get; set; }
       
        public CheckedIn(Vehicle checkedInVehicle, Employee employee)
        {
            CheckedInVehicle = checkedInVehicle;
            CheckedInBy = employee;
            CheckedInDate = DateTime.Now;
        }
    }

}
