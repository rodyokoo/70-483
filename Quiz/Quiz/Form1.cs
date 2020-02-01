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
        public int anded1, anded2, timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        private void plusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                TimeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                TimeLabel.Text = "Time is up!";
                MessageBox.Show("You didn't finish on time!");
                sum.Value = anded1 + anded2;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timeLeft = 30;
            TimeLabel.Text = "30 seconds";
            timer1.Start();

            anded1 = randomizer.Next(51);
            anded2 = randomizer.Next(51);

            plusLeftLabel.Text = anded1.ToString();
            plusRightLabel.Text = anded2.ToString();

            sum.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
