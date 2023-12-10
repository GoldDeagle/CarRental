using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string Model { get; set; }
        public bool IsAvailable { get; set; }
        public Employee AssignedEmployee { get; set; }

        public Vehicle(int vehicleID, string model)
        {
            VehicleID = vehicleID;
            Model = model;
            IsAvailable = true; // assumes that the vehicle is initially available
        }
    }
}
