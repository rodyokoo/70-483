using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Random randomizer = new Random();
        public int anded1, anded2, timeLeft, minus1, minus2, multi1, multi2, div1, div2;

        public Form1()
        {
            InitializeComponent();
        }

        private void plusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Congratulations! You got all the answers right!");
            } 
            else if (timeLeft > 0)
            {
                timeLeft--;
                TimeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                TimeLabel.Text = "Time is up!";
                MessageBox.Show("You didn't finish on time!");
                sum.Value = anded1 + anded2;
                difference.Value = minus1 - minus2;
                product.Value = multi1 * multi2;
                quotient.Value = div1 / div2;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timeLeft = 30;
            TimeLabel.Text = "30 seconds";
            timer1.Start();

            minus1 = randomizer.Next(1, 101);
            minus2 = randomizer.Next(1, minus1);
            minusLeftLabel.Text = minus1.ToString();
            minusRightLabel.Text = minus2.ToString();
            difference.Value = 0;

            anded1 = randomizer.Next(51);
            anded2 = randomizer.Next(51);
            plusLeftLabel.Text = anded1.ToString();
            plusRightLabel.Text = anded2.ToString();
            sum.Value = 0;

            multi1 = randomizer.Next(2, 11);
            multi2 = randomizer.Next(2, 11);
            timesLeftLabel.Text = multi1.ToString();
            timesRightLabel.Text = multi2.ToString();
            product.Value = 0;

            div2 = randomizer.Next(2, 11);
            int temp = randomizer.Next(2, 11);
            div1 = div2 * temp;
            dividedLeftLabel.Text = div1.ToString();
            dividedRightLabel.Text = div2.ToString();
            quotient.Value = 0;
        }

        private bool CheckTheAnswer()
        {
            if((anded1 + anded2 == sum.Value) 
                && (minus1 - minus2 == difference.Value) 
                && (multi1 * multi2 == product.Value) 
                && (div1 / div2 == quotient.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
