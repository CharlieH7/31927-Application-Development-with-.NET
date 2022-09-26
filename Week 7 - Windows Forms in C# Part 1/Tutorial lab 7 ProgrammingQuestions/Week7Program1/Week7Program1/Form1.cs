using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // Complete the Method to create the payment receipt 
        public string GetReceipt()
        {
            // Write code to Initialize the variables for total proice and the recipt string
            double totalPrice = 0;
            string receipt = "Student Restaurant\n\nYour Order Details:\n\n";

            // Write code to Create a Checkbox array for food items and assigned each food item to an element
            CheckBox[] menuItems = new CheckBox[7];
            menuItems[0] = CheckBoxTeaAndCoffee;
            menuItems[1] = CheckBoxJuice;
            menuItems[2] = CheckBoxBananaBread;
            menuItems[3] = CheckBoxCereal;
            menuItems[4] = CheckBoxSushi;
            menuItems[5] = CheckBoxPizza;
            menuItems[6] = CheckBoxDrinks;


            // Write code to Create a label array for food item prices and assigned each price item to an element
            Label[] price = new Label[7];
            price[0] = PriceTeaCoffee;
            price[1] = PriceJuice;
            price[2] = PriceBananaBread;
            price[3] = PriceCereal;
            price[4] = PriceSushi;
            price[5] = PricePizza;
            price[6] = PriceDrinks;


            // Write code to Process each selected food item and calculate the total price
            for (int loopVar = 0; loopVar < menuItems.Length; loopVar++)
            {
                if (menuItems[loopVar].Checked == true)
                {
                    // Write code to Concatenate the selected food items and their price.
                    receipt = receipt + menuItems[loopVar].Text + " : $" + price[loopVar].Text + "\n";

                    //Write code to Calculate the total price
                    totalPrice += Convert.ToDouble(price[loopVar].Text);
                }
            }

            // Write code to Add the total price to the Receipt
            receipt = receipt + "Total Price: $" + totalPrice;

            // Write code to Return receipt
            return receipt;
        }

     
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetReceipt(), "Receipt");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
