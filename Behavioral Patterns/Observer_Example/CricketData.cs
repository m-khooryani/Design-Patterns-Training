using System.Collections.Generic;

namespace Observer_Example
{
    class CricketData : ISubject
    {
        int runs;
        int wickets;
        double overs;
        List<IObserver> observerList;


        public CricketData()
        {
            observerList = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o) => observerList.Add(o);

        public void UnregisterObserver(IObserver o)
        {
            observerList.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observerList)
            {
                observer.Update(runs, wickets, overs);
            }
        }

        private int GetLatestRuns() => 90;

        private int GetLatestWickets() => 2;

        private double GetLatestOvers() => 10.2;

        public void DataChanged()
        {
            runs = GetLatestRuns();
            wickets = GetLatestWickets();
            overs = GetLatestOvers();

            NotifyObservers();
        }
    }
}
