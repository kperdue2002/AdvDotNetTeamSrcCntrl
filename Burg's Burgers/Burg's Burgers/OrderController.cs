using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burg_s_Burgers
{
    public class OrderController
    {
        private static OrderContext orderContext;

        static OrderController()
        {
            orderContext = new OrderContext();
        }

        public static async Task Add(Form_PlaceOrder addForm)
        {
            Order newOrder = new Order
            {
                FirstName = addForm.TB_FIRST_NAME.Text,
                LastName = addForm.TB_LAST_NAME.Text,
                Address = addForm.TB_ADDRESS.Text,
                City = addForm.TB_CITY.Text,
                State = addForm.CB_STATE.SelectedItem is StateItem state ?
                        state.StateAbbreviation : "ER",
                ZipCode = addForm.TB_ZIP_CODE.Text,
                PhoneNumber = addForm.TB_PHONE_NUMBER.Text,
                Quantity = Convert.ToByte(addForm.NUD_QUANTITY.Value),
                SpecialDirections = addForm.TB_SPECIAL_DIRECTIONS.Text,
                DateOfOrder = DateTime.Now
            };

            ValidationContext validationContext = new ValidationContext(newOrder);
            IList<ValidationResult> errors = new List<ValidationResult>();

            string errMsg = "VALIDATION ERROR:";

            if (!Validator.TryValidateObject(newOrder, validationContext, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    errMsg += $"\n{result.ErrorMessage}";
                }
                MessageBox.Show(errMsg);
            }
            else
            {
                await OrderDB.Add(newOrder, orderContext);
                MessageBox.Show("Order Added");
            }
        }
        private async Task<int> GetMaxPage(int PageSize)
        {
            int numProducts = await OrderDB.GetNumOrders(orderContext);
            return Convert.ToInt32(
                   Math.Ceiling((double)numProducts / PageSize));
        }
        public static void ShowPage(Form_ShowOrders displayForm)
        {
            const byte pageSize = 14;
            List<Order> pageOrders = 
                OrderDB.GetOrdersByPage(displayForm.PageNum, pageSize, orderContext);
            foreach (Order orderItem in pageOrders)
            {
                var orderRow = new DataGridViewRow();
                orderRow.Cells[0].Value = orderItem.OrderID;
                orderRow.Cells[1].Value = orderItem.FirstName;
                orderRow.Cells[2].Value = orderItem.LastName;
                orderRow.Cells[3].Value = orderItem.Address;
                orderRow.Cells[4].Value = orderItem.City;
                orderRow.Cells[5].Value = orderItem.State;
                orderRow.Cells[6].Value = orderItem.ZipCode;
                orderRow.Cells[7].Value = orderItem.PhoneNumber;
                orderRow.Cells[8].Value = orderItem.Quantity;
                orderRow.Cells[9].Value = orderItem.SpecialDirections;
                orderRow.Cells[10].Value = orderItem.SpecialDirections;
                orderRow.Cells[11].Value = orderItem.DateOfOrder;
                orderRow.Cells[12].Value = orderItem.IsDelivered;
                displayForm.dGridOrderDisplay.Rows.Add();
            }
        }
    }
}
