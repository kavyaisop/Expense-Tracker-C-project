using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExpenseTracker
{
    partial class Form6
    {
        private Label totalExpensesLabel;
        private Label expensesValueLabel;
        private Button backButton;

        private void InitializeComponent()
        {
            this.totalExpensesLabel = new System.Windows.Forms.Label();
            this.expensesValueLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalExpensesLabel
            // 
            this.totalExpensesLabel.AutoSize = true;
            this.totalExpensesLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.totalExpensesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.totalExpensesLabel.Location = new System.Drawing.Point(50, 50);
            this.totalExpensesLabel.Name = "totalExpensesLabel";
            this.totalExpensesLabel.Size = new System.Drawing.Size(176, 26);
            this.totalExpensesLabel.TabIndex = 0;
            this.totalExpensesLabel.Text = "Total Expenses:";
            // 
            // expensesValueLabel
            // 
            this.expensesValueLabel.AutoSize = true;
            this.expensesValueLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.expensesValueLabel.ForeColor = System.Drawing.Color.Black;
            this.expensesValueLabel.Location = new System.Drawing.Point(200, 50);
            this.expensesValueLabel.Name = "expensesValueLabel";
            this.expensesValueLabel.Size = new System.Drawing.Size(24, 26);
            this.expensesValueLabel.TabIndex = 1;
            this.expensesValueLabel.Text = "0";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.OrangeRed;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(50, 150);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(300, 40);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // Form6
            // 
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.totalExpensesLabel);
            this.Controls.Add(this.expensesValueLabel);
            this.Controls.Add(this.backButton);
            this.Name = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
