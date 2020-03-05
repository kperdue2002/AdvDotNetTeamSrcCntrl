using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burg_s_Burgers
{
    public partial class Form_PlaceOrder : Form
    {
        public Form_PlaceOrder()
        {
            InitializeComponent();
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            bool OrderHasEmptyTextbox = false;
            
            foreach(Control c in gBoxPlaceOrder.Controls)
            {
                if (c is TextBox) //c is the group box for some reason.
                {
                    TextBox currField = c as TextBox;
                    if (string.IsNullOrEmpty(currField.Text))
                    {
                        OrderHasEmptyTextbox = true;
                    }
                }
            }
            if (numUpDwnBurgers.Value > 0)
            {
                if (!OrderHasEmptyTextbox)
                {
                    //if all the textboxes are filled, check the combo box
                    Order newOrder = new Order
                    {
                        FirstName = tBoxFname.Text,
                        LastName = tBoxLname.Text,
                        Address = tBoxAddress.Text,
                        City = tBoxCity.Text,
                        State = cBoxState.Text,
                        ZipCode = tBoxZip.Text,
                        PhoneNumber = tBoxPhone.Text,
                        Quantity = Convert.ToByte(numUpDwnBurgers.Value),
                        SpecialDirections = txtBoxInstruct.Text,
                        DateOfOrder = DateTime.Now
                    };

                    MessageBox.Show("Order Added");
                }
                else
                {
                    MessageBox.Show("All required boxes must be populated.");
                }
            }
            else
            {
                MessageBox.Show("Please select the number of Burgers to order.");
            }
            
        }

        private void lblInstruc_Click(object sender, EventArgs e)
        {

        }
    }
}
