namespace Burg_s_Burgers
{
    partial class Form1
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
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Image = global::Burg_s_Burgers.Properties.Resources.Borger;
            this.pBoxLogo.Location = new System.Drawing.Point(115, 12);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(200, 101);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogo.TabIndex = 2;
            this.pBoxLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.Location = new System.Drawing.Point(119, 116);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(196, 81);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "Description of Burg\'s Burgers\r\nBuy our burgers, bro\r\nthey got meat and cheese";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(12, 200);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(170, 101);
            this.btnCreateOrder.TabIndex = 4;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 101);
            this.button2.TabIndex = 5;
            this.button2.Text = "View Orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pBoxLogo);
            this.Name = "Form1";
            this.Text = "Burg\'s Burgers";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button button2;
    }
}
