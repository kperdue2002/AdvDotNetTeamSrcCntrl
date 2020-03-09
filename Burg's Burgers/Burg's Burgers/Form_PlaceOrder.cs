using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burg_s_Burgers
{
    public partial class Form_PlaceOrder : Form
    {
        public Form_PlaceOrder()
        {
            InitializeComponent();
        }

        //none of this works
        /*private bool ValidZipCode(string zipCode)
        {
            string ZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            return !Regex.Match(zipCode, ZipRegEx).Success;

        }

        private bool ValidPhoneNumber(string phoneNumber)
        {
            //I googled an already existing Regex string for phone number validation
            //this regex string (in theory) allows numbers that are 10 digits, with extensions allowed, and spaces, dashes, or periods as the delimiters.
            //https://stackoverflow.com/a/123666
            string PhoneRegEx = @"/(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})/";
            return Regex.Match(phoneNumber, PhoneRegEx).Success;
        }*/

        public bool InputIsValid(Control.ControlCollection Input)
        {
            if
                (
                    tBoxFname.Text is string &&
                    tBoxLname.Text is string &&
                    tBoxAddress.Text is string && //assumes user will input a valid US address. adding address validation can be done but would limit test data input
                    tBoxCity.Text is string
                    //ValidZipCode(tBoxZip.Text)
                    //ValidPhoneNumber(tBoxPhone.Text)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            bool OrderHasEmptyTextbox = false;
            
            foreach(Control c in gBoxPlaceOrder.Controls)
            {
                if (c is TextBox) //c is the group box for some reason.
                {
                    TextBox currField = c as TextBox;
                    if (string.IsNullOrEmpty(currField.Text))
                    {
                        OrderHasEmptyTextbox = true;
                    }
                }
            }
            if (numUpDwnBurgers.Value > 0)
            {
                if (!OrderHasEmptyTextbox)
                {
                    //if all the textboxes are filled, check the combo box for valid input

                    if (InputIsValid(gBoxPlaceOrder.Controls))
                    {
                        Order newOrder = new Order
                        {
                            //validation code is messy
                            FirstName = tBoxFname.Text,
                            LastName = tBoxLname.Text,
                            Address = tBoxAddress.Text,
                            City = tBoxCity.Text,
                            State = cBoxState.Text,
                            ZipCode = tBoxZip.Text,
                            PhoneNumber = tBoxPhone.Text,
                            Quantity = Convert.ToByte(numUpDwnBurgers.Value),
                            SpecialDirections = txtBoxInstruct.Text,
                            DateOfOrder = DateTime.Now
                        };
                        MessageBox.Show("Order Added");
                    }
                    else
                    {
                        MessageBox.Show("Not all data is valid. Please check your input and try again.");
                    }


                }
                else
                {
                    MessageBox.Show("All required boxes must be populated.");
                }
            }
            else
            {
                MessageBox.Show("Please select the number of Burgers to order.");
            }
            
        }

        private void lblInstruc_Click(object sender, EventArgs e)
        {

        }
    }
}
