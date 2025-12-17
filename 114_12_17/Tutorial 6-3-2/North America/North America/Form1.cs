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

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetFileName method gets a filename from the
        // user and assigns it to the variable passed as
        // an argument.

        // The GetCountries method accepts a filename as an
        // argument. It opens the specified file and displays
        // its contents in the countriesListBox control.
        

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName;

            fileName = GetFileName();

            // Call the method that reads and displays countries
            GetCountries(fileName);
        }

        private string GetFileName()
        {
            string fileName;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }
            else
            {
                fileName = string.Empty;
            }
            return fileName;
        }

        // Renamed method to avoid conflict with the button field name
        private void GetCountries(string fileName)
        {
            countriesListBox.Items.Clear();

            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    using (StreamReader inputFile = File.OpenText(fileName))
                    {
                        string country;
                        while ((country = inputFile.ReadLine()) != null)
                        {
                            countriesListBox.Items.Add(country);
                        }
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Choose a file", "Error");
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

    }
}
