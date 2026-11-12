namespace Ending_Balance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startingBalancePromptLabel = new System.Windows.Forms.Label();
            this.monthsPromptLabel = new System.Windows.Forms.Label();
            this.startingBalTextBox = new System.Windows.Forms.TextBox();
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.endingBalanceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.detalListBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startingBalancePromptLabel
            // 
            this.startingBalancePromptLabel.AutoSize = true;
            this.startingBalancePromptLabel.Location = new System.Drawing.Point(45, 19);
            this.startingBalancePromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startingBalancePromptLabel.Name = "startingBalancePromptLabel";
            this.startingBalancePromptLabel.Size = new System.Drawing.Size(98, 18);
            this.startingBalancePromptLabel.TabIndex = 0;
            this.startingBalancePromptLabel.Text = "起始餘額：";
            // 
            // monthsPromptLabel
            // 
            this.monthsPromptLabel.AutoSize = true;
            this.monthsPromptLabel.Location = new System.Drawing.Point(32, 55);
            this.monthsPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monthsPromptLabel.Name = "monthsPromptLabel";
            this.monthsPromptLabel.Size = new System.Drawing.Size(98, 18);
            this.monthsPromptLabel.TabIndex = 2;
            this.monthsPromptLabel.Text = "月份數量：";
            // 
            // startingBalTextBox
            // 
            this.startingBalTextBox.Location = new System.Drawing.Point(186, 14);
            this.startingBalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startingBalTextBox.Name = "startingBalTextBox";
            this.startingBalTextBox.Size = new System.Drawing.Size(418, 29);
            this.startingBalTextBox.TabIndex = 3;
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(186, 51);
            this.monthsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(418, 29);
            this.monthsTextBox.TabIndex = 5;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(50, 101);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(98, 18);
            this.outputDescriptionLabel.TabIndex = 6;
            this.outputDescriptionLabel.Text = "結束餘額：";
            // 
            // endingBalanceLabel
            // 
            this.endingBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingBalanceLabel.Location = new System.Drawing.Point(186, 94);
            this.endingBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endingBalanceLabel.Name = "endingBalanceLabel";
            this.endingBalanceLabel.Size = new System.Drawing.Size(418, 31);
            this.endingBalanceLabel.TabIndex = 7;
            this.endingBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endingBalanceLabel.Click += new System.EventHandler(this.endingBalanceLabel_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(48, 347);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(170, 80);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "計算";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(227, 347);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(173, 80);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(408, 347);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(196, 80);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // detalListBox1
            // 
            this.detalListBox1.FormattingEnabled = true;
            this.detalListBox1.ItemHeight = 18;
            this.detalListBox1.Location = new System.Drawing.Point(48, 151);
            this.detalListBox1.Name = "detalListBox1";
            this.detalListBox1.Size = new System.Drawing.Size(556, 184);
            this.detalListBox1.TabIndex = 11;
            this.detalListBox1.SelectedIndexChanged += new System.EventHandler(this.detalListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 457);
            this.Controls.Add(this.detalListBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endingBalanceLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.monthsTextBox);
            this.Controls.Add(this.startingBalTextBox);
            this.Controls.Add(this.monthsPromptLabel);
            this.Controls.Add(this.startingBalancePromptLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "結束餘額";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingBalancePromptLabel;
        private System.Windows.Forms.Label monthsPromptLabel;
        private System.Windows.Forms.TextBox startingBalTextBox;
        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label endingBalanceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox detalListBox1;
    }
}