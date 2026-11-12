using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        // 建立表單並初始化控制項。
        public Form1()
        {
            InitializeComponent();
        }

        // 計算期末餘額。
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal RATE = 0.005m; // 每月利率為 0.5%
            decimal balance = 0;
                int months;

            int count = 1;

            if(decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                if(int.TryParse(monthsTextBox.Text, out months))
                {
                    while(count <= months)
                    {
                        balance = balance * (1 + RATE);
                        detalListBox1.Items.Add($"第{count} 個月的本利和:{balance:C2}");
                        count = count + 1;
                    }
                    endingBalanceLabel.Text = balance.ToString("c");
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數量。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的數字。");
            }
            endingBalanceLabel.Text = balance.ToString("C2");
            // 計算功能尚未實作。
        }
        // 清除輸入內容。
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除起始餘額、月份和期末餘額的內容。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";

            // 將游標移回起始餘額輸入框。
            startingBalTextBox.Focus();
        }

        // 結束程式。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void detalListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void endingBalanceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
