
namespace COMP2129_GroupProject_001
{
    partial class addBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addbk_lst_Flight = new System.Windows.Forms.ListView();
            this.addbk_flNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addbk_florgdest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addbk_availSeat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addbk_lst_Customer = new System.Windows.Forms.ListView();
            this.addbk_custID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addbk_custFn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addbk_custLn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_addBk_sfFlight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_addBk_sfCustomer = new System.Windows.Forms.TextBox();
            this.btn_createBk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_addBk_trip_disp = new System.Windows.Forms.Label();
            this.txt_addbk_flNum_disp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_addBk_cFn_disp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_addBk_cID_disp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // addbk_lst_Flight
            // 
            this.addbk_lst_Flight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addbk_flNum,
            this.addbk_florgdest,
            this.addbk_availSeat});
            this.addbk_lst_Flight.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbk_lst_Flight.FullRowSelect = true;
            this.addbk_lst_Flight.GridLines = true;
            this.addbk_lst_Flight.HideSelection = false;
            this.addbk_lst_Flight.Location = new System.Drawing.Point(10, 43);
            this.addbk_lst_Flight.MultiSelect = false;
            this.addbk_lst_Flight.Name = "addbk_lst_Flight";
            this.addbk_lst_Flight.Size = new System.Drawing.Size(411, 534);
            this.addbk_lst_Flight.TabIndex = 0;
            this.addbk_lst_Flight.UseCompatibleStateImageBehavior = false;
            this.addbk_lst_Flight.View = System.Windows.Forms.View.Details;
            // 
            // addbk_flNum
            // 
            this.addbk_flNum.Text = "#Flight";
            this.addbk_flNum.Width = 95;
            // 
            // addbk_florgdest
            // 
            this.addbk_florgdest.Text = "Origin - Destination";
            this.addbk_florgdest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addbk_florgdest.Width = 220;
            // 
            // addbk_availSeat
            // 
            this.addbk_availSeat.Text = "Available Seat";
            this.addbk_availSeat.Width = 90;
            // 
            // addbk_lst_Customer
            // 
            this.addbk_lst_Customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addbk_custID,
            this.addbk_custFn,
            this.addbk_custLn});
            this.addbk_lst_Customer.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbk_lst_Customer.FullRowSelect = true;
            this.addbk_lst_Customer.GridLines = true;
            this.addbk_lst_Customer.HideSelection = false;
            this.addbk_lst_Customer.Location = new System.Drawing.Point(10, 43);
            this.addbk_lst_Customer.MultiSelect = false;
            this.addbk_lst_Customer.Name = "addbk_lst_Customer";
            this.addbk_lst_Customer.Size = new System.Drawing.Size(403, 534);
            this.addbk_lst_Customer.TabIndex = 1;
            this.addbk_lst_Customer.UseCompatibleStateImageBehavior = false;
            this.addbk_lst_Customer.View = System.Windows.Forms.View.Details;
            // 
            // addbk_custID
            // 
            this.addbk_custID.Text = "#ID";
            this.addbk_custID.Width = 70;
            // 
            // addbk_custFn
            // 
            this.addbk_custFn.Text = "First Name";
            this.addbk_custFn.Width = 160;
            // 
            // addbk_custLn
            // 
            this.addbk_custLn.Text = "Last Name";
            this.addbk_custLn.Width = 160;
            // 
            // txt_addBk_sfFlight
            // 
            this.txt_addBk_sfFlight.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addBk_sfFlight.Location = new System.Drawing.Point(118, 9);
            this.txt_addBk_sfFlight.Name = "txt_addBk_sfFlight";
            this.txt_addBk_sfFlight.Size = new System.Drawing.Size(303, 22);
            this.txt_addBk_sfFlight.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for Flight:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search for Customer:";
            // 
            // txt_addBk_sfCustomer
            // 
            this.txt_addBk_sfCustomer.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addBk_sfCustomer.Location = new System.Drawing.Point(142, 9);
            this.txt_addBk_sfCustomer.Name = "txt_addBk_sfCustomer";
            this.txt_addBk_sfCustomer.Size = new System.Drawing.Size(271, 22);
            this.txt_addBk_sfCustomer.TabIndex = 4;
            // 
            // btn_createBk
            // 
            this.btn_createBk.Font = new System.Drawing.Font("SF Pro Rounded", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createBk.Location = new System.Drawing.Point(916, 490);
            this.btn_createBk.Name = "btn_createBk";
            this.btn_createBk.Size = new System.Drawing.Size(213, 34);
            this.btn_createBk.TabIndex = 6;
            this.btn_createBk.Text = "Book the Flight";
            this.btn_createBk.UseVisualStyleBackColor = true;
            this.btn_createBk.Click += new System.EventHandler(this.btn_createBk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addbk_lst_Customer);
            this.panel1.Controls.Add(this.txt_addBk_sfCustomer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(441, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 579);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addbk_lst_Flight);
            this.panel2.Controls.Add(this.txt_addBk_sfFlight);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 579);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(862, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 230);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_addBk_trip_disp);
            this.panel4.Controls.Add(this.txt_addbk_flNum_disp);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 167);
            this.panel4.TabIndex = 9;
            // 
            // txt_addBk_trip_disp
            // 
            this.txt_addBk_trip_disp.AutoSize = true;
            this.txt_addBk_trip_disp.Font = new System.Drawing.Font("SF Pro Rounded", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addBk_trip_disp.Location = new System.Drawing.Point(7, 107);
            this.txt_addBk_trip_disp.Name = "txt_addBk_trip_disp";
            this.txt_addBk_trip_disp.Size = new System.Drawing.Size(60, 23);
            this.txt_addBk_trip_disp.TabIndex = 3;
            this.txt_addBk_trip_disp.Text = "label6";
            // 
            // txt_addbk_flNum_disp
            // 
            this.txt_addbk_flNum_disp.AutoSize = true;
            this.txt_addbk_flNum_disp.Font = new System.Drawing.Font("SF Pro Rounded", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addbk_flNum_disp.Location = new System.Drawing.Point(7, 44);
            this.txt_addbk_flNum_disp.Name = "txt_addbk_flNum_disp";
            this.txt_addbk_flNum_disp.Size = new System.Drawing.Size(60, 23);
            this.txt_addbk_flNum_disp.TabIndex = 2;
            this.txt_addbk_flNum_disp.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Origin - Destination:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Flight Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Flight Information";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(862, 251);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 230);
            this.panel5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer Information";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_addBk_cFn_disp);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.txt_addBk_cID_disp);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(3, 59);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(307, 167);
            this.panel6.TabIndex = 0;
            // 
            // txt_addBk_cFn_disp
            // 
            this.txt_addBk_cFn_disp.AutoSize = true;
            this.txt_addBk_cFn_disp.Font = new System.Drawing.Font("SF Pro Rounded", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addBk_cFn_disp.Location = new System.Drawing.Point(7, 103);
            this.txt_addBk_cFn_disp.Name = "txt_addBk_cFn_disp";
            this.txt_addBk_cFn_disp.Size = new System.Drawing.Size(60, 23);
            this.txt_addBk_cFn_disp.TabIndex = 7;
            this.txt_addBk_cFn_disp.Text = "label6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Customer ID:";
            // 
            // txt_addBk_cID_disp
            // 
            this.txt_addBk_cID_disp.AutoSize = true;
            this.txt_addBk_cID_disp.Font = new System.Drawing.Font("SF Pro Rounded", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addBk_cID_disp.Location = new System.Drawing.Point(7, 40);
            this.txt_addBk_cID_disp.Name = "txt_addBk_cID_disp";
            this.txt_addBk_cID_disp.Size = new System.Drawing.Size(60, 23);
            this.txt_addBk_cID_disp.TabIndex = 6;
            this.txt_addBk_cID_disp.Text = "label6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Customer Full Name:";
            // 
            // addBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 599);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_createBk);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addBooking";
            this.Text = "Add Booking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView addbk_lst_Flight;
        private System.Windows.Forms.ListView addbk_lst_Customer;
        private System.Windows.Forms.ColumnHeader addbk_flNum;
        private System.Windows.Forms.ColumnHeader addbk_florgdest;
        private System.Windows.Forms.ColumnHeader addbk_availSeat;
        private System.Windows.Forms.TextBox txt_addBk_sfFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_addBk_sfCustomer;
        private System.Windows.Forms.ColumnHeader addbk_custID;
        private System.Windows.Forms.ColumnHeader addbk_custFn;
        private System.Windows.Forms.ColumnHeader addbk_custLn;
        private System.Windows.Forms.Button btn_createBk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txt_addBk_trip_disp;
        private System.Windows.Forms.Label txt_addbk_flNum_disp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label txt_addBk_cFn_disp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_addBk_cID_disp;
        private System.Windows.Forms.Label label9;
    }
}