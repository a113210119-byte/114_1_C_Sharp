using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile; // 這裡是取得國家按鈕的點擊事件處理程式。
            string countryName; // 用來儲存國家名稱的變數。
            try
            {
                inputFile = File.OpenText(@"C:\Users\m303\Desktop\114_1_C_Sharp\114_11_19\Countries_Chinese.txt");
                countriesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    countryName = inputFile.ReadLine();
                    countriesListBox.Items.Add(countryName);
                }

                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
