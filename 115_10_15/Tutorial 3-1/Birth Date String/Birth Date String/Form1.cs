using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        // 建立表單並初始化所有視覺元件。
        public Form1()
        {
            InitializeComponent();
        }

        // 按下「顯示日期」按鈕後，組合輸入的日期資料並顯示結果。
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 依序取得星期、月份、日期及年份，並使用斜線連接。
            string output;

            output = dayOfWeekTextBox.Text + "/" + monthTextBox.Text + "/" + dayOfMonthTextBox.Text + "/" + yearTextBox.Text;

            // 將組合完成的日期字串顯示在輸出標籤中。
            dateOutputLabel.Text = output;
        }

        // 按下「清除」按鈕後，清空所有輸入欄位及輸出結果。
        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";

            dateOutputLabel.Text = "";
        }

        // 按下「離開」按鈕後關閉目前表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
