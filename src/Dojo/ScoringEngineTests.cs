using NUnit.Framework;

namespace Dojo
{
    [TestFixture]
    public class ScoringEngineTests
    {
        [Test]
        public void GivenPlayerAHasFivePointsAndPlayerBHasFourPoints_ReturnsAdvantagePlayerA()
        {
            var scoreCounter = new ScoreStub(5, 4);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("Advantage PlayerA", score);
        }

        [Test]
        public void GivenPlayerAHasFourPointsAndPlayerBHasFivePoints_ReturnsAdvantagePlayerB()
        {
            var scoreCounter = new ScoreStub(4, 5);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("Advantage PlayerB", score);
        }

        [Test]
        public void GivenPlayerAHasThreePointsAndPlayerBHasFivePoints_ReturnsPlayerBWins()
        {
            var scoreCounter = new ScoreStub(3, 5);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("PlayerB wins", score);
        }

        [Test]
        public void GivenPlayerAHasFivePointsAndPlayerBHasThreePoints_ReturnsPlayerAWins()
        {
            var scoreCounter = new ScoreStub(5, 3);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("PlayerA wins", score);
        }

        [Test]
        public void GivenPlayerAHasFourPointsAndPlayerBHasZeroPoints_ReturnsPlayerAWins()
        {
            var scoreCounter = new ScoreStub(4, 0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("PlayerA wins", score);
        }

        [Test]
        public void GivenPlayerAHasFourPointsAndPlayerBHasFourPoints_ReturnsDeuce()
        {
            var scoreCounter = new ScoreStub(4, 4);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("deuce", score);
        }

        [Test]
        public void GivenPlayerAHasFourPointsAndPlayerBHasThreePoints_ReturnsAdvantagePlayerA()
        {
            var scoreCounter = new ScoreStub(4, 3);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("Advantage PlayerA", score);
        }

        [Test]
        public void GivenPlayerAHasOnePointAndPlayerBHasZeroPoints_ReturnsFifteenLove()
        {
            var scoreCounter = new ScoreStub(1, 0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("fifteen-love", score);
        }

        [Test]
        public void GivenPlayerAHasThreePointsAndPlayerBHasThreePoints_ReturnsDeuce()
        {
            var scoreCounter = new ScoreStub(3, 3);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("deuce", score);
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
        public void GivenPlayerAHasTwoPointsAndPlayerBHasZeroPoints_ReturnsThirtyLove()
        {
            var scoreCounter = new ScoreStub(2, 0);
            var scoringEngine = new ScoringEngine(scoreCounter);

            string score = scoringEngine.Score;

            Assert.AreEqual("thirty-love", score);
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
}