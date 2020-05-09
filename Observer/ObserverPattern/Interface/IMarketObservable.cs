namespace ObserverPattern.Interface
{
    internal interface IMarketObservable
    {
        void AddObserver(IMarketObserver marketObserver);
        void RemoveObserver(IMarketObserver marketObserver);
        void NotifyObservers();
    }
}
