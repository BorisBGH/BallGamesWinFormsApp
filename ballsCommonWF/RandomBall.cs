
using System;
using System.Windows.Forms;

namespace ballsCommonWF
{
    public class RandomBall : Ball
    {
        protected Random random = new Random();
        
        public RandomBall(Control control) : base(control)
        {
            radius = random.Next(20, 50);
            centerX = random.Next(0, control.Size.Width);
            centerY = random.Next(0, control.Height);
            vX = random.Next(-5,6);
            vY = random.Next(-5,6);

        }

        public bool isMovable()
        {
            return timer.Enabled;
        }

        
    }
}
