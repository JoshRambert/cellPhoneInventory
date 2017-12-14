using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cellPhoneInventory
{
    public partial class Form1 : Form
    {
        //List to hold the celphone data
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }
        //create a method to get the data from for the cellPhone

        private void GetData(CellPhone phone) {
            //temp variable to hold the price
            decimal price;

            //get the brand and all the other shit
            brandTextBox.Text = phone.Brand;
            modelTextBox.Text = phone.Model;

            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();

            //get the phone Data and add to the list 
            GetData(myPhone);
            phoneList.Add(myPhone);

            //Add entry to the listBox
            phoneListBox.Items.Add(myPhone.Brand + "" + myPhone.Model);

            //clear the textBoxes
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            //Focus the brandTextBox
            brandTextBox.Focus();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the index of the selected item
            int index = phoneListBox.SelectedIndex;

            //Display the selected items price
            MessageBox.Show(phoneList[index].Price.ToString("c"));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //close the form 
            this.Close();
        }
    }
}
