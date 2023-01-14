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
    public partial class viewBooking : Form
    {
        string customer;
        private Booking[] list;
        public viewBooking(string customer, Booking[] list)
        {
            InitializeComponent();
            this.list = list;
            this.customer = customer;
            bookingFetching();
            txt_viewbk_custFn.Text = this.customer;
        }
        public void bookingFetching()
        {
            lstv_viewbk_listBk.Items.Clear();
            if (this.list != null)
            {
                foreach (Booking b in this.list)
                {
                    lstv_viewbk_listBk.Items.Add(new ListViewItem(new[] { Convert.ToString(b.getBookingID()), b.getFight().getFlightNumber(), b.getFight().getOrigin() + " - " + b.getFight().getDestination(), b.getBookingDate() }));
                }
            }
        }
    }
}
