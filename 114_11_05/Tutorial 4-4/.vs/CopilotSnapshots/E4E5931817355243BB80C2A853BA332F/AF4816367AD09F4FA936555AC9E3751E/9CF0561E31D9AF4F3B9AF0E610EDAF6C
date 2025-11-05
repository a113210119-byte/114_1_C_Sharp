using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 使用 double.TryParse 解析使用者輸入，並在解析失敗時顯示繁體中文錯誤訊息
            double miles;
            double gallons;
            double mpg;

            if (double.TryParse(milesTextBox.Text, out miles))
            {
                if (double.TryParse(gallonsTextBox.Text, out gallons))
                {
                    if (gallons != 0)
                    {
                        mpg = miles / gallons;
                        mpgLabel.Text = mpg.ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("加侖數不能為零。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的加侖數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的英里數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
