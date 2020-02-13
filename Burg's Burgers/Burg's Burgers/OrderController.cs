using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burg_s_Burgers
{
    public class OrderController
    {
        private static OrderContext context;

        static OrderController()
        {
            context = new OrderContext();
        }

        public static async Task Add(Form_PlaceOrder addForm)
        {
            Order newOrder = new Order
            {
                FirstName = addForm.TB_FIRST_NAME.Text,
                LastName = addForm.TB_LAST_NAME.Text,
                Address = addForm.TB_ADDRESS.Text,
                City = addForm.TB_CITY.Text,
                State = (addForm.CB_STATE.SelectedItem as StateItem).StateAbbreviation,
                ZipCode = addForm.TB_ZIP_CODE.Text,
                PhoneNumber = addForm.TB_PHONE_NUMBER.Text,
                Quantity = Convert.ToByte(addForm.NUD_QUANTITY.Value),
                SpecialDirections = addForm.TB_SPECIAL_DIRECTIONS.Text,
                DateOfOrder = DateTime.Now
            };

            await OrderDB.Add(newOrder, context);
        }
    }
}
