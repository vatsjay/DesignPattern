using ObserverPattern.Implementation;
using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AssociatedRetailInvestor firstInvestor = new AssociatedRetailInvestor();
            IndependentRetailBroker independentRetail = new IndependentRetailBroker();
            SmartStockExchange exchange = new SmartStockExchange();
            SmartBroker broker = new SmartBroker();

            broker.Register(exchange);
            independentRetail.Register(exchange);
            firstInvestor.Register(broker);


            Console.WriteLine($"Earning of first investor is {firstInvestor.Earning}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Independent retailer's stock values : ");
            independentRetail.DisplayMyStock();
            Console.WriteLine("-----------------------------------");
            exchange.ChangePrice(1235, 107.10);
            independentRetail.DisplayMyStock();

            firstInvestor.BuyStock(1236, 4);
            Console.WriteLine($"Earning of first investor is {firstInvestor.Earning}");
        }
    }
}