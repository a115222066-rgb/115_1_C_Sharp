using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double test1;
            double test2;
            double test3;

            if (double.TryParse(test1TextBox.Text, out test1) &&
                double.TryParse(test2TextBox.Text, out test2) &&
                double.TryParse(test3TextBox.Text, out test3))
            {
                double average = (test1 + test2 + test3) / 3;
                averageLabel.Text = average.ToString("0.##");

                if (average >= 60)
                {
                    if (average >= 95)
                        MessageBox.Show("恭喜拿到高分！！！");
                    else
                    {
                        MessageBox.Show("平時成績及格");
                    }
                }
                else
                {
                    MessageBox.Show("平時成績不及格");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的成績");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the averageLabel control.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // Reset the focus to test1.
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
