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
    class LeftBall : DiffusionBall
    {
        public event EventHandler<MidFormEventArgs> MidFormCrossed;
        public  int counter = 0;

        private Control control = new Control();
       
        public LeftBall(Control control) : base(control)
        {
            this.control = control;
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
