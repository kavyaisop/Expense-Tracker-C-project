using System;
using System.Windows.Forms;
using System.Drawing;

namespace ExpenseTracker
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;
            string exportFormat = formatComboBox.SelectedItem.ToString();

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be after end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (exportFormat)
            {
                case "CSV":
                    ExportToCSV(startDate, endDate);
                    break;
                case "Excel":
                    ExportToExcel(startDate, endDate);
                    break;
                case "PDF":
                    ExportToPDF(startDate, endDate);
                    break;
            }
        }

        private void ExportToCSV(DateTime startDate, DateTime endDate)
        {
            MessageBox.Show($"Expenses from {startDate.ToShortDateString()} to {endDate.ToShortDateString()} have been exported as CSV.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToExcel(DateTime startDate, DateTime endDate)
        {
            MessageBox.Show($"Expenses from {startDate.ToShortDateString()} to {endDate.ToShortDateString()} have been exported as Excel.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToPDF(DateTime startDate, DateTime endDate)
        {
            MessageBox.Show($"Expenses from {startDate.ToShortDateString()} to {endDate.ToShortDateString()} have been exported as PDF.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
