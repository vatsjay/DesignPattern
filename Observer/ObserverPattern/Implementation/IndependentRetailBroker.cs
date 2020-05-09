using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern.Implementation
{
    internal class IndependentRetailBroker : IMarketObserver
    {
        #region Instance Variable

        private List<Stock> _myStockList;
        private SmartStockExchange _stockExchange;

        #endregion

        public IndependentRetailBroker()
        {
            _myStockList = new List<Stock>();
            InitializeMyStock();
        }

        private void InitializeMyStock()
        {
            _myStockList.Add(new Stock { StockId = 1235, Name = "ABFRL", Price = 106.05 });
            _myStockList.Add(new Stock { StockId = 1239, Name = "SBIN", Price = 169.80 });
            _myStockList.Add(new Stock { StockId = 1238, Name = "RPOWER", Price = 1.69 });
            _myStockList.Add(new Stock { StockId = 1237, Name = "TRENT", Price = 459.70 });
            _myStockList.Add(new Stock { StockId = 1236, Name = "ICICI", Price = 459.70 });
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

        public void Update()
        {
            foreach (var stock in _stockExchange.StockList)
            {
                var foundStock = _myStockList.FirstOrDefault(x => x.StockId == stock.StockId);

                if (null != foundStock)
                {
                    foundStock.Name = stock.Name;
                    foundStock.Price = stock.Price;
                }
            }
        }

        public void DisplayMyStock()
        {
            foreach (var stock in _myStockList)
            {
                Console.WriteLine($"Name : {stock.Name} Price : {stock.Price}");
            }
        }
    }
}
