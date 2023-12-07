using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarRental
{
    internal class Vehicle
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumOfSeats { get; set; }
        public double RentalRate { get; set; }

        public Vehicle(string vin, string make, string model, int numberOfSeats, double rentalRate)
        {
            VIN = vin;
            Make = make;
            Model = model;
            NumOfSeats = numberOfSeats;
            RentalRate = rentalRate;
        }
    }
}
