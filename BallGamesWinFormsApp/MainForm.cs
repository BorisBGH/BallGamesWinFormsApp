using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        RandomSizeAndPointBall ball;

        List<MoveBall> mBalls = new List<MoveBall>();
        PointBall pBall;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // timer1.Enabled = true; the same:
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ball = new RandomSizeAndPointBall(this);
            ball.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pBall = new PointBall(this, e.X, e.Y);
            pBall.Show();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
        }

      
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MoveBall moveBall = new MoveBall(this);
                mBalls.Add(moveBall);
                moveBall.Start();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var mBall in mBalls)
            {
                mBall.Stop();
            }
        }
    }
}
