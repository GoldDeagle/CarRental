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
        private int rl_id;
        private int cust_id;
        private string vin;
        // these are private fields so I can only access them within the class
        // but also there for storing data in this class

        public int GetRequestLogId()
        {
            return rl_id;
        }
        // gets the value of Request Log ID
        public void SetRequestLogId(int rlId)
        {
            // use if else statement for validation of user entry
            // if user enters an invalid ID number (0), then it would print error message
            if (rlId == 0)
            {
                Console.WriteLine("Invalid Request Log ID");
            }
            else
            {
                rl_id = rlId;
                // if request log number is valid, then set to private field
            }
        }

        
        public int GetCustomerId()
        {
            return cust_id;
        }
        // get value of customer ID
        public void SetCustomerId(int customerId)
        {
            // if user enters an invalid number such as zero, then it would print an error message
            if (customerId == 0)
            {
                Console.WriteLine("Invalid Customer ID");
            }
            else
            {
                cust_id = customerId;
                // anything else would be valid and set it to a private field
            }
        }

        
        public string GetVIN()
        {
            return vin;
        }
        // get value of VIN

        public void SetVIN(string vehicleIdentificationNumber)
        {
            if (!string.IsNullOrEmpty(vehicleIdentificationNumber))
            {
                vin = vehicleIdentificationNumber;
                // Use of ChatGPT recommeded to use the "!" and .IsNullOrEmpty
                // the latter checks if the string is either null or empty and is true if is either or
                // "!" is used to do the opposite of .IsNullOrEmpty
                // now it becomes true if is neither null or empty
            }
            else
            {
                Console.WriteLine("Invalid VIN number");
                // else statement used if user enter an invalid statement to which it would print an error message
            }
        }

    }
}
