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

namespace SaluteBallsWF_Stepik_rocket_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var startBall = new StartBall(this);
            startBall.TopReached += StartBall_TopReached;
            startBall.Start();
        }

        private void StartBall_TopReached(object sender, TopReachedEventArgs e)
        {
            for (int i = 0; i < new Random().Next(4,6); i++)
            {
                var ball = new SalutBall(this, e.x, e.y);
                ball.Start();
            }
        }
    }
}
