using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class CheckedOut
    {
        public Vehicle CheckedOutVehicle { get; set; }
        public Employee CheckedOutBy { get; set; }
        public DateTime CheckedOutDate { get; set; }

        public CheckedOut(Vehicle checkedOutVehicle, Employee checkedOutBy, DateTime checkedOutDate)
        {
            CheckedOutVehicle = checkedOutVehicle;
            CheckedOutBy = checkedOutBy;
            CheckedOutDate = checkedOutDate;
        }
    }
}
