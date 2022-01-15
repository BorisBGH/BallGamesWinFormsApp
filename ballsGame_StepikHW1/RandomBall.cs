﻿using System;
using System.Windows.Forms;

namespace ballsGame_StepikHW1
{
    public class RandomBall : Ball
    {
        private Random random = new Random();
        
        public RandomBall(Form form) : base(form)
        {
            size = random.Next(50, 90);
            x = random.Next(0, form.Size.Width);
            y = random.Next(0, form.Height);
           
        }
    }
}
