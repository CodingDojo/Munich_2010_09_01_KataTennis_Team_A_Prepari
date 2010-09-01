using System;
using NUnit.Framework;

namespace Dojo
{
    public class ScoreCounter
    {
        public int PointsA { get; set; }
    }

    [TestFixture]
    public class ScoreCounterTests
    {
        public void GivenANewlyCreatedScoureCounter_PlayerAHasZeroPoints()
        {
            var scoreCounter = new ScoreCounter();

            Assert.AreEqual(0, scoreCounter.PointsA);
        }
    }
}