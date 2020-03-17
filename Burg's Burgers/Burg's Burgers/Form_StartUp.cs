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
    public partial class Form_StartUp : Form
    {
        public Form_StartUp()
        {
            InitializeComponent();
        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            Form_PlaceOrder PlaceOrder = new Form_PlaceOrder();
            PlaceOrder.ShowDialog();
        }

        private void BtnShowOrders_Click(object sender, EventArgs e)
        {
            Form_ShowOrders ShowOrders = new Form_ShowOrders();
            ShowOrders.ShowDialog();
        }
    }
}
