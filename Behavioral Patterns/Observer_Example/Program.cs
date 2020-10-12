namespace Observer_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            AverageScoreDisplay averageScoreDisplay =
                              new AverageScoreDisplay();
            CurrentScoreDisplay currentScoreDisplay =
                              new CurrentScoreDisplay();

            CricketData cricketData = new CricketData();

            cricketData.RegisterObserver(averageScoreDisplay);
            cricketData.RegisterObserver(currentScoreDisplay);

            cricketData.DataChanged();

            cricketData.UnregisterObserver(averageScoreDisplay);

            cricketData.DataChanged();
        }
    }
}
