namespace Burg_s_Burgers
{
    partial class Form_PlaceOrder
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
            this.gBoxPlaceOrder = new System.Windows.Forms.GroupBox();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.tBoxZip = new System.Windows.Forms.TextBox();
            this.lblBurger = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.numUpDwnBurgers = new System.Windows.Forms.NumericUpDown();
            this.cBoxState = new System.Windows.Forms.ComboBox();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.tBoxAddress = new System.Windows.Forms.TextBox();
            this.tBoxCity = new System.Windows.Forms.TextBox();
            this.tBoxLname = new System.Windows.Forms.TextBox();
            this.tBoxFname = new System.Windows.Forms.TextBox();
            this.lblInstruc = new System.Windows.Forms.Label();
            this.txtBoxInstruct = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.gBoxPlaceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnBurgers)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxPlaceOrder
            // 
            this.gBoxPlaceOrder.Controls.Add(this.pBoxLogo);
            this.gBoxPlaceOrder.Controls.Add(this.lblZipcode);
            this.gBoxPlaceOrder.Controls.Add(this.tBoxZip);
            this.gBoxPlaceOrder.Controls.Add(this.lblBurger);
            this.gBoxPlaceOrder.Controls.Add(this.lblPhone);
            this.gBoxPlaceOrder.Controls.Add(this.lblState);
            this.gBoxPlaceOrder.Controls.Add(this.lblCity);
            this.gBoxPlaceOrder.Controls.Add(this.lblAddress);
            this.gBoxPlaceOrder.Controls.Add(this.lblLname);
            this.gBoxPlaceOrder.Controls.Add(this.lblFname);
            this.gBoxPlaceOrder.Controls.Add(this.numUpDwnBurgers);
            this.gBoxPlaceOrder.Controls.Add(this.cBoxState);
            this.gBoxPlaceOrder.Controls.Add(this.tBoxPhone);
            this.gBoxPlaceOrder.Controls.Add(this.tBoxAddress);
            this.gBoxPlaceOrder.Controls.Add(this.tBoxCity);
            this.gBoxPlaceOrder.Controls.Add(this.tBoxLname);
            this.gBoxPlaceOrder.Controls.Add(this.tBoxFname);
            this.gBoxPlaceOrder.Location = new System.Drawing.Point(12, 12);
            this.gBoxPlaceOrder.Name = "gBoxPlaceOrder";
            this.gBoxPlaceOrder.Size = new System.Drawing.Size(445, 234);
            this.gBoxPlaceOrder.TabIndex = 0;
            this.gBoxPlaceOrder.TabStop = false;
            this.gBoxPlaceOrder.Text = "Place Order";
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Image = global::Burg_s_Burgers.Properties.Resources.Borger;
            this.pBoxLogo.Location = new System.Drawing.Point(27, 76);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(200, 101);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogo.TabIndex = 20;
            this.pBoxLogo.TabStop = false;
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(259, 128);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(52, 13);
            this.lblZipcode.TabIndex = 17;
            this.lblZipcode.Text = "ZIP Code";
            this.lblZipcode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tBoxZip
            // 
            this.tBoxZip.Location = new System.Drawing.Point(318, 125);
            this.tBoxZip.Name = "tBoxZip";
            this.tBoxZip.Size = new System.Drawing.Size(120, 20);
            this.tBoxZip.TabIndex = 5;
            // 
            // lblBurger
            // 
            this.lblBurger.AutoSize = true;
            this.lblBurger.Location = new System.Drawing.Point(131, 22);
            this.lblBurger.Name = "lblBurger";
            this.lblBurger.Size = new System.Drawing.Size(183, 13);
            this.lblBurger.TabIndex = 14;
            this.lblBurger.Text = "Select the number of Burgers to order";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(236, 206);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(282, 179);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(287, 154);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(266, 102);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(254, 76);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(58, 13);
            this.lblLname.TabIndex = 9;
            this.lblLname.Text = "Last Name";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(257, 49);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 8;
            this.lblFname.Text = "First Name";
            // 
            // numUpDwnBurgers
            // 
            this.numUpDwnBurgers.Location = new System.Drawing.Point(318, 20);
            this.numUpDwnBurgers.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numUpDwnBurgers.Name = "numUpDwnBurgers";
            this.numUpDwnBurgers.ReadOnly = true;
            this.numUpDwnBurgers.Size = new System.Drawing.Size(121, 20);
            this.numUpDwnBurgers.TabIndex = 1;
            // 
            // cBoxState
            // 
            this.cBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxState.FormattingEnabled = true;
            this.cBoxState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.cBoxState.Location = new System.Drawing.Point(318, 176);
            this.cBoxState.Name = "cBoxState";
            this.cBoxState.Size = new System.Drawing.Size(121, 21);
            this.cBoxState.Sorted = true;
            this.cBoxState.TabIndex = 7;
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Location = new System.Drawing.Point(318, 203);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(121, 20);
            this.tBoxPhone.TabIndex = 8;
            // 
            // tBoxAddress
            // 
            this.tBoxAddress.Location = new System.Drawing.Point(318, 99);
            this.tBoxAddress.Name = "tBoxAddress";
            this.tBoxAddress.Size = new System.Drawing.Size(121, 20);
            this.tBoxAddress.TabIndex = 4;
            // 
            // tBoxCity
            // 
            this.tBoxCity.Location = new System.Drawing.Point(318, 151);
            this.tBoxCity.Name = "tBoxCity";
            this.tBoxCity.Size = new System.Drawing.Size(120, 20);
            this.tBoxCity.TabIndex = 6;
            // 
            // tBoxLname
            // 
            this.tBoxLname.Location = new System.Drawing.Point(318, 73);
            this.tBoxLname.Name = "tBoxLname";
            this.tBoxLname.Size = new System.Drawing.Size(121, 20);
            this.tBoxLname.TabIndex = 3;
            // 
            // tBoxFname
            // 
            this.tBoxFname.Location = new System.Drawing.Point(318, 46);
            this.tBoxFname.Name = "tBoxFname";
            this.tBoxFname.Size = new System.Drawing.Size(121, 20);
            this.tBoxFname.TabIndex = 2;
            // 
            // lblInstruc
            // 
            this.lblInstruc.AutoSize = true;
            this.lblInstruc.Location = new System.Drawing.Point(169, 252);
            this.lblInstruc.Name = "lblInstruc";
            this.lblInstruc.Size = new System.Drawing.Size(99, 13);
            this.lblInstruc.TabIndex = 19;
            this.lblInstruc.Text = "Special Instructions";
            this.lblInstruc.Click += new System.EventHandler(this.lblInstruc_Click);
            // 
            // txtBoxInstruct
            // 
            this.txtBoxInstruct.Location = new System.Drawing.Point(274, 249);
            this.txtBoxInstruct.MaxLength = 512;
            this.txtBoxInstruct.Multiline = true;
            this.txtBoxInstruct.Name = "txtBoxInstruct";
            this.txtBoxInstruct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxInstruct.Size = new System.Drawing.Size(183, 46);
            this.txtBoxInstruct.TabIndex = 9;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(318, 301);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(139, 46);
            this.btnPlaceOrder.TabIndex = 10;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // Form_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 350);
            this.Controls.Add(this.gBoxPlaceOrder);
            this.Controls.Add(this.lblInstruc);
            this.Controls.Add(this.txtBoxInstruct);
            this.Controls.Add(this.btnPlaceOrder);
            this.Name = "Form_PlaceOrder";
            this.Text = "Place Order";
            this.gBoxPlaceOrder.ResumeLayout(false);
            this.gBoxPlaceOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnBurgers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxPlaceOrder;
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
        private System.Windows.Forms.Label lblInstruc;
        private System.Windows.Forms.TextBox txtBoxInstruct;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.TextBox tBoxZip;
        private System.Windows.Forms.PictureBox pBoxLogo;
    }
}