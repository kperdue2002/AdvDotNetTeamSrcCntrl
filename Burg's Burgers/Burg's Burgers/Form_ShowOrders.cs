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

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var selectedRow = dGridOrderDisplay.CurrentRow;
            var selectedID = int.Parse(selectedRow.Cells[0].Value.ToString());

            Form_PlaceOrder EditOrder = new Form_PlaceOrder
            {
                IsEditing = true,
                OrderToEdit = OrderDB.GetOrderbyID(selectedID, OrderController.orderContext)
            };
            EditOrder.ShowDialog();
            string[] RowReplacement = 
                OrderController.ToStringArray(OrderDB.GetOrderbyID(selectedID, OrderController.orderContext));
            dGridOrderDisplay.CurrentRow.SetValues(RowReplacement);
        }
    }
}
