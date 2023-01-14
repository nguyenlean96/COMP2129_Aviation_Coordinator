using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2129_GroupProject_001
{
    class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManagement bkManager;

        public AirlineCoordinator(int custIdSeed, int maxCust, int maxFlights)
        {
            flManager = new FlightManager(maxFlights);
            custManager = new CustomerManager(maxCust);
            bkManager = new BookingManagement(custIdSeed);
        }

        public bool addFlight(string origin, string destination, int maxSeats) { return flManager.addFlight(origin, destination, maxSeats); }
        public bool restoreFlight(string fid, string origin, string destination, int seat) { return flManager.restoreFlight(fid, origin, destination, seat); }
        public bool addCustomer(string fName, string lName, string phone) { return custManager.addCustomer(fName, lName, phone); }
        public bool restoreCustomer(int cid, string fn, string ln, string phone) { return custManager.restoreCustomer(cid, fn, ln, phone); }

        public bool addBooking(string fid, int cid)
        {
            //if (flManager.addPassenger(fid, custManager.getCustomer(cid)) && custManager.findCustomer(cid) != -1)
            if (custManager.findCustomer(cid) != -1 && flManager.addPassenger(fid, custManager.getCustomer(cid)))
                {
                bkManager.addBooking(flManager.getFlight(fid), custManager.getCustomer(cid));
                int bkLoc = bkManager.getBookingID(cid);
                if (bkLoc != -1)
                {
                    custManager.addBooking(cid, bkManager.getLatestBooking());
                    return true;
                }
                else return false;
            }
            return false;
        }


        public bool deleteFlight(string fid) { return flManager.deleteFlight(fid); }
        public bool deleteCustomer(int cid) { return custManager.deleteCustomer(cid); }
        public bool bookingCancellation(int bid) { return bkManager.cancelBooking(bid); }

        public int getNumOfFlight() { return flManager.getNumOfFlight(); }
        public Flight getFlight(string fid) { return flManager.getFlight(fid); }
        public Flight getLatestFlight() { return flManager.getLatestFlight(); }
        public Flight[] getFlightList() { return flManager.getFlightList(); }
        public int getAvailableSeat(string fid) { return flManager.getAvailableSeat(fid); }

        public string bookingList() { return bkManager.viewAllBookings(); }
        public string flightList() { return flManager.getAllFlights(); }
        public string viewCustomers() { return custManager.ToString(); }

        public bool customerDuplicate(string fn, string ln, string phone) { return custManager.isDuplicated(fn, ln, phone); }
        public Customer GetCustomer(int cid) { return custManager.getCustomer(cid); }
        public Customer[] getCustomerList() { return custManager.getAllCustomers(); }
        public int getNumOfActiveCustomer() { return custManager.getNumOfActive(); }
        public Customer getLatestCustomer() { return custManager.getLatestCustomer(); }
        public bool updateCustomer(int cid, string fn, string ln, string phone) { return custManager.updateCustomer(cid, fn, ln, phone); }

        // BOOKING SECTION /////////////////////////////////////////
        public Booking[] getBookingByCustomer(int cid)
        {
            return custManager.getCustomer(cid).getBookingList();
        }
        public Booking getBookingByID(int bid) { return bkManager.getBooking(bid); }
        public Booking getLatestBooking() { return bkManager.getLatestBooking(); }
        public Booking[] getAllBooking() { return bkManager.getAllBooking(); }
    }
}
