using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2129_GroupProject_001
{
    class BookingManagement
    {
        private int maxNumOfBooking;
        private int numOfBooking;
        private Booking[] bookingList;
        public BookingManagement(int max)
        {
            this.maxNumOfBooking = max;
            this.numOfBooking = 0;
            this.bookingList = new Booking[this.maxNumOfBooking];
        }
        public bool addBooking(Flight flight, Customer customer)
        {
            if (this.numOfBooking < this.maxNumOfBooking)
            {
                this.bookingList[this.numOfBooking] = new Booking((this.numOfBooking), flight, customer);
                this.numOfBooking++;
                return true;
            }
            return false;
        }
        public int findBooking(int bid)
        {
            for (int i=0; i < this.bookingList.Length; i++)
            {
                if (this.bookingList[i].getBookingID() == bid) return i;
            }
            return -1;
        }
        public Booking getBooking(int bid)
        {
            int loc = findBooking(bid);
            if (loc != -1)
                return this.bookingList[loc];
            return null;
        }
        public int getBookingID(int cid)
        {
            for (int i=0; i < this.numOfBooking; i++ )
            {
                if (this.bookingList[i].getCustomer().getId() == cid) return i;
            }
            return -1;
        }
        public bool cancelBooking(int bid)
        {
            int loc = findBooking(bid);
            if (loc == -1) return false;
            Booking[] newList = new Booking[this.maxNumOfBooking];
            for (int i = 0; i < this.bookingList.Length; i++)
            {
                if (i < loc) newList[i] = this.bookingList[i];
                if (i == loc) continue;
                if (i > loc) newList[i - 1] = this.bookingList[i];
            }
            this.bookingList = newList;
            // this.bookingList[loc] = bookingList[numOfBooking - 1];
            this.numOfBooking--;
            return true;
        }
        public int getNumOfActiveBooking() { return this.numOfBooking; }

        public Booking[] getAllBooking()
        {
            if (this.numOfBooking > 0)
            {
                Booking[] currentList = new Booking[this.numOfBooking];
                for (int i=0; i < this.numOfBooking; i++)
                {
                    currentList[i] = this.bookingList[i];
                }
                return currentList;
            }
            return null;
        }
        public Booking getLatestBooking()
        {
            return this.bookingList[this.numOfBooking - 1];
        }
        public string viewAllBookings()
        {
            string output = "Booking List:\n";
            if (this.numOfBooking > 0)
            {
                for (int i = 0; i < this.numOfBooking; i++)
                {
                    output += "\n\t|| " + Convert.ToString(Convert.ToInt32(this.bookingList[i].getBookingID())) + " ///////////////////////"
                            + "\n\t  `-| Flight Number: " + this.bookingList[i].getFight().getFlightNumber() +
                              "\n\t    | Customer: " + this.bookingList[i].getCustomer().getFullName() + 
                              "\n\t    | From " + this.bookingList[i].getFight().getOrigin() + " to " + this.bookingList[i].getFight().getDestination() +
                              "\n\t--------------------------------------------------------";
                }
            }
            // output += "\nThis list contains " + this.bookingList.Length + " bookings";
            else output += "\n\tSorry...\n\tNo booking history found.";
            return output;
        }
    }
}
