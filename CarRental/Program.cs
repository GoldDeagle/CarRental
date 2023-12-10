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

        
    }
}
