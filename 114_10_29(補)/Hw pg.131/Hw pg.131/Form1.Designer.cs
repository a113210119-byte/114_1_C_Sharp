namespace Hw_pg._131
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBoxJoker = new System.Windows.Forms.PictureBox();
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            this.pictureBoxK = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJoker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.ErrorImage")));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.InitialImage")));
            this.pictureBox8.Location = new System.Drawing.Point(50, 186);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(109, 171);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxJoker
            // 
            this.pictureBoxJoker.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxJoker.Image")));
            this.pictureBoxJoker.Location = new System.Drawing.Point(793, 186);
            this.pictureBoxJoker.Name = "pictureBoxJoker";
            this.pictureBoxJoker.Size = new System.Drawing.Size(109, 171);
            this.pictureBoxJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJoker.TabIndex = 1;
            this.pictureBoxJoker.TabStop = false;
            this.pictureBoxJoker.Click += new System.EventHandler(this.pictureBoxJoker_Click);
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxA.Image")));
            this.pictureBoxA.Location = new System.Drawing.Point(602, 186);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(109, 171);
            this.pictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxA.TabIndex = 2;
            this.pictureBoxA.TabStop = false;
            this.pictureBoxA.Click += new System.EventHandler(this.pictureBoxA_Click);
            // 
            // pictureBoxK
            // 
            this.pictureBoxK.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxK.Image")));
            this.pictureBoxK.Location = new System.Drawing.Point(418, 186);
            this.pictureBoxK.Name = "pictureBoxK";
            this.pictureBoxK.Size = new System.Drawing.Size(109, 171);
            this.pictureBoxK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxK.TabIndex = 3;
            this.pictureBoxK.TabStop = false;
            this.pictureBoxK.Click += new System.EventHandler(this.pictureBoxK_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(236, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(248, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(463, 55);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Click a Card to See Its Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResult
            // 
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelResult.Location = new System.Drawing.Point(205, 430);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(524, 69);
            this.labelResult.TabIndex = 6;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(396, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxK);
            this.Controls.Add(this.pictureBoxA);
            this.Controls.Add(this.pictureBoxJoker);
            this.Controls.Add(this.pictureBox8);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJoker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBoxJoker;
        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.PictureBox pictureBoxK;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
    }
}

