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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Order o = new Order();

            o.FirstName = tBoxFname.Text;
            o.LastName = tBoxLname.Text;
            o.Address = tBoxAddress.Text;
            o.City = tBoxCity.Text;
            o.State = cBoxState.Text;
            o.ZipCode = tBoxZip.Text;
            o.PhoneNumber = tBoxPhone.Text;

            //BUG - "Unable to cast object of type 'System.Windows.Forms.NumericUpDown' to type 'System.IConvertible'.
            o.Quantity = Convert.ToByte(numUpDwnBurgers); 
            o.SpecialDirections = txtBoxInstruct.Text;
            o.DateOfOrder = DateTime.Now;

            MessageBox.Show("Order Added");

        }
    }
}
