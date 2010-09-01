using System;
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

            Assert.AreEqual("fifteen-love", score);
        }

        [Test]
        public void GivenPlayerAHasTwoPointsAndPlayerBHasZeroPoints_ReturnsThirtyLove()
        {
            var scoreCounter = new ScoreStub(2, 0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("thirty-love", score);
        }

        [Test]
        public void GivenPlayerAHasThreePointsAndPlayerBHasZeroPoints_ReturnsFourtyLove()
        {
            var scoreCounter = new ScoreStub(3, 0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("fourty-love", score);
        }

        [Test]
        public void GivenPlayerAHasZeroPointsAndPlayerBHasOnePoints_ReturnsLoveFifteen()
        {
            var scoreCounter = new ScoreStub(0, 1);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("love-fifteen", score);
        }
    }

    public class ScoringEngine
    {
        private readonly IScore _scoreCounter;

        public ScoringEngine(IScore scoreCounter)
        {
            _scoreCounter = scoreCounter;
        }

        public string Score
        {
            get
            {
                string scorePhraseA = GetScorePhrase(_scoreCounter.PointsA);
                string scorePhraseB = GetScorePhrase(_scoreCounter.PointsB);
                return scorePhraseA + "-" + scorePhraseB;
            }
        }

        private string GetScorePhrase(int points)
        {
            switch (points)
            {
                case 0:
                    return "love";
                case 1:
                    return "fifteen";
                case 2:
                    return "thirty";
                case 3:
                    return "fourty";
                default:
                    throw new ArgumentException("Undefinied points");
            }
        }
    }
}