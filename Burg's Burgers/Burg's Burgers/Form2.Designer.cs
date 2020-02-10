namespace Burg_s_Burgers
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUpDwnBurgers = new System.Windows.Forms.NumericUpDown();
            this.cBoxState = new System.Windows.Forms.ComboBox();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.tBoxAddress = new System.Windows.Forms.TextBox();
            this.tBoxCity = new System.Windows.Forms.TextBox();
            this.tBoxLname = new System.Windows.Forms.TextBox();
            this.tBoxFname = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBurger = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnBurgers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlaceOrder);
            this.groupBox1.Controls.Add(this.lblBurger);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblLname);
            this.groupBox1.Controls.Add(this.lblFname);
            this.groupBox1.Controls.Add(this.numUpDwnBurgers);
            this.groupBox1.Controls.Add(this.cBoxState);
            this.groupBox1.Controls.Add(this.tBoxPhone);
            this.groupBox1.Controls.Add(this.tBoxAddress);
            this.groupBox1.Controls.Add(this.tBoxCity);
            this.groupBox1.Controls.Add(this.tBoxLname);
            this.groupBox1.Controls.Add(this.tBoxFname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Place Order";
            // 
            // numUpDwnBurgers
            // 
            this.numUpDwnBurgers.Location = new System.Drawing.Point(6, 56);
            this.numUpDwnBurgers.Name = "numUpDwnBurgers";
            this.numUpDwnBurgers.Size = new System.Drawing.Size(120, 20);
            this.numUpDwnBurgers.TabIndex = 7;
            // 
            // cBoxState
            // 
            this.cBoxState.FormattingEnabled = true;
            this.cBoxState.Location = new System.Drawing.Point(6, 280);
            this.cBoxState.Name = "cBoxState";
            this.cBoxState.Size = new System.Drawing.Size(121, 21);
            this.cBoxState.TabIndex = 6;
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Location = new System.Drawing.Point(6, 307);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(121, 20);
            this.tBoxPhone.TabIndex = 5;
            // 
            // tBoxAddress
            // 
            this.tBoxAddress.Location = new System.Drawing.Point(6, 228);
            this.tBoxAddress.Name = "tBoxAddress";
            this.tBoxAddress.Size = new System.Drawing.Size(121, 20);
            this.tBoxAddress.TabIndex = 4;
            // 
            // tBoxCity
            // 
            this.tBoxCity.Location = new System.Drawing.Point(6, 254);
            this.tBoxCity.Name = "tBoxCity";
            this.tBoxCity.Size = new System.Drawing.Size(121, 20);
            this.tBoxCity.TabIndex = 3;
            // 
            // tBoxLname
            // 
            this.tBoxLname.Location = new System.Drawing.Point(137, 176);
            this.tBoxLname.Name = "tBoxLname";
            this.tBoxLname.Size = new System.Drawing.Size(121, 20);
            this.tBoxLname.TabIndex = 1;
            // 
            // tBoxFname
            // 
            this.tBoxFname.Location = new System.Drawing.Point(6, 176);
            this.tBoxFname.Name = "tBoxFname";
            this.tBoxFname.Size = new System.Drawing.Size(121, 20);
            this.tBoxFname.TabIndex = 0;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(6, 160);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 8;
            this.lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(134, 160);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(58, 13);
            this.lblLname.TabIndex = 9;
            this.lblLname.Text = "Last Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(134, 228);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(134, 255);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(134, 281);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "State";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(134, 307);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblBurger
            // 
            this.lblBurger.AutoSize = true;
            this.lblBurger.Location = new System.Drawing.Point(6, 40);
            this.lblBurger.Name = "lblBurger";
            this.lblBurger.Size = new System.Drawing.Size(183, 13);
            this.lblBurger.TabIndex = 14;
            this.lblBurger.Text = "Select the number of Burgers to order";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(218, 281);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(139, 46);
            this.btnPlaceOrder.TabIndex = 15;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 357);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Place Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnBurgers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numUpDwnBurgers;
        private System.Windows.Forms.ComboBox cBoxState;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.TextBox tBoxAddress;
        private System.Windows.Forms.TextBox tBoxCity;
        private System.Windows.Forms.TextBox tBoxLname;
        private System.Windows.Forms.TextBox tBoxFname;
        private System.Windows.Forms.Label lblBurger;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}