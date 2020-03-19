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
    public partial class Form_PlaceOrder : Form
    {
        public CheckBox chkBoxIsDelivered;
        public bool IsEditing { get; set; }
        public Order OrderToEdit { get; set; }

        private readonly string[,] StateNames = new string[,]
        {
            {
                "Alabama", "Alaska", "Arizona", "Arkansas", "California",
                "Colorado", "Connecticut", "Delaware", "Florida", "Georgia",
                "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa",
                "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland",
                "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri",
                "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey",
                "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio",
                "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina",
                "South Dakota", "Tennessee", "Texas", "Utah", "Vermont",
                "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"
            },
            {
                "AL", "AK", "AZ", "AR", "CA",
                "CO", "CT", "DE", "FL", "GA",
                "HI", "ID", "IL", "IN", "IA",
                "KS", "KY", "LA", "ME", "MD",
                "MA", "MI", "MN", "MS", "MO",
                "MT", "NE", "NV", "NH", "NJ",
                "NM", "NY", "NC", "ND", "OH",
                "OK", "OR", "PA", "RI", "SC",
                "SD", "TN", "TX", "UT", "VT",
                "VA", "WA", "WV", "WI", "WY"
            }
        };
        public Form_PlaceOrder()
        {
            InitializeComponent();

            AddStates();
        }

        private void EditorSetup()
        {
            chkBoxIsDelivered = new CheckBox
            {
                AutoSize = true,
                CheckAlign = ContentAlignment.MiddleRight,
                Checked = OrderToEdit.IsDelivered,
                Location = new Point(186, 296),
                //Name = "chkBoxIsDelivered",
                Size = new Size(97, 17),
                //TabIndex = 29,
                Text = "Delivery Status",
                UseVisualStyleBackColor = true
            };
            groupBox1.Controls.Add(chkBoxIsDelivered);

            tBoxFname.Text = OrderToEdit.FirstName;
            tBoxLname.Text = OrderToEdit.LastName;
            tBoxAddress.Text = OrderToEdit.Address;
            tBoxCity.Text = OrderToEdit.City;
            cBoxState.SelectedIndex = FindStateIndex(OrderToEdit.State);
            tBoxZip.Text = OrderToEdit.ZipCode;
            tBoxPhone.Text = OrderToEdit.PhoneNumber;
            numUpDwnBurgers.Value = OrderToEdit.Quantity;
            txtBoxInstruct.Text = OrderToEdit.SpecialDirections;

            btnPlaceOrder.Text = "Edit Order";
            groupBox1.Text = "Edit Order";
            Text = "Edit Order";
        }

        private void AddStates()
        {
            for (int i = 0; i < StateNames.GetLength(1); i++)
            {
                StateItem stateItem = new StateItem
                {
                    StateName = StateNames[0, i],
                    StateAbbreviation = StateNames[1, i]
                };
                cBoxState.Items.Add(stateItem);
            }
        }

        private int FindStateIndex(string state)
        {
            for (int i = 0; i < StateNames.GetLength(1); i++)
            {
                if (state == StateNames[1, i])
                {
                    return i;
                }
            }
            return 0;
        }

        private async void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            Enabled = false;
            await OrderController.Add(this, IsEditing, OrderToEdit);
            Enabled = true;
        }

        private void Form_PlaceOrder_Load(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                EditorSetup();
            }
        }
    }
}
