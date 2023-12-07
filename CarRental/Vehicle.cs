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
    public enum VehicleType
    {
        Leisure, Utility
    }
    public class Vehicle
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumOfSeats { get; set; }
        public double RentalRate { get; set; }
        public VehicleType Type { get; set; }

        public bool IsRented { get; private set; } // Tracks rental status
        public Vehicle(string vin, string make, string model, int numberOfSeats, double rentalRate, VehicleType type)
        {
            VIN = vin;
            Make = make;
            Model = model;
            NumOfSeats = numberOfSeats;
            RentalRate = rentalRate;
            Type = type;

            IsRented = false; // Initialize IsRented to false when creating a new vehicle
        }
        // Method to update the rental status of a vehicle
        public void SetRentalStatus(bool isRented)
        {
            IsRented = isRented;

            if (isRented)
            {
                Console.WriteLine($"Vehicle with VIN {VIN} is now rented.");
            }
            else
            {
                Console.WriteLine($"Vehicle with VIN {VIN} is now available for rent.");
            }
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"VIN: {VIN}, Make: {Make}, Model: {Model}, Seats: {NumOfSeats}, Rental Rate: {RentalRate:C}, Type: {Type}");
        }
        public static void CreateNewVehicle(List<Vehicle> vehicles, string vin, string make, string model, int numberOfSeats, double rentalRate, VehicleType type)
        {
            if (vehicles.Exists(vehicle => vehicle.VIN == vin))
            {
                Console.WriteLine($"Vehicle with VIN {vin} already exists.");
                return;
            }

            Vehicle newVehicle = new Vehicle(vin, make, model, numberOfSeats, rentalRate, type);

            vehicles.Add(newVehicle);

            Console.WriteLine("New vehicle added successfully.");
        }
    }
}
