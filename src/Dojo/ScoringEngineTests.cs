using System;
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
                if (_scoreCounter.PointsA >= 3 && _scoreCounter.PointsB >= 3)
                {
                    if (_scoreCounter.PointsA == _scoreCounter.PointsB)
                    {
                        return "deuce";
                    }

                    if (_scoreCounter.PointsA - _scoreCounter.PointsB == 1)
                    {
                        return "Advantage PlayerA";
                    }

                    if (_scoreCounter.PointsB - _scoreCounter.PointsA == 1)
                    {
                        return "Advantage PlayerB";
                    }    
                    
                    if (_scoreCounter.PointsB - _scoreCounter.PointsA == 2)
                    {
                        return "PlayerB wins";
                    } 
                    
                    if (_scoreCounter.PointsA - _scoreCounter.PointsB == 2)
                    {
                        return "PlayerA wins";
                    }
                }

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