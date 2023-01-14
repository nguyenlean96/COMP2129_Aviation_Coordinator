// COMP2129 - Advanced Object-Oriented Programming
// Group Project
// Members:
//          += Le An Nguyen - 101292266
//          += Vishvarajsinh Rana - 101307136
//          += Vraj Patel - 101327087

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace COMP2129_GroupProject_001
{
    public partial class Main : Form
    {
        static AirlineCoordinator aCoord;
        int currentSelectedCustomer;
        AddFlight addFlightForm;
        AddCustomer addCustomerForm;
        addBooking addBookingForm;
        viewBooking viewBookingForm;
        About AboutThisProject;
        public Main()
        {
            InitializeComponent();

            aCoord = new AirlineCoordinator(100, 100, 100);
            /* 
            aCoord.addCustomer("Le An", "Nguyen", "432-123-4567");
            aCoord.addCustomer("Vraj", "Patel", "467-000-0001");
            aCoord.addCustomer("Jacob", "Solano", "122-234-5678");
            aCoord.addCustomer("Renzzi", "Adorador", "456-234-5678");
            aCoord.addCustomer("Vishvarajsinh", "Rana", "678-901-2345");

            aCoord.addFlight("Los Angeles", "San Francisco", 3);
            aCoord.addFlight("Hong Kong", "Toronto", 2);
            aCoord.addFlight("Tokyo", "Los Angeles", 3);
            aCoord.addFlight("Toronto", "Texas", 1);
            aCoord.addFlight("Toronto", "Vancouver", 2);
            */
            DataReloading();

            txt_retrieved_custFn.Text = "";
            txt_retrieved_custLn.Text = "";
            txt_retrieved_custPn.Text = "";

            txt_search_flight.TextChanged += new EventHandler(txt_search_flight_TextChanged);
            txt_cust_search.TextChanged += new EventHandler(txt_cust_search_TextChanged);
            txt_booking_search.TextChanged += new EventHandler(txt_booking_search_TextChanged);

            pn_cust_info.Visible = false;
            pn_bkView.Visible = false;
            lstv_customer.SelectedIndexChanged += new EventHandler(lstv_customer_ItemActivate);
            lstv_booking.SelectedIndexChanged += new EventHandler(lstv_booking_ItemActivate);
        }

        // FLIGHT ////////////////////////////////////////////////////
        private void flightListFetching()
        {
            lstv_flightList.Items.Clear();
            int activeFlights = aCoord.getNumOfFlight();
            Flight[] current = aCoord.getFlightList();
            if (activeFlights != 0)
            {
                for (int i = 0; i < activeFlights; i++)
                {
                    lstv_flightList.Items.Add(new ListViewItem(new[] { current[i].getFlightNumber(), current[i].getOrigin(), current[i].getDestination(), Convert.ToString(current[i].getAvailableSeat()) }));
                }
            }
        }
        private void btn_main_addFlight_Click(object sender, EventArgs e)
        {
            addFlightForm = new AddFlight();
            addFlightForm.ShowDialog();
            if (addFlightForm.item[0] != "" && addFlightForm.item[1] != "" && addFlightForm.item[2] != "")
            {
                aCoord.addFlight(addFlightForm.item[0], addFlightForm.item[1], Convert.ToInt32(addFlightForm.item[2]));
                lstv_flightList.Items.Add(new ListViewItem(new[] { aCoord.getLatestFlight().getFlightNumber(), aCoord.getLatestFlight().getOrigin(), aCoord.getLatestFlight().getDestination(), Convert.ToString(aCoord.getLatestFlight().getAvailableSeat()) }));
            }
        }

        private void btn_flight_cancel_Click(object sender, EventArgs e)
        {
            if (lstv_flightList.SelectedItems.Count > 0)
            {
                string[] temp = new string[] { lstv_flightList.SelectedItems[0].Text, lstv_flightList.SelectedItems[0].SubItems[1].Text, lstv_flightList.SelectedItems[0].SubItems[2].Text };
                if (aCoord.deleteFlight(lstv_flightList.SelectedItems[0].Text))
                {
                    MessageBox.Show("Flight No." + temp[0] + " from " + temp[1] + " to " + temp[2] + " does not have any customer.", "Successful flight cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataReloading();
                }
                else MessageBox.Show("This flight has already been booked by customer.\nCan not be cancelled.", "Failed to cancel", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            } else MessageBox.Show("No Flight selected!", "Flight Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txt_search_flight_TextChanged(object sender, EventArgs e)
        {
            Flight[] f = aCoord.getFlightList();
            if (txt_search_flight.Text != "")
            {
                
                lstv_flightList.Items.Clear();
                
                if (f.Length > 0)
                {
                    for (int i = 0; i < f.Length; i++)
                    {

                        if (f[i].getFlightNumber().ToLower().Contains(txt_search_flight.Text.ToLower()) || f[i].getOrigin().ToLower().Contains(txt_search_flight.Text.ToLower()) || f[i].getDestination().ToLower().Contains(txt_search_flight.Text.ToLower()))
                        {
                            lstv_flightList.Items.Add(new ListViewItem(new[] { f[i].getFlightNumber(), f[i].getOrigin(), f[i].getDestination(), Convert.ToString(f[i].getAvailableSeat()) }));
                        }
                    }
                }
            } else { flightListFetching(); }
        }

        // CUSTOMER SECTION //////////////////////////////////////////

        private void customerListFetching()
        {
            lstv_customer.Items.Clear();
            Customer[] current = aCoord.getCustomerList();
            if (aCoord.getNumOfActiveCustomer() > 0)
            {
                foreach (Customer c in current)
                {
                    lstv_customer.Items.Add(new ListViewItem(new[] { Convert.ToString(c.getId()), c.getFirstName(), c.getLastName() }));
                }
            }
            pn_cust_info.Visible = false;
        }
        private void txt_cust_search_TextChanged(object sender, EventArgs e)
        {
            Customer[] customers = aCoord.getCustomerList();
            if (txt_cust_search.Text != "")
            {
                lstv_customer.Items.Clear();
                if (customers != null)
                {
                    if (customers.Length > 0)
                    {
                        foreach (Customer c in customers)
                        {
                            if (Convert.ToString(c.getId()).Contains(txt_cust_search.Text) || c.getFirstName().ToLower().Contains(txt_cust_search.Text.ToLower()) || c.getLastName().ToLower().Contains(txt_cust_search.Text.ToLower()))
                            {
                                lstv_customer.Items.Add(new ListViewItem(new[] { Convert.ToString(c.getId()), c.getFirstName(), c.getLastName() }));
                            }
                        }
                    }
                }
            }
            else { customerListFetching(); }
        }
        private void lstv_customer_ItemActivate(object sender, EventArgs e)
        {
            if (lstv_customer.SelectedIndices.Count > 0)
            {
                addCustomerForm = new AddCustomer();
                pn_cust_info.Visible = true;
                
                Customer c = aCoord.GetCustomer(Convert.ToInt32(lstv_customer.SelectedItems[0].Text));
                this.currentSelectedCustomer = Convert.ToInt32(lstv_customer.SelectedItems[0].Text);
                txt_retrieved_custFn.Text = c.getFirstName();
                txt_retrieved_custLn.Text = c.getLastName();
                txt_retrieved_custPn.Text = c.getPhone();
                txt_retrieved_custNumBk.Text = Convert.ToString(c.getNumBookings());
                if (c.getNumBookings() == 0) btn_view_custBk.Visible = false;
                else btn_view_custBk.Visible = true;
                addCustomerForm.getInput(c.getFirstName(), c.getLastName(), c.getPhone());
            }
            else pn_cust_info.Visible = false;
        }
        private void btn_view_custBk_Click(object sender, EventArgs e)
        {
            viewBookingForm = new viewBooking(aCoord.GetCustomer(this.currentSelectedCustomer).getFullName(), aCoord.getBookingByCustomer(this.currentSelectedCustomer));
            viewBookingForm.ShowDialog();
        }
        private void btn_cust_update_Click(object sender, EventArgs e)
        {
            addCustomerForm.ShowDialog();
            string[] customer = addCustomerForm.returnCustomer();
            aCoord.updateCustomer(Convert.ToInt32(lstv_customer.SelectedItems[0].Text), customer[0], customer[1], customer[2]);
            DataReloading();
            pn_cust_info.Visible = false;
        }

        private void btn_cust_delete_Click(object sender, EventArgs e)
        {
            if (lstv_customer.SelectedItems.Count > 0)
            {
                if (aCoord.deleteCustomer(Convert.ToInt32(lstv_customer.SelectedItems[0].Text)))
                {
                    customerListFetching();
                    pn_cust_info.Visible = false;
                    MessageBox.Show("Customer deleted successfully.", "Delete customer successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataReloading();
                }
                else
                {
                    Customer temp = aCoord.GetCustomer(Convert.ToInt32(lstv_customer.SelectedItems[0].Text));
                    if (temp == null) MessageBox.Show("Selected customer doesn't exist.", "Non-existing customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (temp.getNumBookings() > 0) MessageBox.Show("Unable to delete customer with active Booking " + (temp.getNumBookings() == 1 ? "flight." : "flights."), "Customer can not be deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_cust_add_Click(object sender, EventArgs e)
        {
            addCustomerForm = new AddCustomer();
            addCustomerForm.ShowDialog();
            addCustomer();
        }
        private void addCustomer()
        {
            string[] newCustomer = addCustomerForm.returnCustomer();
            if (newCustomer[0] != "" && newCustomer[1] != "" && newCustomer[2] != "")
            {
                if (aCoord.customerDuplicate(newCustomer[0], newCustomer[1], newCustomer[2]))
                    MessageBox.Show("A contact with the same first name, last name and phone number has already existed.", "Duplicate contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    aCoord.addCustomer(newCustomer[0], newCustomer[1], newCustomer[2]);
                    DataReloading();
                }
            }
        }

        // BOOKING SECTION /////////////////////////////////////////////////////////////////////////////////
        private void btn_open_booking_Click(object sender, EventArgs e)
        {
            addBookingForm = new addBooking(aCoord.getFlightList(), aCoord.getCustomerList());
            addBookingForm.ShowDialog();
            addBooking();
            DataReloading();
        }
        private void txt_booking_search_TextChanged(object sender, EventArgs e)
        {
            Booking[] bookings = aCoord.getAllBooking();
            if (txt_booking_search.Text != "")
            {
                lstv_booking.Items.Clear();
                if (bookings != null)
                {
                    if (bookings.Length > 0)
                    {
                        foreach (Booking b in bookings)
                        {
                            if (Convert.ToString(b.getBookingID()).Contains(txt_booking_search.Text) || b.getFight().getFlightNumber().ToLower().Contains(txt_booking_search.Text.ToLower()) || b.getCustomer().getFullName().ToLower().Contains(txt_booking_search.Text.ToLower()))
                            {
                                lstv_booking.Items.Add(new ListViewItem(new[] { Convert.ToString(b.getBookingID()), b.getFight().getFlightNumber(), b.getCustomer().getFullName() }));
                            }
                        }
                    }
                }
            }
            else { BookingListFetching(); }
        }
        private void addBooking()
        {
            string[] booking = addBookingForm.returnData();
            if (booking[0] != null && booking[1] != null)
            {

                if (aCoord.addBooking(booking[0], Convert.ToInt32(booking[1])))
                    MessageBox.Show("Customer " + aCoord.GetCustomer(Convert.ToInt32(booking[1])).getFullName() + " has booked the flight No." + aCoord.getLatestBooking().getFight().getFlightNumber() + " successfully.", "Booking success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                else MessageBox.Show("Failed to create booking.\nPlease try again later.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void BookingListFetching()
        {
            lstv_booking.Items.Clear();
            Booking[] current = aCoord.getAllBooking();
            if (current != null)
            {
                foreach (Booking b in current)
                {
                    lstv_booking.Items.Add(new ListViewItem(new[] { Convert.ToString(b.getBookingID()), b.getFight().getFlightNumber(), b.getCustomer().getFullName() }));
                }
            }
        }
        private void lstv_booking_ItemActivate(object sender, EventArgs e)
        {
            if (lstv_booking.SelectedIndices.Count > 0)
            {
                pn_bkView.Visible = true;

                Booking b = aCoord.getBookingByID(Convert.ToInt32(lstv_booking.SelectedItems[0].Text));
                txt_bkNum_disp.Text = Convert.ToString(b.getBookingID());
                txt_bkFlight_disp.Text = b.getFight().getFlightNumber();
                txt_bkDate_disp.Text = b.getBookingDate();
                txt_bkCust_disp.Text = b.getCustomer().getFullName();
                
            }
            else pn_bkView.Visible = false;
        }
        private void DataReloading()
        {
            BookingListFetching();
            flightListFetching();
            customerListFetching();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var request = MessageBox.Show("All data will be going to a better place for good.\nDo you want to continue?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (request == DialogResult.Yes) this.Close(); 
        }

        private void btn_pg1_refresh_Click(object sender, EventArgs e)
        {
            DataReloading();
        }

        private void btn_pg2_refresh_Click(object sender, EventArgs e)
        {
            DataReloading();
        }

        private void btn_pg3_refresh_Click(object sender, EventArgs e)
        {
            DataReloading();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutThisProject = new About();
            AboutThisProject.ShowDialog();
        }
        private void DataExport()
        {
            try
            {
                Flight[] currentFlights = aCoord.getFlightList();
                if (currentFlights != null)
                {
                    StreamWriter flightOutput = new StreamWriter("flight.txt", false);
                    foreach (Flight f in currentFlights)
                    {
                        flightOutput.WriteLine(f.getFlightNumber() + "," + f.getOrigin() + "," + f.getDestination() + "," + f.getAvailableSeat());
                    }
                    flightOutput.Close();
                }
                else MessageBox.Show("No flights found to be exported.");

                Customer[] currentCustomer = aCoord.getCustomerList();
                if (currentCustomer != null)
                {
                    StreamWriter customerOutput = new StreamWriter("customer.txt", false);
                    foreach (Customer c in currentCustomer)
                    {
                        customerOutput.WriteLine(c.getId() + "," + c.getFirstName() + "," + c.getLastName() + "," + c.getPhone());
                    }
                    customerOutput.Close();
                }

                Booking[] currentBooking = aCoord.getAllBooking();
                if (currentBooking != null)
                {
                    StreamWriter bookingOutput = new StreamWriter("booking.txt", false);
                    foreach (Booking b in currentBooking)
                    {
                        bookingOutput.WriteLine(b.getBookingID() + "," + b.getFight().getFlightNumber() + "," + b.getCustomer().getId());
                    }
                    bookingOutput.Close();
                }
                DataReloading();
                MessageBox.Show("Data has been exported successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Failed to export data.");
            }
        }
        private void DataRetrieve()
        {
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = false;
            StreamReader flightInput;
            try
            {
                flightInput = new StreamReader("flight.txt");
                while (flightInput.Peek() != -1)
                {
                    string[] temp = flightInput.ReadLine().Split(Convert.ToChar(","));
                    aCoord.restoreFlight(temp[0], temp[1], temp[2], Convert.ToInt32(temp[3]));
                }
                flightInput.Close();
                flag1 = true;
                DataReloading();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Data files not found.");
                StreamWriter newFlightFile = new StreamWriter("flight.txt", false);
                newFlightFile.Close();
                MessageBox.Show("New empty files has been created successfully.");
            }

            StreamReader customerInput;
            try
            {
                customerInput = new StreamReader("customer.txt");
                while (customerInput.Peek() != -1)
                {
                    string[] temp = customerInput.ReadLine().Split(Convert.ToChar(","));
                    aCoord.restoreCustomer(Convert.ToInt32(temp[0]), temp[1], temp[2], temp[3]);
                }
                customerInput.Close();
                flag2 = true;
                DataReloading();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Data files not found.");
                StreamWriter newCustomerFile = new StreamWriter("customer.txt", false);
                newCustomerFile.Close();
                MessageBox.Show("New empty files has been created successfully.");
            }

            StreamReader bookingInput;
            try
            {
                // Try retrieving data
                bookingInput = new StreamReader("booking.txt");
                while (bookingInput.Peek() != -1)
                {
                    string[] temp = bookingInput.ReadLine().Split(Convert.ToChar(","));
                    aCoord.addBooking(temp[1], Convert.ToInt32(temp[2]));
                }
                // Close in case retrieving proccess was successful
                bookingInput.Close();
                flag3 = true;
                DataReloading();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Data files not found.");
                StreamWriter newBookingFile = new StreamWriter("booking.txt", false);
                newBookingFile.Close();
                MessageBox.Show("New empty files has been created successfully.");
            }
            if (flag1 && flag2 && flag3) MessageBox.Show("Data has been restored successfully.", "Data restored successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataExport();
        }

        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRetrieve();
        }
    }
}
