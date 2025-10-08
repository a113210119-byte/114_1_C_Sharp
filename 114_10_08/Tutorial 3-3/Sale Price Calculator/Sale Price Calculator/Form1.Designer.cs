namespace Sale_Price_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            // 如果正在釋放資源且元件不為 null，則釋放元件資源
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設計師支援所需的方法 - 請勿以程式碼編輯器修改此方法內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.originalPriceTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.originalPricePromptLabel = new System.Windows.Forms.Label();
            this.discPercentagePromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalPriceTextBox
            // 
            this.originalPriceTextBox.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.originalPriceTextBox.Location = new System.Drawing.Point(600, 26);
            this.originalPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.originalPriceTextBox.Name = "originalPriceTextBox";
            this.originalPriceTextBox.Size = new System.Drawing.Size(148, 66);
            this.originalPriceTextBox.TabIndex = 0;
            // 
            // discountPercentageTextBox
            // 
            this.discountPercentageTextBox.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.discountPercentageTextBox.Location = new System.Drawing.Point(600, 108);
            this.discountPercentageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountPercentageTextBox.Name = "discountPercentageTextBox";
            this.discountPercentageTextBox.Size = new System.Drawing.Size(148, 66);
            this.discountPercentageTextBox.TabIndex = 1;
            // 
            // originalPricePromptLabel
            // 
            this.originalPricePromptLabel.AutoSize = true;
            this.originalPricePromptLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.originalPricePromptLabel.Location = new System.Drawing.Point(57, 29);
            this.originalPricePromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originalPricePromptLabel.Name = "originalPricePromptLabel";
            this.originalPricePromptLabel.Size = new System.Drawing.Size(376, 55);
            this.originalPricePromptLabel.TabIndex = 2;
            this.originalPricePromptLabel.Text = "請輸入商品原價：";
            this.originalPricePromptLabel.Click += new System.EventHandler(this.originalPricePromptLabel_Click);
            // 
            // discPercentagePromptLabel
            // 
            this.discPercentagePromptLabel.AutoSize = true;
            this.discPercentagePromptLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.discPercentagePromptLabel.Location = new System.Drawing.Point(13, 111);
            this.discPercentagePromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discPercentagePromptLabel.Name = "discPercentagePromptLabel";
            this.discPercentagePromptLabel.Size = new System.Drawing.Size(420, 55);
            this.discPercentagePromptLabel.TabIndex = 3;
            this.discPercentagePromptLabel.Text = "請輸入折扣百分比：";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(277, 213);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(156, 55);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "特價：";
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePriceLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.salePriceLabel.Location = new System.Drawing.Point(469, 206);
            this.salePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(354, 69);
            this.salePriceLabel.TabIndex = 5;
            this.salePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.calculateButton.Location = new System.Drawing.Point(151, 294);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(226, 67);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算特價";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.exitButton.Location = new System.Drawing.Point(448, 294);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(226, 67);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 374);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.discPercentagePromptLabel);
            this.Controls.Add(this.originalPricePromptLabel);
            this.Controls.Add(this.discountPercentageTextBox);
            this.Controls.Add(this.originalPriceTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "特價計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 宣告所有元件
        private System.Windows.Forms.TextBox originalPriceTextBox; // 商品原價輸入框
        private System.Windows.Forms.TextBox discountPercentageTextBox; // 折扣百分比輸入框
        private System.Windows.Forms.Label originalPricePromptLabel; // 原價提示標籤
        private System.Windows.Forms.Label discPercentagePromptLabel; // 折扣百分比提示標籤
        private System.Windows.Forms.Label outputDescriptionLabel; // 特價描述標籤
        private System.Windows.Forms.Label salePriceLabel; // 特價顯示標籤
        private System.Windows.Forms.Button calculateButton; // 計算按鈕
        private System.Windows.Forms.Button exitButton; // 離開按鈕
    }
}

