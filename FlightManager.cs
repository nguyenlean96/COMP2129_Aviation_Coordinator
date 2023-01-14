using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2129_GroupProject_001
{
    class FlightManager
    {
        private int maxFlights;
        private int numFlights;
        private Flight[] flightList;

        public FlightManager(int max)
        {
            maxFlights = max;
            numFlights = 0;
            flightList = new Flight[maxFlights];
        }

        public bool addFlight(string origin, string destination, int maxSeats)
        {
            if (numFlights < maxFlights)
            {
                Flight f = new Flight(validID(2, 3), origin, destination, maxSeats);
                this.flightList[this.numFlights] = f;
                this.numFlights++;
                return true;
            }
            return false;
        }
        public bool restoreFlight(string fid, string origin, string destination, int seat)
        {
            if (numFlights < maxFlights)
            {
                Flight f = new Flight(fid, origin, destination, seat);
                this.flightList[this.numFlights] = f;
                this.numFlights++;
                return true;
            }
            return false;
        }
        public bool addPassenger(string fid, Customer c)
        {
            int loc = findFlight(fid);
            if (loc != -1)
            {
                if (this.flightList[loc].addPassenger(c)) 
                    return true;
            }
            return false;
        } 
        private string autoGenID(int numOfChar, int numOfNum)
        {
            string output = "";
            Random rand = new Random();
            for (int i=0; i < numOfChar; i++)
            {
                output += (char)rand.Next(65, 90);
            }
            for (int i = 0; i < numOfNum; i++)
            {
                output += (char)rand.Next(48, 57);
            }
            return output;
        }
        private string validID(int numOfChar, int numOfNum)
        {
            string preID = autoGenID(numOfChar, numOfNum);
            if (this.numFlights > 0)
            {
                while (findFlight(preID) != -1)
                {
                    preID = autoGenID(numOfChar, numOfNum);
                }
            }
            return preID;
        }
        public int findFlight(string fid)
        {
            for (int x = 0; x < numFlights; x++)
            {
                if (flightList[x].getFlightNumber() == fid)
                    return x;
            }
            return -1;
        }
        public int getNumOfFlight() { return this.numFlights; }
        public bool flightExists(string fid)
        {
            int loc = findFlight(fid);
            if (loc != -1) return true;
            return false;
        }

        public Flight getFlight(string fid)
        {
            int loc = findFlight(fid);
            if (loc != -1) return flightList[loc];
            return null;
        }

        public Flight[] getFlightList() {
            Flight[] temp = new Flight[this.numFlights];
            for (int i=0; i < this.numFlights; i++)
            {
                temp[i] = this.flightList[i];
            }
            return temp;
        }
        public Flight getLatestFlight()
        {
            if (this.numFlights > 0) return this.flightList[this.numFlights - 1];
            return null;
        }
        public bool deleteFlight(string fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) return false;
            if (this.flightList[loc].getNumPassengers() > 0) return false;
            Flight[] newList = new Flight[this.maxFlights];
            for (int i = 0; i < this.flightList.Length; i++)
            {
                if (i < loc) newList[i] = this.flightList[i];
                if (i == loc) continue;
                if (i > loc) newList[i - 1] = this.flightList[i];
            }
            this.flightList = newList;
            this.numFlights--;
            return true;
        }

        public int getAvailableSeat(string fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) return -1;
            return this.flightList[loc].getAvailableSeat();
        }
        public string getAllFlights()
        {
            string s = "";
            if (this.numFlights > 0)
            {
                s += "\tFlight List ///////////////////////////////////////////////////" +
                    "\n\t```````````````````````````````````````````````````````````````";
                for (int x = 0; x < numFlights; x++)
                {
                    s += "\n\n\t |[ " + flightList[x].getFlightNumber() + " `-------------------------------------------" +
                           "\n\t      `-| From " + flightList[x].getOrigin() + " to " + flightList[x].getDestination() +
                         "\n\t------------------------------------------------------";
                }
            }
            // else s += "\n\tSorry...\n\tNo flights were booked so far.";
            return s;
        }
    }
}
