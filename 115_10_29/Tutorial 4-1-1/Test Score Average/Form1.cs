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

                if (average >= 90)
                {
                    MessageBox.Show("成績A");
                }
                else if(average >= 80)
                {
                    MessageBox.Show("成績B");
                }
                else if (average >= 70)
                {
                    MessageBox.Show("成績C");
                }
                else if (average >= 60)
                {
                    MessageBox.Show("成績D");
                }
                else 
                {
                    MessageBox.Show("成績F");
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
