using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExpenseTracker
{
    partial class Form4
    {
        private Label labelExpense;
        private Label labelReason;
        private TextBox textBoxExpense;
        private TextBox textBoxReason;
        private Button addButton;
        private Button exportButton;
        private Button reportSummaryButton;
        private DataGridView expenseTable;
        private Panel headerPanel;
        private Label headerLabel;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelExpense = new System.Windows.Forms.Label();
            this.labelReason = new System.Windows.Forms.Label();
            this.textBoxExpense = new System.Windows.Forms.TextBox();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.reportSummaryButton = new System.Windows.Forms.Button();
            this.expenseTable = new System.Windows.Forms.DataGridView();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTable)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExpense
            // 
            this.labelExpense.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelExpense.Location = new System.Drawing.Point(30, 80);
            this.labelExpense.Name = "labelExpense";
            this.labelExpense.Size = new System.Drawing.Size(100, 23);
            this.labelExpense.TabIndex = 1;
            this.labelExpense.Text = "Expense Amount:";
            // 
            // labelReason
            // 
            this.labelReason.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelReason.Location = new System.Drawing.Point(30, 130);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(100, 23);
            this.labelReason.TabIndex = 3;
            this.labelReason.Text = "Reason:";
            // 
            // textBoxExpense
            // 
            this.textBoxExpense.BackColor = System.Drawing.Color.White;
            this.textBoxExpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExpense.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxExpense.Location = new System.Drawing.Point(180, 80);
            this.textBoxExpense.Name = "textBoxExpense";
            this.textBoxExpense.Size = new System.Drawing.Size(200, 25);
            this.textBoxExpense.TabIndex = 2;
            // 
            // textBoxReason
            // 
            this.textBoxReason.BackColor = System.Drawing.Color.White;
            this.textBoxReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReason.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxReason.Location = new System.Drawing.Point(180, 130);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(200, 25);
            this.textBoxReason.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(30, 180);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 40);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Expense";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.Location = new System.Drawing.Point(160, 180);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(120, 40);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Export Expenses";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click_1);
            // 
            // reportSummaryButton
            // 
            this.reportSummaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.reportSummaryButton.FlatAppearance.BorderSize = 0;
            this.reportSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportSummaryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.reportSummaryButton.ForeColor = System.Drawing.Color.White;
            this.reportSummaryButton.Location = new System.Drawing.Point(290, 180);
            this.reportSummaryButton.Name = "reportSummaryButton";
            this.reportSummaryButton.Size = new System.Drawing.Size(120, 40);
            this.reportSummaryButton.TabIndex = 7;
            this.reportSummaryButton.Text = "Report Summary";
            this.reportSummaryButton.UseVisualStyleBackColor = false;
            this.reportSummaryButton.Click += new System.EventHandler(this.reportSummaryButton_Click_1);
            // 
            // expenseTable
            // 
            this.expenseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.expenseTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.expenseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.expenseTable.Location = new System.Drawing.Point(30, 249);
            this.expenseTable.Name = "expenseTable";
            this.expenseTable.RowHeadersVisible = false;
            this.expenseTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseTable.Size = new System.Drawing.Size(740, 300);
            this.expenseTable.TabIndex = 8;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(784, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(784, 60);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Expense Tracker";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Expense Amount";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 164;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Reason";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // Form4
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.labelExpense);
            this.Controls.Add(this.textBoxExpense);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.reportSummaryButton);
            this.Controls.Add(this.expenseTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.expenseTable)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
