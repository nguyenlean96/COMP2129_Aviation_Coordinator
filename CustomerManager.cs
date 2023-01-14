using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2129_GroupProject_001
{
    class CustomerManager
    {
        private int maxNumOfCustomers;
        private int numOfCustomers;
        private Customer[] customerList;

        public CustomerManager(int max)
        {
            this.maxNumOfCustomers = max;
            this.numOfCustomers = 0;
            this.customerList = new Customer[this.maxNumOfCustomers];
        }
        public bool addCustomer(string fName, string lName, string phone)
        {
            if (this.numOfCustomers < this.maxNumOfCustomers)
            {
                this.customerList[numOfCustomers] = new Customer(validID(), fName, lName, phone);
                this.numOfCustomers++;
                return true;
            }
            return false;
        }
        public bool restoreCustomer(int cid, string fn, string ln, string phone)
        {
            if (this.numOfCustomers < this.maxNumOfCustomers)
            {
                this.customerList[numOfCustomers] = new Customer(cid, fn, ln, phone);
                this.numOfCustomers++;
                return true;
            }
            return false;
        }
        public bool updateCustomer(int cid, string fn, string ln, string phone)
        {
            int loc = findCustomer(cid);
            if (loc == -1) return false;
            return this.customerList[loc].update(fn, ln, phone);
        }
        private int autoGenCustID()
        {
            Random rand = new Random();
            string output = rand.Next(1, 9).ToString();
            while (output.Length < 6)
            {
                output += rand.Next(0, 9).ToString();
            }
            return Convert.ToInt32(output);
        }
        private int validID()
        {
            int id = autoGenCustID();
            while (customerExist(id)) { id = autoGenCustID(); }
            return id;
        }
        public int findCustomer(int cid)
        {
            for (int i=0; i < this.numOfCustomers; i++)
            {
                if (this.customerList[i].getId() == cid) return i;
            }
            return -1;
        }
        public bool isDuplicated(string fn, string ln, string phone)
        {
            bool duplicated = false;
            if (this.numOfCustomers > 0)
            {
                for (int i=0; i < this.numOfCustomers; i++)
                {
                    if (fn == this.customerList[i].getFirstName() && ln == this.customerList[i].getLastName() && phone == this.customerList[i].getPhone())
                        duplicated = true;
                }
            }
            return duplicated;
        }
        public bool customerExist(int cid)
        {
            int loc = findCustomer(cid);
            if (loc != -1) return true;
            return false;
        }
        public Customer getCustomer(int cid)
        {
            int loc = findCustomer(cid);
            if (loc != -1)
            {
                return this.customerList[loc];
            }
            return null;
        }
        public bool addBooking(int cid, Booking booking)
        {
            int loc = findCustomer(cid);
            if (loc != -1)
            {
                return this.customerList[loc].addBooking(booking);
            }
            return false;
        }
        public bool deleteCustomer(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) return false;
            // ELSE
            if (this.customerList[loc].getNumBookings() > 0) return false;
            Customer[] newList = new Customer[this.maxNumOfCustomers];
            for (int i = 0; i < this.customerList.Length; i++)
            {
                if (i < loc) newList[i] = this.customerList[i];
                else if (i == loc) continue;
                else if (i > loc) newList[i - 1] = this.customerList[i];
            }
            this.numOfCustomers--;
            this.customerList = newList;

            return true;
        }
        public int getNumOfActive()
        {
            return this.numOfCustomers;
        }
        public Customer getLatestCustomer()
        {
            if (this.numOfCustomers > 0) return this.customerList[this.numOfCustomers - 1];
            return null;
        }
        public Customer[] getAllCustomers()
        {
            if (this.numOfCustomers == 0) return null;
            Customer[] temp = new Customer[this.numOfCustomers];
            for (int i = 0; i < this.numOfCustomers; i++)
            {
                temp[i] = this.customerList[i];
            }
            return temp;
        }

        public override string ToString()
        {
            string output = "------------------";
            if (this.numOfCustomers > 0)
            {
                output += ((this.numOfCustomers == 1) ? "Customer " : "Customers ") + "list------------------";
                for (int i = 0; i < this.numOfCustomers; i++)
                {
                    output += "\n" + this.customerList[i];
                }
            }
            else output += "No customer found";
            return output;
        }
    }
}
