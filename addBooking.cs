using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2129_GroupProject_001
{
    public partial class addBooking : Form
    {
        private string[] items;
        
        bool flag1 = false;
        bool flag2 = false;
        private Flight[] flights;
        private Customer[] customerList;
        public addBooking(Flight[] flights, Customer[] customers)
        {
            InitializeComponent();
            this.flights = flights;
            this.customerList = customers;
            items = new string[2];

            addbk_lst_Flight.SelectedItems.Clear();
            addbk_lst_Flight.SelectedItems.Clear();

            txt_addbk_flNum_disp.Visible = false;
            txt_addBk_trip_disp.Visible = false;
            txt_addBk_cID_disp.Visible = false;
            txt_addBk_cFn_disp.Visible = false;
            btn_createBk.Visible = false;

            // Load all of the data sent from the Main
            DataFetching();

            txt_addBk_sfFlight.TextChanged += new EventHandler(txt_addBk_sfFlight_TextChanged);
            txt_addBk_sfCustomer.TextChanged += new EventHandler(txt_addBk_sfCustomer_TextChanged);
            addbk_lst_Flight.SelectedIndexChanged += new EventHandler(addbk_lst_Flight_ItemActivate);
            addbk_lst_Customer.SelectedIndexChanged += new EventHandler(addbk_lst_Customer_ItemActivate);
        }
        private void txt_addBk_sfFlight_TextChanged(object sender, EventArgs e)
        {
            if (txt_addBk_sfFlight.Text != "")
            {
                addbk_lst_Flight.Items.Clear();
                if (this.flights.Length > 0)
                {
                    foreach (Flight f in this.flights)
                    {
                        if (f.getFlightNumber().ToLower().Contains(txt_addBk_sfFlight.Text.ToLower()) || f.getOrigin().ToLower().Contains(txt_addBk_sfFlight.Text.ToLower()) || f.getDestination().ToLower().Contains(txt_addBk_sfFlight.Text))
                        {
                            addbk_lst_Flight.Items.Add(new ListViewItem(new[] { f.getFlightNumber(), f.getOrigin() + " - " + f.getDestination(), Convert.ToString(f.getAvailableSeat()) }));
                        }
                    }
                }
            }
            else { flightListFetching(); }
        }
        private void txt_addBk_sfCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txt_addBk_sfCustomer.Text != "")
            {
                addbk_lst_Customer.Items.Clear();
                if (this.customerList != null)
                {
                    if (this.customerList.Length > 0)
                    {
                        foreach (Customer c in this.customerList)
                        {
                            if (Convert.ToString(c.getId()).Contains(txt_addBk_sfCustomer.Text.ToLower()) || c.getFirstName().ToLower().Contains(txt_addBk_sfCustomer.Text.ToLower()) || c.getLastName().ToLower().Contains(txt_addBk_sfCustomer.Text.ToLower()))
                            {
                                addbk_lst_Customer.Items.Add(new ListViewItem(new[] { Convert.ToString(c.getId()), c.getFirstName(), c.getLastName() }));
                            }
                        }
                    }
                }
            }
            else { customerListFetching(); }
        }
        private void addbk_lst_Flight_ItemActivate(object sender, EventArgs e)
        {
            if (addbk_lst_Flight.SelectedIndices.Count > 0)
            {
                flag1 = true;
                items[0] = addbk_lst_Flight.SelectedItems[0].Text;
                foreach (Flight f in this.flights)
                {
                    if (f.getFlightNumber() == addbk_lst_Flight.SelectedItems[0].Text)
                    {
                        txt_addbk_flNum_disp.Visible = true;
                        txt_addBk_trip_disp.Visible = true;
                        txt_addbk_flNum_disp.Text = f.getFlightNumber();
                        txt_addBk_trip_disp.Text = f.getOrigin() + " - " + f.getDestination();
                    }
                }
            }
            else
            {
                flag1 = false;
                txt_addbk_flNum_disp.Visible = false;
                txt_addBk_trip_disp.Visible = false;
            }
            addBtn_enable();
        }
        private void addbk_lst_Customer_ItemActivate(object sender, EventArgs e)
        {
            if (addbk_lst_Customer.SelectedIndices.Count > 0)
            {
                flag2 = true;
                items[1] = addbk_lst_Customer.SelectedItems[0].Text;
                foreach (Customer c in this.customerList)
                {
                    if (c.getId() == Convert.ToInt32(addbk_lst_Customer.SelectedItems[0].Text))
                    {
                        txt_addBk_cID_disp.Visible = true;
                        txt_addBk_cFn_disp.Visible = true;
                        txt_addBk_cID_disp.Text = Convert.ToString(c.getId());
                        txt_addBk_cFn_disp.Text = c.getFullName();
                    }
                }
            }
            else
            {
                flag2 = false;
                txt_addBk_cID_disp.Visible = false;
                txt_addBk_cFn_disp.Visible = false;
            }
            addBtn_enable();
        }
        private void addBtn_enable()
        {
            if (flag1 && flag2) btn_createBk.Visible = true;
            else btn_createBk.Visible = false;
        }
        private void DataFetching()
        {
            flightListFetching();
            customerListFetching();
        }
        private void flightListFetching()
        {
            addbk_lst_Flight.Items.Clear();
            if (this.flights != null)
            {
                foreach (Flight f in flights)
                {
                    if (f != null)
                        addbk_lst_Flight.Items.Add(new ListViewItem(new[] { f.getFlightNumber(), f.getOrigin() + " - " + f.getDestination(), Convert.ToString(f.getAvailableSeat()) }));
                }
            }
        }
        private void customerListFetching()
        {
            addbk_lst_Customer.Items.Clear();
            if (this.customerList != null)
            {
                foreach (Customer c in customerList)
                {
                    if (c != null)
                        addbk_lst_Customer.Items.Add(new ListViewItem(new[] { Convert.ToString(c.getId()), c.getFirstName(), c.getLastName() }));
                }
            }
        }
        public void getInput(Flight[] flights, Customer[] customers)
        {
            this.flights = flights;
            this.customerList = customers;
        }
        public string[] returnData() { return this.items; }
        private void btn_createBk_Click(object sender, EventArgs e)
        {
            if (items[0] == addbk_lst_Flight.SelectedItems[0].Text && items[1] == addbk_lst_Customer.SelectedItems[0].Text)
            {
                this.Close();
                addbk_lst_Flight.SelectedItems.Clear();
                addbk_lst_Flight.SelectedItems.Clear();
            }
        }
    }
}
