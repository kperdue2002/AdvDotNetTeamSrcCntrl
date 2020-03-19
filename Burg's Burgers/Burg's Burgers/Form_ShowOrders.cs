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
    public partial class Form_ShowOrders : Form
    {
        public int PageNum { get; set; }
        public Form_ShowOrders(int PageNum)
        {
            this.PageNum = PageNum;
        }

        public Form_ShowOrders()
        {
            PageNum = 1;
            InitializeComponent();
            //OrderController.ShowPage(this).GetAwaiter().GetResult();
            OrderController.ShowPage(this);
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            await OrderController.Delete(this);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            OrderController.Edit(this);
        }
    }
}
