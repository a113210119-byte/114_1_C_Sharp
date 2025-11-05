namespace RadioButtonDemo
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
            this.飲料 = new System.Windows.Forms.GroupBox();
            this.juiceButton = new System.Windows.Forms.RadioButton();
            this.teaButton = new System.Windows.Forms.RadioButton();
            this.milkteaButton = new System.Windows.Forms.RadioButton();
            this.coffeeButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fishSandButton = new System.Windows.Forms.RadioButton();
            this.hamSandButton = new System.Windows.Forms.RadioButton();
            this.JellySandButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.飲料.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 飲料
            // 
            this.飲料.Controls.Add(this.juiceButton);
            this.飲料.Controls.Add(this.teaButton);
            this.飲料.Controls.Add(this.milkteaButton);
            this.飲料.Controls.Add(this.coffeeButton);
            this.飲料.Location = new System.Drawing.Point(47, 51);
            this.飲料.Name = "飲料";
            this.飲料.Size = new System.Drawing.Size(291, 342);
            this.飲料.TabIndex = 7;
            this.飲料.TabStop = false;
            this.飲料.Text = "飲料";
            // 
            // juiceButton
            // 
            this.juiceButton.AutoSize = true;
            this.juiceButton.Location = new System.Drawing.Point(111, 283);
            this.juiceButton.Name = "juiceButton";
            this.juiceButton.Size = new System.Drawing.Size(69, 22);
            this.juiceButton.TabIndex = 7;
            this.juiceButton.TabStop = true;
            this.juiceButton.Text = "果汁";
            this.juiceButton.UseVisualStyleBackColor = true;
            // 
            // teaButton
            // 
            this.teaButton.AutoSize = true;
            this.teaButton.Location = new System.Drawing.Point(111, 203);
            this.teaButton.Name = "teaButton";
            this.teaButton.Size = new System.Drawing.Size(69, 22);
            this.teaButton.TabIndex = 6;
            this.teaButton.TabStop = true;
            this.teaButton.Text = "紅茶";
            this.teaButton.UseVisualStyleBackColor = true;
            // 
            // milkteaButton
            // 
            this.milkteaButton.AutoSize = true;
            this.milkteaButton.Location = new System.Drawing.Point(111, 122);
            this.milkteaButton.Name = "milkteaButton";
            this.milkteaButton.Size = new System.Drawing.Size(69, 22);
            this.milkteaButton.TabIndex = 5;
            this.milkteaButton.TabStop = true;
            this.milkteaButton.Text = "奶茶";
            this.milkteaButton.UseVisualStyleBackColor = true;
            // 
            // coffeeButton
            // 
            this.coffeeButton.AutoSize = true;
            this.coffeeButton.Location = new System.Drawing.Point(111, 37);
            this.coffeeButton.Name = "coffeeButton";
            this.coffeeButton.Size = new System.Drawing.Size(69, 22);
            this.coffeeButton.TabIndex = 4;
            this.coffeeButton.TabStop = true;
            this.coffeeButton.Text = "咖啡";
            this.coffeeButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fishSandButton);
            this.groupBox1.Controls.Add(this.hamSandButton);
            this.groupBox1.Controls.Add(this.JellySandButton);
            this.groupBox1.Location = new System.Drawing.Point(424, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 342);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "三明治";
            // 
            // fishSandButton
            // 
            this.fishSandButton.AutoSize = true;
            this.fishSandButton.Location = new System.Drawing.Point(84, 243);
            this.fishSandButton.Name = "fishSandButton";
            this.fishSandButton.Size = new System.Drawing.Size(123, 22);
            this.fishSandButton.TabIndex = 9;
            this.fishSandButton.TabStop = true;
            this.fishSandButton.Text = "鮪魚三明治";
            this.fishSandButton.UseVisualStyleBackColor = true;
            // 
            // hamSandButton
            // 
            this.hamSandButton.AutoSize = true;
            this.hamSandButton.Location = new System.Drawing.Point(84, 162);
            this.hamSandButton.Name = "hamSandButton";
            this.hamSandButton.Size = new System.Drawing.Size(123, 22);
            this.hamSandButton.TabIndex = 8;
            this.hamSandButton.TabStop = true;
            this.hamSandButton.Text = "火腿三明治";
            this.hamSandButton.UseVisualStyleBackColor = true;
            // 
            // JellySandButton
            // 
            this.JellySandButton.AutoSize = true;
            this.JellySandButton.Location = new System.Drawing.Point(84, 77);
            this.JellySandButton.Name = "JellySandButton";
            this.JellySandButton.Size = new System.Drawing.Size(123, 22);
            this.JellySandButton.TabIndex = 7;
            this.JellySandButton.TabStop = true;
            this.JellySandButton.Text = "果醬三明治";
            this.JellySandButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "送出訂單";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.飲料);
            this.Name = "Form1";
            this.Text = "飲料";
            this.飲料.ResumeLayout(false);
            this.飲料.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 飲料;
        private System.Windows.Forms.RadioButton juiceButton;
        private System.Windows.Forms.RadioButton teaButton;
        private System.Windows.Forms.RadioButton milkteaButton;
        private System.Windows.Forms.RadioButton coffeeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fishSandButton;
        private System.Windows.Forms.RadioButton hamSandButton;
        private System.Windows.Forms.RadioButton JellySandButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

