using System;
using NUnit.Framework;

namespace Dojo
{
    public class ScoreCounter
    {
        public int PointsA { get; private set; }

        public int PointsB { get; private set; }

        public void ScoreA()
        {
            PointsA++;
        }

        public void ScoreB()
        {
            PointsB++;
        }
    }

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
    }
}