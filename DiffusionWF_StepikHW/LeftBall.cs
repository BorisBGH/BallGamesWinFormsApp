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
    class LeftBall : BilliardBall
    {

        public LeftBall(Control control) : base(control)
        {
            centerX = random.Next(0, control.Size.Width/2);
            centerY = random.Next(0, control.Height);

        }

        public override void Show()
        {
            Brush brush = Brushes.Red;
            Draw(brush);    
        }
    }
}
