using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class NewUserForm : Form
    {
        // global variables to keep track of username, password, confirmed password, first and last name in the textbox
        string username = "";
        string password = "";
        string confirmPassword = "";
        string firstName = "";
        string lastName = "";
        public NewUserForm()
        {
            InitializeComponent();
        }

        // called when the cancel button is clicked, hide the current form (new user form) and shows the login form
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        // Called when the username text box has changed.
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            username = UsernameTextBox.Text;
        }

        // Called when the password text box has changed.
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            password = PasswordTextBox.Text;
        }

        // Called when the re-enter password text box has changed.
        private void ReEnterPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmPassword = ReEnterPasswordTextBox.Text;
        }

        // Called when the first name text box has changed.
        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            firstName = FirstNameTextBox.Text;
        }

        // Called when the last name text box has changed.
        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            lastName = LastNameTextBox.Text;
        }

        // Check if username already existed in the login.txt file, if exists return true, else return false
        private bool UsernameExists(string username)
        {
            string[] userNames = File.ReadAllLines("login.txt");
            foreach (string userName in userNames)
            {
                string[] separator = { ",", " " };
                string[] userNameInfo = userName.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (username == userNameInfo[0])
                    return true;
            }
            return false;
        }

        // called when the submit button is clicked
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // check if the username textbox is blank or not 
            if (username == "")
            {
                MessageBox.Show("Username cannot be blank.\nPlease re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // check if username already exist in login.txt
            else if (UsernameExists(this.username))
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // check if password or re-enter password field is empty
            else if (password == "" || confirmPassword == "")
            {
                MessageBox.Show("Password cannot be blank.\nPlease re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // check if password is the same as re-enter password textbox
            else if (password != confirmPassword)
            {
                MessageBox.Show("Password do not match\nPlease re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                PasswordTextBox.Text = string.Empty;
                ReEnterPasswordTextBox.Text = string.Empty;
            }
            // check if the user has selected an item in the combo box (view || edit)
            else if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("User type cannot be empty\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // check if the firstname textbox is empty
            else if (firstName == "")
            {
                MessageBox.Show("First Name cannot be blank.\nPlease re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // check if the lastname textbox is empty
            else if (lastName == "")
            {
                MessageBox.Show("Last Name cannot be blank.\nPlease re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // if all the textbox and combo box has been filled then add then to login.txt with the specified format
            else
            {
                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.MaxDate = DateTime.Today;
                dateTimePicker.CustomFormat = "dd-MM-yyyy";
                File.AppendAllText("login.txt", $"\n{username},{password}," +$"{comboBox.SelectedItem},{firstName},{lastName}," + $"{dateTimePicker.Text}");
                MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new LoginForm().Show();
            }
        }


        // custom made function that when you clicked on the closed eye image in the password textbox it shows revert back to '*'
        private void HideButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '\0')
            {
                ShowButton.BringToFront();
                PasswordTextBox.PasswordChar = '*';
            }
        }

        // custom made function that when you clicked on the eye image in the password textbox it shows the password rather then '*'
        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '*')
            {
                HideButton.BringToFront();
                PasswordTextBox.PasswordChar = '\0';
            }
        }

        // custom made function that when you clicked on the eye image in the password textbox it shows the password rather then '*'
        private void ShowButton2_Click(object sender, EventArgs e)
        {
            if (ReEnterPasswordTextBox.PasswordChar == '*')
            {
                HideButton2.BringToFront();
                ReEnterPasswordTextBox.PasswordChar = '\0';
            }
        }

        // custom made function that when you clicked on the closed eye image in the password textbox it shows revert back to '*'
        private void HideButton2_Click(object sender, EventArgs e)
        {
            if (ReEnterPasswordTextBox.PasswordChar == '\0')
            {
                ShowButton2.BringToFront();
                ReEnterPasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
