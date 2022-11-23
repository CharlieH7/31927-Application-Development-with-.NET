using Microsoft.VisualBasic.ApplicationServices;

namespace Assignment_2
{
    public partial class LoginForm : Form
    {
        // global variables to keep track of username and password in the textbox
        string username = "";
        string password = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        // Called when exit button clicked. Terminate the windows form.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // Called when the user's login text box has changed.
        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            this.username = LoginTextBox.Text;
        }

        // Called when the user's password text box has changed.
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            this.password = PasswordTextBox.Text;
        }

        // Called when the login button is pressed
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Go through login.txt line by line flitering out each element by a comma into a string array called login
                string[] loginCredentials = File.ReadAllLines("login.txt");
                bool loginSuccessful = false;
                foreach (string loginCredential in loginCredentials)
                {
                    string[] separator = { ",", " " };
                    string[] login = loginCredential.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    // check if the username and the password in the textbox equals to the ones in login.txt, if true then show textEditor form
                    if (username.CompareTo(login[0]) == 0 && password.CompareTo(login[1]) == 0)
                    {
                        loginSuccessful = true;
                        this.Hide();
                        new TextEditorForm(this, login[2], login[3]).Show();
                        break;
                    }
                    else
                    {
                        loginSuccessful = false;
                    }
                }
                // if username or password does not match the ones in login.txt then display a messagebox showing incorrect username or password message
                if (!loginSuccessful)
                {
                    MessageBox.Show("Incorrect username or password.\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            // catch file not being found exception with the message box displaying file not found
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found");
            }
        }
        
        // called when the new user button is clicked, triggered the new user form
        private void NewUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NewUserForm().Show();   
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

        // custom made function that when you clicked on the closed eye image in the password textbox it shows revert back to '*'
        private void HideButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '\0')
            {
                ShowButton.BringToFront();
                PasswordTextBox.PasswordChar = '*';
            }
        }
    }
}