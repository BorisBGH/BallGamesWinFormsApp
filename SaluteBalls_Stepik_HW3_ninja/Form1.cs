using ballsCommonWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace SaluteBalls_Stepik_HW3_ninja
{
    public partial class Form1 : Form
    {
        
        private Random random;
        Timer timer = new Timer();
        Timer bombTimer = new Timer();
        Timer bananaTimer = new Timer();
        List<BallNinja> ninjaBalls = new List<BallNinja>();
        public Form1()
        {
            InitializeComponent();

            random = new Random();
          
           
        }

       

     /*   private void Timer_Tick(object sender, EventArgs e)
        {
            CreateBall();
            timer.Stop();
        }*/

       

        private void DecreaseSpeed()
        {
            foreach (var ball in ninjaBalls)
            {
                ball.DecreaseSpeed();
            };
        }

        private void ReturnDpeed()
        {
            foreach (var ball in ninjaBalls)
            {
                ball.ReturnSpeed();
            };
        }

       

        private void button_Play_Click(object sender, EventArgs e)
        {
            
            BallNinja ball;
            //   timer.Start(); 
            for (int i = 0; i < 10; i++)
            {
                var randomDigit = random.Next(5);
               
                     if (randomDigit == 3)
                     {
                        ball = new BananaBall(this, random.Next(0, ClientSize.Width - 1), random.Next(ClientSize.Height, ClientSize.Height + 2));
                        ninjaBalls.Add(ball);
                        ball.Start();
                     }
                    else if (randomDigit == 2)
                    {
                    ball = new BombBall(this, random.Next(0, ClientSize.Width - 1), random.Next(ClientSize.Height, ClientSize.Height + 2));
                    ninjaBalls.Add(ball);
                    ball.Start();
                    }
                    else
                    {
                    ball = new BallNinja(this, random.Next(0, ClientSize.Width - 1), random.Next(ClientSize.Height, ClientSize.Height + 2));
                    ninjaBalls.Add(ball);
                    ball.Start();
                    }

            }
      

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var ball in ninjaBalls)
            {
                if (ball.HasPoint(e.X, e.Y))
                {
                    ball.Stop();
                    ball.Clear();

                    if (ball is BombBall)
                    {
                        foreach (var ninjaball in ninjaBalls)
                        {
                            ninjaball.Stop();
                        }
                        MessageBox.Show("GAME OVER");

                    }

                    if (ball is BananaBall)
                    {
                        bananaTimer.Start();
                        bananaTimer.Interval = 10;
                        DecreaseSpeed();
                        bananaTimer.Stop();
                        ReturnDpeed();
                    }


                }
            }
        }
    }
       
    
}
