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
       

        public BirdBall(Control control) : base(control, 0 + 25, control.ClientSize.Height-25)
        {
            radius = 25;
            /*   g = 0;
               vX = 0;
               vY = 0; */
            //vX = 2;
            
            brush = new SolidBrush(Color.Red);
            timer.Interval = 50;
        }

        public override void Go()
        {
            
           base.Go();
          // centerX += vX;
         //  centerY +=
         vY += g;
          
            
        }
        public void AcceptTargetAndGo(float x, float y)
        {

            vX = (x - centerX)/timer.Interval;
            vY = (y - centerY)/timer.Interval;
           
            

        }
    }
}
