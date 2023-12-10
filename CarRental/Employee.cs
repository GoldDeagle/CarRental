using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }

        public Employee(int employeeID, string firstName, string lastName, string contactNumber)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            ContactNumber = contactNumber;
        }

        public List<Vehicle> ManagedVehicles { get; set; } = new List<Vehicle>();

    }
}
