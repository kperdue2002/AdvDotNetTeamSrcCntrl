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
            //const byte pageSize = 14;

            List<Order> pageOrders =
                //OrderDB.GetOrdersByPageWorkaround(displayForm.PageNum, pageSize, orderContext);
                OrderDB.GetAllOrders(orderContext);

            //List<Order> pageOrders = await
            //    OrderDB.GetOrdersByPage(displayForm.PageNum, pageSize, orderContext);
            foreach (Order orderItem in pageOrders)
            {
                var orderRow = new DataGridViewRow();
                DataGridViewCell[] orderCells = new DataGridViewCell[12];

                orderCells[0] = ToGridCell_TextBox(orderItem.OrderID);
                orderCells[1] = ToGridCell_TextBox(orderItem.FirstName);
                orderCells[2] = ToGridCell_TextBox(orderItem.LastName);
                orderCells[3] = ToGridCell_TextBox(orderItem.Address);
                orderCells[4] = ToGridCell_TextBox(orderItem.City);
                orderCells[5] = ToGridCell_TextBox(orderItem.State);
                orderCells[6] = ToGridCell_TextBox(orderItem.ZipCode);
                orderCells[7] = ToGridCell_TextBox(orderItem.PhoneNumber);
                orderCells[8] = ToGridCell_TextBox(orderItem.Quantity);
                orderCells[9] = ToGridCell_TextBox(orderItem.SpecialDirections);
                orderCells[10] = ToGridCell_TextBox(orderItem.DateOfOrder);
                orderCells[11] = ToGridCell_TextBox(orderItem.IsDelivered);
                
                orderRow.Cells.AddRange(orderCells);

                displayForm.dGridOrderDisplay.Rows.Add(orderRow);
            }
        }
        private static DataGridViewCell ToGridCell_TextBox(Object obj)
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            cell.Value = obj.ToString();
            return cell;
        }
    }
}
