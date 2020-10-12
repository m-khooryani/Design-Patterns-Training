using System.Collections.Generic;

namespace Observer_Example
{
    class CricketData : Subject
    {
        int runs;
        int wickets;
        double overs;
        List<Observer> observerList;


        public CricketData()
        {
            observerList = new List<Observer>();
        }

        public void RegisterObserver(Observer o) => observerList.Add(o);

        public void UnregisterObserver(Observer o)
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
