using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ballsCommonWF;

namespace ballsGame_StepikHW1
{
    public partial class MainForm : Form
    {
        Random random;
        List<RandomBall> balls = new List<RandomBall>();
        int count = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            random = new Random();
            var randomBallsNumber = random.Next(5,11);

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
            CountBalls();
            button_Stop.Enabled = false;
            button_Clear.Enabled = true;

        }

        private void CountBalls()
        {
            foreach (var ball in balls)
            {
                ball.Stop();

                if (ball.IsOnForm())
                {
                    count++;
                }
            }

            MessageBox.Show($"Поймано {count} шариков");
            count = 0;
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            button_Stop.Enabled = false;
            button_Clear.Enabled = false;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Clear();
            }
            button_Clear.Enabled = false;
            button_Create.Enabled = true;
        }
    }

    
}
