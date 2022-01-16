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
        private Form form;
        protected int radius = 25;
        public int centerX = 0;
        public int centerY = 0;
        protected int vX = 2;
        protected int vY = 2;
        protected Timer timer;

       

        public Ball(Form form)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void Show()
        {
            var brush = Brushes.Black;
            Draw(brush);
        }

        private void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
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
            var brush = new SolidBrush(form.BackColor);
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
            return form.ClientSize.Width - radius;
        }

        public int TopSide()
        {
            return radius;
        }

        public int DownSide()
        {
            return form.ClientSize.Height - radius;
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
