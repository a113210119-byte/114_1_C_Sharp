namespace Hw_pg._213
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalIncome = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grossIncome = new System.Windows.Forms.Label();
            this.netIncome = new System.Windows.Forms.Label();
            this.taxPayable = new System.Windows.Forms.Label();
            this.calculation = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.exemptions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(31, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Total Income:";
            // 
            // totalIncome
            // 
            this.totalIncome.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalIncome.Location = new System.Drawing.Point(296, 2);
            this.totalIncome.Name = "totalIncome";
            this.totalIncome.Size = new System.Drawing.Size(298, 51);
            this.totalIncome.TabIndex = 1;
            this.totalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalIncome.TextChanged += new System.EventHandler(this.totalIncome_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 41);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Gross Income:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(56, 243);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 41);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Net Income:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(31, 336);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(228, 41);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Tax Payable:";
            // 
            // grossIncome
            // 
            this.grossIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grossIncome.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grossIncome.Location = new System.Drawing.Point(293, 151);
            this.grossIncome.Name = "grossIncome";
            this.grossIncome.Size = new System.Drawing.Size(301, 41);
            this.grossIncome.TabIndex = 5;
            this.grossIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grossIncome.Click += new System.EventHandler(this.grossIncome_Click);
            // 
            // netIncome
            // 
            this.netIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.netIncome.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.netIncome.Location = new System.Drawing.Point(296, 243);
            this.netIncome.Name = "netIncome";
            this.netIncome.Size = new System.Drawing.Size(301, 41);
            this.netIncome.TabIndex = 6;
            this.netIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxPayable
            // 
            this.taxPayable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxPayable.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.taxPayable.Location = new System.Drawing.Point(296, 336);
            this.taxPayable.Name = "taxPayable";
            this.taxPayable.Size = new System.Drawing.Size(301, 41);
            this.taxPayable.TabIndex = 7;
            this.taxPayable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculation
            // 
            this.calculation.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculation.Location = new System.Drawing.Point(148, 422);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(151, 50);
            this.calculation.TabIndex = 8;
            this.calculation.Text = "Calculation";
            this.calculation.UseVisualStyleBackColor = true;
            this.calculation.Click += new System.EventHandler(this.calculation_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exit.Location = new System.Drawing.Point(443, 422);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(151, 50);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(31, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 41);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Exemptions:";
            // 
            // exemptions
            // 
            this.exemptions.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exemptions.Location = new System.Drawing.Point(293, 83);
            this.exemptions.Name = "exemptions";
            this.exemptions.Size = new System.Drawing.Size(298, 51);
            this.exemptions.TabIndex = 11;
            this.exemptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.exemptions);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.taxPayable);
            this.Controls.Add(this.netIncome);
            this.Controls.Add(this.grossIncome);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.totalIncome);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox totalIncome;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label grossIncome;
        private System.Windows.Forms.Label netIncome;
        private System.Windows.Forms.Label taxPayable;
        private System.Windows.Forms.Button calculation;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox exemptions;
    }
}

