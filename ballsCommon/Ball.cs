using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace ballsCommon
{

    public class Ball
    {
        private Form form;
        protected int size = 70;
        public int x = 0;
        public int y = 0;
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
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(x, y, size, size);
            var brush = Brushes.Black;
            graphics.FillEllipse(brush, rectangle);
        }

        public void Go()
        {
                x += vX;
                y += vY;
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
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(x, y, size, size);
           // var brush = Brushes.White;
            SolidBrush sBrush = new SolidBrush(SystemColors.Control);
            graphics.FillEllipse(sBrush, rectangle);
        }

        public void Move()
        {
            
           Clear();
           Go();
           Show();
            
        }

        public bool isOnForm()
        {
            return x >= 0 && y >= 0 && y + 70 <= form.ClientSize.Height && x + 70 <= form.ClientSize.Width;
        }

    }
}
