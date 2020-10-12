namespace Observer_Example
{
    interface Subject
    {
        void RegisterObserver(Observer o);
        void UnregisterObserver(Observer o);
        void NotifyObservers();
    }
}
