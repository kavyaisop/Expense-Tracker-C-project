using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Override OnPaint method to implement gradient background
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(30, 144, 255), // Shiny blue
                                                                       Color.FromArgb(255, 140, 0),  // Shiny orange
                                                                       45F)) // Angle of the gradient
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            string uname = usernameTextBox.Text;
            string pass = passwordTextBox.Text;
            string cpass = confirmPasswordTextBox.Text;
            string email = emailTextBox.Text;

            // Validation logic
            if (string.IsNullOrWhiteSpace(uname))
            {
                MessageBox.Show("Please input Username properly.");
                return;
            }
            if (uname.Contains(" "))
            {
                MessageBox.Show("Username cannot contain whitespace.");
                return;
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Enter proper password.");
                return;
            }
            if (pass.Length > 14 || pass.Length < 8)
            {
                MessageBox.Show("Password cannot be more than 14 characters or less than 8 characters.");
                return;
            }
            if (!pass.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one uppercase letter.");
                return;
            }
            if (!pass.Any(char.IsLower))
            {
                MessageBox.Show("Password must contain at least one lowercase letter.");
                return;
            }
            if (pass != cpass)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            if(pass == cpass) {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\source\repos\ExpenseTracker\ExpenseTracker\Database1.mdf;Integrated Security=True";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        // Insert query for the logintbl
                        string query = "INSERT INTO [logintbl] ([user], [pass], [email]) VALUES (@uname, @pass1, @email1)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Add parameters for user, pass, and email
                            cmd.Parameters.AddWithValue("@uname", uname);  // 'uname' is assumed to be the username variable
                            cmd.Parameters.AddWithValue("@pass1", pass);   // 'pass' is the password variable
                            cmd.Parameters.AddWithValue("@email1", email); // 'email' is the email variable (can be NULL)

                            // Open the database connection
                            conn.Open();

                            // Execute the insertion query
                            cmd.ExecuteNonQuery();

                            // Success message
                            MessageBox.Show("Sign Up Successful!");

                            // Navigate to the login form
                            Form2 loginForm = new Form2();
                            loginForm.Show();
                            this.Hide(); // Hide the sign-up form
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show an error message in case of failure
                    MessageBox.Show("An error occurred: " + ex.Message);
                }


            }


        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Hide();
        }
    }

       
    }
