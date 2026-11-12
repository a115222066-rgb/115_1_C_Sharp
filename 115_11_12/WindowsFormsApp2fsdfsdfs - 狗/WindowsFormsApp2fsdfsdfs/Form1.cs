using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace WindowsFormsApp2fsdfsdfs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 比較Button_Click(object sender, EventArgs e)
        {
            string string1, string2;

            string1 = string1TextBox.Text;
            string2 = string2TextBox.Text;

            if (string1TextBox.Text == string2TextBox.Text)
            {
                MessageBox.Show("兩個字串相同");
            }
            else if (String.Compare(string1, string2) == 0)
            {
                MessageBox.Show($"{string1}, {string2}");
            }
            else
            {
                MessageBox.Show(string1 + "大於" + string2);
            }
        }

        private void 離開Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 輸入字串1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void string2TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
