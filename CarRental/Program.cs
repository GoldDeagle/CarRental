namespace CarRental
{
    public class Program
    {
        private static Customers customers;
        private static List<Appointment> appointments;
        private static List<CustomerAppointment> customerAppointments;
        static void Main(string[] args)
        {
            Console.WriteLine("Loading...");
            Initialize();
        }

        static void Initialize()
        {
            var c1 = new Customer
            {
                FirstName = "Test",
                LastName = "Test",
                UserName = "Test",

            };

            var c2 = new Customer
            {
                FirstName = "Test",
                LastName = "Test",
                UserName = "Test",
            };

            var a1 = new Appointment();
            var a2 = new Appointment();
            var a3 = new Appointment();


            
        }

        static void Menu()
            // access to the data using a menu
        {
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Options: Login: Press 1 ----- SignUp: Press 2 ----- Quit: Press 3");

                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch(choice)
                    // more efficienct if else statement
                {
                    case "1":
                        LoginMenu();
                        break;
                    case "2":
                        SignUpMenu();
                        break;
                    case "3":
                        done = true;
                        break;
                    default: Console.WriteLine("Invalid Input");
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

                authenticatedCustomer = customers.Authenticate(username, password);
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
                Console.WriteLine($"You are already logged in as {authenticatedCustomer.Username}");
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


    }
}
