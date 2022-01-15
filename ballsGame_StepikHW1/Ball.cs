using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ballsGame_StepikHW1
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

        //public int LeftDot
        //{
        //    set
        //    {
        //        LeftDot = x;
        //    }

        //    get
        //    {
        //        return LeftDot;
        //    }
        //}

        //public int RightDot
        //{
        //    set
        //    {
        //        RightDot = x + size;
        //    }
        //    get
        //    {
        //        return RightDot;
        //    }
        //}

        //public int UpDot
        //{
        //    set
        //    {
        //        UpDot = y;
        //    }
        //    get
        //    {
        //        return UpDot;
        //    }
        //}

        //public int DownDot
        //{
        //    set
        //    {
        //        DownDot = y + size;
        //    }
        //    get
        //    {
        //        return DownDot;
        //    }

        //}

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
            var brush = Brushes.White;
            graphics.FillEllipse(brush, rectangle);
        }

        public void Move()
        {
            
           Clear();
           Go();
           Show();
            
        }

    }
}
