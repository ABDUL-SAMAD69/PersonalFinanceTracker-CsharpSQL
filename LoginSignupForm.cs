using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceTracker
{
    public partial class LoginSignupForm : Form
    {

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonalFinanceTracker;Integrated Security=True";


        public LoginSignupForm()
        {
            InitializeComponent();
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUSERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPASSWORD_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLOGIN_Click(object sender, EventArgs e)
        {



            string username = textBoxUSERNAME.Text.Trim();
            string password = textBoxPASSWORD.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                string loginQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand loginCommand = new SqlCommand(loginQuery, connection);
                loginCommand.Parameters.AddWithValue("@Username", username);
                loginCommand.Parameters.AddWithValue("@Password", password);

                int isValidUser = (int)loginCommand.ExecuteScalar();

                if (isValidUser > 0)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); 

                    Form1 mainForm = new Form1();
                    mainForm.Show(); 
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void buttonSIGNUP_Click(object sender, EventArgs e)
        {


            string username = textBoxUSERNAME.Text.Trim();
            string password = textBoxPASSWORD.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection);
                checkUserCommand.Parameters.AddWithValue("@Username", username);

                int userExists = (int)checkUserCommand.ExecuteScalar();

                if (userExists > 0)
                {
                    MessageBox.Show("You've already signed up. Click Login.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string insertUserQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                    SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, connection);
                    insertUserCommand.Parameters.AddWithValue("@Username", username);
                    insertUserCommand.Parameters.AddWithValue("@Password", password);

                    insertUserCommand.ExecuteNonQuery();
                    MessageBox.Show("Signup successful! Please click Login to proceed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
