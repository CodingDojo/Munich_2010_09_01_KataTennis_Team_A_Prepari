namespace Dojo
{
    public class ScoreCounterFake : IScoreCounter
    {
        public ScoreCounterFake(int pointsA, int pointsB)
        {
            PointsA = pointsA;
            PointsB = pointsB;
        }

        public int PointsA { get; private set; }

        public int PointsB { get; private set; }
    }
}