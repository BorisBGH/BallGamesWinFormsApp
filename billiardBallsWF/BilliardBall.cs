using ballsCommonWF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billiardBallsWF
{
    class BilliardBall : RandomBall
    {

        public BilliardBall(Form form) : base(form)
        {

        }

        public override void Go()
        {
            base.Go();

            if (centerX <= LeftSide() || centerX >= RightSide())
            {
                vX = -vX;
            }

            if (centerY <= TopSide() || centerY >= DownSide())
            {
                vY = -vY;
            }
        }
    }
}
