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
        List<LeftBall> leftBalls = new List<LeftBall>();
        List<RightBall> rightBalls = new List<RightBall>();

        List<BilliardBall> balls = new List<BilliardBall>();
        private Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DrawLine();
            var leftBallsOnLeft = 0;
            var rightBallsOnLeft = 0;
            var leftBallsOnRight = 0;
            var rightBallsOnRight = 0;

            for (int i = 0; i < leftBalls.Count; i++)
            {
                if (leftBalls[i].LeftOfCenter())
                {
                    leftBallsOnLeft++;
                }

                if (rightBalls[i].LeftOfCenter())
                {
                   rightBallsOnLeft++;
                }

                if (leftBalls[i].RightOfCenter())
                {
                    leftBallsOnRight++;
                }

                if (rightBalls[i].RightOfCenter())
                {
                   rightBallsOnRight++;
                }
            }

            if ( leftBallsOnLeft == leftBallsOnRight && rightBallsOnRight == rightBallsOnLeft)
            {
                for (int i = 0; i < leftBalls.Count; i++)
                {
                    leftBalls[i].Stop();
                    rightBalls[i].Stop();

                }
                timer.Stop();
                MessageBox.Show("DIFFUSION");
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Blue;
            label5.ForeColor = Color.Blue;
            label8.ForeColor = Color.Blue;
            label7.ForeColor = Color.Blue;

            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
        }

        private void RSideBall_OnHit(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left: label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                    break;
                case Side.Right: label8.Text = (Convert.ToInt32(label8.Text) + 1).ToString();
                    break;
                case Side.Top: label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                    break;
                case Side.Down: label7.Text = (Convert.ToInt32(label7.Text) + 1).ToString();
                    break;
                default:
                    break;
            }
        }

        private void LSideBall_OnHit(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
                    break;
                case Side.Right:
                    label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                    break;
                case Side.Top:
                    label3.Text = (Convert.ToInt32(label3.Text) + 1).ToString();
                    break;
                case Side.Down:
                    label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void DrawLine()
        {
            var graphics = CreateGraphics();
            var pen = new Pen(Color.BlueViolet, 5);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            graphics.DrawLine(pen, Width / 2, 0, Width / 2, Height);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            timer.Start();

            if (!isMouseClicked)
            {
                for (int i = 0; i < 4; i++)
                {
                    var lSideBall = new LeftBall(this);
                    lSideBall.Start();
                    lSideBall.OnHit += LSideBall_OnHit;
                    leftBalls.Add(lSideBall);

                    var rSideBall = new RightBall(this);
                    rSideBall.Start();
                    rSideBall.OnHit += RSideBall_OnHit;
                    rightBalls.Add(rSideBall);
                    
                }
                isMouseClicked = true;

              
               
                
            }
            else
            {
                foreach (var leftBall in leftBalls)
                {
                    leftBall.Stop();
                }
                foreach (var rightBall in rightBalls)
                {
                    rightBall.Stop();
                }
                isMouseClicked = false;
            }
           
        }
        
	

                  
        
    }
}
