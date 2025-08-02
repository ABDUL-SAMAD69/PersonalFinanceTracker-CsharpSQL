using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceTracker
{
    public partial class Form1 : Form
    {

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonalFinanceTracker;Integrated Security=True";

        private decimal monthlyBudget = 0;
        private decimal budget;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void labelMonthlyBudget_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMonthlyBudget_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSetMonthlyBudget_Click(object sender, EventArgs e)
        {
            decimal budget;
            if (decimal.TryParse(textBoxMonthlyBudget.Text, out budget))
            {
                monthlyBudget = budget;
                UpdateRemainingBudget();
                MessageBox.Show("Monthly budget set successfully.");
            }
            else
            {
                MessageBox.Show("Please enter a valid budget amount.");
            }
        }

        private void labelExpenseName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxExpenseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelExpenseAmount_Click(object sender, EventArgs e)
        {

        }

        private void textBoxExpenseAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddExpense_Click(object sender, EventArgs e)
        {
            string expenseName = textBoxExpenseName.Text;
            decimal expenseAmount;

            if (decimal.TryParse(textBoxExpenseAmount.Text, out expenseAmount) && !string.IsNullOrWhiteSpace(expenseName))
            {
                InsertExpense(expenseName, expenseAmount);
                LoadExpenses();
                UpdateRemainingBudget();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please enter a valid expense name and amount.");
            }
        }

        private void buttonEditExpense_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpenseDisplay.SelectedRows.Count > 0)
            {
                int Id = Convert.ToInt32(dataGridViewExpenseDisplay.SelectedRows[0].Cells[0].Value);
                string expenseName = textBoxExpenseName.Text;
                decimal expenseAmount;

                if (decimal.TryParse(textBoxExpenseAmount.Text, out expenseAmount) && !string.IsNullOrWhiteSpace(expenseName))
                {
                    UpdateExpense(Id, expenseName, expenseAmount);
                    LoadExpenses();
                    UpdateRemainingBudget();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Please enter a valid expense name and amount.");
                }
            }
            else
            {
                MessageBox.Show("Please select an expense to edit.");
            }
        }

        private void buttonDeleteExpense_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewExpenseDisplay.SelectedRows.Count > 0)
            {
                try
                {
                    
                    int Id = Convert.ToInt32(dataGridViewExpenseDisplay.SelectedRows[0].Cells["Id"].Value);

                    
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this expense?", "Delete Expense", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DeleteExpense(Id); 
                        LoadExpenses();          
                        UpdateRemainingBudget();
                        MessageBox.Show("Expense deleted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select an expense to delete."); 
            }
        }

        private void labelTotalExpense_Click(object sender, EventArgs e)
        {

        }

        private void labelRemainingBudget_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewExpenseDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadExpenses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Expenses";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewExpenseDisplay.DataSource = dataTable;
            }
        }

        
        private void InsertExpense(string expenseName, decimal expenseAmount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Expenses (ExpenseName, ExpenseAmount) VALUES (@ExpenseName, @ExpenseAmount)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ExpenseName", expenseName);
                command.Parameters.AddWithValue("@ExpenseAmount", expenseAmount);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        
        private void UpdateExpense(int Id, string expenseName, decimal expenseAmount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Expenses SET ExpenseName = @ExpenseName, ExpenseAmount = @ExpenseAmount WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", Id);
                command.Parameters.AddWithValue("@ExpenseName", expenseName);
                command.Parameters.AddWithValue("@ExpenseAmount", expenseAmount);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void DeleteExpense(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Expenses WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void UpdateRemainingBudget()
        {
            decimal totalExpenses = 0;

            foreach (DataGridViewRow row in dataGridViewExpenseDisplay.Rows)
            {
                if (row.Cells["ExpenseAmount"].Value != DBNull.Value)
                {
                    totalExpenses += Convert.ToDecimal(row.Cells["ExpenseAmount"].Value);
                }
            }

            labelTotalExpense.Text = "Rs. " + totalExpenses.ToString("F2");
            labelRemainingBudget.Text = "Rs. " + (monthlyBudget - totalExpenses).ToString("F2");

            if (totalExpenses > monthlyBudget)
            {
                MessageBox.Show("Warning: Total expenses exceed the monthly budget!");
            }
        }

      
        private void ClearInputs()
        {
            textBoxExpenseName.Clear();
            textBoxExpenseAmount.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        private void buttonResetEverything_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to Reset? All progress will be lost.", "Reset Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Expenses";
                        SqlCommand command = new SqlCommand(query, connection);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    
                    monthlyBudget = 0;
                    labelTotalExpense.Text = "Rs. 0.00";
                    labelRemainingBudget.Text = "Rs. 0.00";


                    dataGridViewExpenseDisplay.DataSource = null;

                    
                    textBoxMonthlyBudget.Clear();

                    
                    MessageBox.Show("All progress has been reset successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while resetting: {ex.Message}");
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        


    }
}
