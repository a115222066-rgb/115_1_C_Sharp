using System;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            dailyRateLabel.Text = "—";
            totalLabel.Text = "—";
            feedbackLabel.Text = "";
            discountLabel.Text = "—";

            int days;
            if (int.TryParse(daysTextBox.Text, out days))
            {
                if (days >= 1 && days <= 7)
                {
                    // 依借用天數計算每日費用
                    int dailyRate;

                    if (days <= 2)
                    {
                        dailyRate = 80;
                    }
                    else if (days <= 5)
                    {
                        dailyRate = 70;
                    }
                    else
                    {
                        dailyRate = 60;
                    }

                    int total = dailyRate * days;

                    // 社團成員借用 3 天以上可折抵 30 元
                    if (clubCheckBox.Checked)
                    {
                        if (days >= 3)
                        {
                            total -= 30;
                            discountLabel.Text = "折抵 30 元";
                        }
                        else
                        {
                            discountLabel.Text = "未達折抵門檻";
                        }
                    }
                    else
                    {
                        discountLabel.Text = "無優惠";
                    }

                    // 更新結果欄位
                    dailyRateLabel.Text = dailyRate + " 元";
                    totalLabel.Text = total + " 元";
                }
                else
                {
                    feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";

                    if (days < 1)
                    {
                        feedbackLabel.Text += " 天數不能小於 1。";
                    }
                    else if (days > 7)
                    {
                        feedbackLabel.Text += " 天數不能大於 7。";
                    }
                }
            }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void discountCaptionLabel_Click(object sender, EventArgs e)
        {
            if (discountCaptionLabel.Text == "社團優惠")
            {
                MessageBox.Show("社團優惠說明：若您為本校社團成員，借用設備可享有 10% 的折扣。請記得攜帶相關證明文件。", "社團優惠說明", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearButton.Enabled = false;
        }

        private void discountLabel_Click(object sender, EventArgs e)
        {
            if (discountLabel.Text == "折抵 30 元")
            {
                MessageBox.Show("您已享有社團優惠，已折抵 30 元。請記得攜帶相關證明文件。", "社團優惠說明", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
