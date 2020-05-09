using ObserverPattern.Interface;
using System.Linq;
using System.Collections.Generic;

namespace ObserverPattern.Implementation
{
    internal class AssociatedRetailInvestor : IMarketObserver
    {
        #region Instance Variable

        private Dictionary<int, int> _myStocks;
        private double _myFund;
        private double _initialFund;
        private SmartBroker _myBroker;

        #endregion

        public AssociatedRetailInvestor()
        {
            _myStocks = new Dictionary<int, int>();
            _myFund = 10000;
            _initialFund = 10000;
        }

        public double Earning 
        {
            get { return _initialFund - _myFund;}
        }

        public bool BuyStock(int stockId, int quantity)
        {
            var isStockBought = false;
            var stock = _myBroker.stocksList.FirstOrDefault(x => x.StockId == stockId);
            var totalPrice = stock.Price * quantity;

            if (_myFund > stock.Price * quantity)
            {
                if (_myStocks.ContainsKey(stock.StockId))
                {
                    _myStocks[stock.StockId] += quantity;
                }
                else
                {
                    _myStocks.Add(stock.StockId, quantity);
                }

                _myFund -= totalPrice;
                isStockBought = true;
            }
            return isStockBought;
        }

        public bool SellStock(Stock stock, int quantity)
        {
            var isStocksSold = false;
            
            if (_myStocks.ContainsKey(stock.StockId) && _myStocks[stock.StockId] >= quantity)
            {
                _myStocks[stock.StockId] -= quantity;
                _myFund += quantity * stock.Price;
                isStocksSold = true;
            }

            return isStocksSold;
        }

        public void Deregister(IMarketObservable observable)
        {
            observable.RemoveObserver(this);
        }

        public void Register(IMarketObservable observable)
        {
            observable.AddObserver(this);
            _myBroker = (SmartBroker)observable;
        }

        public void Update()
        {
            
        }
    }
}
