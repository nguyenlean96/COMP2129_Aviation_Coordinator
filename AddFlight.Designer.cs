
namespace COMP2129_GroupProject_001
{
    partial class AddFlight
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
            this.btn_addFlight = new System.Windows.Forms.Button();
            this.bx_addDest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bx_addOrigin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_closeAddFlight = new System.Windows.Forms.Button();
            this.bx_addSeats = new System.Windows.Forms.DomainUpDown();
            this.lb_numberWrn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addFlight
            // 
            this.btn_addFlight.Enabled = false;
            this.btn_addFlight.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFlight.Location = new System.Drawing.Point(140, 253);
            this.btn_addFlight.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addFlight.Name = "btn_addFlight";
            this.btn_addFlight.Size = new System.Drawing.Size(133, 44);
            this.btn_addFlight.TabIndex = 4;
            this.btn_addFlight.Text = "Add";
            this.btn_addFlight.UseVisualStyleBackColor = true;
            this.btn_addFlight.Click += new System.EventHandler(this.btn_addFlight_Click);
            // 
            // bx_addDest
            // 
            this.bx_addDest.Font = new System.Drawing.Font("SF Pro Rounded", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bx_addDest.Location = new System.Drawing.Point(140, 103);
            this.bx_addDest.Margin = new System.Windows.Forms.Padding(4);
            this.bx_addDest.Name = "bx_addDest";
            this.bx_addDest.Size = new System.Drawing.Size(316, 27);
            this.bx_addDest.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Origin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination City";
            // 
            // bx_addOrigin
            // 
            this.bx_addOrigin.Font = new System.Drawing.Font("SF Pro Rounded", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bx_addOrigin.Location = new System.Drawing.Point(140, 36);
            this.bx_addOrigin.Margin = new System.Windows.Forms.Padding(4);
            this.bx_addOrigin.Name = "bx_addOrigin";
            this.bx_addOrigin.Size = new System.Drawing.Size(316, 27);
            this.bx_addOrigin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Available Seats";
            // 
            // btn_closeAddFlight
            // 
            this.btn_closeAddFlight.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeAddFlight.Location = new System.Drawing.Point(324, 253);
            this.btn_closeAddFlight.Margin = new System.Windows.Forms.Padding(4);
            this.btn_closeAddFlight.Name = "btn_closeAddFlight";
            this.btn_closeAddFlight.Size = new System.Drawing.Size(133, 44);
            this.btn_closeAddFlight.TabIndex = 5;
            this.btn_closeAddFlight.Text = "Cancel";
            this.btn_closeAddFlight.UseVisualStyleBackColor = true;
            this.btn_closeAddFlight.Click += new System.EventHandler(this.btn_closeAddFlight_Click);
            // 
            // bx_addSeats
            // 
            this.bx_addSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bx_addSeats.Font = new System.Drawing.Font("SF Pro Rounded", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bx_addSeats.Location = new System.Drawing.Point(299, 154);
            this.bx_addSeats.Margin = new System.Windows.Forms.Padding(4);
            this.bx_addSeats.Name = "bx_addSeats";
            this.bx_addSeats.Size = new System.Drawing.Size(160, 27);
            this.bx_addSeats.TabIndex = 3;
            // 
            // lb_numberWrn
            // 
            this.lb_numberWrn.AutoSize = true;
            this.lb_numberWrn.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numberWrn.ForeColor = System.Drawing.Color.Red;
            this.lb_numberWrn.Location = new System.Drawing.Point(178, 190);
            this.lb_numberWrn.Name = "lb_numberWrn";
            this.lb_numberWrn.Size = new System.Drawing.Size(237, 18);
            this.lb_numberWrn.TabIndex = 8;
            this.lb_numberWrn.Text = "* Available Seat must be an integer *";
            this.lb_numberWrn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_numberWrn.Visible = false;
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 313);
            this.Controls.Add(this.lb_numberWrn);
            this.Controls.Add(this.bx_addSeats);
            this.Controls.Add(this.btn_closeAddFlight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bx_addOrigin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bx_addDest);
            this.Controls.Add(this.btn_addFlight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddFlight";
            this.Text = "Add Flight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addFlight;
        private System.Windows.Forms.TextBox bx_addDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bx_addOrigin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_closeAddFlight;
        private System.Windows.Forms.DomainUpDown bx_addSeats;
        private System.Windows.Forms.Label lb_numberWrn;
    }
}