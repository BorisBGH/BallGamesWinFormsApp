using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaluteBalls_Stepik_HW3_ninja
{
    public partial class Form1 : Form
    {
        
        private Random random;
        Timer timer = new Timer();
        Timer bombTimer = new Timer();
        List<BallNinja> ninjaBalls = new List<BallNinja>();
        public Form1()
        {
            InitializeComponent();

            random = new Random();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;

            bombTimer.Interval = 100000000;
            timer.Tick += BombTimer_Tick;
           
        }

        private void BombTimer_Tick(object sender, EventArgs e)
        {
           var bombBall = new BombBall(this, random.Next(ClientSize.Width), ClientSize.Height);
            ninjaBalls.Add(bombBall);
            bombBall.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CreateBall();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var ball in ninjaBalls)
            {
                if (ball.HasPoint(e.X, e.Y))
                {
                    ball.Stop();
                    ball.Clear();

                    if (ball is BombBall)
                    {
                        timer.Stop();
                        bombTimer.Stop();
                        MessageBox.Show("GAME OVER");
                       
                    }
                }
            }
        }

        private void CreateBall()
        {
            var ninjaBall = new BallNinja(this, random.Next(ClientSize.Width), ClientSize.Height);
            ninjaBalls.Add(ninjaBall);
            ninjaBall.Start();
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
           
            timer.Start();

        }

       
	

	}
       
    
}
