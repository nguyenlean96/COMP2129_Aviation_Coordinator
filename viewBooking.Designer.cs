
namespace COMP2129_GroupProject_001
{
    partial class viewBooking
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
            this.lstv_viewbk_listBk = new System.Windows.Forms.ListView();
            this.viewbk_BkNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewbk_FlNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewbk_FlightOD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewbk_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_viewbk_custFn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstv_viewbk_listBk
            // 
            this.lstv_viewbk_listBk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.viewbk_BkNum,
            this.viewbk_FlNum,
            this.viewbk_FlightOD,
            this.viewbk_date});
            this.lstv_viewbk_listBk.Font = new System.Drawing.Font("SF Pro Display", 10.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_viewbk_listBk.FullRowSelect = true;
            this.lstv_viewbk_listBk.GridLines = true;
            this.lstv_viewbk_listBk.HideSelection = false;
            this.lstv_viewbk_listBk.Location = new System.Drawing.Point(12, 70);
            this.lstv_viewbk_listBk.Name = "lstv_viewbk_listBk";
            this.lstv_viewbk_listBk.Size = new System.Drawing.Size(569, 563);
            this.lstv_viewbk_listBk.TabIndex = 0;
            this.lstv_viewbk_listBk.UseCompatibleStateImageBehavior = false;
            this.lstv_viewbk_listBk.View = System.Windows.Forms.View.Details;
            // 
            // viewbk_BkNum
            // 
            this.viewbk_BkNum.Text = "#Booking";
            this.viewbk_BkNum.Width = 80;
            // 
            // viewbk_FlNum
            // 
            this.viewbk_FlNum.Text = "#Flight";
            this.viewbk_FlNum.Width = 90;
            // 
            // viewbk_FlightOD
            // 
            this.viewbk_FlightOD.Text = "Origin - Destination";
            this.viewbk_FlightOD.Width = 180;
            // 
            // viewbk_date
            // 
            this.viewbk_date.Text = "Created Date";
            this.viewbk_date.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Booking List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "from customer:";
            // 
            // txt_viewbk_custFn
            // 
            this.txt_viewbk_custFn.AutoSize = true;
            this.txt_viewbk_custFn.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_viewbk_custFn.Location = new System.Drawing.Point(123, 22);
            this.txt_viewbk_custFn.Name = "txt_viewbk_custFn";
            this.txt_viewbk_custFn.Size = new System.Drawing.Size(172, 29);
            this.txt_viewbk_custFn.TabIndex = 3;
            this.txt_viewbk_custFn.Text = "Customer name";
            // 
            // viewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 645);
            this.Controls.Add(this.txt_viewbk_custFn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstv_viewbk_listBk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "viewBooking";
            this.Text = "View Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstv_viewbk_listBk;
        private System.Windows.Forms.ColumnHeader viewbk_BkNum;
        private System.Windows.Forms.ColumnHeader viewbk_FlNum;
        private System.Windows.Forms.ColumnHeader viewbk_FlightOD;
        private System.Windows.Forms.ColumnHeader viewbk_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_viewbk_custFn;
    }
}