namespace Tutorial_3_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.showDateButton = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(147, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "星期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(147, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "月：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(147, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "日：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(147, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "年：";
            // 
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(307, 46);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(420, 65);
            this.dayOfWeekTextBox.TabIndex = 4;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthTextBox.Location = new System.Drawing.Point(307, 126);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(420, 65);
            this.monthTextBox.TabIndex = 5;
            // 
            // dayOfMonthTextBox
            // 
            this.dayOfMonthTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(307, 203);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(420, 65);
            this.dayOfMonthTextBox.TabIndex = 6;
            this.dayOfMonthTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearTextBox.Location = new System.Drawing.Point(307, 283);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(420, 65);
            this.yearTextBox.TabIndex = 7;
            this.yearTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateOutputLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateOutputLabel.Location = new System.Drawing.Point(28, 373);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(795, 75);
            this.dateOutputLabel.TabIndex = 8;
            // 
            // showDateButton
            // 
            this.showDateButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showDateButton.Location = new System.Drawing.Point(56, 479);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(207, 55);
            this.showDateButton.TabIndex = 9;
            this.showDateButton.Text = "顯示日期";
            this.showDateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.showDateButton.TextChanged += new System.EventHandler(this.showDateButton_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(330, 479);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(207, 55);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "清除";
            this.clearButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearButton.TextChanged += new System.EventHandler(this.clearButton_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(607, 479);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(207, 55);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "離開";
            this.exitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitButton.TextChanged += new System.EventHandler(this.exitButton_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 574);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.TextBox showDateButton;
        private System.Windows.Forms.TextBox clearButton;
        private System.Windows.Forms.TextBox exitButton;
    }
}

