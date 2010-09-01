using System;

namespace Dojo
{
    public class ScoreCounter : IScoreCounter
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
}