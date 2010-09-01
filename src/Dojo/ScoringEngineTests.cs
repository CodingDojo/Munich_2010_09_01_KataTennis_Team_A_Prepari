using NUnit.Framework;

namespace Dojo
{
    [TestFixture]
    public class ScoringEngineTests
    {
        [Test]
        public void GivenPlayerAHasOnePointAndPlayerBHasZeroPoints_ReturnsFifteenLove()
        {
            var scoreCounter = new ScoreCounterFake(1,0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual(score, "fifteen love");
        }
    }

    public class ScoringEngine
    {
        public ScoringEngine(IScoreCounter scoreCounter)
        {
        }

        public string Score
        {
            get { return "fifteen love"; }
        }
    }

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