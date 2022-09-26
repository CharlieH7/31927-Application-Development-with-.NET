using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Write code to Method to create the payment receipt 
        
        public string GetReceipt()
        {
            // Write code to Initialize the variables for total proice and the recipt string
            double totalPrice = 0.0;
            string receipt = "Student Restaurant \n\nYour Order Details: \n\n";

            // Write code to Process each selected food item and calculate the total price
            foreach (int i in FoodListBox.SelectedIndices)
            {
                // Write code to Concatenate the selected food items and their price.
                receipt = receipt + FoodListBox.Items[i].ToString() + " : $" + PriceListBox.Items[i].ToString() + "\n";

                // Write code to Calculate the total price
                totalPrice += Convert.ToDouble(PriceListBox.Items[i].ToString());
               
            }
            // Write code to Add the total price to the Receipt
            receipt = receipt + "\nTotal Price: $" + totalPrice.ToString();

            // Write code to Return receipt
            return receipt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            ReceiptLabel.Text = GetReceipt();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
