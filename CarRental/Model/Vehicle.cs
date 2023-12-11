using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Model;


internal class Vehicle
{
    public string VIN { get; set; } // Uses getter and setter to get and set Vehicle VIN
    public string Make { get; set; } // Uses getter and setter to get and set Vehicle Make
    public string Model { get; set; } // Uses getter and setter to get and set Vehicle Model
    public int NumOfSeats { get; set; } // Uses getter and setter to get and set Vehicle Number of Seats
    public double RentalRate { get; set; } // Uses getter and setter to get and set Vehicle Rental Rate
}
