using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace CarRental
{
    public class RequestLog
    {
        public Customer customer { get; set; }
        // customer property gets and obtains the associated information about customer


        public Vehicle vehicle { get; set; }
        // vehicle property gets and obtains the associated information about customer
    }

    public RequestLog(Customer c, Vehicle v)
        // public constructor 'c' and 'v' parameters intializing the info with vehicle and customer
    {
        customer = c;
        vehicle = v;
        // sets the associated objects with the properties of customer and vehicle
    }

}
