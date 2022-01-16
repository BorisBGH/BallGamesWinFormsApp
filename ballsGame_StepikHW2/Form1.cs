using ballsCommonWF;
using ballsGame_StepikHW1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ballsGame_StepikHW2
{
    public partial class Form1 : Form
    {
        List<RandomBall> balls;
        int count = 0;

        Random random;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            balls = new List<RandomBall>();
            random = new Random();
            button_Stop.Enabled = false;
            button_Clear.Enabled = false;
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            var randomBallsNumber = random.Next(5, 10);
            for (int i = 0; i < randomBallsNumber; i++)
            {
                var ball = new RandomBall(this);
                balls.Add(ball);
                ball.Start();
            }
            button_Stop.Enabled = true;
            button_Create.Enabled = false;
            
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Stop();
            }
            button_Clear.Enabled = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var ball in balls)
            {
                if (ball.isMovable() && (e.X >= ball.x && e.X <= ball.x + 70  && e.Y >= ball.y && e.Y <= ball.y + 70))
                {

                        ball.Stop();
                        count++;
                        label_counter.Text = count.ToString();
             
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Clear();
                button_Clear.Enabled = false;
                button_Create.Enabled = true;
                count = 0;
                label_counter.Text = "0";
            }
        }
    }
}
