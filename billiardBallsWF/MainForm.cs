using ballsCommonWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billiardBallsWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                var ball = new BilliardBall(this);
                ball.Start();
                ball.OnHit += Ball_OnHit;
               
            }
           
        }

        private void Ball_OnHit(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left: leftLabel.Text = (Convert.ToInt32(leftLabel.Text) + 1).ToString();
                    break;
                case Side.Right: rightLabel.Text = (Convert.ToInt32(rightLabel.Text) + 1).ToString();
                    break;
                case Side.Top: TopLabel.Text = (Convert.ToInt32(TopLabel.Text) + 1).ToString();
                    break;
                case Side.Down: DownLabel.Text = (Convert.ToInt32(DownLabel.Text) + 1).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
