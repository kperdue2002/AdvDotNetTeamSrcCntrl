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
    }
}
