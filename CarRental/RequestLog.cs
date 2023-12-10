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

        public Vehicle vehicle { get; set; }

    }

    public RequestLog(Customer c, Vehicle v)
    {
        customer = c;
        vehicle = v;
    }

}
