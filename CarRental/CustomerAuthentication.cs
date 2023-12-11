using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental;

public class CustomerAuthentication
{
    public List<Customer> customerauthentication { get; set; }
    //getting and setting a customer's login as into the computers local file on their programming

    public CustomerAuthentication()
    {
        customerauthentication = new List<Customer>();
    }
    //creating no-arg customer authentication constructor as a list 
    public Customer Authenticate(string username, string password, string DriversLicesnseID)
    {//creating autenticated constructor for Customer Authentication class
        //customer will need to enter in username, password, and drivers license ID, in order to view rental rate
        var c = customerauthentication.Where(o => (o.username == username) && (o.password == password) && (o.DriversLicenseID == DriversLicesnseID));
        //Allows customer username, password, and birthdate to be checked through if statement below
        if (c.Count() > 0)
        {
            return c.First();
            //parameters for each input is a 1 or greater amount of characters, returns the next input for customer to enter

        }
        else
        {
            return null;
        }
    }
}
