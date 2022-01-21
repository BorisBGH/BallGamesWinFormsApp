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
using billiardBallsWF;

namespace DiffusionWF_StepikHW
{
    public partial class Form1 : Form
    {

        bool isMouseClicked = false;

        List<BilliardBall> balls = new List<BilliardBall>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void RSideBall_OnHit(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    break;
                case Side.Right:
                    break;
                case Side.Top:
                    break;
                case Side.Down:
                    break;
                default:
                    break;
            }
        }

        private void LSideBall_OnHit(object sender, HitEventArgs e)
        {
            return;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
                var graphics = CreateGraphics();
                var pen = new Pen(Color.BlueViolet, 5);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                graphics.DrawLine(pen, Width / 2, 0, Width / 2, Height);
            
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            if (!isMouseClicked)
            {
                for (int i = 0; i < 5; i++)
                {
                    var lSideBall = new LeftBall(this);
                    lSideBall.Start();
                    lSideBall.OnHit += LSideBall_OnHit;
                    balls.Add(lSideBall);

                    var rSideBall = new RightBall(this);
                    rSideBall.Start();
                    rSideBall.OnHit += RSideBall_OnHit;
                    balls.Add(rSideBall);
                    
                }
                isMouseClicked = true;
            }
            else
            {
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
                isMouseClicked = false;
            }
           
        }
    }
}
