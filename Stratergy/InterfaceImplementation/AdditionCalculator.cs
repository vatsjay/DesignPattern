using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.InterfaceImplementation
{
    public class AdditionCalculator : ICalculateStrategy
    {
        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
}
