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
        public TextBox TB_FIRST_NAME;
        public TextBox TB_LAST_NAME;
        public TextBox TB_ADDRESS;
        public TextBox TB_CITY;
        public ComboBox CB_STATE;
        public TextBox TB_ZIP_CODE;
        public TextBox TB_PHONE_NUMBER;
        public NumericUpDown NUD_QUANTITY;
        public TextBox TB_SPECIAL_DIRECTIONS;

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

            TB_FIRST_NAME = tBoxFname;
            TB_LAST_NAME = tBoxLname;
            TB_ADDRESS = tBoxAddress;
            TB_CITY = tBoxCity;
            CB_STATE = cBoxState;
            TB_ZIP_CODE = tBoxZip;
            TB_PHONE_NUMBER = tBoxPhone;
            NUD_QUANTITY = numUpDwnBurgers;
            TB_SPECIAL_DIRECTIONS = txtBoxInstruct;

            AddStates();
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

        private async void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            await OrderController.Add(this);

            MessageBox.Show("Order Added");
        }
    }
}
