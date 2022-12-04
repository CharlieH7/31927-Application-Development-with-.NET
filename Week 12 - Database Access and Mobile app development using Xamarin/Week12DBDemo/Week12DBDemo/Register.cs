using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12DBDemo
{
    public partial class Register : Form
    {
        //Global Connection object accessable within form
        // Openn connect to a data source --> MS Access in this example
        private OleDbConnection conn = new OleDbConnection();

        public Register()
        {
            InitializeComponent();
            // Create the connection string
            // 
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudentDB.accdb"; //C:\\Users\\130410\\AppLockerExceptions\\Week12DBDemo\\Week12DBDemo\\
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                       
            try
            {
                //conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "INSERT INTO student (email, FName, LName, [Year], passwd) VALUES ('"+txt_email.Text+"','"+ txt_Name.Text + "','"+txt_Lname.Text+ "','" +cmb_year.SelectedItem+ "','" + txt_pwd.Text + "')";
                MessageBox.Show(command.CommandText);
                conn.Open();


                command.ExecuteNonQuery();
                // Insert code to process data.
                MessageBox.Show("Registration Successfull!");
                //conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update database: "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 loginFrm = new Form1();
            loginFrm.ShowDialog();
        }
    }
}
