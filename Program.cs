// COMP2129 - Advanced Object-Oriented Programming
// Group Project
// Members:
//          += Le An Nguyen - 101292266
//          += Vishvarajsinh Rana - 101307136
//          += Vraj Patel - 101327087
using System;
using static System.Console;
using System.Windows.Forms;

namespace COMP2129_GroupProject_001
{
    static class Program
    {
        static AirlineCoordinator aCoord;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            // Starting codes from professor
            aCoord = new AirlineCoordinator(100, 50, 30);

            Console.Clear();
            Console.WriteLine("\n\t|| Group Project on XYZ AirLine Ltd. ///////////////////////" +
                              "\n\t```--------------------------------- \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\" +
                              "\n\t\t`-|| Members " +
                              "\n\t\t      `-| Le An Nguyen\t\t101292266" +
                              "\n\t\t        | Vraj Patel  \t\t101327087" +
                              "\n\t\t        | Vishvarajsinh Rana\t\t" +
                              "\n\t============================================================\n");
            Console.WriteLine("Application start...");

            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            
            /* 
            runProgram();
            Console.Write("\n\n\n\n\t\tThank you for using XYZ Airlines System.\n\t\tPress any key to exit ");
            Console.ReadKey();
            */
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        public static void _header()
        {
            Console.Clear();
            Console.WriteLine("\n\t=============================================================\n\t   XYZ AirLines Limited\t////////////////////////////////////\n\t```````````````````````` \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\" +
            "\n\t-------------------------------------------------------------\n\t     Please select a choice from the menu below:\n");
        }
        public static void _footer()
        {
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }
        public static void deleteFlight()
        {
            string id;
            _header();
            Console.WriteLine(aCoord.flightList());
            Console.Write("Please enter a flight id to delete:");
            id = Console.ReadLine();

            if (aCoord.deleteFlight(id))
                Console.WriteLine("Flight with id {0} deleted..", id);
            else
                Console.WriteLine("Flight with id {0} was not found..", id);

            _footer();
        }
        public static void deleteCustomer()
        {

        }
        public static void viewAllBookings()
        {
            _header();
            WriteLine(aCoord.bookingList());
            _footer();
        }
        public static void viewFlights()
        {
            _header();
            Console.WriteLine(aCoord.flightList());
            
            _footer();
        }

        public static void viewCustomers() {
            _header();
            
            WriteLine(aCoord.viewCustomers());

            _footer();
        }
        public static void addBooking()
        {

            _header();
            WriteLine("\n-----------Add Booking----------");
            WriteLine("Booking made for: ");
            WriteLine(aCoord.viewCustomers());
            Write("Customer ID: ");
            Customer chosenCust = aCoord.GetCustomer(Convert.ToInt32(ReadLine()));
            if (chosenCust != null) WriteLine(chosenCust.getFullName() + " has been set succesfully.");
            
            if (chosenCust == null) WriteLine("Failed to select customer. Customer might not exist. Please try again");
            WriteLine("Please choose one of the listed flights below:");
            WriteLine(aCoord.flightList());
            Flight chosenFlight = aCoord.getFlight(ReadLine());
            if (chosenFlight != null) WriteLine("Flight :" + chosenFlight.getFlightNumber() + " from " + chosenFlight.getOrigin() + " to " + chosenFlight.getDestination() + " has been set succesfully.");

            if (chosenFlight == null) WriteLine("Failed to select Flight. Flight might not exist. Please try again");

            Clear();
            WriteLine(aCoord.addBooking(chosenFlight.getFlightNumber(), chosenCust.getId()) ? "Booking has been placed successfully." : "Failed to place booking.");
            _footer();
        }
        public static void addFlight()
        {
            int maxSeats;
            string origin, destination;

            _header();
            Console.WriteLine("-----------Add Flight----------");
            Write("Please the maximum number of seats: ");
            maxSeats = Convert.ToInt32(ReadLine());
            Write("Please enter the port of Origin: ");
            origin = ReadLine();
            Write("Please enter the destination port: ");
            destination = ReadLine();
            if (aCoord.addFlight(origin, destination, maxSeats))
                Console.WriteLine("Flight successfully added..");
            else Console.WriteLine("Flight was not added..");

            _footer();
        }
        public static void addCustomer()
        {
            Clear();
            WriteLine("----------Add Customer---------");
            Write("Customer's first name: ");
            string fName = ReadLine();
            Write("Customer's last name: ");
            string lName = ReadLine();
            Write("Phone Number: ");
            string phoneNo = ReadLine();
            if (aCoord.addCustomer(fName, lName, phoneNo)) WriteLine("Customer added successfully.");
            else WriteLine("Failed to add new customer.");

            _footer();
        }
        public static void showFlightMenu()
        {
            _header();
            Console.WriteLine("\t\t1: Add Flight" +
                            "\n\t\t2: View Flights" +
                            "\n\t\t3: View Flight by ID" +
                            "\n\t\t4: Cancel Flight");
            Console.WriteLine("\t\t5: Back to main menu");
        }
        public static void showBookingMenu()
        {
            _header();
            Console.WriteLine("\t\t1: Make Booking" +
                            "\n\t\t2: View Bookings");
            Console.WriteLine("\t\t3: Back to main menu");
        }
        public static void showCustomerMenu()
        {
            _header();
            Console.WriteLine("\t\t1: Add Customer" +
                            "\n\t\t2: View Customers" +
                            "\n\t\t3: Delete Customer");
            Console.WriteLine("\t\t4: Back to main menu");
        }
        public static void showMainMenu()
        {
            _header();
            Console.WriteLine("\t\t1: Customers" +
                            "\n\t\t2: Flights" +
                            "\n\t\t3: Bookings");
            Console.WriteLine("\t\t4: Exit");
            // Console.WriteLine("1: Add Flight\n2 :Add Customer\n3: View Flights\n4: View Customers");
            // Console.WriteLine("5: Delete Customer\n6: Delete Flight");
        }

        public static int getValidChoice(string catalog, int lower, int upper)
        {
            int choice;
            if (catalog == "main") showMainMenu();
            switch (catalog)
            {
                case "main":
                    showMainMenu();
                    break;
                case "cust":
                    showCustomerMenu();
                    break;
                case "flight":
                    showFlightMenu();
                    break;
                case "booking":
                    showBookingMenu();
                    break;
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < lower || choice > upper))
            {
                switch (catalog)
                {
                    case "main":
                        showMainMenu();
                        break;
                    case "cust":
                        showCustomerMenu();
                        break;
                    case "flight":
                        showFlightMenu();
                        break;
                    case "booking":
                        showBookingMenu();
                        break;
                }
                Console.Write("Please enter a valid choice:");
            }
            return choice;
        }
        public static void runProgram()
        {
            int choice = getValidChoice("main", 1, 4);
            while (choice != 4)
            {
                // Customer Menu
                if (choice == 1)
                {
                    int subChoice = getValidChoice("cust", 1, 4);
                    while (subChoice != 4)
                    {
                        // Add customer
                        if (subChoice == 1) addCustomer();
                        // View all customers
                        if (subChoice == 2) viewCustomers();
                        // Delete customer
                        if (subChoice == 3) deleteCustomer();
                        subChoice = getValidChoice("cust", 1, 4);
                    }
                }
                if (choice == 2) 
                {
                    int subChoice = getValidChoice("flight", 1, 5);
                    while (subChoice != 5)
                    {
                        // Add flight
                        if (subChoice == 1) addFlight();
                        // View all flight
                        if (subChoice == 2) viewFlights();
                        // View a flight by ID
                        if (subChoice == 3) deleteCustomer();
                        // Delete Flight
                        if (subChoice == 4) deleteFlight();
                        subChoice = getValidChoice("flight", 1, 5);
                    }
                }
                if (choice == 3) {
                    int subChoice = getValidChoice("booking", 1, 3);
                    while (subChoice != 3)
                    {
                        // Add a booking
                        if (subChoice == 1) addBooking();
                        // View all bookings
                        if (subChoice == 2) viewAllBookings();
                        // Cancel booking
                        if (subChoice == 3) deleteCustomer();
                        subChoice = getValidChoice("booking", 1, 3);
                    }
                }
                /* 
                if (choice == 4) { viewCustomers(); }
                if (choice == 5) { deleteCustomer(); }
                if (choice == 6) { deleteFlight(); }
                */
                choice = getValidChoice("main", 1, 4);
            }
        }
    }
}
