        namespace Time_Zone
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.promptLabel.Location = new System.Drawing.Point(30, 25);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(620, 55);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "選擇城市，我會告訴您時區。";
            this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityListBox
            // 
            this.cityListBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.IntegralHeight = false;
            this.cityListBox.ItemHeight = 46;
            this.cityListBox.Items.AddRange(new object[] {
            "丹佛",
            "檀香山",
            "明尼阿波利斯",
            "紐約",
            "舊金山"});
            this.cityListBox.Location = new System.Drawing.Point(30, 96);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(300, 205);
            this.cityListBox.TabIndex = 1;
            this.cityListBox.SelectedIndexChanged += new System.EventHandler(this.cityListBox_SelectedIndexChanged);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(39, 330);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(125, 50);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "時區";
            this.outputDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeZoneLabel
            // 
            this.timeZoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeZoneLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.timeZoneLabel.Location = new System.Drawing.Point(170, 330);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(300, 50);
            this.timeZoneLabel.TabIndex = 3;
            this.timeZoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.okButton.Location = new System.Drawing.Point(30, 415);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(170, 60);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "確定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.exitButton.Location = new System.Drawing.Point(369, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(170, 60);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.button1.Location = new System.Drawing.Point(369, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.button2.Location = new System.Drawing.Point(30, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "加入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 680);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.timeZoneLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.promptLabel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "時區查詢";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.ListBox cityListBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label timeZoneLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

