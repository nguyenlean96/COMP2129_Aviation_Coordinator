using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2129_GroupProject_001
{
    public class Booking
    {
        private int bookingID;
        private string bookingDate;
        private Flight chosenFlight;
        private Customer customer;

        public Booking(int id, Flight flight, Customer customer)
        {
            this.bookingID = id;
            this.bookingDate = DateTime.Now.ToString(@"MM\/dd\/yyy h\:mm tt");
            this.chosenFlight = flight;
            this.customer = customer;
        }
        public int getBookingID() { return this.bookingID; }
        public string getBookingDate() { return this.bookingDate; }
        public Flight getFight() { return this.chosenFlight; }
        public Customer getCustomer() { return this.customer; }
        public override string ToString()
        {
            return "|| " + this.getBookingID() + " ////////////////////////////////" + "\nCustomer: " + this.getCustomer().getFirstName() + " " + this.getCustomer().getLastName() + "\nBooking date: " + this.getBookingDate() + "\nFlight Number: " + this.getFight().getFlightNumber() + "\n`````````````````````````````````````````````````";
        }
    }
}
