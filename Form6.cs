using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(400, 300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = Color.FromArgb(240, 248, 255); // Light blue background
            CalculateTotalExpenses(); // Call to calculate expenses
        }

        private void CalculateTotalExpenses()
        {
            // Assuming Form4 is open and expenses are stored in the DataGridView
            var mainForm = Application.OpenForms.OfType<Form4>().FirstOrDefault(); // Get the Form4 instance
            if (mainForm != null)
            {
                var expenseTable = mainForm.Controls.OfType<DataGridView>().FirstOrDefault(); // Find the DataGridView
                if (expenseTable != null)
                {
                    decimal totalExpenses = 0;
                    foreach (DataGridViewRow row in expenseTable.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            decimal expenseAmount;
                            if (decimal.TryParse(row.Cells[0].Value.ToString(), out expenseAmount))
                            {
                                totalExpenses += expenseAmount; // Accumulate total expenses
                            }
                        }
                    }
                    expensesValueLabel.Text = totalExpenses.ToString("C"); // Format as currency
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form6
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
