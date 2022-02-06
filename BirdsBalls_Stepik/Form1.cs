using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdsBalls_Stepik
{
     
    public partial class Form1 : Form
    {
       BirdBall bird;
       PigBall pig;
       Timer timer = new Timer();
       int count = 0;
        private bool isClicked = false;
        private bool isPigOnForm = false;
        private bool hitPig = false;

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 18;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pig.CheckForHit(bird) && !hitPig)
            {
               
                //count++;
                //count_label.Text = count.ToString();
               
                
                count++;
                count_label.Text = count.ToString();
                hitPig = true;
                ReturnBird();
                pig = new PigBall(this);
                pig.Show();

            }
            
            ReturnBird();
        }

        private void ReturnBird()
        {
            if (bird.centerX > ClientSize.Width + 30 || bird.centerX < -30 || bird.centerY < -70)
            {
                bird.Stop();
               
                bird.centerX = 25;
                bird.centerY = ClientSize.Height - 25;
                bird.Show();
                isClicked = false;
                hitPig = false;
            }
        }

       

       
       private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isClicked == false)
            {
                timer.Start();
                bird.DefineDestinationAndSpeed(e.X, e.Y);
                bird.Start();
                isClicked = true;

               

            }
         

        } 
    

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //if (isPigOnForm)
            //{
            //    pig.Clear();
            //    isPigOnForm = false;
            //}

            bird = new BirdBall(this);
            bird.Show();

            pig = new PigBall(this);
            pig.Show();
            isPigOnForm = true;

            timer.Start();
            isClicked = false;

        }
    }
}
