
namespace COMP2129_GroupProject_001
{
    partial class AddCustomer
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
            this.txt_addCustFn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_addCustLn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_addCustPhone = new System.Windows.Forms.TextBox();
            this.btn_cust_add = new System.Windows.Forms.Button();
            this.btn_cust_clearFields = new System.Windows.Forms.Button();
            this.addCust_wrn1 = new System.Windows.Forms.Label();
            this.addCust_wrn2 = new System.Windows.Forms.Label();
            this.addCust_wrn3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_addCustFn
            // 
            this.txt_addCustFn.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addCustFn.Location = new System.Drawing.Point(243, 34);
            this.txt_addCustFn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_addCustFn.Name = "txt_addCustFn";
            this.txt_addCustFn.Size = new System.Drawing.Size(417, 29);
            this.txt_addCustFn.TabIndex = 0;
            this.txt_addCustFn.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // txt_addCustLn
            // 
            this.txt_addCustLn.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addCustLn.Location = new System.Drawing.Point(243, 138);
            this.txt_addCustLn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_addCustLn.Name = "txt_addCustLn";
            this.txt_addCustLn.Size = new System.Drawing.Size(417, 29);
            this.txt_addCustLn.TabIndex = 2;
            this.txt_addCustLn.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number:";
            // 
            // txt_addCustPhone
            // 
            this.txt_addCustPhone.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addCustPhone.Location = new System.Drawing.Point(243, 243);
            this.txt_addCustPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_addCustPhone.Name = "txt_addCustPhone";
            this.txt_addCustPhone.Size = new System.Drawing.Size(417, 29);
            this.txt_addCustPhone.TabIndex = 4;
            this.txt_addCustPhone.WordWrap = false;
            // 
            // btn_cust_add
            // 
            this.btn_cust_add.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cust_add.Location = new System.Drawing.Point(263, 338);
            this.btn_cust_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cust_add.Name = "btn_cust_add";
            this.btn_cust_add.Size = new System.Drawing.Size(124, 49);
            this.btn_cust_add.TabIndex = 6;
            this.btn_cust_add.Text = "Save";
            this.btn_cust_add.UseVisualStyleBackColor = true;
            this.btn_cust_add.Click += new System.EventHandler(this.btn_cust_add_Click);
            // 
            // btn_cust_clearFields
            // 
            this.btn_cust_clearFields.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cust_clearFields.Location = new System.Drawing.Point(492, 338);
            this.btn_cust_clearFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cust_clearFields.Name = "btn_cust_clearFields";
            this.btn_cust_clearFields.Size = new System.Drawing.Size(124, 49);
            this.btn_cust_clearFields.TabIndex = 7;
            this.btn_cust_clearFields.Text = "Clear";
            this.btn_cust_clearFields.UseVisualStyleBackColor = true;
            this.btn_cust_clearFields.Click += new System.EventHandler(this.btn_cust_clearFields_Click);
            // 
            // addCust_wrn1
            // 
            this.addCust_wrn1.AutoSize = true;
            this.addCust_wrn1.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCust_wrn1.ForeColor = System.Drawing.Color.Red;
            this.addCust_wrn1.Location = new System.Drawing.Point(240, 69);
            this.addCust_wrn1.Name = "addCust_wrn1";
            this.addCust_wrn1.Size = new System.Drawing.Size(59, 23);
            this.addCust_wrn1.TabIndex = 8;
            this.addCust_wrn1.Text = "label4";
            this.addCust_wrn1.Visible = false;
            // 
            // addCust_wrn2
            // 
            this.addCust_wrn2.AutoSize = true;
            this.addCust_wrn2.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCust_wrn2.ForeColor = System.Drawing.Color.Red;
            this.addCust_wrn2.Location = new System.Drawing.Point(240, 173);
            this.addCust_wrn2.Name = "addCust_wrn2";
            this.addCust_wrn2.Size = new System.Drawing.Size(47, 18);
            this.addCust_wrn2.TabIndex = 9;
            this.addCust_wrn2.Text = "label5";
            this.addCust_wrn2.Visible = false;
            // 
            // addCust_wrn3
            // 
            this.addCust_wrn3.AutoSize = true;
            this.addCust_wrn3.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCust_wrn3.ForeColor = System.Drawing.Color.Red;
            this.addCust_wrn3.Location = new System.Drawing.Point(240, 278);
            this.addCust_wrn3.Name = "addCust_wrn3";
            this.addCust_wrn3.Size = new System.Drawing.Size(47, 18);
            this.addCust_wrn3.TabIndex = 10;
            this.addCust_wrn3.Text = "label6";
            this.addCust_wrn3.Visible = false;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 401);
            this.Controls.Add(this.addCust_wrn3);
            this.Controls.Add(this.addCust_wrn2);
            this.Controls.Add(this.addCust_wrn1);
            this.Controls.Add(this.btn_cust_clearFields);
            this.Controls.Add(this.btn_cust_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_addCustPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_addCustLn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_addCustFn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCustomer";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_addCustFn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_addCustLn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_addCustPhone;
        private System.Windows.Forms.Button btn_cust_add;
        private System.Windows.Forms.Button btn_cust_clearFields;
        private System.Windows.Forms.Label addCust_wrn1;
        private System.Windows.Forms.Label addCust_wrn2;
        private System.Windows.Forms.Label addCust_wrn3;
    }
}