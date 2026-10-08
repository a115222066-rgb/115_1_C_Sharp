using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortuial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardBackPixturebox_Click(object sender, EventArgs e)
        {

        }

        private void cardfrontPixturebox_Click(object sender, EventArgs e)
        {

        }

        private void showBackbutton_Click(object sender, EventArgs e)
        {
            cardBackPixturebox.Visible = true;
            cardfrontPixturebox.Visible = false;
        }

        private void showFacebutton_Click(object sender, EventArgs e)
        {
            cardBackPixturebox.Visible = false;
            cardfrontPixturebox.Visible = true;
        }
    }
}
