using SaluteBalls_StepikWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaluteBallsWF_Stepik_HW2_rocket
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        RocketBall rocket;
        private float lastY;
        private float lastX;
        
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (rocket.centerY <= this.ClientSize.Height/2)
            {
                lastX = rocket.centerX;
                lastY = rocket.centerY;
                rocket.Stop();
                rocket.Clear();
                timer.Stop();

                for (int i = 0; i < 30; i++)
                {
                    var saluteBall = new SalutBall(this, lastX, lastY);
                    saluteBall.Start();
                }
               
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            rocket = new RocketBall(this);
            rocket.Start();
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
