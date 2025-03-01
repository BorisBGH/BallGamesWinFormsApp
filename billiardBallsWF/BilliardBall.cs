﻿using ballsCommonWF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace billiardBallsWF
{

  public  class BilliardBall : RandomBall
    {
        public event EventHandler<HitEventArgs> OnHit;
        public BilliardBall(Control control) : base(control)
        {
            radius = 25;
            
        }

        public override void Go()
        {
            base.Go();

            if (centerX <= LeftSide())
            {
                centerX = LeftSide();
                vX = -vX;
                OnHit.Invoke(this, new HitEventArgs(Side.Left));
            }

            if (centerX >= RightSide())
            {
                centerX = RightSide();
                vX = -vX;
                OnHit.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (centerY <= TopSide())
            {
                centerY = TopSide();
                vY = -vY;
                OnHit.Invoke(this, new HitEventArgs(Side.Top));
            }

            if (centerY >= DownSide())
            {
                centerY = DownSide();
                vY = -vY;
                OnHit.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
    }
}
