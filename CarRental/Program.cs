namespace CarRental
{
    public class Program
    {
        private static CustomerAuthentication customerauthentication;
        private static List<Vehicle> vehicles;
        private static List<RequestLog> requestLogs;
        private static Customer authenticatedCustomer;
        static void Main(string[] args)
        {
            Console.WriteLine("Loading...");
            Initialize();
            Menu();
        }

        static void Initialize()
        {
            var c1 = new Customer
            {
                FirstName = "Haig",
                LastName = "Hagopian",
                username = "hhagopian11",
                password = "1234",
                DriversLicenseID = "R219-1939-5930",
                Birthdate = "06-24-2003"

            };

            var c2 = new Customer
            {
                FirstName = "Massimo",
                LastName = "Mauro",
                username = "mmauro443",
                password = "1235",
                DriversLicenseID = "Y859-9403-0604",
                Birthdate = "03-28-2002"
            };

            var v1 = new Vehicle
            {
                VIN = "JR392009581359",
                Make = "Infiniti",
                Model = "Q50",
                NumOfSeats = 3,
                RentalRate = 100.33,
            };
            var v2 = new Vehicle
            {
                VIN = "JO29485239058205",
                Make = "Acura",
                Model = "MDX",
                NumOfSeats = 7,
                RentalRate = 100.33,
            };
            var v3 = new Vehicle
            {
                VIN = "FY1134058310510",
                Make = "KIA",
                Model = "Sorento",
                NumOfSeats = 3,
                RentalRate = 100.33,
            };

            var cv1 = new RequestLog(c1, v1);
            var cv2 = new RequestLog(c2, v2);

            customerauthentication = new CustomerAuthentication();
            customerauthentication.customerauthentication.Add(c1);
            customerauthentication.customerauthentication.Add(c2);

            vehicles = new List<Vehicle>();
            vehicles.Add(v1);
            vehicles.Add(v2);
            vehicles.Add(v3);

            requestLogs = new List<RequestLog>();
            requestLogs.Add(cv1);
            requestLogs.Add(cv2);



        }

        static void Menu()
            // access to the data using a menu
        {
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Options: Login: Press 1 ----- Logout: Press 2 ----- Sign Up: Press 3 ----- Vehicle List: Press 4 ----- Clear Screen: c ----- Quit: q -----");

                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch(choice)
                    // more efficienct if else statement
                {
                    case "1":
                        LoginMenu();
                        break;
                    case "2":
                        LogoutMenu();
                        break;
                    case "3":
                        SignUpMenu();
                        break;
                    case "4":
                        GetCurrentRequestsMenu();
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    case "q":
                        done = true;
                        break;
                    default: 
                        Console.WriteLine("Invalid Input");
                        break;

                }

            }

        }

        static void LoginMenu()
        {
            if (authenticatedCustomer == null)
                // checks if customer is already logged in 
            {
                // user enters username and stores it
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();

                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                // user enters the password and stores it 

                authenticatedCustomer = customerauthentication.Authenticate(username, password);
                // authenticates the user's input 

                if (authenticatedCustomer != null)
                    // checks if the authentication is correct
                {
                    Console.WriteLine($"Welcome {authenticatedCustomer.FirstName}");
                    // user is entered in the system
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                    // if not found or invalid, then prompt error message
                }
            }
            else
            {
                Console.WriteLine($"You are already logged in as {authenticatedCustomer.username}");
                // prompt user to let them know they are already logged in if they attempt to log in again
            }
        }

        static void LogoutMenu()
        {
            authenticatedCustomer = null;
            // sets the customer to null
            Console.WriteLine("Logged out");
            // then inform them they are now logged out
        }

        static void SignUpMenu() // Method for inputting new users
        {
            Console.Write("First Name: "); // Writeline requesting customer first name
            string firstName = Console.ReadLine(); // Sets user input as firstName
            Console.Write("Last Name: "); // Writeline requesting customer last name
            string LastName = Console.ReadLine(); // Sets user input as LastName
            Console.Write("Username: "); // Writeline requesting customer username
            string username = Console.ReadLine(); // Sets user input as username
            Console.Write("Password: "); // Writeline requesting customer password
            string password = Console.ReadLine(); // Sets user input as password

            var newCustomer = new Customer // Creating a new instance of the Customer class to represent a new customer
            {
                FirstName = firstName, // Creates variable for customer first name
                LastName = LastName, // Creates variable for customer last name
                username = username, // Creates variable for customer username
                password = password // Creates variable for customer password
            };

            customerauthentication.customerauthentication.Add(newCustomer); // Creates new customer account

            Console.WriteLine("Account created!"); // Prints confirmation that user account has been created

        }


        static void GetCurrentRequestsMenu()
        {
            if (authenticatedCustomer == null)
            {
                Console.WriteLine("You are not logged in.");
                return;
            }

            var vehicleList = requestLogs.Where(o => o.customer.username == authenticatedCustomer.username);

            if(vehicleList.Count() == 0)
            {

                Console.WriteLine("0 requests found. ");
            }
            else
            {
                foreach(var vehicle in vehicleList)
                {
                    Console.WriteLine(vehicle.vehicle.RentalRate);
                }
            }
        }
    }
}
