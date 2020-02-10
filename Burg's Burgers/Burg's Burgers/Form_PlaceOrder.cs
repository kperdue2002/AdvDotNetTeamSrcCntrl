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
    }
}
