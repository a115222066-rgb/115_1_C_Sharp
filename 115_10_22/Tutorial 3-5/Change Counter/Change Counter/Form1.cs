using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENTS = 0.05m;
        const decimal TEN_CENTS = 0.10m;
        const decimal TWENTY_FIVE = 0.25m;
        const decimal FIFTY_CENTS = 0.50m;
        decimal total = 0.00m;

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //decimal total = 0.00m;
            total = total + FIVE_CENTS;
            totalLabel.Text = total.ToString("C");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            //decimal total = 0.00m;
            total = total + TEN_CENTS;
            totalLabel.Text = total.ToString("C");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = total + TWENTY_FIVE;
            totalLabel.Text = total.ToString("C");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = total + FIFTY_CENTS;
            totalLabel.Text = total.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
