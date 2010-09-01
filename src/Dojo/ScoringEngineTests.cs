using NUnit.Framework;

namespace Dojo
{
    [TestFixture]
    public class ScoringEngineTests
    {
        [Test]
        public void GivenPlayerAHasOnePointAndPlayerBHasZeroPoints_ReturnsFifteenLove()
        {
            var scoreCounter = new ScoreStub(1, 0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual(score, "fifteen-love");
        }

        [Test]
        public void GivenPlayerAHasThreePointsAndPlayerBHasZeroPoints_ReturnsFourtyLove()
        {
            var scoreCounter = new ScoreStub(3, 0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual(score, "fourty-love");
        }

        [Test]
        public void GivenPlayerAHasTwoPointsAndPlayerBHasZeroPoints_ReturnsThirtyLove()
        {
            var scoreCounter = new ScoreStub(2, 0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual(score, "thirty-love");
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
            get
            {
                string scorePhraseA = GetScorePhrase(_score.PointsA);
                return scorePhraseA + "-love";
            }
        }

        private string GetScorePhrase(int points)
        {
            switch (points)
            {
                case 1:
                    return "fifteen";
                case 2:
                    return "thirty";
                default:
                    return "fourty";
            }
        }
    }
}