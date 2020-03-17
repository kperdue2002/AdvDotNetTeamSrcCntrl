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
        public static OrderContext orderContext;

        static OrderController()
        {
            orderContext = new OrderContext();
        }

        public static async Task Add(Form_PlaceOrder addForm, bool IsEditing, Order newOrder)
        {
            if (!IsEditing)
            {
                newOrder = new Order();
                newOrder.DateOfOrder = DateTime.Now;
            }
            else
            {
                newOrder.IsDelivered = addForm.chkBoxIsDelivered.Checked;
            }

            newOrder.FirstName = addForm.tBoxFname.Text;
            newOrder.LastName = addForm.tBoxLname.Text;
            newOrder.Address = addForm.tBoxAddress.Text;
            newOrder.City = addForm.tBoxCity.Text;
            newOrder.State = addForm.cBoxState.SelectedItem is StateItem state ?
                             state.StateAbbreviation : "ER";
            newOrder.ZipCode = addForm.tBoxZip.Text;
            newOrder.PhoneNumber = addForm.tBoxPhone.Text;
            newOrder.Quantity = Convert.ToByte(addForm.numUpDwnBurgers.Value);
            newOrder.SpecialDirections = addForm.txtBoxInstruct.Text;

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
                if (!IsEditing)
                {
                    await OrderDB.Add(newOrder, orderContext);
                    MessageBox.Show("Order Added");
                }
                else
                {
                    await OrderDB.Edit(newOrder, orderContext);
                    MessageBox.Show("Order Edited");
                }
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
                DataGridViewRow orderRow = ToRow(orderItem);

                displayForm.dGridOrderDisplay.Rows.Add(orderRow);
            }
        }

        public static DataGridViewRow ToRow(Order orderItem)
        {
            var orderRow = new DataGridViewRow();
            DataGridViewCell[] orderCells = ToCellArray(orderItem);

            orderRow.Cells.AddRange(orderCells);
            return orderRow;
        }

        public static DataGridViewCell[] ToCellArray(Order orderItem)
        {
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
            return orderCells;
        }
        public static string[] ToStringArray(Order orderItem)
        {
            string[] orderStrings = new string[12];

            orderStrings[0]  = orderItem.OrderID.ToString();
            orderStrings[1]  = orderItem.FirstName;
            orderStrings[2]  = orderItem.LastName;
            orderStrings[3]  = orderItem.Address;
            orderStrings[4]  = orderItem.City;
            orderStrings[5]  = orderItem.State;
            orderStrings[6]  = orderItem.ZipCode;
            orderStrings[7]  = orderItem.PhoneNumber;
            orderStrings[8]  = orderItem.Quantity.ToString();
            orderStrings[9]  = orderItem.SpecialDirections;
            orderStrings[10] = orderItem.DateOfOrder.ToString();
            orderStrings[11] = orderItem.IsDelivered.ToString();
            return orderStrings;
        }

        private static DataGridViewCell ToGridCell_TextBox(Object obj)
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            cell.Value = obj.ToString();
            return cell;
        }
    }
}
