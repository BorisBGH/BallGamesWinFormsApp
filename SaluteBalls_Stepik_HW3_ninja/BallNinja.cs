using SaluteBalls_StepikWF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaluteBalls_Stepik_HW3_ninja
{
  public class BallNinja : SalutBall
    {
             

        public BallNinja(Control control, float centerX, float centerY) : base(control, centerX, centerY)
        {
         

           radius = random.Next(17, 21);
            vY = -12;

        }
    }
}
