using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern.Implementation
{
    class SmartStockExchange : IMarketObservable
    {
        #region Instance Variables

        public List<Stock> StockList { get; private set; }
        private List<IMarketObserver> _observerList;

        #endregion

        public SmartStockExchange()
        {
            StockList = new List<Stock>();
            _observerList = new List<IMarketObserver>();
            InitializeStockList();
        }

        private void InitializeStockList()
        {
            StockList.Add(new Stock { StockId = 1235, Name = "ABFRL", Price = 106.05 });
            StockList.Add(new Stock { StockId = 1239,  Name = "SBIN", Price = 169.80 });
            StockList.Add(new Stock { StockId = 1238, Name = "RPOWER", Price = 1.69 });
            StockList.Add(new Stock { StockId = 1237, Name = "TRENT", Price = 459.70 });
            StockList.Add(new Stock { StockId = 1236, Name = "ICICI", Price = 459.70 });
        }

        public void AddStock(Stock stock)
        {
            StockList.Add(stock);
            NotifyObservers();
        }

        public void RemoveStock(Stock stock)
        {
            StockList.Remove(stock);
            NotifyObservers();
        }

        public void AddObserver(IMarketObserver observer)
        {
            _observerList.Add(observer);
        }

        public void RemoveObserver(IMarketObserver observer)
        {
            _observerList.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observerList)
            {
                observer.Update();
            }
        }

        public void ChangePrice(int stockId, double price)
        {
            var foundStock = StockList.FirstOrDefault(x => x.StockId == stockId);
            if (null != foundStock)
            {
                foundStock.Price = price;
            }
            NotifyObservers();
        }
    }
}
