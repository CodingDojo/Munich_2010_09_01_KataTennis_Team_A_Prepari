using NUnit.Framework;

namespace Dojo
{
    [TestFixture]
    public class ScoreCounterTests
    {
        [Test]
        public void GivenANewlyCreatedScoureCounter_PlayerAHasZeroPoints()
        {
            var scoreCounter = new ScoreCounter();

            Assert.AreEqual(0, scoreCounter.PointsA);
        }

        [Test]
        public void GivenANewlyCreatedScoureCounter_PlayerBHasZeroPoints()
        {
            var scoreCounter = new ScoreCounter();

            Assert.AreEqual(0, scoreCounter.PointsB);
        }

        [Test]
        public void GivenANewlyCreatedScoreCounter_AndPlayerAScores_PlayerAHasOnePoint()
        {
            var scoreCounter = new ScoreCounter();

            scoreCounter.ScoreA();

            Assert.AreEqual(1, scoreCounter.PointsA);
        }

        [Test]
        public void GivenANewlyCreatedScoreCounter_AndPlayerBScores_PlayerBHasOnePoint()
        {
            var scoreCounter = new ScoreCounter();

            scoreCounter.ScoreB();

            Assert.AreEqual(1, scoreCounter.PointsB);
        }

        [Test]
        public void GivenAScoreCounterWherePlayerAHasOnePoint_AndPlayerAScores_PlayerAHasTwoPoints()
        {
            var scoreCounter = new ScoreCounter();
            scoreCounter.ScoreA();

            scoreCounter.ScoreA();

            Assert.AreEqual(2, scoreCounter.PointsA);
        }

        [Test]
        public void GivenAScoreCounterWherePlayerBHasOnePoint_AndPlayerBScores_PlayerBHasTwoPoints()
        {
            var scoreCounter = new ScoreCounter();
            scoreCounter.ScoreB();

            scoreCounter.ScoreB();

            Assert.AreEqual(2, scoreCounter.PointsB);
        }
    }
}