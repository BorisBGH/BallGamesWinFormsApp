using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdsBalls_Stepik
{
     
    public partial class Form1 : Form
    {
       BirdBall bird;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            bird = new BirdBall(this);
            bird.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bird.AcceptTargetAndGo(e.X, e.Y);
            bird.Start();
        }
    }
}
