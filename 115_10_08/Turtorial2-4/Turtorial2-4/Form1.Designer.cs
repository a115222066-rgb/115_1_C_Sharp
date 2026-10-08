namespace Turtorial2_4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.germanyBox = new System.Windows.Forms.PictureBox();
            this.franceBox = new System.Windows.Forms.PictureBox();
            this.finlandBox = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.demoPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.germanyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // germanyBox
            // 
            this.germanyBox.Image = global::Turtorial2_4.Properties.Resources.Germany;
            this.germanyBox.Location = new System.Drawing.Point(864, 247);
            this.germanyBox.Name = "germanyBox";
            this.germanyBox.Size = new System.Drawing.Size(372, 231);
            this.germanyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanyBox.TabIndex = 2;
            this.germanyBox.TabStop = false;
            this.germanyBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // franceBox
            // 
            this.franceBox.Image = global::Turtorial2_4.Properties.Resources.France;
            this.franceBox.Location = new System.Drawing.Point(439, 247);
            this.franceBox.Name = "franceBox";
            this.franceBox.Size = new System.Drawing.Size(372, 231);
            this.franceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.franceBox.TabIndex = 1;
            this.franceBox.TabStop = false;
            this.franceBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // finlandBox
            // 
            this.finlandBox.Image = global::Turtorial2_4.Properties.Resources.Finland;
            this.finlandBox.Location = new System.Drawing.Point(31, 247);
            this.finlandBox.Name = "finlandBox";
            this.finlandBox.Size = new System.Drawing.Size(372, 231);
            this.finlandBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandBox.TabIndex = 0;
            this.finlandBox.TabStop = false;
            this.finlandBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countryLabel.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countryLabel.Location = new System.Drawing.Point(392, 589);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(439, 74);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(59, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1156, 74);
            this.label1.TabIndex = 4;
            this.label1.Text = "點選一個國旗 我告訴你是哪個國家";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // demoPicturebox
            // 
            this.demoPicturebox.Location = new System.Drawing.Point(1009, 589);
            this.demoPicturebox.Name = "demoPicturebox";
            this.demoPicturebox.Size = new System.Drawing.Size(131, 74);
            this.demoPicturebox.TabIndex = 5;
            this.demoPicturebox.TabStop = false;
            this.demoPicturebox.Click += new System.EventHandler(this.demoPicturebox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 754);
            this.Controls.Add(this.demoPicturebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.germanyBox);
            this.Controls.Add(this.franceBox);
            this.Controls.Add(this.finlandBox);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.germanyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox finlandBox;
        private System.Windows.Forms.PictureBox franceBox;
        private System.Windows.Forms.PictureBox germanyBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox demoPicturebox;
    }
}

