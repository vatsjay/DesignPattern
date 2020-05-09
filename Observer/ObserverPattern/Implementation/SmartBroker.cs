using System;
using System.Collections.Generic;
using System.Linq;
using ObserverPattern.Interface;

namespace ObserverPattern.Implementation
{
    internal class SmartBroker : IMarketObservable, IMarketObserver
    {
        #region Instance Variables

        private List<IMarketObserver> _observerList;
        public List<Stock> stocksList { get; private set; }
        private SmartStockExchange _stockExchange;

        #endregion

        public SmartBroker()
        {
            _observerList = new List<IMarketObserver>();
            stocksList = new List<Stock>();
        }

        public void Register(IMarketObservable observable)
        {
            observable.AddObserver(this);
            _stockExchange = (SmartStockExchange)observable;
        }

        public void Deregister(IMarketObservable observable)
        {
            observable.RemoveObserver(this);
        }

        public void AddObserver(IMarketObserver marketObserver)
        {
            _observerList.Add(marketObserver);
        }

        public void RemoveObserver(IMarketObserver marketObserver)
        {
            _observerList.Remove(marketObserver);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observerList)
            {
                observer.Update();
            }
        }

        public void Update()
        {
            foreach (var stock in _stockExchange.StockList)
            {
                var foundStock = stocksList.FirstOrDefault(x => x.StockId == stock.StockId);

                if (null != foundStock)
                {
                    foundStock.Name = stock.Name;
                    foundStock.Price = stock.Price;
                }
                else
                {
                    stocksList.Add(stock);
                }
            }
            NotifyObservers();
        }
    }
}
