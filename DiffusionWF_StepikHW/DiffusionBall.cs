using ballsCommonWF;
using billiardBallsWF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffusionWF_StepikHW
{
   public class DiffusionBall : BilliardBall
    {
        Brush brush;
        public int StartPoint { get; set; }

        public DiffusionBall(Control control, int startPoint, int endPoint, Brush brush) : base(control)
        {
            StartPoint = startPoint;
            centerX = random.Next(startPoint, endPoint);
            this.brush = brush;
        }

        public override void Show()
        {
            Draw(brush);    
        }
     /*   public override void Draw(Brush brush)
        {
            base.Draw(brush);
        }*/

    }
}
