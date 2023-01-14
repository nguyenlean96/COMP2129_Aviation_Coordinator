
namespace COMP2129_GroupProject_001
{
    partial class Main
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
            this.txt_search_flight = new System.Windows.Forms.TextBox();
            this.ControlPanel = new System.Windows.Forms.TabControl();
            this.tab_flight = new System.Windows.Forms.TabPage();
            this.btn_pg1_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_flight_cancel = new System.Windows.Forms.Button();
            this.btn_main_addFlight = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstv_flightList = new System.Windows.Forms.ListView();
            this.lstv_col1_flightNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstv_col2_origin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstv_h3_destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstv_h4_seatAvail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_cust_info = new System.Windows.Forms.Panel();
            this.btn_view_custBk = new System.Windows.Forms.Button();
            this.txt_retrieved_custNumBk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_retrieved_custPn = new System.Windows.Forms.Label();
            this.txt_retrieved_custLn = new System.Windows.Forms.Label();
            this.txt_retrieved_custFn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cust_delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cust_update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_pg2_refresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cust_search = new System.Windows.Forms.TextBox();
            this.btn_cust_add = new System.Windows.Forms.Button();
            this.lstv_customer = new System.Windows.Forms.ListView();
            this.lstv_col1_custID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstv_col2_custFn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstv_col3_custLn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_pg3_refresh = new System.Windows.Forms.Button();
            this.pn_bkView = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_bkFlight_disp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_bkCust_disp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_bkDate_disp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_bkNum_disp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_booking_search = new System.Windows.Forms.TextBox();
            this.btn_open_booking = new System.Windows.Forms.Button();
            this.lstv_booking = new System.Windows.Forms.ListView();
            this.lstv_col1_bkNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstv_col2_flNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstv_col3_custName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlPanel.SuspendLayout();
            this.tab_flight.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_cust_info.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pn_bkView.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search_flight
            // 
            this.txt_search_flight.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_flight.Location = new System.Drawing.Point(608, 31);
            this.txt_search_flight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search_flight.Name = "txt_search_flight";
            this.txt_search_flight.Size = new System.Drawing.Size(411, 30);
            this.txt_search_flight.TabIndex = 2;
            // 
            // ControlPanel
            // 
            this.ControlPanel.AllowDrop = true;
            this.ControlPanel.Controls.Add(this.tab_flight);
            this.ControlPanel.Controls.Add(this.tabPage2);
            this.ControlPanel.Controls.Add(this.tabPage1);
            this.ControlPanel.Font = new System.Drawing.Font("SF Pro Rounded", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlPanel.Location = new System.Drawing.Point(19, 37);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Padding = new System.Drawing.Point(40, 7);
            this.ControlPanel.SelectedIndex = 0;
            this.ControlPanel.Size = new System.Drawing.Size(1173, 769);
            this.ControlPanel.TabIndex = 1;
            // 
            // tab_flight
            // 
            this.tab_flight.Controls.Add(this.btn_pg1_refresh);
            this.tab_flight.Controls.Add(this.label1);
            this.tab_flight.Controls.Add(this.btn_flight_cancel);
            this.tab_flight.Controls.Add(this.btn_main_addFlight);
            this.tab_flight.Controls.Add(this.label4);
            this.tab_flight.Controls.Add(this.lstv_flightList);
            this.tab_flight.Controls.Add(this.txt_search_flight);
            this.tab_flight.Location = new System.Drawing.Point(4, 37);
            this.tab_flight.Margin = new System.Windows.Forms.Padding(4);
            this.tab_flight.Name = "tab_flight";
            this.tab_flight.Padding = new System.Windows.Forms.Padding(4);
            this.tab_flight.Size = new System.Drawing.Size(1165, 728);
            this.tab_flight.TabIndex = 0;
            this.tab_flight.Text = "Flight Management";
            this.tab_flight.UseVisualStyleBackColor = true;
            // 
            // btn_pg1_refresh
            // 
            this.btn_pg1_refresh.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pg1_refresh.Location = new System.Drawing.Point(1044, 28);
            this.btn_pg1_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pg1_refresh.Name = "btn_pg1_refresh";
            this.btn_pg1_refresh.Size = new System.Drawing.Size(100, 36);
            this.btn_pg1_refresh.TabIndex = 6;
            this.btn_pg1_refresh.Text = "Refresh";
            this.btn_pg1_refresh.UseVisualStyleBackColor = true;
            this.btn_pg1_refresh.Click += new System.EventHandler(this.btn_pg1_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Flight Search:";
            // 
            // btn_flight_cancel
            // 
            this.btn_flight_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_flight_cancel.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flight_cancel.Location = new System.Drawing.Point(832, 661);
            this.btn_flight_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_flight_cancel.Name = "btn_flight_cancel";
            this.btn_flight_cancel.Size = new System.Drawing.Size(300, 50);
            this.btn_flight_cancel.TabIndex = 4;
            this.btn_flight_cancel.Text = "Cancel Flight";
            this.btn_flight_cancel.UseVisualStyleBackColor = false;
            this.btn_flight_cancel.Click += new System.EventHandler(this.btn_flight_cancel_Click);
            // 
            // btn_main_addFlight
            // 
            this.btn_main_addFlight.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_main_addFlight.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_addFlight.Location = new System.Drawing.Point(507, 661);
            this.btn_main_addFlight.Margin = new System.Windows.Forms.Padding(4);
            this.btn_main_addFlight.Name = "btn_main_addFlight";
            this.btn_main_addFlight.Size = new System.Drawing.Size(300, 50);
            this.btn_main_addFlight.TabIndex = 3;
            this.btn_main_addFlight.Text = "Add Flight";
            this.btn_main_addFlight.UseVisualStyleBackColor = false;
            this.btn_main_addFlight.Click += new System.EventHandler(this.btn_main_addFlight_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "XYZ AirLine Ltd.";
            // 
            // lstv_flightList
            // 
            this.lstv_flightList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstv_flightList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstv_col1_flightNum,
            this.lstv_col2_origin,
            this.lstv_h3_destination,
            this.lstv_h4_seatAvail});
            this.lstv_flightList.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_flightList.FullRowSelect = true;
            this.lstv_flightList.GridLines = true;
            this.lstv_flightList.HideSelection = false;
            this.lstv_flightList.Location = new System.Drawing.Point(8, 76);
            this.lstv_flightList.Margin = new System.Windows.Forms.Padding(4);
            this.lstv_flightList.MultiSelect = false;
            this.lstv_flightList.Name = "lstv_flightList";
            this.lstv_flightList.Size = new System.Drawing.Size(1135, 573);
            this.lstv_flightList.TabIndex = 0;
            this.lstv_flightList.UseCompatibleStateImageBehavior = false;
            this.lstv_flightList.View = System.Windows.Forms.View.Details;
            // 
            // lstv_col1_flightNum
            // 
            this.lstv_col1_flightNum.Text = "#FlightNumber";
            this.lstv_col1_flightNum.Width = 120;
            // 
            // lstv_col2_origin
            // 
            this.lstv_col2_origin.Text = "Origin";
            this.lstv_col2_origin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstv_col2_origin.Width = 300;
            // 
            // lstv_h3_destination
            // 
            this.lstv_h3_destination.Text = "Destination";
            this.lstv_h3_destination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstv_h3_destination.Width = 300;
            // 
            // lstv_h4_seatAvail
            // 
            this.lstv_h4_seatAvail.Text = "Available Seats";
            this.lstv_h4_seatAvail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstv_h4_seatAvail.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btn_pg2_refresh);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txt_cust_search);
            this.tabPage2.Controls.Add(this.btn_cust_add);
            this.tabPage2.Controls.Add(this.lstv_customer);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage2.Size = new System.Drawing.Size(1165, 728);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pn_cust_info);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(11, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 694);
            this.panel1.TabIndex = 16;
            // 
            // pn_cust_info
            // 
            this.pn_cust_info.Controls.Add(this.btn_view_custBk);
            this.pn_cust_info.Controls.Add(this.txt_retrieved_custNumBk);
            this.pn_cust_info.Controls.Add(this.label2);
            this.pn_cust_info.Controls.Add(this.txt_retrieved_custPn);
            this.pn_cust_info.Controls.Add(this.txt_retrieved_custLn);
            this.pn_cust_info.Controls.Add(this.txt_retrieved_custFn);
            this.pn_cust_info.Controls.Add(this.label5);
            this.pn_cust_info.Controls.Add(this.btn_cust_delete);
            this.pn_cust_info.Controls.Add(this.label6);
            this.pn_cust_info.Controls.Add(this.btn_cust_update);
            this.pn_cust_info.Controls.Add(this.label7);
            this.pn_cust_info.Location = new System.Drawing.Point(3, 54);
            this.pn_cust_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_cust_info.Name = "pn_cust_info";
            this.pn_cust_info.Size = new System.Drawing.Size(469, 635);
            this.pn_cust_info.TabIndex = 13;
            // 
            // btn_view_custBk
            // 
            this.btn_view_custBk.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_custBk.Location = new System.Drawing.Point(21, 273);
            this.btn_view_custBk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_view_custBk.Name = "btn_view_custBk";
            this.btn_view_custBk.Size = new System.Drawing.Size(417, 37);
            this.btn_view_custBk.TabIndex = 4;
            this.btn_view_custBk.Text = "View Booking List";
            this.btn_view_custBk.UseVisualStyleBackColor = true;
            this.btn_view_custBk.Visible = false;
            this.btn_view_custBk.Click += new System.EventHandler(this.btn_view_custBk_Click);
            // 
            // txt_retrieved_custNumBk
            // 
            this.txt_retrieved_custNumBk.AutoSize = true;
            this.txt_retrieved_custNumBk.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_retrieved_custNumBk.Location = new System.Drawing.Point(169, 230);
            this.txt_retrieved_custNumBk.Name = "txt_retrieved_custNumBk";
            this.txt_retrieved_custNumBk.Size = new System.Drawing.Size(63, 24);
            this.txt_retrieved_custNumBk.TabIndex = 17;
            this.txt_retrieved_custNumBk.Text = "#Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Booking:";
            // 
            // txt_retrieved_custPn
            // 
            this.txt_retrieved_custPn.AutoSize = true;
            this.txt_retrieved_custPn.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_retrieved_custPn.Location = new System.Drawing.Point(169, 165);
            this.txt_retrieved_custPn.Name = "txt_retrieved_custPn";
            this.txt_retrieved_custPn.Size = new System.Drawing.Size(106, 24);
            this.txt_retrieved_custPn.TabIndex = 15;
            this.txt_retrieved_custPn.Text = "PhoneNum";
            // 
            // txt_retrieved_custLn
            // 
            this.txt_retrieved_custLn.AutoSize = true;
            this.txt_retrieved_custLn.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_retrieved_custLn.Location = new System.Drawing.Point(169, 100);
            this.txt_retrieved_custLn.Name = "txt_retrieved_custLn";
            this.txt_retrieved_custLn.Size = new System.Drawing.Size(99, 24);
            this.txt_retrieved_custLn.TabIndex = 14;
            this.txt_retrieved_custLn.Text = "Last Name";
            // 
            // txt_retrieved_custFn
            // 
            this.txt_retrieved_custFn.AutoSize = true;
            this.txt_retrieved_custFn.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_retrieved_custFn.Location = new System.Drawing.Point(169, 34);
            this.txt_retrieved_custFn.Name = "txt_retrieved_custFn";
            this.txt_retrieved_custFn.Size = new System.Drawing.Size(100, 24);
            this.txt_retrieved_custFn.TabIndex = 13;
            this.txt_retrieved_custFn.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "First name:";
            // 
            // btn_cust_delete
            // 
            this.btn_cust_delete.BackColor = System.Drawing.Color.Red;
            this.btn_cust_delete.Font = new System.Drawing.Font("SF Pro Display", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cust_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cust_delete.Location = new System.Drawing.Point(21, 539);
            this.btn_cust_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cust_delete.Name = "btn_cust_delete";
            this.btn_cust_delete.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btn_cust_delete.Size = new System.Drawing.Size(417, 50);
            this.btn_cust_delete.TabIndex = 6;
            this.btn_cust_delete.Text = "Delete";
            this.btn_cust_delete.UseVisualStyleBackColor = false;
            this.btn_cust_delete.Click += new System.EventHandler(this.btn_cust_delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last name:";
            // 
            // btn_cust_update
            // 
            this.btn_cust_update.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_cust_update.Font = new System.Drawing.Font("SF Pro Rounded", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cust_update.Location = new System.Drawing.Point(21, 471);
            this.btn_cust_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cust_update.Name = "btn_cust_update";
            this.btn_cust_update.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btn_cust_update.Size = new System.Drawing.Size(417, 50);
            this.btn_cust_update.TabIndex = 5;
            this.btn_cust_update.Text = "Update Information";
            this.btn_cust_update.UseVisualStyleBackColor = false;
            this.btn_cust_update.Click += new System.EventHandler(this.btn_cust_update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone Number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("SF Pro Rounded", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(345, 41);
            this.label14.TabIndex = 0;
            this.label14.Text = "Customer Information";
            // 
            // btn_pg2_refresh
            // 
            this.btn_pg2_refresh.Location = new System.Drawing.Point(1040, 14);
            this.btn_pg2_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pg2_refresh.Name = "btn_pg2_refresh";
            this.btn_pg2_refresh.Size = new System.Drawing.Size(100, 28);
            this.btn_pg2_refresh.TabIndex = 15;
            this.btn_pg2_refresh.Text = "Refresh";
            this.btn_pg2_refresh.UseVisualStyleBackColor = true;
            this.btn_pg2_refresh.Click += new System.EventHandler(this.btn_pg2_refresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Search for Customer:";
            // 
            // txt_cust_search
            // 
            this.txt_cust_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_search.Location = new System.Drawing.Point(692, 14);
            this.txt_cust_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cust_search.Name = "txt_cust_search";
            this.txt_cust_search.Size = new System.Drawing.Size(339, 26);
            this.txt_cust_search.TabIndex = 1;
            this.txt_cust_search.WordWrap = false;
            // 
            // btn_cust_add
            // 
            this.btn_cust_add.AllowDrop = true;
            this.btn_cust_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cust_add.Location = new System.Drawing.Point(509, 661);
            this.btn_cust_add.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_cust_add.Name = "btn_cust_add";
            this.btn_cust_add.Size = new System.Drawing.Size(631, 49);
            this.btn_cust_add.TabIndex = 3;
            this.btn_cust_add.Text = "Add Customer";
            this.btn_cust_add.UseVisualStyleBackColor = true;
            this.btn_cust_add.Click += new System.EventHandler(this.btn_cust_add_Click);
            // 
            // lstv_customer
            // 
            this.lstv_customer.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstv_customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstv_col1_custID,
            this.lstv_col2_custFn,
            this.lstv_col3_custLn});
            this.lstv_customer.FullRowSelect = true;
            this.lstv_customer.GridLines = true;
            this.lstv_customer.HideSelection = false;
            this.lstv_customer.Location = new System.Drawing.Point(496, 54);
            this.lstv_customer.Margin = new System.Windows.Forms.Padding(4);
            this.lstv_customer.MultiSelect = false;
            this.lstv_customer.Name = "lstv_customer";
            this.lstv_customer.Size = new System.Drawing.Size(644, 597);
            this.lstv_customer.TabIndex = 2;
            this.lstv_customer.UseCompatibleStateImageBehavior = false;
            this.lstv_customer.View = System.Windows.Forms.View.Details;
            // 
            // lstv_col1_custID
            // 
            this.lstv_col1_custID.Text = "Customer ID";
            this.lstv_col1_custID.Width = 100;
            // 
            // lstv_col2_custFn
            // 
            this.lstv_col2_custFn.Text = "First Name";
            this.lstv_col2_custFn.Width = 190;
            // 
            // lstv_col3_custLn
            // 
            this.lstv_col3_custLn.Text = "Last Name";
            this.lstv_col3_custLn.Width = 190;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_pg3_refresh);
            this.tabPage1.Controls.Add(this.pn_bkView);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_booking_search);
            this.tabPage1.Controls.Add(this.btn_open_booking);
            this.tabPage1.Controls.Add(this.lstv_booking);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1165, 728);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Booking Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_pg3_refresh
            // 
            this.btn_pg3_refresh.Location = new System.Drawing.Point(556, 18);
            this.btn_pg3_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pg3_refresh.Name = "btn_pg3_refresh";
            this.btn_pg3_refresh.Size = new System.Drawing.Size(100, 30);
            this.btn_pg3_refresh.TabIndex = 13;
            this.btn_pg3_refresh.Text = "Refresh";
            this.btn_pg3_refresh.UseVisualStyleBackColor = true;
            this.btn_pg3_refresh.Click += new System.EventHandler(this.btn_pg3_refresh_Click);
            // 
            // pn_bkView
            // 
            this.pn_bkView.Controls.Add(this.label13);
            this.pn_bkView.Controls.Add(this.label12);
            this.pn_bkView.Controls.Add(this.txt_bkFlight_disp);
            this.pn_bkView.Controls.Add(this.label9);
            this.pn_bkView.Controls.Add(this.txt_bkCust_disp);
            this.pn_bkView.Controls.Add(this.label10);
            this.pn_bkView.Controls.Add(this.txt_bkDate_disp);
            this.pn_bkView.Controls.Add(this.label11);
            this.pn_bkView.Controls.Add(this.txt_bkNum_disp);
            this.pn_bkView.Location = new System.Drawing.Point(667, 63);
            this.pn_bkView.Margin = new System.Windows.Forms.Padding(4);
            this.pn_bkView.Name = "pn_bkView";
            this.pn_bkView.Size = new System.Drawing.Size(480, 583);
            this.pn_bkView.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SF Pro Rounded", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(321, 41);
            this.label13.TabIndex = 12;
            this.label13.Text = "Booking Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Flight Number:";
            // 
            // txt_bkFlight_disp
            // 
            this.txt_bkFlight_disp.AutoSize = true;
            this.txt_bkFlight_disp.Location = new System.Drawing.Point(180, 250);
            this.txt_bkFlight_disp.Name = "txt_bkFlight_disp";
            this.txt_bkFlight_disp.Size = new System.Drawing.Size(65, 21);
            this.txt_bkFlight_disp.TabIndex = 11;
            this.txt_bkFlight_disp.Text = "label13";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Booking Number:";
            // 
            // txt_bkCust_disp
            // 
            this.txt_bkCust_disp.AutoSize = true;
            this.txt_bkCust_disp.Location = new System.Drawing.Point(180, 194);
            this.txt_bkCust_disp.Name = "txt_bkCust_disp";
            this.txt_bkCust_disp.Size = new System.Drawing.Size(65, 21);
            this.txt_bkCust_disp.TabIndex = 10;
            this.txt_bkCust_disp.Text = "label14";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Booking Date:";
            // 
            // txt_bkDate_disp
            // 
            this.txt_bkDate_disp.AutoSize = true;
            this.txt_bkDate_disp.Location = new System.Drawing.Point(180, 139);
            this.txt_bkDate_disp.Name = "txt_bkDate_disp";
            this.txt_bkDate_disp.Size = new System.Drawing.Size(117, 21);
            this.txt_bkDate_disp.TabIndex = 9;
            this.txt_bkDate_disp.Text = "Booking Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Customer:";
            // 
            // txt_bkNum_disp
            // 
            this.txt_bkNum_disp.AutoSize = true;
            this.txt_bkNum_disp.Location = new System.Drawing.Point(180, 84);
            this.txt_bkNum_disp.Name = "txt_bkNum_disp";
            this.txt_bkNum_disp.Size = new System.Drawing.Size(143, 21);
            this.txt_bkNum_disp.TabIndex = 8;
            this.txt_bkNum_disp.Text = "Booking Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Rounded", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search for Booking:";
            // 
            // txt_booking_search
            // 
            this.txt_booking_search.Location = new System.Drawing.Point(193, 18);
            this.txt_booking_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_booking_search.Name = "txt_booking_search";
            this.txt_booking_search.Size = new System.Drawing.Size(353, 28);
            this.txt_booking_search.TabIndex = 2;
            // 
            // btn_open_booking
            // 
            this.btn_open_booking.Location = new System.Drawing.Point(28, 660);
            this.btn_open_booking.Margin = new System.Windows.Forms.Padding(0);
            this.btn_open_booking.Name = "btn_open_booking";
            this.btn_open_booking.Size = new System.Drawing.Size(611, 41);
            this.btn_open_booking.TabIndex = 1;
            this.btn_open_booking.Text = "Add Booking";
            this.btn_open_booking.UseVisualStyleBackColor = true;
            this.btn_open_booking.Click += new System.EventHandler(this.btn_open_booking_Click);
            // 
            // lstv_booking
            // 
            this.lstv_booking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstv_col1_bkNum,
            this.lstv_col2_flNum,
            this.lstv_col3_custName});
            this.lstv_booking.FullRowSelect = true;
            this.lstv_booking.GridLines = true;
            this.lstv_booking.HideSelection = false;
            this.lstv_booking.Location = new System.Drawing.Point(11, 63);
            this.lstv_booking.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lstv_booking.MultiSelect = false;
            this.lstv_booking.Name = "lstv_booking";
            this.lstv_booking.Size = new System.Drawing.Size(644, 582);
            this.lstv_booking.TabIndex = 0;
            this.lstv_booking.UseCompatibleStateImageBehavior = false;
            this.lstv_booking.View = System.Windows.Forms.View.Details;
            // 
            // lstv_col1_bkNum
            // 
            this.lstv_col1_bkNum.Text = "#Booking";
            this.lstv_col1_bkNum.Width = 120;
            // 
            // lstv_col2_flNum
            // 
            this.lstv_col2_flNum.Text = "Flight";
            this.lstv_col2_flNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstv_col2_flNum.Width = 140;
            // 
            // lstv_col3_custName
            // 
            this.lstv_col3_custName.Text = "Customer";
            this.lstv_col3_custName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstv_col3_custName.Width = 215;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.howToToolStripMenuItem.Text = "How to";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuBar
            // 
            this.menuBar.Font = new System.Drawing.Font("SF Pro Rounded", 10F);
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuBar.Size = new System.Drawing.Size(1205, 30);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.exportDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.importDataToolStripMenuItem.Text = "Import Data";
            this.importDataToolStripMenuItem.Click += new System.EventHandler(this.importDataToolStripMenuItem_Click);
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.exportDataToolStripMenuItem.Text = "Export Data";
            this.exportDataToolStripMenuItem.Click += new System.EventHandler(this.exportDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1205, 820);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "XYZ Airline Ltd.";
            this.ControlPanel.ResumeLayout(false);
            this.tab_flight.ResumeLayout(false);
            this.tab_flight.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_cust_info.ResumeLayout(false);
            this.pn_cust_info.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pn_bkView.ResumeLayout(false);
            this.pn_bkView.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl ControlPanel;
        private System.Windows.Forms.TabPage tab_flight;
        private System.Windows.Forms.ListView lstv_flightList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_search_flight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader lstv_col1_flightNum;
        private System.Windows.Forms.ColumnHeader lstv_col2_origin;
        private System.Windows.Forms.ColumnHeader lstv_h3_destination;
        private System.Windows.Forms.Button btn_main_addFlight;
        private System.Windows.Forms.Button btn_flight_cancel;
        private System.Windows.Forms.ListView lstv_customer;
        private System.Windows.Forms.ColumnHeader lstv_h4_seatAvail;
        private System.Windows.Forms.ColumnHeader lstv_col1_custID;
        private System.Windows.Forms.ColumnHeader lstv_col2_custFn;
        private System.Windows.Forms.ColumnHeader lstv_col3_custLn;
        private System.Windows.Forms.ListView lstv_booking;
        private System.Windows.Forms.Button btn_cust_add;
        private System.Windows.Forms.ColumnHeader lstv_col1_bkNum;
        private System.Windows.Forms.ColumnHeader lstv_col2_flNum;
        private System.Windows.Forms.ColumnHeader lstv_col3_custName;
        private System.Windows.Forms.TextBox txt_cust_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cust_delete;
        private System.Windows.Forms.Button btn_cust_update;
        private System.Windows.Forms.Panel pn_cust_info;
        private System.Windows.Forms.Label txt_retrieved_custFn;
        private System.Windows.Forms.Label txt_retrieved_custPn;
        private System.Windows.Forms.Label txt_retrieved_custLn;
        private System.Windows.Forms.Button btn_open_booking;
        private System.Windows.Forms.TextBox txt_booking_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_retrieved_custNumBk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_view_custBk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_bkFlight_disp;
        private System.Windows.Forms.Label txt_bkCust_disp;
        private System.Windows.Forms.Label txt_bkDate_disp;
        private System.Windows.Forms.Label txt_bkNum_disp;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.Panel pn_bkView;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_pg3_refresh;
        private System.Windows.Forms.Button btn_pg2_refresh;
        private System.Windows.Forms.Button btn_pg1_refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
    }
}

