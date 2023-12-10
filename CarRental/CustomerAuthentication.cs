using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental;

public class CustomerAuthentication
{
    public List<Customer> customers { get; set; }

    public CustomerAuthentication()
    {
        customers = new List<Customer>();
    }
    public Customer Authenticate(string username, string password)
    {
        var c = customers.Where(o => (o.UserName == username) && (o.password == password));
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
