using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double test1, test2, test3;

            try
            {
                // 嘗試將使用者輸入的文字轉換為數字
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算三個分數的平均值
                double average = (test1 + test2 + test3) / 3.0;

                averageLabel.Text = average.ToString("n2");
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show("例外發生！", ex.Message);
                test1TextBox.Text = "";
                test2TextBox.Text = "";
                test3TextBox.Text = "";
                averageLabel.Text = "";
                test1TextBox.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void averageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
