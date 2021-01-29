using System;

namespace Observer_Example
{
    class CurrentScoreDisplay : IObserver
    {
        private int runs, wickets;
        private double overs;

        public void Update(int runs, int wickets,
                           double overs)
        {
            this.runs = runs;
            this.wickets = wickets;
            this.overs = overs;
            Console.WriteLine(Display());
        }

        public string Display()
        {
            return ("\nCurrent Score Display:\n"
                               + "Runs: " + runs +
                               "\nWickets:" + wickets +
                               "\nOvers: " + overs);
        }
    }
}
