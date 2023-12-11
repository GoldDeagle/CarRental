using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental;

public class CustomerAuthentication
{
    public List<Customer> customerauthentication { get; set; }

    public CustomerAuthentication()
    {
        customerauthentication = new List<Customer>();
    }
    
    public Customer Authenticate(string username, string password, string DriversLicesnseID)
    {
        var c = customerauthentication.Where(o => (o.username == username) && (o.password == password) && (o.DriversLicenseID == DriversLicesnseID));
        if (c.Count() > 0)
        {
            return c.First();
        }
        else
        {
            return null;
        }
    }
}
