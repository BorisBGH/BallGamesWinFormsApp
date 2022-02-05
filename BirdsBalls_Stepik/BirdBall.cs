using ballsCommonWF;
using SaluteBalls_StepikWF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdsBalls_Stepik
{
    public class BirdBall : SalutBall
    {
       
        //private float accelX;
        //private float accelY;

        public BirdBall(Control control) : base(control, 0 + 25, control.ClientSize.Height-25)
        {
            radius = 25;                     
            brush = new SolidBrush(Color.Red);
            timer.Interval = 45;
        }

     
        public void DefineDestinationAndSpeed(float x, float y)
        {
          //  DefineAccels(x, y);
            vX = (x - centerX) / timer.Interval * DefineAcceleration(x,y);
            vY = (y - centerY) / timer.Interval * DefineAcceleration(x, y);

        }

      

        private float DefineAcceleration(float x, float y)
        {
            if (x - centerX > control.ClientSize.Width/2)
            {
                return 2.5f;
            }
            if (y - centerY < control.ClientSize.Height/0.8f)
            {
                return 2.5f;
            }
            return 1;

        } 

      /* private void DefineAccels(float x, float y)
        {
            if (x - centerX > control.ClientSize.Width / 3)
            {
                accelX = 2.7f;
            }
            else
            {
                accelX = 1.5f;
            }
            if (y - centerY < control.ClientSize.Height / 3)
            {
                accelY = 2.7f;
            }
            else
            {
                accelY = 1.5f;
            }
            
        }
      */

        public override void Go()
        {
            base.Go();
            if (centerY >= DownSide())
            {
                vY = -vY;
                vY *= 0.85f;
               
            }
        }
    }
}
