using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaluteBalls_Stepik_HW3_ninja
{
    class BananaBall : BallNinja
    {
        public BananaBall(Control control, float centerX, float centerY) : base(control, centerX, centerY)
        {

        }

        public override void Show()
        {
            Brush brush = Brushes.Yellow;
            Draw(brush);
        }
    }
}
