using ballsCommonWF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaluteBalls_StepikWF
{
  public  class SalutBall : RandomBall
  {
        private float g = 0.2f;
      //  private Random random = new Random(); inherited field
        private SolidBrush brush; 


        public SalutBall(Control control, float centerX, float centerY) : base(control)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = 10;
            vY = -Math.Abs(vY);
            brush = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));

        }

        public override void Show()
        {
          
            Draw(brush);
        }

        public override void Go()
        {
            base.Go();
            vY += g;

        }

    }
}
