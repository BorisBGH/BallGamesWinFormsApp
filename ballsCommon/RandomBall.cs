using ballsCommon;
using System;
using System.Windows.Forms;

namespace ballsCommom
{
    public class RandomBall : Ball
    {
        private Random random = new Random();
        
        public RandomBall(Form form) : base(form)
        {
            size = random.Next(50, 90);
            x = random.Next(0, form.Size.Width);
            y = random.Next(0, form.Height);
            vX = random.Next(-5, 6);
            vY = random.Next(-5, 6);

           
        }

        public bool isMovable()
        {
            return timer.Enabled;
        }
    }
}
