using System;
using System.Windows.Forms;
using System.Drawing;

namespace ExpenseTracker
{
    partial class Form5
    {
        private Label labelStartDate;
        private Label labelEndDate;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private Label labelExportFormat;
        private ComboBox formatComboBox;
        private Button exportButton;
        private Label headerLabel;

        private void InitializeComponent()
        {
            // Form properties
            this.labelStartDate = new Label();
            this.labelEndDate = new Label();
            this.startDatePicker = new DateTimePicker();
            this.endDatePicker = new DateTimePicker();
            this.labelExportFormat = new Label();
            this.formatComboBox = new ComboBox();
            this.exportButton = new Button();
            this.headerLabel = new Label();

            this.SuspendLayout();

            // Form properties
            this.Text = "Export Expenses";
            this.Width = 600;
            this.Height = 350;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(255, 255, 255); // White background

            // Header Label
            headerLabel.Text = "Export Expense Data";
            headerLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            headerLabel.ForeColor = Color.FromArgb(0, 120, 215); // Blue color
            headerLabel.Width = 400;
            headerLabel.Height = 40;
            headerLabel.Top = 20;
            headerLabel.Left = 100;
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(headerLabel);

            // Start Date Label
            labelStartDate.Text = "Start Date:";
            labelStartDate.Font = new Font("Arial", 12, FontStyle.Regular);
            labelStartDate.ForeColor = Color.FromArgb(64, 64, 64); // Dark gray
            labelStartDate.Top = 80;
            labelStartDate.Left = 50;
            labelStartDate.Width = 120;
            this.Controls.Add(labelStartDate);

            // Start Date Picker
            startDatePicker.Font = new Font("Arial", 10);
            startDatePicker.Top = 80;
            startDatePicker.Left = 200;
            startDatePicker.Width = 250;
            startDatePicker.Format = DateTimePickerFormat.Short;
            this.Controls.Add(startDatePicker);

            // End Date Label
            labelEndDate.Text = "End Date:";
            labelEndDate.Font = new Font("Arial", 12, FontStyle.Regular);
            labelEndDate.ForeColor = Color.FromArgb(64, 64, 64);
            labelEndDate.Top = 120;
            labelEndDate.Left = 50;
            labelEndDate.Width = 120;
            this.Controls.Add(labelEndDate);

            // End Date Picker
            endDatePicker.Font = new Font("Arial", 10);
            endDatePicker.Top = 120;
            endDatePicker.Left = 200;
            endDatePicker.Width = 250;
            endDatePicker.Format = DateTimePickerFormat.Short;
            this.Controls.Add(endDatePicker);

            // Export Format Label
            labelExportFormat.Text = "Export Format:";
            labelExportFormat.Font = new Font("Arial", 12, FontStyle.Regular);
            labelExportFormat.ForeColor = Color.FromArgb(64, 64, 64);
            labelExportFormat.Top = 160;
            labelExportFormat.Left = 50;
            labelExportFormat.Width = 120;
            this.Controls.Add(labelExportFormat);

            // Export Format ComboBox
            formatComboBox.Font = new Font("Arial", 10);
            formatComboBox.Top = 160;
            formatComboBox.Left = 200;
            formatComboBox.Width = 250;
            formatComboBox.Items.AddRange(new string[] { "CSV", "Excel", "PDF" });
            formatComboBox.SelectedIndex = 0; // Default to CSV
            this.Controls.Add(formatComboBox);

            // Export Button
            exportButton.Text = "Export";
            exportButton.Font = new Font("Arial", 12, FontStyle.Bold);
            exportButton.Width = 150;
            exportButton.Height = 40;
            exportButton.Top = 220;
            exportButton.Left = 250;
            exportButton.BackColor = Color.FromArgb(50, 205, 50); // Lime Green
            exportButton.ForeColor = Color.White;
            exportButton.FlatStyle = FlatStyle.Flat;
            exportButton.FlatAppearance.BorderSize = 0;
            exportButton.Click += new EventHandler(ExportButton_Click);
            this.Controls.Add(exportButton);

            // Finalize the form
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
