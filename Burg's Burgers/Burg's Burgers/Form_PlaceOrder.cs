﻿using System;
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

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order
            {
                FirstName = tBoxFname.Text,
                LastName = tBoxLname.Text,
                Address = tBoxAddress.Text,
                City = tBoxCity.Text,
                State = (cBoxState.SelectedItem as StateItem).StateAbbreviation,
                ZipCode = tBoxZip.Text,
                PhoneNumber = tBoxPhone.Text,
                Quantity = Convert.ToByte(numUpDwnBurgers.Value),
                SpecialDirections = txtBoxInstruct.Text,
                DateOfOrder = DateTime.Now
            };

            //Really gotta get this thing working
            //OrderDB.Add(newOrder);

            MessageBox.Show("Order Added");
        }
    }
}
