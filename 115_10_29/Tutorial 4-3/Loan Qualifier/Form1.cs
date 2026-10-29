using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try {
                if (double.Parse(salaryTextBox.Text) < 40000) { decisionLabel.Text = "你薪資不符合貸款資格"; }
                else if (double.Parse(yearsTextBox.Text) < 2) { decisionLabel.Text = "你工作年資不符合貸款資格"; }
                else { decisionLabel.Text = "你符合貸款資格"; }
            }
            catch (FormatException ex) { MessageBox.Show("請輸入有效的數字", ex.Message); }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the decisionLabel.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // Reset the focus.
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
