namespace Dojo
{
    public class ScoreStub : IScore
    {
        public ScoreStub(int pointsA, int pointsB)
        {
            PointsA = pointsA;
            PointsB = pointsB;
        }

        public int PointsA { get; private set; }

        public int PointsB { get; private set; }
    }
}