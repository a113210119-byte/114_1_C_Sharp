using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surname = textBoxSurname.Text;
            string givenName = textBoxGivenName.Text;
            int quiz1, quiz2, quiz3;
            if (int.TryParse(textBoxExam1.Text, out quiz1) &&
               int.TryParse(textBoxExam2.Text, out quiz2) &&
               int.TryParse(textBoxExam3.Text, out quiz3))
            {
                // show debug/info about quiz2 after successful parsing
                MessageBox.Show(string.Format("Quiz2 = {0}", quiz2));

                showResult(surname, givenName, quiz1, quiz2, quiz3);
            }
            else
            {
                MessageBox.Show("Please enter valid integer scores for all quizzes.", "Input Error");
                clearTextBoxes();
            }
        }

        private void showResult(string surname, string givenName, int quiz1, int quiz2, int quiz3)
        {
            int highestScore = findHighestScore(quiz1, quiz2, quiz3);

            lblResult.Text = string.Format("{0} {1}'s highest quiz score is {2}.", surname, givenName, highestScore);

            clearTextBoxes();
        }

        private int findHighestScore(int score1, int score2, int score3)
        {
            if (score1 >= score2 && score1 >= score3)
            {
                return score1;
            }
            else if (score2 >= score1 && score2 >= score3)
            {
                return score2;
            }
            else
            {
                return score3;
            }
        }

        private void clearTextBoxes()
        {
            textBoxSurname.Clear();
            textBoxGivenName.Clear();
            textBoxExam1.Clear();
            textBoxExam2.Clear();
            textBoxExam3.Clear();
        }

        // optional exit handler in case designer is wired later
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
