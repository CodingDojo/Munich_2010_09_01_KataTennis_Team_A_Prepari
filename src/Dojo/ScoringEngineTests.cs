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
            var scoreCounter = new ScoreCounter();
            scoreCounter.ScoreA();
            var scoringEngine = new ScoringEngine(scoreCounter);

            var score = scoringEngine.Score;

            Assert.AreEqual(score, "fifteen love");
        }
    }

    public class ScoringEngine
    {
        public ScoringEngine(ScoreCounter scoreCounter)
        {
        }

        public string Score
        {
            get { return "fifteen love"; }
        }
    }
}