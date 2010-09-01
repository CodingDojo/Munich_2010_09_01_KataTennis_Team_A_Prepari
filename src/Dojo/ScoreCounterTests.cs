using NUnit.Framework;

namespace Dojo
{
    [TestFixture]
    public class ScoreCounterTests
    {
        [Test]
        public void GivenANewlyCreatedScoureCounter_PlayerAHasZeroPoints()
        {
            var scoreCounter = new Score();

            Assert.AreEqual(0, scoreCounter.PointsA);
        }

        [Test]
        public void GivenANewlyCreatedScoureCounter_PlayerBHasZeroPoints()
        {
            var scoreCounter = new Score();

            Assert.AreEqual(0, scoreCounter.PointsB);
        }

        [Test]
        public void GivenANewlyCreatedScoreCounter_AndPlayerAScores_PlayerAHasOnePoint()
        {
            var scoreCounter = new Score();

            scoreCounter.ScoreA();

            Assert.AreEqual(1, scoreCounter.PointsA);
        }

        [Test]
        public void GivenANewlyCreatedScoreCounter_AndPlayerBScores_PlayerBHasOnePoint()
        {
            var scoreCounter = new Score();

            scoreCounter.ScoreB();

            Assert.AreEqual(1, scoreCounter.PointsB);
        }

        [Test]
        public void GivenAScoreCounterWherePlayerAHasOnePoint_AndPlayerAScores_PlayerAHasTwoPoints()
        {
            var scoreCounter = new Score();
            scoreCounter.ScoreA();

            scoreCounter.ScoreA();

            Assert.AreEqual(2, scoreCounter.PointsA);
        }

        [Test]
        public void GivenAScoreCounterWherePlayerBHasOnePoint_AndPlayerBScores_PlayerBHasTwoPoints()
        {
            var scoreCounter = new Score();
            scoreCounter.ScoreB();

            scoreCounter.ScoreB();

            Assert.AreEqual(2, scoreCounter.PointsB);
        }
    }
}