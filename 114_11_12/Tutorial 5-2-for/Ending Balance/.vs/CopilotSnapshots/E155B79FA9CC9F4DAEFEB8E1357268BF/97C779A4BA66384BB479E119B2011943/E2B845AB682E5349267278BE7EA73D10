using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 表單建構子
        /// </summary>
        public Form1()
        {
            // 初始化表單上的控制項與屬性
            // 注意：InitializeComponent 為設計器產生的程式碼，負責建立並設定所有控制項。
            InitializeComponent();
        }



        /// <summary>
        /// 計算按鈕事件處理程序
        ///    使用者按下「計算」按鈕時會觸發此方法。
        ///    目前此方法為空的占位符 (placeholder)，預期在此實作：
        ///      1. 由 startingBalTextBox 讀取起始餘額（字串轉成數值）。
        ///      2. 由 monthsTextBox 讀取月份數量（字串轉成整數）。
        ///      3. 根據需求計算每月的變化並將每月明細加入 detailListBox。
        ///      4. 將最後計算出的結餘顯示在 endingBalanceLabel 上。
        ///    實作時應處理輸入驗證、例外狀況（如字串無法轉數值）以及適當的格式化顯示。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 每月利率 0.5%
            const decimal INTEREST_RATE = 0.005m;

            decimal startingBalance;
            int months;

            // 嘗試將使用者輸入的起始餘額轉為 decimal
            if (decimal.TryParse(startingBalTextBox.Text, out startingBalance))
            {
                // 嘗試將使用者輸入的月份數量轉為 int，且必須為正整數
                if (int.TryParse(monthsTextBox.Text, out months) && months > 0)
                {
                    // 逐月計算利息並更新餘額，使用 for 迴圈並以區域變數 count 表示當前月份
                    for (int count = 1; count <= months; count++)
                    {
                        // 計算本月利息並加入到目前餘額
                        startingBalance *= (1 + INTEREST_RATE);

                        // 將第 count 個月的結餘加入詳細清單，使用貨幣格式 (C2)
                        detailListBox.Items.Add("第" + count + "個月結餘: " + startingBalance.ToString("C2"));
                    }

                    // 將最終結餘顯示在 endingBalanceLabel 上
                    endingBalanceLabel.Text = startingBalance.ToString("C2");
                }
                else
                {
                    // 月份輸入無效，顯示錯誤訊息
                    MessageBox.Show("請輸入有效的月份數量（正整數）。", "輸入錯誤");
                }
            }
            else
            {
                // 起始餘額輸入無效，顯示錯誤訊息
                MessageBox.Show("請輸入有效的起始餘額。", "輸入錯誤");
            }
        }

        /// <summary>
        /// 清除按鈕事件處理程序
        ///    使用者按下「清除」按鈕時會觸發此方法。
        ///    此方法會清除輸入欄位與顯示區塊，並重設輸入焦點。
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBox、結餘標籤與詳細清單的內容。
            // Clear the TextBoxes, the endingBalanceLabel control,
            // and the ListBox.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 重設輸入焦點到起始餘額欄位，方便使用者立即輸入新資料。
            // Reset the focus.
            startingBalTextBox.Focus();
        }

        /// <summary>
        /// 退出按鈕事件處理程序
        ///    使用者按下「退出」按鈕時會觸發此方法。
        ///    此方法會關閉目前表單，結束應用程式視窗（如果此表單為主視窗）。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            // Close the form.
            this.Close();
        }

        /// <summary>
        /// outputDescriptionLabel 的 Click 事件處理程序
        ///    此處保留空實作以符合設計器所綁定的事件，
        ///    若不需要處理點擊事件可將事件從設計器移除。
        /// </summary>
        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
