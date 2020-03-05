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
            int numPopulated = 0;
            foreach(Control c in Controls)
            {
                if (c is TextBox)
                {
                    TextBox currField = c as TextBox;
                    if (!string.IsNullOrEmpty(currField.Text))
                    {
                        numPopulated++;
                    }
                }
            }
            if (numPopulated >= 6)
            {
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
                throw new Exception("All required fields must be populated.");
            }
        }
    }
}
