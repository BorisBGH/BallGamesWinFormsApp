namespace BallGamesWinFormsApp
{
    public class PointBall : Ball
    {
        public PointBall(MainForm form, int x, int y) : base(form)
        {
            this.x = x;
            this.y = y;
            
            //var graphics = form.CreateGraphics();
            //var brush = Brushes.Aqua;
           
            //var rectangle = new Rectangle(x-70/2, y-70/2, 70, 70);
            //graphics.FillEllipse(brush, rectangle);
        }
    }
}
