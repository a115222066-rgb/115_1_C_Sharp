using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConfigureUserInterface(object sender, EventArgs e)
        {
            //計算平均
            double test1, test2, test3, average;

            try
            {
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);
                
                average = (test1 + test2 + test3) / 3;
                
                averageLabel.Text = average.ToString("F1");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Font largeFont = new Font("Microsoft JhengHei", 32F);

            Text = "測驗平均成績";
            ClientSize = new Size(900, 560);
            AutoScaleMode = AutoScaleMode.None;

            test1PromptLabel.Text = "第一次測驗：";
            test2PromptLabel.Text = "第二次測驗：";
            test3PromptLabel.Text = "第三次測驗：";
            outputDescriptionLabel.Text = "測驗平均：";

            calculateButton.Text = "計算平均";
            clearButton.Text = "清除";
            exitButton.Text = "離開";

            test1PromptLabel.SetBounds(30, 30, 320, 65);
            test2PromptLabel.SetBounds(30, 130, 320, 65);
            test3PromptLabel.SetBounds(30, 230, 320, 65);
            outputDescriptionLabel.SetBounds(30, 330, 320, 65);

            test1TextBox.SetBounds(370, 25, 450, 70);
            test2TextBox.SetBounds(370, 125, 450, 70);
            test3TextBox.SetBounds(370, 225, 450, 70);
            averageLabel.SetBounds(370, 325, 450, 70);

            calculateButton.SetBounds(30, 440, 250, 80);
            clearButton.SetBounds(325, 440, 250, 80);
            exitButton.SetBounds(620, 440, 250, 80);

            test1PromptLabel.Font = largeFont;
            test2PromptLabel.Font = largeFont;
            test3PromptLabel.Font = largeFont;
            outputDescriptionLabel.Font = largeFont;
            test1TextBox.Font = largeFont;
            test2TextBox.Font = largeFont;
            test3TextBox.Font = largeFont;
            averageLabel.Font = largeFont;
            calculateButton.Font = largeFont;
            clearButton.Font = largeFont;
            exitButton.Font = largeFont;

            test1PromptLabel.AutoSize = false;
            test2PromptLabel.AutoSize = false;
            test3PromptLabel.AutoSize = false;
            outputDescriptionLabel.AutoSize = false;

            test1PromptLabel.TextAlign = ContentAlignment.MiddleLeft;
            test2PromptLabel.TextAlign = ContentAlignment.MiddleLeft;
            test3PromptLabel.TextAlign = ContentAlignment.MiddleLeft;
            outputDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            averageLabel.TextAlign = ContentAlignment.MiddleCenter;

            test1TextBox.Multiline = true;
            test2TextBox.Multiline = true;
            test3TextBox.Multiline = true;

            test1TextBox.TextAlign = HorizontalAlignment.Center;
            test2TextBox.TextAlign = HorizontalAlignment.Center;
            test3TextBox.TextAlign = HorizontalAlignment.Center;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
