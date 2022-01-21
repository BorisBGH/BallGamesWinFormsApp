using billiardBallsWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffusionWF_StepikHW
{
    public partial class TestForm : Form
    {
        List<DiffusionBall> leftSideBalls = new List<DiffusionBall>(5);
        List<DiffusionBall> rightSideBalls = new List<DiffusionBall>(5);
        Brush redBall = Brushes.Red;
        public TestForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            var graph = splitContainer1.Panel1.CreateGraphics();
            var br = Brushes.Red;
            var rec = new Rectangle(splitContainer1.Panel1.Width/2, splitContainer1.Panel1.Height/2, 30, 30);
            graph.FillRectangle(br, rec);
        }

        private void LSideBall_OnHit(object sender, HitEventArgs e)
        {
            return;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
