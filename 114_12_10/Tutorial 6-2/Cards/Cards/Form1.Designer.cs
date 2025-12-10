namespace Cards
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
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.showCardButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.cardPanel = new System.Windows.Forms.Panel();
            this.kingClubsPictureBox = new System.Windows.Forms.PictureBox();
            this.tenHeartsPictureBox = new System.Windows.Forms.PictureBox();
            this.aceSpadesPictureBox = new System.Windows.Forms.PictureBox();
            this.cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingClubsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHeartsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardListBox
            // 
            this.cardListBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cardListBox.FormattingEnabled = true;
            this.cardListBox.ItemHeight = 45;
            this.cardListBox.Items.AddRange(new object[] {
            "黑桃 A",
            "紅心 10",
            "梅花 K"});
            this.cardListBox.Location = new System.Drawing.Point(40, 200);
            this.cardListBox.Name = "cardListBox";
            this.cardListBox.Size = new System.Drawing.Size(180, 94);
            this.cardListBox.TabIndex = 3;
            // 
            // showCardButton
            // 
            this.showCardButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showCardButton.Location = new System.Drawing.Point(240, 200);
            this.showCardButton.Name = "showCardButton";
            this.showCardButton.Size = new System.Drawing.Size(120, 45);
            this.showCardButton.TabIndex = 4;
            this.showCardButton.Text = "顯示牌面";
            this.showCardButton.UseVisualStyleBackColor = true;
            this.showCardButton.Click += new System.EventHandler(this.showCardButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(240, 255);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 45);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cardPanel
            // 
            this.cardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPanel.Controls.Add(this.kingClubsPictureBox);
            this.cardPanel.Controls.Add(this.tenHeartsPictureBox);
            this.cardPanel.Controls.Add(this.aceSpadesPictureBox);
            this.cardPanel.Location = new System.Drawing.Point(20, 20);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(340, 165);
            this.cardPanel.TabIndex = 7;
            // 
            // kingClubsPictureBox
            // 
            this.kingClubsPictureBox.Image = global::Cards.Properties.Resources.King_Clubs;
            this.kingClubsPictureBox.Location = new System.Drawing.Point(230, 10);
            this.kingClubsPictureBox.Name = "kingClubsPictureBox";
            this.kingClubsPictureBox.Size = new System.Drawing.Size(100, 140);
            this.kingClubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingClubsPictureBox.TabIndex = 5;
            this.kingClubsPictureBox.TabStop = false;
            this.kingClubsPictureBox.Visible = false;
            // 
            // tenHeartsPictureBox
            // 
            this.tenHeartsPictureBox.Image = global::Cards.Properties.Resources._10_Hearts;
            this.tenHeartsPictureBox.Location = new System.Drawing.Point(115, 10);
            this.tenHeartsPictureBox.Name = "tenHeartsPictureBox";
            this.tenHeartsPictureBox.Size = new System.Drawing.Size(100, 140);
            this.tenHeartsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tenHeartsPictureBox.TabIndex = 4;
            this.tenHeartsPictureBox.TabStop = false;
            this.tenHeartsPictureBox.Visible = false;
            // 
            // aceSpadesPictureBox
            // 
            this.aceSpadesPictureBox.Image = global::Cards.Properties.Resources.Ace_Spades;
            this.aceSpadesPictureBox.Location = new System.Drawing.Point(10, 10);
            this.aceSpadesPictureBox.Name = "aceSpadesPictureBox";
            this.aceSpadesPictureBox.Size = new System.Drawing.Size(100, 140);
            this.aceSpadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aceSpadesPictureBox.TabIndex = 3;
            this.aceSpadesPictureBox.TabStop = false;
            this.aceSpadesPictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.cardPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showCardButton);
            this.Controls.Add(this.cardListBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "撲克牌範例";
            this.cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kingClubsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHeartsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cardListBox;
        private System.Windows.Forms.Button showCardButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.PictureBox kingClubsPictureBox;
        private System.Windows.Forms.PictureBox tenHeartsPictureBox;
        private System.Windows.Forms.PictureBox aceSpadesPictureBox;
    }
}

