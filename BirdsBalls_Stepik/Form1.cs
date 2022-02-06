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
      
       

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 18;
            timer.Tick += Timer_Tick;
            count_label.Text = Convert.ToString(0);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pig.CheckForHit(bird))
            {


                
                count++;
                
                count_label.Text = count.ToString();
                CreateNewBird();
                CreateNewPig();

            }

            if (bird.centerX > bird.RightSide())
            {
                CreateNewBird();
            }

        }

        private void CreateNewPig()
        {
          //  timer.Stop();
            if (pig != null)
            {
               pig.Stop();
                pig.Clear();
            }
            pig = new PigBall(this);
            pig.Show();
        }

        private void CreateNewBird()
        {
            timer.Stop();
            if (bird != null)
            {
                bird.Stop();
                bird.Clear();

            }
            bird = new BirdBall(this);
            bird.Show();
        }

        //private void ReturnBird()
        //{
        //    if (bird.centerX > ClientSize.Width + 30 || bird.centerX < -30 || bird.centerY < -70)
        //    {
        //        bird.Stop();
        //        bird.Clear();

        //        bird = new BirdBall(this);

        //        bird.centerX = 25;
        //        bird.centerY = ClientSize.Height - 25;
        //        bird.Show();
        //        isClicked = false;

        //    }
        //}




        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
               
                bird.DefineDestinationAndSpeed(e.X, e.Y);
                timer.Start();
                bird.Start();
               
         

        } 
    

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            CreateNewBird();
            CreateNewPig();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }
    }
}
