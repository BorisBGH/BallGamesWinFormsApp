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
        private Control control;

        public DiffusionBall(Control control) : base(control)
        {
            this.control = control;
        }

        public bool LeftOfCenter()
        {
            return centerX + radius < control.ClientSize.Width / 2;
        }

        public bool RightOfCenter()
        {
            return centerX - radius > control.ClientSize.Width / 2;
        }

    }
}
