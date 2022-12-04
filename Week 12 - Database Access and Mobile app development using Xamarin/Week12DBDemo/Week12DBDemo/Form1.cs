using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12DBDemo
{
    public partial class Form1 : Form
    {
        //Global Connection object accessable within form
        private OleDbConnection conn = new OleDbConnection();

        // Method to check database connection during the form load event.
        public bool checkDbConnection()
        {   
            try
            {
                //private OleDbConnection conn = new OleDbConnection();
                //conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\130410\\AppLockerExceptions\\Week12DBDemo\\Week12DBDemo\\StudentDB.accdb";
                conn.Open();
                //MessageBox.Show("Database Connection Established!");
                status.ForeColor = Color.Green;               
                status.Text = "Connected!";
                return true;
            }
            catch (Exception ex)
            {
                status.ForeColor = Color.Red;
                status.Text = "Not Connected!";
                return false;
            }
            finally
            {
                conn.Close();
            }

        }
        public Form1()
        {
            InitializeComponent();
            // Define the Connection string
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudentDB.accdb"; //C:\\Users\\130410\\AppLockerExceptions\\Week12DBDemo\\Week12DBDemo\\
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkDbConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open(); // Open connection
            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;
            // Create the SQL query 
            command.CommandText = "SELECT * FROM student where email='"+txt_Username.Text+"' and passwd='"+txt_pwd.Text+"'";
                        
            
            try
            {
                
                // Run the SQL query          
               OleDbDataReader reader =   command.ExecuteReader();

                // To check if the credentials matched with the database.
                int count = 0;

                // Browse all the records retrieved from the SQL query
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Credetials are valid!");
                   
                }
                else {
                    MessageBox.Show("Invalid Credetials!");

                }

                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to database");                

            }
            finally
            {
                conn.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Hide the current form and display the new user registration form.
            this.Hide();
            Register form2 = new Register();
            form2.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
