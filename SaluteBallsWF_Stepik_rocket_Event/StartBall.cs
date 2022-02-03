using SaluteBalls_StepikWF;
using SaluteBallsWF_Stepik_HW2_rocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaluteBallsWF_Stepik_rocket_Event
{
   public class StartBall : SalutBall
    {
        public event EventHandler<TopReachedEventArgs> TopReached;

        public StartBall(Control control) : base(control, control.ClientSize.Width / 2, control.ClientSize.Height)
        {
          
            vX = 0;
            vY = (float)new Random().NextDouble() * -6 -7;

        }

        public override void Go()
        {
            base.Go();
            if (vY > 0)
            {
                Stop();
                Clear();
                TopReached?.Invoke(this, new TopReachedEventArgs(centerX, centerY));
            }
        }
    }
}
