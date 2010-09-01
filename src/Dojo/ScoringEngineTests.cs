using NUnit.Framework;

namespace Dojo
{
    [TestFixture]
    public class ScoringEngineTests
    {
        [Test]
        public void GivenPlayerAHasOnePointAndPlayerBHasZeroPoints_ReturnsFifteenLove()
        {
            var scoreCounter = new ScoreStub(1,0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual(score, "fifteen-love");
        }

        [Test]
        public void GivenPlayerAHasTwoPointsAndPlayerBHasZeroPoints_ReturnsThirtyLove()
        {
            var scoreCounter = new ScoreStub(2, 0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual(score, "thirty-love");
        }

        [Test]
        public void GivenPlayerAHasThreePointsAndPlayerBHasZeroPoints_ReturnsFourtyLove()
        {
            var scoreCounter = new ScoreStub(3, 0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual(score, "fourty-love");
        }
    }

    public class ScoringEngine
    {
        private readonly IScore _score;

        public ScoringEngine(IScore score)
        {
            _score = score;
        }

        public string Score
        {
            get {
                if (_score.PointsA == 1)
                    return "fifteen-love";
                else
                    return "thirty-love";
                }
        }
    }
}