using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Forms;

namespace ballsCommonWF
{

    public class Ball
    {
        private Control control;
        protected int radius = 25;
        public int centerX = 0;
        public int centerY = 0;
        protected int vX = 2;
        protected int vY = 2;
        protected Timer timer;

       

        public Ball(Control control)
        {
            this.control = control;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public virtual void Show()
        {
            var brush = Brushes.Black;
            Draw(brush);
        }

        protected  void Draw(Brush brush)
        {
            var graphics = control.CreateGraphics();
            var rectangle = new Rectangle(centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brush, rectangle);
        }

        public virtual void Go()
        {
                centerX += vX;
                centerY += vY;

        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Clear()
        {
            var brush = new SolidBrush(control.BackColor);
            Draw(brush);
        }

        public void Move()
        {
            
           Clear();
           Go();
           Show();
            
        }

        public int LeftSide()
        {
           return radius;
        }

        public int RightSide()
        {
            return control.ClientSize.Width - radius;
        }

        public int TopSide()
        {
            return radius;
        }

        public int DownSide()
        {
            return control.ClientSize.Height - radius;
        }

        public bool IsOnForm()
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide();
        }

        public bool HasPoint(int pointX, int pointY)
        {
          return  (pointX - centerX) * (pointX - centerX) + (pointY - centerY) * (pointY - centerY) <= radius * radius;
        }

    }
}
