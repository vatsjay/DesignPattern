namespace ObserverPattern.Interface
{
    internal interface IMarketObserver
    {
        void Update();
        void Register(IMarketObservable observable);
        void Deregister(IMarketObservable observable);
    }
}
