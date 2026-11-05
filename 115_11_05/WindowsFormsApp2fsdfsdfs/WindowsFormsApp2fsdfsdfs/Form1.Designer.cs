    namespace WindowsFormsApp2fsdfsdfs
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label 顯示字串1Label;
        private System.Windows.Forms.Label 顯示字串2Label;
        private System.Windows.Forms.TextBox string1TextBox;
        private System.Windows.Forms.TextBox string2TextBox;
        private System.Windows.Forms.Button 比較Button;
        private System.Windows.Forms.Button 離開Button;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.顯示字串1Label = new System.Windows.Forms.Label();
            this.顯示字串2Label = new System.Windows.Forms.Label();
            this.string1TextBox = new System.Windows.Forms.TextBox();
            this.string2TextBox = new System.Windows.Forms.TextBox();
            this.比較Button = new System.Windows.Forms.Button();
            this.離開Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 顯示字串1Label
            // 
            this.顯示字串1Label.AutoSize = true;
            this.顯示字串1Label.Location = new System.Drawing.Point(62, 54);
            this.顯示字串1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.顯示字串1Label.Name = "顯示字串1Label";
            this.顯示字串1Label.Size = new System.Drawing.Size(70, 18);
            this.顯示字串1Label.TabIndex = 0;
            this.顯示字串1Label.Text = "字串1：";
            // 
            // 顯示字串2Label
            // 
            this.顯示字串2Label.AutoSize = true;
            this.顯示字串2Label.Location = new System.Drawing.Point(62, 106);
            this.顯示字串2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.顯示字串2Label.Name = "顯示字串2Label";
            this.顯示字串2Label.Size = new System.Drawing.Size(70, 18);
            this.顯示字串2Label.TabIndex = 1;
            this.顯示字串2Label.Text = "字串2：";
            // 
            // string1TextBox
            // 
            this.string1TextBox.Location = new System.Drawing.Point(154, 50);
            this.string1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.string1TextBox.Name = "string1TextBox";
            this.string1TextBox.Size = new System.Drawing.Size(307, 29);
            this.string1TextBox.TabIndex = 2;
            this.string1TextBox.TextChanged += new System.EventHandler(this.輸入字串1TextBox_TextChanged);
            // 
            // string2TextBox
            // 
            this.string2TextBox.Location = new System.Drawing.Point(154, 102);
            this.string2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.string2TextBox.Name = "string2TextBox";
            this.string2TextBox.Size = new System.Drawing.Size(307, 29);
            this.string2TextBox.TabIndex = 3;
            this.string2TextBox.TextChanged += new System.EventHandler(this.string2TextBox_TextChanged);
            // 
            // 比較Button
            // 
            this.比較Button.Location = new System.Drawing.Point(154, 162);
            this.比較Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.比較Button.Name = "比較Button";
            this.比較Button.Size = new System.Drawing.Size(116, 36);
            this.比較Button.TabIndex = 4;
            this.比較Button.Text = "比較";
            this.比較Button.UseVisualStyleBackColor = true;
            this.比較Button.Click += new System.EventHandler(this.比較Button_Click);
            // 
            // 離開Button
            // 
            this.離開Button.Location = new System.Drawing.Point(347, 162);
            this.離開Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.離開Button.Name = "離開Button";
            this.離開Button.Size = new System.Drawing.Size(116, 36);
            this.離開Button.TabIndex = 5;
            this.離開Button.Text = "離開";
            this.離開Button.UseVisualStyleBackColor = true;
            this.離開Button.Click += new System.EventHandler(this.離開Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 264);
            this.Controls.Add(this.離開Button);
            this.Controls.Add(this.比較Button);
            this.Controls.Add(this.string2TextBox);
            this.Controls.Add(this.string1TextBox);
            this.Controls.Add(this.顯示字串2Label);
            this.Controls.Add(this.顯示字串1Label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "字串比較";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

