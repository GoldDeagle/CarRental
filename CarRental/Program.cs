namespace CarRental
{
    public class Program
    {
        private static CustomerAuthentication customerauthentication;
        private static List<Vehicle> vehicles;
        private static List<RequestLog> requestLogs;
        private static Customer authenticatedCustomer;
        // static variables for storing customer authentication,
        // list of vehicles, list of request logs, and currently authenticated customer
        static void Main(string[] args)
        {
            
            Console.WriteLine("Loading...");
            Initialize();
            // initialize the data 
            Menu();
            //  show menu and give user question prompts to answer
        }

        static void Initialize()
        {
            var c1 = new Customer
            // create customer object
            {
                FirstName = "Haig",
                LastName = "Hagopian",
                username = "hhagopian11",
                password = "1234",
                DriversLicenseID = "R219-1939-5930",
                Birthdate = "06-24-2003"
                // details needed to input for user to sign up or login
            };

            var c2 = new Customer
            // create customer object
            {
                FirstName = "Massimo",
                LastName = "Mauro",
                username = "mmauro443",
                password = "1235",
                DriversLicenseID = "Y859-9403-0604",
                Birthdate = "03-18-2002"
                // details needed to input for user to sign up or login
            };
            var c3 = new Customer
            // create customer object
            {
                FirstName = "Jayden",
                LastName = "Rajpurkar",
                username = "jraj0925",
                password = "8822",
                DriversLicenseID = "H923-3829-2245",
                Birthdate = "09-25-2002"
                // details needed to input for user to sign up or login
            };

            var v1 = new Vehicle
            // create vehicle object
            {
                VIN = "JR392009581359",
                Make = "Infiniti",
                Model = "Q50",
                NumOfSeats = 3,
                RentalRate = 100.33,
                // specs for car rental system and other misc details
            };
            var v2 = new Vehicle
            // create vehicle object
            {
                VIN = "JO29485239058205",
                Make = "Acura",
                Model = "MDX",
                NumOfSeats = 7,
                RentalRate = 100.33,
                // specs for car rental system and other misc details
            };
            var v3 = new Vehicle
            // create vehicle object
            {
                VIN = "FY1134058310510",
                Make = "KIA",
                Model = "Sorento",
                NumOfSeats = 3,
                RentalRate = 100.33,
                // specs for car rental system and other misc details
            };

            var cv1 = new RequestLog(c1, v1);
            var cv2 = new RequestLog(c2, v2);
            var cv3 = new RequestLog(c3, v3);
            // request log entry created which links customers and vehicles 

            customerauthentication = new CustomerAuthentication();
            customerauthentication.customerauthentication.Add(c1);
            customerauthentication.customerauthentication.Add(c2);
            customerauthentication.customerauthentication.Add(c3);
            // created customers gets authenticated and added to the list

            vehicles = new List<Vehicle>();
            // initialize vehicle list 
            vehicles.Add(v1);
            vehicles.Add(v2);
            vehicles.Add(v3);
            // add the created objects to the lists

            requestLogs = new List<RequestLog>();
            // initialize request log list
            requestLogs.Add(cv1);
            requestLogs.Add(cv2);
            requestLogs.Add(cv3);
            // add the created objects to the lists



        }

        static void Menu()
            // access to the data using a menu
        {
            bool done = false;
            // checks to see if the user wants to quit
            // bool initiated to control while loop

            while (!done)
                // keep looping until user wants to quit explicitly 
            {
                Console.WriteLine("Options: Login: Press 1 ----- Logout: Press 2 ----- Sign Up: Press 3 ----- Active Request Rate: Press 4 ----- Clear Screen: c ----- Quit: q -----");
                // show the menu options to the user
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                // prompts the user for our choice and then store user's input

                switch(choice)
                    // switch statement used to run what the user chooses
                {
                    case "1":
                        LoginMenu();
                        break;
                        // brings user to login menu
                    case "2":
                        LogoutMenu();
                        break;
                        // brings user to logout menu
                    case "3":
                        SignUpMenu();
                        break;
                        // brings user to signup menu
                    case "4":
                        GetCurrentRequestsMenu();
                        break;
                        // gets the current request menu
                    case "c":
                        Console.Clear();
                        break;
                        // clears the console screen for neatness and clutter
                    case "q":
                        done = true;
                        break;
                        // ends the while loop by making the bool true so user can quit
                    default: 
                        Console.WriteLine("Invalid Input");
                        break;
                        // anything else entered is counted as invalid
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
                Console.WriteLine("Enter Drivers License ID");
                string DriversLicenseID = Console.ReadLine();

                authenticatedCustomer = customerauthentication.Authenticate(username, password, DriversLicenseID);
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
            Console.WriteLine("Birthdate (Format is 00/00/0000)");//writeline requesting customer birthdate
            string Birthdate = Console.ReadLine(); // sets user input as birthdate
            Console.WriteLine("Drivers License ID (for background check purposes)");//Writeline requesting customer Drivers License ID 
            Console.WriteLine("Enter Drivers License format as X000-0000-0000");
            string DriversLicenseID = Console.ReadLine();
            var newCustomer = new Customer // Creating a new instance of the Customer class to represent a new customer
            {
                FirstName = firstName, // Creates variable for customer first name
                LastName = LastName, // Creates variable for customer last name
                username = username, // Creates variable for customer username
                password = password, // Creates variable for customer password
                Birthdate = Birthdate,
                DriversLicenseID = DriversLicenseID
            };


            customerauthentication.customerauthentication.Add(newCustomer); // Creates new customer account

            Console.WriteLine("Account created!"); // Prints confirmation that user account has been created

        }


        static void GetCurrentRequestsMenu()
        {
            if (authenticatedCustomer == null)
                // checks if the user is logged in
            {
                Console.WriteLine("You are not logged in.");
                return;
                // if not then print a statement alerting them they are not logged in
                // then return back without the user being allowed to proceed
            }

            var vehicleList = requestLogs.Where(o => o.customer.username == authenticatedCustomer.username);
            // filters the request logs to make the relevant ones for logged in user to view

            if(vehicleList.Count() == 0)
                // checks if the list has any current requests
            {

                Console.WriteLine("0 requests found. ");
                // if they do not have any, print this
            }
            else
            {
                foreach(var vehicle in vehicleList)
                    // now will iterate through each of the requests
                {
                    Console.WriteLine(vehicle.vehicle.RentalRate);
                    // then prints the rental rate for the requests filtered 
                }
            }
        }
    }
}
