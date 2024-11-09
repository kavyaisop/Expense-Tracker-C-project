using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent(); // Initialize components
            // Attach event handlers
           // addButton.Click += new EventHandler(addButton_Click_1);
           // exportButton.Click += new EventHandler(ExportButton_Click);
           // reportSummaryButton.Click += new EventHandler(ReportSummaryButton_Click);
        }

        // Event handler for Add Expense button
      

        // Event handler to open Export Form
      //  private void ExportButton_Click(object sender, EventArgs e)
        //{
           
        //}

        // Event handler to open Form6 (Report Summary)
        //private void ReportSummaryButton_Click(object sender, EventArgs e)
        //{
           // Form6 reportForm = new Form6(); // Create an instance of Form6
            //reportForm.ShowDialog(); // Open as a modal dialog
        //}

        private void addButton_Click_1(object sender, EventArgs e)
        {
            string expenseText = textBoxExpense.Text;
            string reason = textBoxReason.Text;

            // Validation for expense and reason
            if (string.IsNullOrWhiteSpace(expenseText))
            {
                MessageBox.Show("Please enter an expense amount.");
                return;
            }

            if (!decimal.TryParse(expenseText, out decimal expense))
            {
                MessageBox.Show("Please enter a valid expense amount.");
                return;
            }

            if (string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Please provide a reason for the expense.");
                return;
            }

            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\source\repos\ExpenseTracker\ExpenseTracker\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // SQL query to insert the expense and reason into the 'expenses' table
                    string query = "INSERT INTO [expense] (expense, reason) VALUES (@expense, @reason)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@expense", expense);
                        cmd.Parameters.AddWithValue("@reason", reason);

                        // Open the connection
                        conn.Open();

                        // Execute the insert command
                        cmd.ExecuteNonQuery();

                        // Show success message
                        MessageBox.Show("Expense added successfully!");
                        string[] row = new string[] { expenseText, reason };
                        expenseTable.Rows.Add(row);
                        textBoxExpense.Clear();
                        textBoxReason.Clear();
                        // Optionally, clear the text boxes after successful addition

                    }
                }
            }
            catch (Exception ex)
            {
                // Display error message in case of failure
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void reportSummaryButton_Click_1(object sender, EventArgs e)
        {
            Form6 reportForm = new Form6(); // Create an instance of Form6
            reportForm.ShowDialog(); // Open as a modal dialog
        }

        private void exportButton_Click_1(object sender, EventArgs e)
        {
            Form5 exportForm = new Form5();
            exportForm.ShowDialog(); // Opens the Export Form as a modal dialog
        }
    }
    }

