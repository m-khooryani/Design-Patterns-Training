﻿namespace Observer_Example
{
    interface ISubject
    {
        void RegisterObserver(IObserver o);
        void UnregisterObserver(IObserver o);
        void NotifyObservers();
    }
}
