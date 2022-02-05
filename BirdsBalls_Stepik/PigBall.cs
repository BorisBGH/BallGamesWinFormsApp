using ballsCommonWF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdsBalls_Stepik
{
    class PigBall : Ball
    {
        public event EventHandler<BirdBallEventArgs>OnHit;
        public PigBall(Control control) : base(control)
        {
            
            centerX = new Random().Next((int)LeftSide(), (int)RightSide());
            centerY = new Random().Next((int)TopSide(), (int)DownSide());
            vX = 0;
            vY = 0;
        }

        public override void Show()
        {
            var brush = Brushes.DeepPink;
            Draw(brush);
        }

        public bool CheckForHit(BirdBall birdBall)
        {
            if ((birdBall.centerX + radius > centerX-radius && birdBall.centerX + radius < centerX + radius) && (birdBall.centerY - radius < centerY + radius && birdBall.centerY - radius > centerY-radius) || (birdBall.centerX-radius < centerX+radius && birdBall.centerX > centerX-radius) && (birdBall.centerY - radius < centerY+centerY+radius && birdBall.centerY - radius > centerY - radius))
            {
              Clear();
              return true;
            }
            return false;
        }
    }

    
}
