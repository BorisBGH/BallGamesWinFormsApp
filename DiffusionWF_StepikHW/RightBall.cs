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
    class RightBall : BilliardBall
    {
        public RightBall(Control control) : base(control)
        {
            centerX = random.Next(control.ClientSize.Width / 2, control.ClientSize.Width);
            centerY = random.Next(0, control.Height);
        }

        public override void Show()
        {
            var brush = Brushes.Blue;
            Draw(brush);
        }
    }
}
