using System;
using NUnit.Framework;

namespace Dojo
{
    public class ScoreCounter
    {
        public int PointsA { get; set; }

        public int PointsB { get; set; }
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
    }
}