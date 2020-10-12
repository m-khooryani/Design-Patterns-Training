using System;

namespace Observer_Example
{
    class AverageScoreDisplay : Observer
    {
        private double runRate;
        private int predictedScore;

        public void Update(int runs, int wickets, double overs)
        {
            this.runRate = runs / overs;
            this.predictedScore = (int)(this.runRate * 50);
            Console.WriteLine(Display());
        }

        public string Display()
        {
            return ("\nAverage Score Display: \n"
                               + "Run Rate: " + runRate +
                               "\nPredictedScore: " +
                               predictedScore);
        }
    }
}
