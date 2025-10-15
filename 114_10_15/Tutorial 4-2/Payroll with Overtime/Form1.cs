using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    // Form1 是主視窗表單，負責加班薪資計算的 UI 與事件處理
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化所有視窗元件
        }

        // 當使用者按下「計算薪資」按鈕時觸發
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 這裡可以加入薪資計算的程式邏輯
            const decimal BASE_HOURS = 40m;
            const decimal OT_MULTIPLIER = 1.5m;

            decimal hoursWorked;
            decimal hourlyPayRate;
            decimal grossPay;

            try
            {
                hoursWorked = decimal.Parse(this.hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(this.hourlyPayRateTextBox.Text);
                if(hoursWorked <= BASE_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    grossPay = (BASE_HOURS * hourlyPayRate) + ((hoursWorked - BASE_HOURS) * hourlyPayRate * OT_MULTIPLIER);
                }
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 當使用者按下「清除」按鈕時觸發
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除工時、時薪輸入欄位與薪資顯示欄位
            this.hoursWorkedTextBox.Text = "";
            this.hourlyPayRateTextBox.Text = "";
            this.grossPayLabel.Text = "";

            // 重設焦點
            this.hoursWorkedTextBox.Focus();
        }

        // 當使用者按下「離開」按鈕時觸發
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {
            // 預留：點擊薪資顯示標籤時的事件處理
        }

        private void hourlyPayRateTextBox_TextChanged(object sender, EventArgs e)
        {
            // 預留：時薪輸入欄位文字變更時的事件處理
        }
    }
}
