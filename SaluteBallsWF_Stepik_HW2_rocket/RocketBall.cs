using ballsCommonWF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaluteBallsWF_Stepik_HW2_rocket
{
   public class RocketBall : Ball
    {
        Brush brush;
        public RocketBall(Control control) : base(control)
        {
           
            centerX = control.ClientSize.Width / 2;
            centerY = control.ClientSize.Height;
            radius = 10;
            vX = 0;
            vY = -8;
            brush = Brushes.Blue;
         
            
        }

        public override void Show()
        {
            Draw(brush);
        }

        protected override void Draw(Brush brush)
        {
           

            var graphics = control.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, radius * 1.5f, radius * 4);
            graphics.FillEllipse(brush, rectangle);
        }


    }
}
