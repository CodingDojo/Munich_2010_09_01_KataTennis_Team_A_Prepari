using System;
using NUnit.Framework;

namespace Dojo
{
    public class ScoreCounter
    {
        public int PointsA { get; set; }

        public int PointsB { get; set; }

        public void ScoreA()
        {
            PointsA++;
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
    }
}