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
    public class Vehicle // Creates Vehicle Class
    {
        public string VIN { get; set; } // Uses getter and setter to get and set Vehicle VIN
        public string Make { get; set; } // Uses getter and setter to get and set Vehicle Make
        public string Model { get; set; } // Uses getter and setter to get and set Vehicle Model
        public int NumOfSeats { get; set; } // Uses getter and setter to get and set Vehicle Number of Seats
        public double RentalRate { get; set; } // Uses getter and setter to get and set Vehicle Rental Rate
    }
}