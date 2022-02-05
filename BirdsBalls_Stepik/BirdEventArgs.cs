namespace BirdsBalls_Stepik
{
    public class BirdEventArgs
    {
        BirdBall birdHit;

        public BirdEventArgs(BirdBall bird)
        {
            birdHit = bird;
        }
    }
}