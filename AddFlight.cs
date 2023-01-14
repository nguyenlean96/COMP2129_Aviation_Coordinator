using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2129_GroupProject_001
{
    public partial class AddFlight : Form
    {
        public string[] item = new string[] { "", "", "" };
        bool flag1 = false;
        bool flag2 = false;
        bool flag3 = false;
        public AddFlight()
        {
            InitializeComponent();
            this.bx_addOrigin.Text = "";
            this.bx_addDest.Text = "";
            this.bx_addSeats.Text = "";

            bx_addOrigin.TextChanged += new EventHandler(bx_addOrigin_TextChanged);
            bx_addDest.TextChanged += new EventHandler(bx_addDest_TextChanged);
            bx_addSeats.TextChanged += new EventHandler(bx_addSeats_TextChanged);
        }
        private void bx_addOrigin_TextChanged(object sender, EventArgs e)
        {
            if (bx_addOrigin.Text != "") flag1 = true;
            else flag1 = false;

            if (flag1 == true && flag2 == true && flag3 == true) btn_addFlight.Enabled = true;
            else btn_addFlight.Enabled = false;
        }

        private void bx_addDest_TextChanged(object sender, EventArgs e)
        {
            
            if (bx_addDest.Text != "") flag2 = true;
            else flag2 = false;

            if (flag1 == true && flag2 == true && flag3 == true) btn_addFlight.Enabled = true;
            else btn_addFlight.Enabled = false;
        }
        private void bx_addSeats_TextChanged(object sender, EventArgs e)
        {
            // Validate data input for Number of Seat available
            Regex number = new Regex(@"^[0-9]+$");
            if (bx_addSeats.Text != "" && !number.IsMatch(bx_addSeats.Text))
            {
                lb_numberWrn.Text = "Number of Available seats\nMUST BE an integer.";
                lb_numberWrn.Visible = true;
                flag3 = false;
            }
            else if (bx_addSeats.Text != "" && number.IsMatch(bx_addSeats.Text) && Convert.ToInt32(bx_addSeats.Text) > 853)
            {
                lb_numberWrn.Text = "The maximum number of passenger\nthat an airplane can carry is 853\nwhich is an Airbus A380.";
                lb_numberWrn.Visible = true;
                flag3 = false;
            }
            else if (bx_addSeats.Text != "" && number.IsMatch(bx_addSeats.Text) && ((Convert.ToInt32(bx_addSeats.Text) < 853) || (Convert.ToInt32(bx_addSeats.Text) == 853)))
            {
                lb_numberWrn.Visible = false;
                flag3 = true;
            }
            else
            {
                flag3 = false;
                lb_numberWrn.Visible = false;
            }

            if (flag1 == true && flag2 == true && flag3 == true) btn_addFlight.Enabled = true;
            else btn_addFlight.Enabled = false;
        }

        private void btn_closeAddFlight_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addFlight_Click(object sender, EventArgs e)
        {
            item = new string[] { this.bx_addOrigin.Text, this.bx_addDest.Text, this.bx_addSeats.Text };
            this.bx_addOrigin.Text = "";
            this.bx_addDest.Text = "";
            this.bx_addSeats.Text = "";
            this.Close();
        }
    }
}
