namespace Tortuial2_5
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
            this.cardBackPixturebox = new System.Windows.Forms.PictureBox();
            this.cardfrontPixturebox = new System.Windows.Forms.PictureBox();
            this.showFacebutton = new System.Windows.Forms.Button();
            this.showBackbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPixturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfrontPixturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardBackPixturebox
            // 
            this.cardBackPixturebox.Image = global::Tortuial2_5.Properties.Resources.Backface_Blue;
            this.cardBackPixturebox.Location = new System.Drawing.Point(424, 40);
            this.cardBackPixturebox.Name = "cardBackPixturebox";
            this.cardBackPixturebox.Size = new System.Drawing.Size(263, 397);
            this.cardBackPixturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBackPixturebox.TabIndex = 1;
            this.cardBackPixturebox.TabStop = false;
            this.cardBackPixturebox.Click += new System.EventHandler(this.cardBackPixturebox_Click);
            // 
            // cardfrontPixturebox
            // 
            this.cardfrontPixturebox.Image = global::Tortuial2_5.Properties.Resources._2_Spades;
            this.cardfrontPixturebox.Location = new System.Drawing.Point(424, 40);
            this.cardfrontPixturebox.Name = "cardfrontPixturebox";
            this.cardfrontPixturebox.Size = new System.Drawing.Size(263, 397);
            this.cardfrontPixturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardfrontPixturebox.TabIndex = 0;
            this.cardfrontPixturebox.TabStop = false;
            this.cardfrontPixturebox.Visible = false;
            this.cardfrontPixturebox.Click += new System.EventHandler(this.cardfrontPixturebox_Click);
            // 
            // showFacebutton
            // 
            this.showFacebutton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showFacebutton.Location = new System.Drawing.Point(625, 484);
            this.showFacebutton.Name = "showFacebutton";
            this.showFacebutton.Size = new System.Drawing.Size(229, 120);
            this.showFacebutton.TabIndex = 2;
            this.showFacebutton.Text = "顯示正面";
            this.showFacebutton.UseVisualStyleBackColor = true;
            this.showFacebutton.Click += new System.EventHandler(this.showFacebutton_Click);
            // 
            // showBackbutton
            // 
            this.showBackbutton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showBackbutton.Location = new System.Drawing.Point(236, 484);
            this.showBackbutton.Name = "showBackbutton";
            this.showBackbutton.Size = new System.Drawing.Size(229, 120);
            this.showBackbutton.TabIndex = 3;
            this.showBackbutton.Text = "顯示背面";
            this.showBackbutton.UseVisualStyleBackColor = true;
            this.showBackbutton.Click += new System.EventHandler(this.showBackbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 683);
            this.Controls.Add(this.showBackbutton);
            this.Controls.Add(this.showFacebutton);
            this.Controls.Add(this.cardBackPixturebox);
            this.Controls.Add(this.cardfrontPixturebox);
            this.Name = "Form1";
            this.Text = "撲克牌展示";
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPixturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfrontPixturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardfrontPixturebox;
        private System.Windows.Forms.PictureBox cardBackPixturebox;
        private System.Windows.Forms.Button showFacebutton;
        private System.Windows.Forms.Button showBackbutton;
    }
}

