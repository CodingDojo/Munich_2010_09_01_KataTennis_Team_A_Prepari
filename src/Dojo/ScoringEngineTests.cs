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

            Assert.AreEqual(score, "fifteen-love");
        }

        [Test]
        public void GivenPlayerAHasTwoPointsAndPlayerBHasZeroPoints_ReturnsThirtyLove()
        {
            var scoreCounter = new ScoreCounterFake(2, 0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual(score, "thirty-love");
        }
    }

    public class ScoringEngine
    {
        private readonly IScoreCounter _scoreCounter;

        public ScoringEngine(IScoreCounter scoreCounter)
        {
            _scoreCounter = scoreCounter;
        }

        public string Score
        {
            get {
                if (_scoreCounter.PointsA == 1)
                    return "fifteen-love";
                else
                    return "thirty-love";
                }
        }
    }
}