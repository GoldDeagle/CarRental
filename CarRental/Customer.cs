using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarRental;

public class Customer
{
    public int CustomerID { get; set; }
    //customer property field for Customer ID
    //uses getter and setter to get customerID and set customer ID value
    public string DriversLicenseID { get; set; }
    //customer property field for DriversLicenseID
    //uses getter and setter to get Drivers License ID and set Drivers License ID value
    public string FirstName { get; set; }
    //customer property field for first name
    //uses getter and setter to get first name and set first name value
    public string LastName { get; set; }
    //customer property field for last name
    //uses getter and setter to get last name and set last name value
    public string username { get; set; }
    //customer property field for username
    //uses getter and setter to get username and set username value
    public string password {  get; set; }
    //customer property field for password
    //uses getter and setter to get password and set password value
    public string Birthdate { get; set; }
    //customer property field for Birthdate
    //uses getter and setter to get birthdate and set birthdate value
}
