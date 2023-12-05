using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string DriversLicenseID { get; set; }
        public string Birthdate { get; set; }



        public Customer(int customerID, string driversLicenseID, string birthdate)
        {
            CustomerID = customerID;
            DriversLicenseID = driversLicenseID;
            Birthdate = birthdate;
        }
        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer ID: {CustomerID}");
            Console.WriteLine($"Driver's License Number: {DriversLicenseID}");
            Console.WriteLine($"Birthdate: {Birthdate}");
        }

    }
}
