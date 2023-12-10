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
    //customer property field for CustomerID
    public string DriversLicenseID { get; set; }
    //customer property field for DriversLicenseID
    public string FirstName { get; set; }
    //customer property field for first name
    public string LastName { get; set; }
    //customer property field for last name 
    public string UserName { get; set; }
    //customer property field for username
    public string password {  get; set; }
    //customer property field for password
    public string Birthdate { get; set; }
    //customer property field for Birthdate
}
