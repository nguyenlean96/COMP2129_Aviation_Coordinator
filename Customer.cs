using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2129_GroupProject_001
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int numOfBooking;
        private Booking[] bookings;

        public Customer(int cId, string fname, string lname, string ph)
        {
            this.bookings = new Booking[this.numOfBooking];
            this.numOfBooking = 0;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }

        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getFullName() { return this.getFirstName() + " " + this.getLastName(); }
        public string getPhone() { return phone; }
        public bool update(string fn, string ln, string phone)
        {
            this.firstName = fn;
            this.lastName = ln;
            this.phone = phone;
            return true;
        }
        public bool addBooking(Booking booking)
        {
            this.numOfBooking++;
            if (this.numOfBooking > 1)
            {
                if (!isBookingExist(booking.getBookingID()))
                {
                    Booking[] newList = new Booking[this.bookings.Length];
                    for (int i = 0; i < newList.Length; i++)
                    {
                        newList[i] = this.bookings[i];
                    }
                    this.bookings = new Booking[this.numOfBooking];
                    for (int k=0; k < newList.Length; k++)
                    {
                        this.bookings[k] = newList[k];
                    }
                    this.bookings[this.numOfBooking - 1] = booking;
                    return true;
                }
                else return false;
            }
            else if (this.numOfBooking == 1)
            {
                this.bookings = new Booking[this.numOfBooking];
                this.bookings[0] = booking;
                return true;
            }
            return false;
        }
        public bool isBookingExist(int bid)
        {
            if (this.numOfBooking > 0)
            {
                foreach (Booking b in this.bookings)
                {
                    if (b.getBookingID() == bid) return true;
                }
            }
            return false;
        }
        public int getNumBookings() { return this.numOfBooking; }
        public Booking[] getBookingList() { return this.bookings; }
        public bool setInactive()
        {
            if (this.bookings.Length == 0)
            {
                this.firstName = null;
                this.lastName = null;
                this.phone = null;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string s = "\n[ " + customerId + " ] " + firstName + " " + lastName;
            s +=       "\n   `-| Phone: " + phone;
            s +=       "\n     | Number of Bookings: " + this.numOfBooking;
            s +=       "\n-----------------------------------------------------------";

            return s;
        }
    }
}
