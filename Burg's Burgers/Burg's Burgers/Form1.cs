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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 CreateOrder = new Form2();
        Form3 ShowOrders = new Form3();
    
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {

            CreateOrder.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowOrders.Show();
        }
    }
}
