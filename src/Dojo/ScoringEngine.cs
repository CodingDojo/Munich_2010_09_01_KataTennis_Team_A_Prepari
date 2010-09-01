using System;

namespace Dojo
{
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