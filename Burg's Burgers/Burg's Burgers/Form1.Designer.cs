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
            this.gBoxMenu = new System.Windows.Forms.GroupBox();
            this.numUpDwnMenu1 = new System.Windows.Forms.NumericUpDown();
            this.cBoxMenu1 = new System.Windows.Forms.CheckBox();
            this.gBoxOrder = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.gBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxMenu
            // 
            this.gBoxMenu.Controls.Add(this.btnAddItem);
            this.gBoxMenu.Controls.Add(this.label1);
            this.gBoxMenu.Controls.Add(this.numUpDwnMenu1);
            this.gBoxMenu.Controls.Add(this.cBoxMenu1);
            this.gBoxMenu.Location = new System.Drawing.Point(12, 12);
            this.gBoxMenu.Name = "gBoxMenu";
            this.gBoxMenu.Size = new System.Drawing.Size(209, 215);
            this.gBoxMenu.TabIndex = 0;
            this.gBoxMenu.TabStop = false;
            this.gBoxMenu.Text = "Menu";
            // 
            // numUpDwnMenu1
            // 
            this.numUpDwnMenu1.Location = new System.Drawing.Point(6, 42);
            this.numUpDwnMenu1.Name = "numUpDwnMenu1";
            this.numUpDwnMenu1.Size = new System.Drawing.Size(79, 20);
            this.numUpDwnMenu1.TabIndex = 1;
            // 
            // cBoxMenu1
            // 
            this.cBoxMenu1.AutoSize = true;
            this.cBoxMenu1.Location = new System.Drawing.Point(6, 19);
            this.cBoxMenu1.Name = "cBoxMenu1";
            this.cBoxMenu1.Size = new System.Drawing.Size(79, 17);
            this.cBoxMenu1.TabIndex = 0;
            this.cBoxMenu1.Text = "MenuItem1";
            this.cBoxMenu1.UseVisualStyleBackColor = true;
            // 
            // gBoxOrder
            // 
            this.gBoxOrder.Location = new System.Drawing.Point(12, 233);
            this.gBoxOrder.Name = "gBoxOrder";
            this.gBoxOrder.Size = new System.Drawing.Size(415, 223);
            this.gBoxOrder.TabIndex = 1;
            this.gBoxOrder.TabStop = false;
            this.gBoxOrder.Text = "Confirm Order";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(91, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Description";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(6, 164);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(197, 45);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Image = global::Burg_s_Burgers.Properties.Resources.Borger;
            this.pBoxLogo.Location = new System.Drawing.Point(227, 68);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(200, 101);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogo.TabIndex = 2;
            this.pBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 468);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.gBoxOrder);
            this.Controls.Add(this.gBoxMenu);
            this.Name = "Form1";
            this.Text = "Burg\'s Burgers";
            this.gBoxMenu.ResumeLayout(false);
            this.gBoxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxMenu;
        private System.Windows.Forms.NumericUpDown numUpDwnMenu1;
        private System.Windows.Forms.CheckBox cBoxMenu1;
        private System.Windows.Forms.GroupBox gBoxOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.PictureBox pBoxLogo;
    }
}

