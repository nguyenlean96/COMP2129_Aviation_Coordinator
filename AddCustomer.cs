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
    public partial class AddCustomer : Form
    {
        public string cid = "";
        public string[] newCustomer = new string[3];
        bool flag1 = false;
        bool flag2 = false;
        bool flag3 = false;
        private Regex name_conv1 = new Regex(@"^[A-Z][a-z]*[\.]*([\s][A-Z][a-z]*[\.]*)*$");
        private Regex name_conv2 = new Regex(@"^[A-Z][a-z]*[\.]*([\-][A-Z][a-z]*[\.]*)*$");
        private Regex phoneNum_conv1 = new Regex(@"^(\d{3})(\-\d{3})(\-\d{4})$");
        private Regex phoneNum_conv2 = new Regex(@"^\d{10}$");
        private Regex phoneNum_conv3 = new Regex(@"^(\({1})(\d{3})(\){1})\s(\d{3})(-\d{4})$");

        public AddCustomer()
        {
            InitializeComponent();
            if (newCustomer[0] != "" && newCustomer[1] != "" && newCustomer[2] != "")
            {
                txt_addCustFn.Text = newCustomer[0];
                txt_addCustLn.Text = newCustomer[1];
                txt_addCustPhone.Text = newCustomer[2];
                
            }
            
            /*
            this.txt_addCustFn.Text = "";
            this.txt_addCustLn.Text = "";
            this.txt_addCustPhone.Text = "";
            */
            this.btn_cust_add.Enabled = false;

            txt_addCustFn.TextChanged += new EventHandler(txt_addCustFn_TextChanged);
            txt_addCustLn.TextChanged += new EventHandler(txt_addCustLn_TextChanged);
            txt_addCustPhone.TextChanged += new EventHandler(txt_addCustPhone_TextChanged);
        }
        private void txt_addCustFn_TextChanged(object sender, EventArgs e)
        {
            if (txt_addCustFn.Text != "" && ((name_conv1.IsMatch(txt_addCustFn.Text)) || (name_conv2.IsMatch(txt_addCustFn.Text))))
            {
                addCust_wrn1.Visible = false;
                flag1 = true;
            }
            else
            {
                addCust_wrn1.Text = "Please enter a correct pattern of name.\nE.g. \"John Lawrence\" or \"John-Lawrence\" or \"Lawrence J.\"";
                addCust_wrn1.Visible = true;
                flag1 = false;
            }
            btnEnable();
        }
        private void txt_addCustLn_TextChanged(object sender, EventArgs e)
        {
            if (txt_addCustLn.Text != "" && ((name_conv1.IsMatch(txt_addCustLn.Text)) || (name_conv2.IsMatch(txt_addCustLn.Text))))
            {
                addCust_wrn2.Visible = false;
                flag2 = true;
            }
            else
            {
                addCust_wrn2.Text = "Please enter a correct pattern of name.\nE.g. \"Parker Harry\" or \"Parker-Harry\" or \"Harry P.\"";
                addCust_wrn2.Visible = true;
                flag2 = false;
            }
            btnEnable();
        }
        private void txt_addCustPhone_TextChanged(object sender, EventArgs e)
        {
            if (txt_addCustPhone.Text != "" && ((phoneNum_conv1.IsMatch(txt_addCustPhone.Text)) || (phoneNum_conv2.IsMatch(txt_addCustPhone.Text)) || (phoneNum_conv3.IsMatch(txt_addCustPhone.Text))))
            {
                addCust_wrn3.Visible = false;
                flag3 = true;
            }
            else
            {
                addCust_wrn3.Text = "Please enter a correct pattern of a phone number.\nE.g. (416) 415-5000 or 416-415-5000 or 4164155000";
                addCust_wrn3.Visible = true;
                flag3 = false;
            }
            btnEnable();
        }
        private void btn_cust_add_Click(object sender, EventArgs e)
        {
            this.newCustomer = new string[] { this.txt_addCustFn.Text, this.txt_addCustLn.Text, this.txt_addCustPhone.Text };
            this.Close();
        }
        private void btnEnable() { if (flag1 == true && flag2 == true && flag3 == true) btn_cust_add.Enabled = true; }

        private void btn_cust_clearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        public void getInput(string fn, string ln, string phone)
        {
            txt_addCustFn.Text = fn;
            txt_addCustLn.Text = ln;
            txt_addCustPhone.Text = phone;
        }
        public string[] returnCustomer()
        {
            return new string[] { this.txt_addCustFn.Text, this.txt_addCustLn.Text, this.txt_addCustPhone.Text };
        }
        public void clearFields()
        {
            newCustomer = new string[] { "", "", "" };
            this.txt_addCustFn.Text = "";
            this.txt_addCustLn.Text = "";
            this.txt_addCustPhone.Text = "";
        }


    }
}
