using System;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addend1, addend2, timeLeft, minuend, subtrahend, multiplicand, multiplier, dividend, divisor;
        public void StartQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            plusLeft.Text = addend1.ToString();
            plusRight.Text = addend2.ToString();
            sum.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeft.Text = minuend.ToString();
            minusRight.Text = subtrahend.ToString();
            roznica.Value = 0;

            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            multiplyLeft.Text = multiplicand.ToString();
            multiplyRight.Text = multiplier.ToString();
            pomnozone.Value = 0;

            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            divideLeft.Text = dividend.ToString();
            divideRight.Text = divisor.ToString();
            iloraz.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 sekund";
            timer1.Start();
        }
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
        && (minuend - subtrahend == roznica.Value)
        && (multiplicand * multiplier == pomnozone.Value)
        && (dividend / divisor == iloraz.Value))
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void multiply_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Jesteś zwycięzcą!",
                                "Gratulacje!");
                startButton.Enabled = true;
            }
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " sekund";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Czas minął!";
                MessageBox.Show("Czas minął", "Sorki!");
                sum.Value = addend1 + addend2;
                roznica.Value = minuend - subtrahend;
                pomnozone.Value = multiplicand * multiplier;
                iloraz.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;
        }
    }
}
