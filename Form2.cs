using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data; // For DataTable
using System.Data.SqlClient; // For SQL-related operations

namespace ExpenseTracker
{
    public partial class Form2 : Form
    {
        // Constructor
        public Form2()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string uname = usernameTextBox.Text;
            string pass = passwordTextBox.Text;

            // Validation logic
            if (string.IsNullOrWhiteSpace(uname))
            {
                MessageBox.Show("Please enter your username.");
                return;
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter your password.");
                return;
            }

            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\source\repos\ExpenseTracker\ExpenseTracker\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Query to check if user credentials exist in the logintbl
                    string query = "SELECT COUNT(1) FROM [logintbl] WHERE [user] = @uname AND [pass] = @pass1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters for username and password
                        cmd.Parameters.AddWithValue("@uname", uname);  // 'uname' is the username
                        cmd.Parameters.AddWithValue("@pass1", pass);   // 'pass' is the password

                        // Open the connection
                        conn.Open();

                        // Execute the query and check if the user exists
                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if (userCount == 1)
                        {
                            // Login successful
                            MessageBox.Show("Login Successful!");
                            Form4 form4 = new Form4();
                            form4.Show();
                            this.Hide();


                        }
                        else
                        {
                            // Invalid login
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                }
            }

            catch (Exception ex) {
                // Handle exceptions (e.g., connection errors)
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
    }
    }

            